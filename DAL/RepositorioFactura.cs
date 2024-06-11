using Entity;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace DAL
{
    public class RepositorioFactura:servicioSQL
    {
        RepositorioInventario repositorioInventario = new RepositorioInventario();
        public void AddFactura(Factura factura)
        {
   
           string query= "INSERT INTO FACTURA " +
                          "(IdFactura, CedulaCliente, NombreCliente, MontoPago, FechaAlquiler, FechaDevolucion) VALUES " +
                             "(@IdFactura, @CedulaCliente, @NombreCliente, @MontoPago, @FechaAlquiler, @FechaDevolucion)";


            string query2 = "INSERT INTO DETALLEFACTURA " +
                             "(IdFactura, IdArticulo, CantidadArticulo) VALUES " +
                             "(@IdFactura, @IdArticulo, @CantidadArticulo)";
            
            SqlTransaction accion = null;

            try
            {
                AbrirConexion();
                accion = conexion.BeginTransaction();

                // Insertar en FACTURA
                using (SqlCommand command = new SqlCommand(query, conexion, accion))
                {
                    command.Parameters.AddWithValue("@IdFactura", factura.idFactura);
                    command.Parameters.AddWithValue("@CedulaCliente", factura.CedulaCliente);
                    command.Parameters.AddWithValue("@NombreCliente", factura.NombreCliente);
                    command.Parameters.AddWithValue("@MontoPago", factura.montoPago);
                    command.Parameters.AddWithValue("@FechaAlquiler", factura.fechaFacturacion);
                    command.Parameters.AddWithValue("@FechaDevolucion", factura.fechaDevolucion);

                    command.ExecuteNonQuery();
                }

                // Insertar en DETALLEFACTURA
                foreach (var item in factura.detalles)
                {
                    using (SqlCommand command1 = new SqlCommand(query2, conexion, accion))
                    {
                        command1.Parameters.AddWithValue("@IdFactura", item.idFactura);
                        command1.Parameters.AddWithValue("@IdArticulo", item.articulo.idArticulo);
                        command1.Parameters.AddWithValue("@CantidadArticulo", item.cantidadProducto);

                        command1.ExecuteNonQuery();
                    }
                }

                accion.Commit();
            }
            catch (Exception ex)
            {
                if (accion != null)
                {
                    accion.Rollback();
                }
            }
            finally
            {
                CerrarConexion();
            }
        }

        public List<Factura> leerFactura()
        {
            List<Factura> facturaList = new List<Factura>();
            string query = "SELECT * FROM FACTURA";

            try
            {
                SqlCommand command = new SqlCommand(query, conexion);
                AbrirConexion();
                SqlDataReader reader = command.ExecuteReader();
                while(reader.Read())
                {
                    facturaList.Add(MapFactura(reader));
                }
                reader.Close();
                CerrarConexion();
            }
            catch (Exception)
            {
                return null;
            }
            return facturaList;

        }

        public List<DetalleFactura> LeerDetalleFactura()
        {
            List<DetalleFactura> detalleFacturas = new List<DetalleFactura>();
            string query = "SELECT * FROM DETALLEFACTURA";
            try
            {
                SqlCommand command = new SqlCommand(query, conexion);
                AbrirConexion();
                SqlDataReader reader = command.ExecuteReader();
                while(reader.Read())
                {
                    detalleFacturas.Add(MapDetalleFactura(reader));
                }
            }
            catch (Exception)
            {
                return null;
            }
            return detalleFacturas;
        }
        public List<DetalleFactura> ObtenerDetalles(string idFactura)
        {
            List<DetalleFactura> detalles = new List<DetalleFactura>();
            if (LeerDetalleFactura() != null)
            {
                foreach (var item in LeerDetalleFactura())
                {
                    if (item.idFactura.Equals(idFactura))
                    {
                        detalles.Add(item);
                    }
                }
            }
            return detalles;
        }
        public Factura EncontrarFactura(string IdFactura)
        {
            try
            {
                var facturas = leerFactura();
                if(facturas == null)
                {
                    return null;
                }
                return facturas.FirstOrDefault(p => p.idFactura == IdFactura);
            }
            catch (Exception)
            {
                return null;
            }
        }

        public Factura MapFactura(SqlDataReader reader)
        {
            Factura factura = new Factura
            {
                idFactura = Convert.ToString(reader["Idfactura"]),
                CedulaCliente = Convert.ToString(reader["CedulaCliente"]),
                NombreCliente = Convert.ToString(reader["NombreCliente"]),
                montoPago = Convert.ToDouble(reader["MontoPago"]),
                fechaFacturacion = Convert.ToDateTime(reader["FechaAlquiler"]),
                fechaDevolucion = Convert.ToDateTime(reader["FechaDevolucion"])
            };
            return factura;
        }

        public DetalleFactura MapDetalleFactura(SqlDataReader reader)
        {
            DetalleFactura detalle = new DetalleFactura
            {
                IdDetalleFactura = Convert.ToInt32(reader["IdDetalleFactura"]),
                idFactura = Convert.ToInt32(reader["IdFactura"]),
                cantidadProducto = Convert.ToInt32(reader["CantidadArticulo"])
            };
            string idArticulo = Convert.ToString(reader["IdArticulo"]);
            detalle.articulo = ObtenerArticulo(idArticulo);
            return detalle;
        }
        public List<DetalleFactura> GetDetalleFacturas(string idFactura)
        {
            return LeerDetalleFactura().Where(detalles=>detalles.idFactura.Equals(int.Parse(idFactura))).ToList();
        }

        public Articulo ObtenerArticulo(string idArticulo)
        {
            return repositorioInventario.EncontrarArticulo(idArticulo);
        }

    }
}

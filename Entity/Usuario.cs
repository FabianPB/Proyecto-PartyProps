using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Usuario
    {
        public string rol {  get; set; }

        public string idUsuario { get; set; } 
        
        public string contraseña { get; set; }

        public string userName { get; set; }    

        public string nombre { get; set; }  
        public string correo {  get; set; }

        public Usuario(string rol, string idUsuario, string contraseña, string userName, string nombre, string correo)
        {
            this.rol = rol;
            this.idUsuario = idUsuario;
            this.contraseña = contraseña;
            this.userName = userName;
            this.nombre = nombre;
            this.correo = correo;
        }
    }
}

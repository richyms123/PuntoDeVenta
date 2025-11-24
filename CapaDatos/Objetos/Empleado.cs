using System;
using System.Collections.Generic;
using System.Text;

namespace CapaDatos.Objetos
{
    internal class Empleado
    {
        /*
            public int id { get; set; }
            public string   usuario         { get; set; }
            public string   nombre          { get; set; }
            public string   apellido        { get; set; }
            public string   telefono        { get; set; }
            public string   correo          { get; set; }
            public string   contrasena      { get; set; }
            public DateTime fechaNacimiento { get; set; } 
        */
        public int idEmpleado { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Usuario { get; set; }
        public string Pasword { get; set; }
        public bool Activo { get; set; }
        // ENUM
        public string Turno { get; set; }
        public DateTime Apellidos { get; set; }
        public string Direccion { get; set; }
        public string Municipio { get; set; }
        public string Estado { get; set; }
        public string CodigoPostal { get; set; }
        public string Pais { get; set; }
        public string Telefono { get; set; }
        public string eMaill { get; set; }
        public string Apellidos { get; set; }
        public string FotoEmpleado { get; set; }
        public DateTime FechaDeAlta { get; set; }




    }
}
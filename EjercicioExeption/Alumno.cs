using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioExeption
{
    public class Alumno
    {
        public Alumno() { }
        public Alumno(string Nombre, string Apellido) 
        {
            if (Nombre.Trim().Length < 1 || Nombre.Length > 50)
            { throw new Exception("El nombre no puede estar vacío o superar los 50 carácteres");
            }
            this.Nombre = Nombre;
            this.Apellido = Apellido;
        }
        private string nombre;
        public string Nombre
        {
            get
            {
                return nombre;
            }
            set
            {
                nombre = value;
            }
        }

        private string apellido;
        public string Apellido
        {
            get
            {
                return apellido;
            }
            set
            {
                apellido = value;
            }
        }
        
    }
}

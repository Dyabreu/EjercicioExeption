using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioExeption
{
    public class Medico
    {
        public Medico() { }
        public Medico(string Nombre, string Apellido, int Matricula)
        {
            if (Nombre.Trim().Length < 1 || Nombre.Length > 50)
            {
                throw new Exception("El nombre no puede estar vacío o superar los 50 carácteres");
            }
            this.Nombre = Nombre;
            this.Apellido = Apellido;
            this.Matricula = Matricula;
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
        public int matricula;
        public int Matricula 
            {
            get
            {
                return matricula;
            }
            set
            {
                matricula = value;
            }
        }
    }
}

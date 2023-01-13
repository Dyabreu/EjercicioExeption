using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EjercicioExeption;

namespace WindowsFormsException
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_nombre_largo_Click(object sender, EventArgs e)
        {
            try
            {
                Alumno alumno = new Alumno("CesarCesarCesarCesarCesarCesarCesarCesarCesarCesarCesar", "Ramirez");
                MessageBox.Show(alumno.Nombre);
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_no_nombre_Click(object sender, EventArgs e)
        {
            try
            {
                Alumno alumno2 = new Alumno("", "Gonzalez");
                MessageBox.Show(alumno2.Nombre);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void nombre_valido_Click(object sender, EventArgs e)
        {
            try
            {
                Alumno alumno3 = new Alumno("Leonardo", "Gonzalez");
                MessageBox.Show(alumno3.Nombre);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

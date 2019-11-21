using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_14_11_2019_Exceptions
{
    public partial class Form1 : Form
    {
        List<Alumno> alumnos = new List<Alumno>();
        public Form1()
        {
            
            InitializeComponent();
        }
        
        private void Baceptar_Click(object sender, EventArgs e)
        {
            if (TBMatricula.Text == "")
            {
                EP.SetError(TBMatricula, "No ingreso matricula");
            }
            if (TBNombre.Text == "")
            {
                EP.SetError(TBNombre, "No ingreso nombre");
            }
            if (TBCarrera.Text == "")
            {
                EP.SetError(TBCarrera, "No ingreso carrera");
            }
            if (TBSemestre.Text == "")
            {
                EP.SetError(TBSemestre, "No ingreso semestre");
            }
            if (TBTelefono.Text == "")
            {
                EP.SetError(TBTelefono, "No ingreso telefono");
            }           
            try
            {
                Alumno alumno = new Alumno();
                alumno.Matricula = Convert.ToInt32(TBMatricula.Text);
                alumno.Nombre = TBNombre.Text;
                alumno.Semestre=Convert.ToInt32(TBSemestre.Text);
                alumno.Carrera = TBCarrera.Text;
                alumno.Telefono = Convert.ToInt32(TBTelefono.Text);
                alumnos.Add(alumno);
                throw new Specialexception("Su alumno se creo exitosamente");
            }
            catch(FormatException r)
            {
                MessageBox.Show("Error en registracion "+r.Message);
            }
            catch(Specialexception espr)
            {
                MessageBox.Show(espr.Message);
            }
            finally
            {
                EP.Clear();
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void TBCalificacion_TextChanged(object sender, EventArgs e)
        {

        }

        private void TBCalificacion_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                int cal = Convert.ToInt32(TBCalificacion.Text);
                if (cal <1 || cal > 10)
                {
                    MessageBox.Show("Ingrese una calificacion del 1 al 10");
                }               
            }
            catch (Exception r)
            {
                MessageBox.Show("Error en la entrada de datos","Error",MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                
            }
        }
    }

}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E05_Sosa_lopez_Alan_Manuel_To_do_list
{
    public partial class Agregartarea : MetroFramework.Forms.MetroForm
    {
        public Form1 form1;
        
        
        public Agregartarea()
        {            
            InitializeComponent();
           
        }
        Usuario usuario;
        public void Combobox()
        {
            
        }
        private void Agregartarea_Load(object sender, EventArgs e)
        {
            MCBATusuario.DataSource = form1.repo.usuarios;
            MCBATusuario.DisplayMember = "Nombre";
            MCBATusuario.ValueMember = "ID";
        }

        private void MBAUcancelar_Click(object sender, EventArgs e)
        {
            
            form1.Show();
            this.Hide();
        }

        private void MCBATusuario_SelectedValueChanged(object sender, EventArgs e)
        {

        }

        private void MBAUA_Click(object sender, EventArgs e)
        {
            //Excepcion
            try
            {


                int id = Convert.ToInt32(MTBATid.Text);
                string nombre = MTBATnombre.Text;
                string descripcion = MTBATdescripcion.Text;
                string horario = MTBAThorario.Text;
                //Metodo para agregado de una tarea
                form1.repo.Agregar_tarea(usuario, id, nombre, descripcion, horario);
                MTBATdescripcion.Text = "";
                MTBAThorario.Text = "";
                MTBATid.Text = "";
                MTBATnombre.Text = "";
            }
            catch
            {
                MessageBox.Show("Verifique sus campos porfavor!");
            }

        }

        private void MCBATusuario_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void MCBATusuario_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            //Metodo para la seleccion del usuario a agregar tarea
            string username = MCBATusuario.Text;
            usuario = form1.repo.usuarios.FirstOrDefault(f => f.Nombre == username);
        }

        private void MetroLabel3_Click(object sender, EventArgs e)
        {

        }
    }
}

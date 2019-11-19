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
    public partial class Agregar : MetroFramework.Forms.MetroForm
    {

        public Form1 form1;
        

        public Agregar()
        {
            InitializeComponent();
        }

        private void Agregar_Load(object sender, EventArgs e)
        {
            
        }
        private void MBAgregarcancelar_Click(object sender, EventArgs e)
        {
            //Abre la forma principal
            form1.Comboagregar();
            form1.Show();

            this.Hide();
        }
        private void MBAgregaragregar_Click(object sender, EventArgs e)
        {
            //Excepcion
            try
            {

                //Agregado de nuevo usuario
                int id = Convert.ToInt32(MTBAgregarid.Text);
                string nombre = MTBAgregarnombre.Text;
                form1.repo.Agregar_usuario(id, nombre);
            }
            catch
            {
                MessageBox.Show("Verifique sus datos porfavor!");
            }           
        }
    }
}

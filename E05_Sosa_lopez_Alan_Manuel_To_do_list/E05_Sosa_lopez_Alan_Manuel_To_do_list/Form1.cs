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
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public Repo repo=new Repo();
        Usuario usuario;
        public Form1()
        {
            
            InitializeComponent();
            
        }        

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        public void Comboagregar()
        {//metodo para agregar a la lista de combobox los usuarios
            MCBusuario.DataSource = repo.usuarios;
            MCBusuario.DisplayMember = "Nombre";
            MCBusuario.ValueMember = "ID";
        }
        private void MetroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void MBAgregarusuario_Click(object sender, EventArgs e)
        {
            //Llamado de la forma que contiene el formulario de agregar usuario
            Agregar agregar = new Agregar();
            agregar.form1 = this;
            agregar.Show();
            this.Hide();
        }

        private void MTAgregartarea_Click(object sender, EventArgs e)
        {
            //Llamado de la forma que contiene el formulario para agregar tarea
            Agregartarea agregartarea = new Agregartarea();
            agregartarea.form1 = this;
            agregartarea.Show();
            this.Hide();
        }

        private void LBUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void MCBusuario_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void MetroButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            
        }

        private void MBVer_Click(object sender, EventArgs e)
        {
            //Metodo para seleccionar al usuario a mostar tareas
            string username = MCBusuario.Text;
            usuario = repo.usuarios.FirstOrDefault(f => f.Nombre == username);
            DGV.DataSource = usuario.tareas;
        }
    }
}

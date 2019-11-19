using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E05_Sosa_lopez_Alan_Manuel_To_do_list
{
    public class Repo
    {
        public List<Usuario> usuarios = new List<Usuario>();
        public void Agregar_usuario(int ID2, string Nombre2)
        {          
            usuarios.Add(new Usuario { ID = ID2, Nombre = Nombre2 });
        }      
        public void Agregar_tarea(Usuario u, int ID1, string Nombre1, string Descripcion1, string Horario1)
        {
            usuarios.Find(f => f.ID == u.ID).tareas.Add(new Tarea { usuario = u, ID = ID1, Nombre = Nombre1, Descripcion = Descripcion1, Horario = Horario1, Estatus = "Pendiente" });
        }
    }
}

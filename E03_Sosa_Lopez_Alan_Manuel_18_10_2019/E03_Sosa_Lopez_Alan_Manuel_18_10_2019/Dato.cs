using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E03_Sosa_Lopez_Alan_Manuel_18_10_2019
{
    public class Dato
    {
        public List<Usuario> usuarios = new List<Usuario>();
        
        
        
        public void Agregar_usuario(int ID2, string Nombre2)
        {
           //Agregamos un objeto nuevo a la lista
            usuarios.Add(new Usuario { ID = ID2, Nombre = Nombre2 });
            
        }
        //Declaracion del metodo a utilizar, recibe 6 parametros mismos con los que trabaja, la funcion find busca un objeto con el parametro que le a sido enviado posteriormente
        public void Agregar_tarea(Usuario u,int ID1, string Nombre1, string Descripcion1, string Horario1, DateTime Vencimiento1)
        {
            usuarios.Find(f => f.ID == u.ID).tareas.Add(new Tarea { usuario = u, ID = ID1, Nombre = Nombre1, Descripcion = Descripcion1, Horario = Horario1, Vencimiento = Vencimiento1, Estatus="Pendiente"});
        }
        
    }
}

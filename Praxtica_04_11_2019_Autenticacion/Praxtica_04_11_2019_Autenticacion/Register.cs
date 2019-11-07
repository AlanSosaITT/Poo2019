using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Praxtica_04_11_2019_Autenticacion
{
    public class Register
    {

        public List<User> users = new List<User>();
        
        public void Register_user(User user, string Path)
        {
            
            users.Add(user);
            int desea = 1;
            Console.Write("Desea ver algun usuario?, Si(1), No(2): ");
            desea = Convert.ToInt32(Console.ReadLine());
            if (desea == 1)
            {
                Write_user(Path);
            }                    
        }
        public void Write_user(string Path)
        {
            Console.Write("Que usuario desea ver?, ingrese su Nombre de usuario: ");
            string deseado = Console.ReadLine();
            foreach(var xdxd in users)
            {
                if (deseado == xdxd.Username)
                {
                    var data = "Nombre: "+xdxd.Name + "\n" +"Contraseña: "+ xdxd.Password + "\n" +"Nombre de usuario: "+ xdxd.Username;
                    File.WriteAllText(Path, data);

                }
            }
        }
    }
}

using Patron_singleton;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consola_Singleton
{
    class Program
    {
        static void Main(string[] args)
        {

            Usuario usuario = new Usuario();
            usuario.Nombre = "Prueba";
            usuario.Password = "prueba";

            try
            {
                SessionManager.Login(usuario);
                SessionManager session = SessionManager.GetInstance;
            }
            catch(Exception e) { Console.WriteLine(e.Message); }
            
        }
    }
}

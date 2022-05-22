using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Corte.CacheFolder;
using DAO;


namespace BE
{
    public class BE_Usuario
    {
        DAO_Usuario usuarioDAO = new DAO_Usuario();

        public BE_Usuario()
        {
        }

        public BE_Usuario(string loginName, string firstName, string lastName, string position, string email, string password)
        {
            LoginName = loginName;
            FirstName = firstName;
            LastName = lastName;
            Position = position;
            Email = email;
            Password = password;
        }

        public string LoginName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Position { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }


        public bool Login(string user, string password)
        {
            return usuarioDAO.Login(user, password);
        }

        public void Registrarse(string nombreDeUsuario, string nombre, string apellido, string email, string contraseña)
        {
            usuarioDAO.Registrarse(nombreDeUsuario, nombre, apellido, email, contraseña);
        }
        public bool YaExisteEnBD(string code)
        {
            return usuarioDAO.YaExisteEnBD(code);
        }
    }
}

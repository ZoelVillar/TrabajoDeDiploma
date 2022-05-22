using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patron_singleton
{
    public class SessionManager
    {
        private static SessionManager _session;
        public Usuario Usuario { get; set; }
        public DateTime FechaInicio { get; set; }

        //private static SessionManager _session; -- Esto es el singleton
        //private SessionManager() { }
        //public static SessionManager GetInstance
        //{
        //    get
        //    {
        //        if (_session == null)
                  //{
                        //_session = new SessionManager();
                  //}
        //        return _session;
        //    }
        //}

        private SessionManager() { }
        public static SessionManager GetInstance
        {
            get
            {
                return _session;
            }
        }

        public static void Login(Usuario usuario)
        {
            if (_session == null)
            {
                _session = new SessionManager();
                _session.Usuario = usuario;
                _session.FechaInicio = DateTime.Now;
            }
            else { throw new Exception("Sesion ya iniciada"); }
        }

        public static void Logout()
        {
            if(_session != null)
            {
                _session = null;
            }
            else { throw new Exception("Sesion no iniciada"); }
        }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TCTD2020.ArquitecturaCapasV1.BE;
using TCTD2020.ArquitecturaCapasV1.BE.Composite;

namespace TCTD2020.ArquitecturaCapasV1.Servicios
{
    public class Sesion
    {

        private Usuario _user { get; set; }

        public Usuario Usuario
        {
            get
            {
                return _user;
            }
        }


        public void Login(Usuario usuario)
        {
            _user = usuario;
        }

        public void Logout()
        {
            _user = null;
        }




        private bool IsInRoleRecursivo(PermisoCompuesto p, TipoPermiso tipoPermiso, bool valid)
        {

            foreach (var item in p.ObtenerHijos())
            {
                if (item is Patente && ((Patente)item).Tipo.Equals(tipoPermiso))
                {
                    valid= true;
                }
                else
                {
                    valid= IsInRoleRecursivo(item, tipoPermiso, valid);
                }
            }
            return valid;
        }


        public bool IsInRole(TipoPermiso tipoPermiso)
        {
            if (_user == null) return false;

            bool valid=false;
            foreach (var p in _user.Permisos)
            {
                if (p is Patente && ((Patente)p).Tipo.Equals(tipoPermiso))
                {
                    valid = true;
                }
                else
                {
                    valid = IsInRoleRecursivo(p, tipoPermiso, valid);
                }
            }

            return valid;
        }

        public bool IsLogged()
        {
            return _user != null;
        }
    }

}

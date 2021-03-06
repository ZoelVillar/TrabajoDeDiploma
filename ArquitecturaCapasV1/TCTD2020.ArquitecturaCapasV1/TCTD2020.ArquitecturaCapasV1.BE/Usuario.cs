using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TCTD2020.ArquitecturaCapasV1.BE.Composite;

namespace TCTD2020.ArquitecturaCapasV1.BE
{
   public class Usuario : Entity
    {

        private IList<PermisoCompuesto> _permisos;

        public Usuario()
        {
            _permisos = new List<PermisoCompuesto>();
        }
        public string Email { get; set; }
        public string Password { get; set; }


        public IList<PermisoCompuesto> Permisos
        {
            get
            {
                return _permisos;
            }
          
        }
        public override string ToString()
        {
            return Email; 
        }
    }
}

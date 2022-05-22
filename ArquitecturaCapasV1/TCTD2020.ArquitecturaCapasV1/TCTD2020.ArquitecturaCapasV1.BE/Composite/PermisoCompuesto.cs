using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCTD2020.ArquitecturaCapasV1.BE.Composite
{
    public abstract class PermisoCompuesto : Entity
    {
        public string Nombre { get; set; }


       public abstract void AgregarPermiso(PermisoCompuesto p);
        public abstract void QuitarPermiso(PermisoCompuesto p);
        public abstract IList<PermisoCompuesto> ObtenerHijos();

        public override string ToString()
        {
            return this.Nombre;
        }
    
    }
}

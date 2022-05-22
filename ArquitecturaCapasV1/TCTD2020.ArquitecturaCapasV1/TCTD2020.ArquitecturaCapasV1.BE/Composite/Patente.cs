using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCTD2020.ArquitecturaCapasV1.BE.Composite
{
   public class Patente : PermisoCompuesto
    {
        public TipoPermiso Tipo { get; set; }

        public override void AgregarPermiso(PermisoCompuesto p)
        {
          
        }

        public override IList<PermisoCompuesto> ObtenerHijos()
        {
            return new List<PermisoCompuesto>();
        }

        public override void QuitarPermiso(PermisoCompuesto p)
        {
            
        }
    }
}

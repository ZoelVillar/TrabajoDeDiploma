using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCTD2020.ArquitecturaCapasV1.BE.Composite
{
    public class Familia : PermisoCompuesto
    {
        private IList<PermisoCompuesto> _hijos;
        public Familia()
        {
            _hijos = new List<PermisoCompuesto>();
        }
        public override void AgregarPermiso(PermisoCompuesto p)
        {
            if (!_hijos.Contains(p))
                _hijos.Add(p);
        }

        public override IList<PermisoCompuesto> ObtenerHijos()
        {
            return _hijos.ToArray();
        }

        public override void QuitarPermiso(PermisoCompuesto p)
        {
            if (_hijos.Contains(p))
                _hijos.Remove(p);
        }
    }
}

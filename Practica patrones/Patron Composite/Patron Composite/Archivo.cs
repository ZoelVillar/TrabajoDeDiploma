using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patron_Composite
{
    public class Archivo : Componente
    {
        int _tamaño;
        public Archivo(string nombre, int tamaño) : base(nombre)
        {
            _tamaño = tamaño;
        }
        public int Tamaño { get { return _tamaño; } }

        public override int ObtenerTamaño { get { return Tamaño; } }

        public override void AgregarHijo(Componente componente)
        {
            throw new NotImplementedException();
        }

        public override IList<Componente> ObtenerHijos()
        {
            throw new NotImplementedException();
        }
    }
}

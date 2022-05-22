using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patron_Composite
{
    public class Directorio : Componente
    {
        private List<Componente> Hijos;
        public Directorio(string nombre) : base(nombre)
        {
            Hijos = new List<Componente>();
        }


        public override void AgregarHijo(Componente componente)
        {
            Hijos.Add(componente);
        }

        public override IList<Componente> ObtenerHijos()
        {
            return Hijos.ToArray();
        }

        public override int ObtenerTamaño
        {
            get
            {
                int num = 0;
                foreach (var H in Hijos)
                {
                    num += H.ObtenerTamaño;
                }
                return num;
            }
        }
    }
}

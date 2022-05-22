using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pueba_Observer
{
    class Producto : ISujetoProducto
    {
        private List<IObserverUsuario> _usuarios;
        public Producto(string nombre, double precio)
        {
            _usuarios = new List<IObserverUsuario>();
            _precio = precio;
            Nombre = nombre;
        }
        public string Nombre { get; set; }
        double _precio;
        public double Precio { get { return _precio; } set { _precio = value; this.Notificar(); } }

        public void Agregar(IObserverUsuario usuario)
        {
            _usuarios.Add(usuario);
        }

        public void Notificar()
        {
            foreach(var usu in _usuarios)
            {
                usu.Actualizar(this);
            }
            if(_usuarios.Count == 0)
            {
                //Notificar.("No hay suscripciones");
            }
        }

        public void Quitar(IObserverUsuario usuario)
        {
            _usuarios.Remove(usuario);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pueba_Observer
{
    class Usuario : IObserverUsuario
    {
        public Usuario(string nombre, string apellido)
        {
            Nombre = nombre;
            Apellido = apellido;
        }

        public string Nombre { get; set; }
        public string Apellido { get; set; }

        public void Actualizar(Producto producto)
        {
            //Notificar.($"El usuario {this} recibio notificacion del producto {p}")
        }
    }
}

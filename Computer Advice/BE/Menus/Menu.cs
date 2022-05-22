using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vista.Menus
{
    class Menu
    {
        public string Nombre { get; set; }
        public string Icono { get; set; }
        public List<Submenu> Listasubmenus { get; set; }
    }
}

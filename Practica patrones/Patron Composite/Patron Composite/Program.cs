using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patron_Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            Componente root = new Directorio("Raiz");

            Componente archivo1 = new Archivo("archivo1", 10);
            Componente archivo2 = new Archivo("archivo2", 20);
            Componente archivo3 = new Archivo("archivo3", 30);
            Componente archivo4 = new Archivo("archivo4", 40);
            Componente archivo5 = new Archivo("archivo5", 50);
            Componente archivo6 = new Archivo("archivo6", 60);

            Componente dir1 = new Directorio("dir1");
            Componente dir2 = new Directorio("dir2");
            Componente dir3 = new Directorio("dir3");

            dir1.AgregarHijo(archivo1);
            dir1.AgregarHijo(archivo2);
            dir3.AgregarHijo(archivo3);
            dir3.AgregarHijo(archivo4);
            dir1.AgregarHijo(dir1);


        }
    }
}

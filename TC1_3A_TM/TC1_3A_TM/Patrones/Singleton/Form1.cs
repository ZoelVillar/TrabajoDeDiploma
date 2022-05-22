using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Singleton
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AccesoBD _x = AccesoBD.InstanciaDeAccesoaBD(1);
            AccesoBD _y = AccesoBD.InstanciaDeAccesoaBD(2);
            MessageBox.Show($"Id de _x: {_x.Id}  y Id es _y: {_y.Id}");
        }
    }
    public class AccesoBD
    {
        static AccesoBD _AccesoBDSingleton;
        public int Id { get; set; }
        // Constructor is 'protected'
        protected AccesoBD()
        {
        }
        public static AccesoBD InstanciaDeAccesoaBD(int pID)
        {
            // Uses lazy initialization.
            // Note: this is not thread safe.
            if (_AccesoBDSingleton == null)
            {
               _AccesoBDSingleton = new AccesoBD();
                _AccesoBDSingleton.Id = pID;
            }
            return _AccesoBDSingleton;
        }
    }
}

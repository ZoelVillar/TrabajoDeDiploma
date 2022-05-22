using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using System.Runtime.InteropServices;
using Corte.CacheFolder;

namespace Vista
{
    public partial class FormPrincipal : Form
    {
        private IconButton botonActual;
        private Panel panelIzquierdoBtn;
        private Form currentChildForm;
        public FormPrincipal()
        {
            InitializeComponent();
            botonActual = new IconButton();
            panelIzquierdoBtn = new Panel();
            panelIzquierdoBtn.Size = new Size(7,55);
            panelLateral.Controls.Add(panelIzquierdoBtn);
            currentChildForm = new Form();

            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }
        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            CargarDatosDeUsuario();
        }

        #region "AnimarBotones"
        private void botonActivo(object senderBtn, Color color)
        {
            if(senderBtn != null)
            {
                descativarBoton();
                botonActual = (IconButton)senderBtn;
                botonActual.BackColor = Color.FromArgb(20,20,20);
                botonActual.ForeColor = color;
                botonActual.TextAlign = ContentAlignment.MiddleCenter;
                botonActual.IconColor = color;
                botonActual.TextImageRelation = TextImageRelation.TextBeforeImage;
                botonActual.ImageAlign = ContentAlignment.MiddleRight;

                panelIzquierdoBtn.BackColor = color;
                panelIzquierdoBtn.Location = new Point(0, botonActual.Location.Y);
                panelIzquierdoBtn.Visible = true;
                panelIzquierdoBtn.BringToFront();

                IconoEnFormulario.IconChar = botonActual.IconChar;
                IconoEnFormulario.IconColor = color;
            }
        }

        private void descativarBoton()
        {
            if(botonActual != null)
            {
                botonActual.BackColor = Color.FromArgb(9, 39, 40);
                botonActual.ForeColor = Color.FromArgb(230, 230, 237);
                botonActual.TextAlign = ContentAlignment.MiddleLeft;
                botonActual.IconColor = Color.FromArgb(230, 230, 237);
                botonActual.TextImageRelation = TextImageRelation.ImageBeforeText;
                botonActual.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }
        #endregion

        #region "Botones"
        #region "Colores"
        private struct RGBcolors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(238, 203, 63);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(24, 161, 251);
            public static Color color7 = Color.FromArgb(65, 138, 236);

        }
        #endregion
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Seguro que quieres salir", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void btnInicio_Click(object sender, EventArgs e)
        {
            currentChildForm.Close();
            IconoEnFormulario.IconChar = IconChar.Home;
            IconoEnFormulario.IconColor = Color.FromArgb(230, 230, 237);
            descativarBoton();
        }
        private void btnPerfil_Click(object sender, EventArgs e)
        {
            botonActivo(sender, RGBcolors.color1);
            abrirFormulario(new FormPerfil());
        }

        private void btnComputadoras_Click(object sender, EventArgs e)
        {
            botonActivo(sender, RGBcolors.color2);
            abrirFormulario(new FormExplorarPC());
        }

        private void btnMensajes_Click(object sender, EventArgs e)
        {
            botonActivo(sender, RGBcolors.color3);
            abrirFormulario(new FormMensajes());
        }

        private void btnForo_Click(object sender, EventArgs e)
        {
            botonActivo(sender, RGBcolors.color5);
            abrirFormulario(new FormForo());
        }

        private void btnFavoritos_Click(object sender, EventArgs e)
        {
            botonActivo(sender, RGBcolors.color4);
            abrirFormulario(new FormFavoritos());
        }
        private void btnHistorial_Click(object sender, EventArgs e)
        {
            botonActivo(sender, RGBcolors.color7);
            abrirFormulario(new FormHistorial());
        }
        private void btnLogout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Seguro que quieres cerrar sesión?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.Close();
            }
        }
        #endregion

        #region "MoverPantalla"
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int IParam);

        private void panelBarra_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        #endregion
        private void abrirFormulario(Form childForm)
        {
            if(childForm != null)
            {
                currentChildForm.Close();
            }

            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelEscritorio.Controls.Add(childForm);
            panelEscritorio.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            childForm.Size = panelEscritorio.Size;
        }

        private void CargarDatosDeUsuario()
        {
            lblNombreYApellido.Text = CacheDeUsuario.FirstName+" "+ CacheDeUsuario.LastName;
            lblCargo.Text = CacheDeUsuario.Position;
        }

        //SEGURIDAD - PRIVILEGIOS DE USUARIO
        public void CualquierMetodo()
        {
            if (CacheDeUsuario.Position == Cargos.Administrador)
            {
                //Algo
                //btnMensajes.Enabled = false;
            }
            if (CacheDeUsuario.Position == Cargos.Backend || CacheDeUsuario.Position == Cargos.Administrador)
            {
                //Algo
            }
        }
      
    }
}

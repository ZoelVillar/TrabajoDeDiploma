using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using BE;

namespace Vista
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }
        #region "Metodos"
        private void txtuser_MouseHover(object sender, EventArgs e)
        {
            if(txtuser.Text == "Usuario")
            {
                txtuser.Text = "";
                txtuser.ForeColor = Color.LightGray;
            }
        }

        private void txtuser_MouseLeave(object sender, EventArgs e)
        {
            if (txtuser.Text == "")
            {
                txtuser.Text = "Usuario";
                txtuser.ForeColor = Color.DimGray;
            }
        }

        private void txtpass_MouseHover(object sender, EventArgs e)
        {
            if (txtpass.Text == "Contraseña")
            {
                txtpass.Text = "";
                txtpass.ForeColor = Color.LightGray;
                txtpass.UseSystemPasswordChar = true;
            }
        }

        private void txtpass_MouseLeave(object sender, EventArgs e)
        {
            if (txtpass.Text == "")
            {
                txtpass.Text = "Contraseña";
                txtpass.ForeColor = Color.DimGray;
                txtpass.UseSystemPasswordChar = false;
            }
        }
        private void txtpass_TextChanged(object sender, EventArgs e)
        {
            txtpass.ForeColor = Color.LightGray;
            txtpass.UseSystemPasswordChar = true;
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnminimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
#endregion

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            if (txtuser.Text != "Usuario" && txtuser.Text != "")
            {
                if (txtpass.Text != "Contraseña" && txtpass.Text != "")
                {
                    BE_Usuario usuario = new BE_Usuario();
                    if (usuario.Login(txtuser.Text, txtpass.Text))
                    {
                        FormPrincipal MenuPrincipal = new FormPrincipal();
                        MenuPrincipal.Show();
                        MenuPrincipal.FormClosed += Logout;
                        this.Hide();
                    }
                    else { msjError("Contraseña o nombre de usuario incorrectos"); txtpass.Text = "Contraseña";  txtuser.Text = "Usuario"; }
                }
                else msjError("Ingrese la contraseña");
            }
            else msjError("Ingrese el nombre de usuario");
        }

        private void msjError(string msg)
        {
            lblError.Text = "   " + msg;
            lblError.Visible = true;
        }

        private void Logout(object sender, FormClosedEventArgs e)
        {
            txtpass.Text = "Contraseña";
            txtuser.Text = "Usuario";
            txtpass.UseSystemPasswordChar = false;
            lblError.Visible = false;
            this.Show();
        }

        private void btncerrar_MouseHover(object sender, EventArgs e)
        {
            //btncerrar.Image = Image.FromFile(@"C:\Users\Villa\OneDrive\Facu UAI\3eraño\1- Trabajo de campo\Computer Advise\SalirMouseOver.png");
        }

        private void btncerrar_MouseLeave(object sender, EventArgs e)
        {
            //btncerrar.Image = Image.FromFile(@"C:\Users\Villa\OneDrive\Facu UAI\3er año\1- Trabajo de campo\Computer Advise\SalirMouseLeave.png");
        }

        private void btnIrRegistrarse_Click(object sender, EventArgs e)
        {
            btnIrRegistrarse.BackColor = Color.FromArgb(43, 185, 193);
            FormRegistrarse Registrarse = new FormRegistrarse();
            Registrarse.Show();
            this.Hide();
        }
    }
}

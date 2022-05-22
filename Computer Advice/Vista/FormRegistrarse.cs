using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Validaciones;
using BE;

namespace Vista
{
    public partial class FormRegistrarse : Form
    {
        VAL_Registrarse ValRegistro = new VAL_Registrarse();
        BE_Usuario BEUsuario = new BE_Usuario();

        public FormRegistrarse()
        {
            InitializeComponent();

        }

        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
            try
            {
                lblValidarRegistro();
            }
            catch (Exception) { throw; }
        }
        #region "Mostrar errores"

        public void lblValidarRegistro()
        {
            if (txtNombreDeUsuario.Text != null && txtNombreDeUsuario.Text != "Nombre de Usuario")
            {
                string NombreDeUsuario = txtNombreDeUsuario.Text;
                if (txtNombre.Text != null && txtNombre.Text != "Nombre" && txtApellido.Text != "Apelldio" && txtApellido.Text != null)
                {
                    string Nombre = txtNombre.Text;
                    string Apellido = txtApellido.Text;
                    if (txtEmail.Text != null && txtEmail.Text != "Email")
                    {
                        string Email = txtEmail.Text;
                        if (txtpass.Text != null && txtpass.Text != "Contraseña")
                        {
                            string Contraseña = txtpass.Text;

                            lblValidarDatosEnRegistro(NombreDeUsuario, Nombre, Apellido, Email, Contraseña);

                        }
                        else { lblErrorVacio(); }
                    }
                    else { lblErrorVacio(); }
                }
                else { lblErrorVacio(); }
            }
            else { lblErrorVacio(); }
        }
        public void lblValidarDatosEnRegistro(string nombreDeUsuario, string nombre, string apellido, string email, string contraseña)
        {
            lblError.Text = "";
            if (ValRegistro.ValidarNombreDeUsuario(nombreDeUsuario) && BEUsuario.YaExisteEnBD(nombreDeUsuario))
            {
                if (ValRegistro.ValidarNombreYApellido(nombre) && ValRegistro.ValidarNombreYApellido(apellido))
                {
                    if (ValRegistro.ValidarEmail(email))
                    {
                        if (ValRegistro.ValidarContraseña(contraseña))
                        {
                            BEUsuario.Registrarse(nombreDeUsuario, nombre, apellido, email, contraseña);
                            FormLogin formLogin = new FormLogin();
                            formLogin.Show();
                            this.Hide();
                        }
                        else { lblError.Visible = true; lblError.Text = "   Contraseña debe contener caracter minúscula, mayúscula, especial y numerico\n"; }
                    }
                    else { lblError.Visible = true; lblError.Text = "   Email invalido\n"; }
                }
                else { lblError.Visible = true; lblError.Text += "   Nombre o Apellido invalido\n"; }
            }
            else { lblError.Visible = true; lblError.Text = "   Nombre de usuario invalido \n"; }
        }
        public void lblErrorVacio()
        {
            lblError.Text = ""; lblError.Visible = true; lblError.Text = "   Complete todos los campos";
        }

        #endregion

        #region "Botones de accion"
        private void btnminimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void btncerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnIrIniciarSesion_Click(object sender, EventArgs e)
        {
            btnIrIniciarSesion.BackColor = Color.FromArgb(43, 185, 193);
            FormLogin IniciarSesion = new FormLogin();
            IniciarSesion.Show();
            this.Hide();
        }
        #endregion

        #region "Textos de botones"

        private void txtuser_MouseHover(object sender, EventArgs e)
        {
            if (txtNombreDeUsuario.Text == "Nombre de Usuario")
            {
                txtNombreDeUsuario.Text = "";
                txtNombreDeUsuario.ForeColor = Color.LightGray;
            }
        }

        private void txtuser_MouseLeave(object sender, EventArgs e)
        {
            if (txtNombreDeUsuario.Text == "")
            {
                txtNombreDeUsuario.Text = "Nombre de Usuario";
                txtNombreDeUsuario.ForeColor = Color.DimGray;
            }
        }

        private void textBox1_MouseHover(object sender, EventArgs e)
        {
            if (txtNombre.Text == "Nombre")
            {
                txtNombre.Text = "";
                txtNombre.ForeColor = Color.LightGray;
            }
        }

        private void textBox1_MouseLeave(object sender, EventArgs e)
        {
            if (txtNombre.Text == "")
            {
                txtNombre.Text = "Nombre";
                txtNombre.ForeColor = Color.DimGray;
            }
        }

        private void textBox2_MouseHover(object sender, EventArgs e)
        {
            if (txtApellido.Text == "Apellido")
            {
                txtApellido.Text = "";
                txtApellido.ForeColor = Color.LightGray;
            }
        }

        private void textBox2_MouseLeave(object sender, EventArgs e)
        {
            if (txtApellido.Text == "")
            {
                txtApellido.Text = "Apellido";
                txtApellido.ForeColor = Color.DimGray;
            }
        }

        private void textBox3_MouseHover(object sender, EventArgs e)
        {
            if (txtEmail.Text == "Email")
            {
                txtEmail.Text = "";
                txtEmail.ForeColor = Color.LightGray;
            }
        }

        private void textBox3_MouseLeave(object sender, EventArgs e)
        {
            if (txtEmail.Text == "")
            {
                txtEmail.Text = "Email";
                txtEmail.ForeColor = Color.DimGray;
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


        #endregion
    }
}

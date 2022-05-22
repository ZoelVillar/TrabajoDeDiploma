
namespace Vista
{
    partial class FormRegistrarse
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRegistrarse));
            this.Logo = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRegistrarse = new System.Windows.Forms.Button();
            this.PanelDeIngreso = new System.Windows.Forms.Panel();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblError = new System.Windows.Forms.Label();
            this.txtNombreDeUsuario = new System.Windows.Forms.TextBox();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.shapeContainer2 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape7 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape6 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape5 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.btnminimizar = new System.Windows.Forms.PictureBox();
            this.btncerrar = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblTitulo2 = new System.Windows.Forms.Label();
            this.lblTitulo1 = new System.Windows.Forms.Label();
            this.lineShape3 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape8 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape4 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.btnIrIniciarSesion = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.PanelDeIngreso.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnminimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btncerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // Logo
            // 
            this.Logo.Image = ((System.Drawing.Image)(resources.GetObject("Logo.Image")));
            this.Logo.Location = new System.Drawing.Point(85, 70);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(116, 99);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Logo.TabIndex = 18;
            this.Logo.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(238)))), ((int)(((byte)(240)))));
            this.label1.Location = new System.Drawing.Point(123, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 31);
            this.label1.TabIndex = 4;
            this.label1.Text = "REGISTRARSE";
            // 
            // btnRegistrarse
            // 
            this.btnRegistrarse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnRegistrarse.FlatAppearance.BorderSize = 0;
            this.btnRegistrarse.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnRegistrarse.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnRegistrarse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(238)))), ((int)(((byte)(240)))));
            this.btnRegistrarse.Location = new System.Drawing.Point(21, 334);
            this.btnRegistrarse.Name = "btnRegistrarse";
            this.btnRegistrarse.Size = new System.Drawing.Size(401, 40);
            this.btnRegistrarse.TabIndex = 3;
            this.btnRegistrarse.Text = "REGISTRARSE";
            this.btnRegistrarse.UseVisualStyleBackColor = false;
            this.btnRegistrarse.Click += new System.EventHandler(this.btnRegistrarse_Click);
            // 
            // PanelDeIngreso
            // 
            this.PanelDeIngreso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.PanelDeIngreso.Controls.Add(this.txtEmail);
            this.PanelDeIngreso.Controls.Add(this.txtApellido);
            this.PanelDeIngreso.Controls.Add(this.txtNombre);
            this.PanelDeIngreso.Controls.Add(this.lblError);
            this.PanelDeIngreso.Controls.Add(this.label1);
            this.PanelDeIngreso.Controls.Add(this.txtNombreDeUsuario);
            this.PanelDeIngreso.Controls.Add(this.txtpass);
            this.PanelDeIngreso.Controls.Add(this.btnRegistrarse);
            this.PanelDeIngreso.Controls.Add(this.shapeContainer2);
            this.PanelDeIngreso.Location = new System.Drawing.Point(304, 43);
            this.PanelDeIngreso.Name = "PanelDeIngreso";
            this.PanelDeIngreso.Size = new System.Drawing.Size(462, 394);
            this.PanelDeIngreso.TabIndex = 17;
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.ForeColor = System.Drawing.Color.DimGray;
            this.txtEmail.Location = new System.Drawing.Point(25, 188);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(405, 19);
            this.txtEmail.TabIndex = 13;
            this.txtEmail.Text = "Email";
            this.txtEmail.MouseLeave += new System.EventHandler(this.textBox3_MouseLeave);
            this.txtEmail.MouseHover += new System.EventHandler(this.textBox3_MouseHover);
            // 
            // txtApellido
            // 
            this.txtApellido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.txtApellido.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellido.ForeColor = System.Drawing.Color.DimGray;
            this.txtApellido.Location = new System.Drawing.Point(230, 132);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(200, 19);
            this.txtApellido.TabIndex = 12;
            this.txtApellido.Text = "Apellido";
            this.txtApellido.MouseLeave += new System.EventHandler(this.textBox2_MouseLeave);
            this.txtApellido.MouseHover += new System.EventHandler(this.textBox2_MouseHover);
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.ForeColor = System.Drawing.Color.DimGray;
            this.txtNombre.Location = new System.Drawing.Point(28, 132);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(200, 19);
            this.txtNombre.TabIndex = 11;
            this.txtNombre.Text = "Nombre";
            this.txtNombre.MouseLeave += new System.EventHandler(this.textBox1_MouseLeave);
            this.txtNombre.MouseHover += new System.EventHandler(this.textBox1_MouseHover);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.ForeColor = System.Drawing.Color.DarkGray;
            this.lblError.Image = ((System.Drawing.Image)(resources.GetObject("lblError.Image")));
            this.lblError.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblError.Location = new System.Drawing.Point(22, 285);
            this.lblError.Name = "lblError";
            this.lblError.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblError.Size = new System.Drawing.Size(0, 17);
            this.lblError.TabIndex = 10;
            this.lblError.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblError.Visible = false;
            // 
            // txtNombreDeUsuario
            // 
            this.txtNombreDeUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.txtNombreDeUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombreDeUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreDeUsuario.ForeColor = System.Drawing.Color.DimGray;
            this.txtNombreDeUsuario.Location = new System.Drawing.Point(25, 83);
            this.txtNombreDeUsuario.Name = "txtNombreDeUsuario";
            this.txtNombreDeUsuario.Size = new System.Drawing.Size(401, 19);
            this.txtNombreDeUsuario.TabIndex = 1;
            this.txtNombreDeUsuario.Text = "Nombre de Usuario";
            this.txtNombreDeUsuario.MouseLeave += new System.EventHandler(this.txtuser_MouseLeave);
            this.txtNombreDeUsuario.MouseHover += new System.EventHandler(this.txtuser_MouseHover);
            // 
            // txtpass
            // 
            this.txtpass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.txtpass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpass.ForeColor = System.Drawing.Color.DimGray;
            this.txtpass.Location = new System.Drawing.Point(25, 246);
            this.txtpass.Name = "txtpass";
            this.txtpass.Size = new System.Drawing.Size(401, 19);
            this.txtpass.TabIndex = 2;
            this.txtpass.Text = "Contraseña";
            this.txtpass.MouseLeave += new System.EventHandler(this.txtpass_MouseLeave);
            this.txtpass.MouseHover += new System.EventHandler(this.txtpass_MouseHover);
            // 
            // shapeContainer2
            // 
            this.shapeContainer2.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer2.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer2.Name = "shapeContainer2";
            this.shapeContainer2.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape7,
            this.lineShape6,
            this.lineShape5,
            this.lineShape2,
            this.lineShape1});
            this.shapeContainer2.Size = new System.Drawing.Size(462, 394);
            this.shapeContainer2.TabIndex = 9;
            this.shapeContainer2.TabStop = false;
            // 
            // lineShape7
            // 
            this.lineShape7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(238)))), ((int)(((byte)(240)))));
            this.lineShape7.Name = "lineShape7";
            this.lineShape7.X1 = 25;
            this.lineShape7.X2 = 425;
            this.lineShape7.Y1 = 221;
            this.lineShape7.Y2 = 221;
            // 
            // lineShape6
            // 
            this.lineShape6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(238)))), ((int)(((byte)(240)))));
            this.lineShape6.Name = "lineShape6";
            this.lineShape6.X1 = 230;
            this.lineShape6.X2 = 425;
            this.lineShape6.Y1 = 165;
            this.lineShape6.Y2 = 165;
            // 
            // lineShape5
            // 
            this.lineShape5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(238)))), ((int)(((byte)(240)))));
            this.lineShape5.Name = "lineShape5";
            this.lineShape5.X1 = 25;
            this.lineShape5.X2 = 207;
            this.lineShape5.Y1 = 165;
            this.lineShape5.Y2 = 165;
            // 
            // lineShape2
            // 
            this.lineShape2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(238)))), ((int)(((byte)(240)))));
            this.lineShape2.Name = "lineShape2";
            this.lineShape2.X1 = 25;
            this.lineShape2.X2 = 425;
            this.lineShape2.Y1 = 277;
            this.lineShape2.Y2 = 277;
            // 
            // lineShape1
            // 
            this.lineShape1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(238)))), ((int)(((byte)(240)))));
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 25;
            this.lineShape1.X2 = 425;
            this.lineShape1.Y1 = 116;
            this.lineShape1.Y2 = 116;
            // 
            // btnminimizar
            // 
            this.btnminimizar.Image = ((System.Drawing.Image)(resources.GetObject("btnminimizar.Image")));
            this.btnminimizar.Location = new System.Drawing.Point(765, 5);
            this.btnminimizar.Name = "btnminimizar";
            this.btnminimizar.Size = new System.Drawing.Size(30, 30);
            this.btnminimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnminimizar.TabIndex = 16;
            this.btnminimizar.TabStop = false;
            this.btnminimizar.Click += new System.EventHandler(this.btnminimizar_Click);
            // 
            // btncerrar
            // 
            this.btncerrar.Image = ((System.Drawing.Image)(resources.GetObject("btncerrar.Image")));
            this.btncerrar.Location = new System.Drawing.Point(800, 5);
            this.btncerrar.Name = "btncerrar";
            this.btncerrar.Size = new System.Drawing.Size(30, 30);
            this.btncerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btncerrar.TabIndex = 15;
            this.btncerrar.TabStop = false;
            this.btncerrar.Click += new System.EventHandler(this.btncerrar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(185)))), ((int)(((byte)(193)))));
            this.label6.Location = new System.Drawing.Point(88, 305);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "¿Ya tienes una cuenta?";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(238)))), ((int)(((byte)(240)))));
            this.label5.Location = new System.Drawing.Point(100, 262);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 20);
            this.label5.TabIndex = 22;
            this.label5.Text = "Regístrate";
            // 
            // lblTitulo2
            // 
            this.lblTitulo2.AutoSize = true;
            this.lblTitulo2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(238)))), ((int)(((byte)(240)))));
            this.lblTitulo2.Location = new System.Drawing.Point(90, 205);
            this.lblTitulo2.Name = "lblTitulo2";
            this.lblTitulo2.Size = new System.Drawing.Size(102, 31);
            this.lblTitulo2.TabIndex = 21;
            this.lblTitulo2.Text = "Advice";
            // 
            // lblTitulo1
            // 
            this.lblTitulo1.AutoSize = true;
            this.lblTitulo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(238)))), ((int)(((byte)(240)))));
            this.lblTitulo1.Location = new System.Drawing.Point(70, 175);
            this.lblTitulo1.Name = "lblTitulo1";
            this.lblTitulo1.Size = new System.Drawing.Size(141, 31);
            this.lblTitulo1.TabIndex = 20;
            this.lblTitulo1.Text = "Computer";
            // 
            // lineShape3
            // 
            this.lineShape3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.lineShape3.Name = "lineShape3";
            this.lineShape3.X1 = 35;
            this.lineShape3.X2 = 265;
            this.lineShape3.Y1 = 250;
            this.lineShape3.Y2 = 250;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape8,
            this.lineShape4,
            this.lineShape3});
            this.shapeContainer1.Size = new System.Drawing.Size(835, 465);
            this.shapeContainer1.TabIndex = 24;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape8
            // 
            this.lineShape8.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.lineShape8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lineShape8.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(185)))), ((int)(((byte)(193)))));
            this.lineShape8.Name = "lineShape8";
            this.lineShape8.X1 = 89;
            this.lineShape8.X2 = 204;
            this.lineShape8.Y1 = 355;
            this.lineShape8.Y2 = 355;
            // 
            // lineShape4
            // 
            this.lineShape4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.lineShape4.Name = "lineShape4";
            this.lineShape4.X1 = 35;
            this.lineShape4.X2 = 265;
            this.lineShape4.Y1 = 295;
            this.lineShape4.Y2 = 295;
            // 
            // btnIrIniciarSesion
            // 
            this.btnIrIniciarSesion.FlatAppearance.BorderSize = 0;
            this.btnIrIniciarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIrIniciarSesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnIrIniciarSesion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(238)))), ((int)(((byte)(240)))));
            this.btnIrIniciarSesion.Location = new System.Drawing.Point(89, 327);
            this.btnIrIniciarSesion.Margin = new System.Windows.Forms.Padding(0);
            this.btnIrIniciarSesion.Name = "btnIrIniciarSesion";
            this.btnIrIniciarSesion.Size = new System.Drawing.Size(116, 28);
            this.btnIrIniciarSesion.TabIndex = 25;
            this.btnIrIniciarSesion.Text = "Inicia sesión";
            this.btnIrIniciarSesion.UseVisualStyleBackColor = true;
            this.btnIrIniciarSesion.Click += new System.EventHandler(this.btnIrIniciarSesion_Click);
            // 
            // FormRegistrarse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(66)))), ((int)(((byte)(67)))));
            this.ClientSize = new System.Drawing.Size(835, 465);
            this.Controls.Add(this.btnIrIniciarSesion);
            this.Controls.Add(this.Logo);
            this.Controls.Add(this.PanelDeIngreso);
            this.Controls.Add(this.btnminimizar);
            this.Controls.Add(this.btncerrar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblTitulo2);
            this.Controls.Add(this.lblTitulo1);
            this.Controls.Add(this.shapeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormRegistrarse";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormRegistrarse";
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.PanelDeIngreso.ResumeLayout(false);
            this.PanelDeIngreso.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnminimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btncerrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRegistrarse;
        private System.Windows.Forms.Panel PanelDeIngreso;
        private System.Windows.Forms.TextBox txtNombreDeUsuario;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer2;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.PictureBox btnminimizar;
        private System.Windows.Forms.PictureBox btncerrar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblTitulo2;
        private System.Windows.Forms.Label lblTitulo1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape3;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape4;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtpass;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape7;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape6;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape5;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape8;
        private System.Windows.Forms.Button btnIrIniciarSesion;
        private System.Windows.Forms.Label lblError;
    }
}
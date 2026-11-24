using Biblioteca;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Escritorio
{
    public partial class FrmAutenticacion : Form
    {
        public FrmAutenticacion()
        {
            InitializeComponent();
            AplicarEstilo();
        }

        private void AplicarEstilo()
        {
            // Configuración de la ventana
            this.Text = "Autenticación";
            this.ClientSize = new Size(540, 460);
            this.MinimumSize = new Size(540, 460);
            this.MaximumSize = new Size(540, 460);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.BackColor = Color.FromArgb(245, 247, 251);
            this.Font = new Font("Segoe UI", 10F);

            // Encabezado
            Panel encabezado = new Panel();
            encabezado.BackColor = Color.FromArgb(23, 59, 112);
            encabezado.SetBounds(0, 0, 540, 105);

            Label titulo = new Label();
            titulo.Text = "INICIO DE SESIÓN";
            titulo.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            titulo.ForeColor = Color.White;
            titulo.AutoSize = true;
            titulo.Location = new Point(105, 20);

            Label subtitulo = new Label();
            subtitulo.Text = "Sistema de Herramientas";
            subtitulo.Font = new Font("Segoe UI", 10F);
            subtitulo.ForeColor = Color.FromArgb(220, 235, 255);
            subtitulo.AutoSize = true;
            subtitulo.Location = new Point(145, 62);

            encabezado.Controls.Add(titulo);
            encabezado.Controls.Add(subtitulo);

            // Panel blanco
            Panel panelLogin = new Panel();
            panelLogin.BackColor = Color.White;
            panelLogin.SetBounds(55, 135, 430, 285);

            // Título del panel
            Label lblBienvenido = new Label();
            lblBienvenido.Text = "Bienvenido";
            lblBienvenido.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblBienvenido.ForeColor = Color.FromArgb(23, 59, 112);
            lblBienvenido.AutoSize = true;
            lblBienvenido.Location = new Point(145, 18);

            // Etiquetas
            lblUsuario.Text = "Usuario";
            lblUsuario.SetBounds(45, 78, 100, 25);
            lblUsuario.Font = new Font("Segoe UI", 10F, FontStyle.Bold);

            lblClave.Text = "Contraseña";
            lblClave.SetBounds(45, 135, 110, 25);
            lblClave.Font = new Font("Segoe UI", 10F, FontStyle.Bold);

            // Campos de texto
            txtUsuario.SetBounds(45, 103, 340, 32);
            txtUsuario.Font = new Font("Segoe UI", 11F);
            txtUsuario.BorderStyle = BorderStyle.FixedSingle;
            txtUsuario.BackColor = Color.White;
            txtUsuario.ForeColor = Color.FromArgb(31, 41, 55);

            txtClave.SetBounds(45, 160, 340, 32);
            txtClave.Font = new Font("Segoe UI", 11F);
            txtClave.BorderStyle = BorderStyle.FixedSingle;
            txtClave.BackColor = Color.White;
            txtClave.ForeColor = Color.FromArgb(31, 41, 55);
            txtClave.UseSystemPasswordChar = true;

            // Botón ingresar
            btnIngresar.Text = "INGRESAR";
            btnIngresar.SetBounds(45, 220, 155, 42);
            btnIngresar.BackColor = Color.FromArgb(37, 99, 235);
            btnIngresar.ForeColor = Color.White;
            btnIngresar.FlatStyle = FlatStyle.Flat;
            btnIngresar.FlatAppearance.BorderSize = 0;
            btnIngresar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnIngresar.Cursor = Cursors.Hand;

            // Botón salir
            btnSalir.Text = "SALIR";
            btnSalir.SetBounds(230, 220, 155, 42);
            btnSalir.BackColor = Color.FromArgb(220, 70, 70);
            btnSalir.ForeColor = Color.White;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.FlatAppearance.BorderSize = 0;
            btnSalir.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSalir.Cursor = Cursors.Hand;

            // Agregar controles al panel
            panelLogin.Controls.Add(lblBienvenido);

            panelLogin.Controls.Add(lblUsuario);
            panelLogin.Controls.Add(lblClave);
            panelLogin.Controls.Add(txtUsuario);
            panelLogin.Controls.Add(txtClave);
            panelLogin.Controls.Add(btnIngresar);
            panelLogin.Controls.Add(btnSalir);

            // Agregar paneles a la ventana
            this.Controls.Add(panelLogin);
            this.Controls.Add(encabezado);

            encabezado.BringToFront();

            // Enter permite ingresar
            this.AcceptButton = btnIngresar;
            this.CancelButton = btnSalir;
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsuario.Text) ||
                string.IsNullOrWhiteSpace(txtClave.Text))
            {
                MessageBox.Show(
                    "Ingrese su usuario y contraseña.",
                    "Datos incompletos",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                txtUsuario.Focus();
                return;
            }

            ClsAutenticacion login = new ClsAutenticacion();

            bool accesoOk = login.Autenticacion(
                txtUsuario.Text,
                txtClave.Text
            );

            if (accesoOk)
            {
                MessageBox.Show(
                    "Bienvenido Jeremy Klinger",
                    "Acceso concedido",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                FrmPrincipal frmPrincipal = new FrmPrincipal();
                frmPrincipal.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show(
                    "Usuario o clave incorrectos",
                    "Error de autenticación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                txtClave.Clear();
                txtClave.Focus();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(
                "¿Está seguro que desea salir?",
                "Salir",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            ) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void FrmAutenticacion_Load(object sender, EventArgs e)
        {
            txtUsuario.Focus();
        }

        // Eventos existentes del diseñador
        private void lbln1_Click(object sender, EventArgs e) { }
        private void txtN1_TextChanged(object sender, EventArgs e) { }
        private void lblN2_Click(object sender, EventArgs e) { }
        private void txtN2_TextChanged(object sender, EventArgs e) { }
        private void lblN1_Click(object sender, EventArgs e) { }
    }
}

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
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();

            // Este formulario utiliza un panel para mostrar
            // los otros formularios, no necesita MDI.
            this.IsMdiContainer = false;

            AplicarEstilo();
            MostrarBienvenida();

            ayudaToolStripMenuItem.Click += ayudaToolStripMenuItem_Click;
        }

        private void AplicarEstilo()
        {
            this.Text = "FrmPrincipal";
            this.BackColor = Color.FromArgb(18, 38, 70);
            this.WindowState = FormWindowState.Maximized;
            this.StartPosition = FormStartPosition.CenterScreen;

            // Menú superior
            menuStrip1.BackColor = Color.FromArgb(12, 27, 52);
            menuStrip1.ForeColor = Color.White;
            menuStrip1.Font = new Font("Segoe UI", 11, FontStyle.Bold);
            menuStrip1.Dock = DockStyle.Top;
            menuStrip1.RenderMode = ToolStripRenderMode.System;

            foreach (ToolStripMenuItem item in menuStrip1.Items)
            {
                item.ForeColor = Color.White;
                item.BackColor = Color.FromArgb(12, 27, 52);
            }

            // Panel principal
            pnlContenedor.Dock = DockStyle.Fill;
            pnlContenedor.BackColor = Color.FromArgb(18, 38, 70);
            pnlContenedor.BorderStyle = BorderStyle.None;

            pnlContenedor.BringToFront();
            menuStrip1.BringToFront();
        }

        private void MostrarBienvenida()
        {
            pnlContenedor.Controls.Clear();

            Label lblTitulo = new Label();
            lblTitulo.Text = "¡BIENVENIDO!";
            lblTitulo.Font = new Font("Segoe UI", 30, FontStyle.Bold);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.AutoSize = true;

            Label lblSubtitulo = new Label();
            lblSubtitulo.Text = "SISTEMA DE HERRAMIENTAS";
            lblSubtitulo.Font = new Font("Segoe UI", 16, FontStyle.Bold);
            lblSubtitulo.ForeColor = Color.FromArgb(80, 170, 255);
            lblSubtitulo.AutoSize = true;

            Label lblDescripcion = new Label();
            lblDescripcion.Text =
                "Selecciona una opción del menú superior\n" +
                "para comenzar a utilizar las herramientas.";
            lblDescripcion.Font = new Font("Segoe UI", 12);
            lblDescripcion.ForeColor = Color.WhiteSmoke;
            lblDescripcion.AutoSize = true;
            lblDescripcion.TextAlign = ContentAlignment.MiddleCenter;

            pnlContenedor.Controls.Add(lblTitulo);
            pnlContenedor.Controls.Add(lblSubtitulo);
            pnlContenedor.Controls.Add(lblDescripcion);

            CentrarBienvenida(lblTitulo, lblSubtitulo, lblDescripcion);

            pnlContenedor.Resize += (s, e) =>
                CentrarBienvenida(lblTitulo, lblSubtitulo, lblDescripcion);
        }

        private void CentrarBienvenida(
            Label titulo,
            Label subtitulo,
            Label descripcion)
        {
            titulo.Left = (pnlContenedor.ClientSize.Width - titulo.Width) / 2;
            titulo.Top = (pnlContenedor.ClientSize.Height / 2) - 100;

            subtitulo.Left = (pnlContenedor.ClientSize.Width - subtitulo.Width) / 2;
            subtitulo.Top = titulo.Bottom + 20;

            descripcion.Left = (pnlContenedor.ClientSize.Width - descripcion.Width) / 2;
            descripcion.Top = subtitulo.Bottom + 25;
        }

        private void AbrirFormulario(Form formulario)
        {
            pnlContenedor.Controls.Clear();

            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;

            pnlContenedor.Controls.Add(formulario);

            formulario.Show();
            formulario.BringToFront();
        }

        private void operacionesBasicasToolStripMenuItem_Click(
            object sender, EventArgs e)
        {
            AbrirFormulario(new FrmOperador());
        }

        private void calculadoraToolStripMenuItem_Click(
            object sender, EventArgs e)
        {
            AbrirFormulario(new FrmCalculadora());
        }

        private void digitoVerificadorToolStripMenuItem_Click(
            object sender, EventArgs e)
        {
            AbrirFormulario(new FrmDigitoVerificador());
        }

        private void ayudaToolStripMenuItem_Click(
            object sender, EventArgs e)
        {
            MessageBox.Show(
                "SISTEMA DE HERRAMIENTAS MATEMÁTICAS\n\n" +
                "Opciones disponibles:\n" +
                "• Operaciones básicas\n" +
                "• Calculadora\n" +
                "• Dígito verificador\n\n" +
                "Selecciona una opción del menú para utilizarla.",
                "Ayuda del sistema",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        private void salirToolStripMenuItem_Click(
            object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show(
                "¿Deseas salir del programa?",
                "Confirmar salida",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (respuesta == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
        }

        private void opcionesToolStripMenuItem_Click(
            object sender, EventArgs e)
        {
        }

        private void pnlContenedor_Paint(
            object sender, PaintEventArgs e)
        {
        }

        private void ayudaToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FrmAcercaDe acerca = new FrmAcercaDe();
            acerca.ShowDialog();
        }
    }
}

using Biblioteca;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Escritorio
{
    public partial class FrmOperador : Form
    {
        internal DockStyle dock;

        public FrmOperador()
        {
            InitializeComponent();
            AplicarEstilo();
        }

        private void AplicarEstilo()
        {
            // Configuración de la ventana
            this.Text = "Operadores matemáticos";
            this.Size = new Size(540, 340);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = Color.FromArgb(18, 38, 70);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Font = new Font("Segoe UI", 10);

            // Etiquetas
            lbln1.Text = "Ingrese el número 1";
            lblN2.Text = "Ingrese el número 2";

            foreach (Label lbl in new Label[] { lbln1, lblN2 })
            {
                lbl.ForeColor = Color.White;
                lbl.Font = new Font("Segoe UI", 11, FontStyle.Bold);
                lbl.AutoSize = true;
            }

            lbln1.Location = new Point(45, 55);
            lblN2.Location = new Point(45, 115);

            // Campos de texto
            foreach (TextBox txt in new TextBox[] { txtN1, txtN2 })
            {
                txt.Size = new Size(250, 32);
                txt.Font = new Font("Segoe UI", 12);
                txt.BackColor = Color.White;
                txt.ForeColor = Color.FromArgb(30, 50, 85);
                txt.BorderStyle = BorderStyle.FixedSingle;
            }

            txtN1.Location = new Point(235, 50);
            txtN2.Location = new Point(235, 110);

            // Botón Procesar
            btnProcesar.Text = "PROCESAR";
            btnProcesar.Size = new Size(135, 45);
            btnProcesar.Location = new Point(45, 195);
            btnProcesar.BackColor = Color.FromArgb(0, 115, 230);
            btnProcesar.ForeColor = Color.White;

            // Botón Encerar
            btnEncerar.Text = "LIMPIAR";
            btnEncerar.Size = new Size(135, 45);
            btnEncerar.Location = new Point(195, 195);
            btnEncerar.BackColor = Color.FromArgb(230, 145, 40);
            btnEncerar.ForeColor = Color.White;

            // Botón Salir
            btnSalir.Text = "SALIR";
            btnSalir.Size = new Size(135, 45);
            btnSalir.Location = new Point(345, 195);
            btnSalir.BackColor = Color.FromArgb(210, 65, 65);
            btnSalir.ForeColor = Color.White;

            foreach (Button btn in new Button[]
            {
            btnProcesar, btnEncerar, btnSalir
            })
            {
                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.BorderSize = 0;
                btn.Font = new Font("Segoe UI", 10, FontStyle.Bold);
                btn.Cursor = Cursors.Hand;
            }
        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            ClsOperadores opAux = new ClsOperadores();

            if (!opAux.EsNumero(txtN1.Text) ||
                !opAux.EsNumero(txtN2.Text))
            {
                MessageBox.Show(
                    "Ingrese solo números.",
                    "Datos incorrectos",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            double n1 = double.Parse(
                txtN1.Text,
                CultureInfo.CurrentCulture
            );

            double n2 = double.Parse(
                txtN2.Text,
                CultureInfo.CurrentCulture
            );

            ClsCalculadora calc = new ClsCalculadora();

            string division = n2 == 0
                ? "No se puede dividir para cero"
                : $"División: {calc.Dividir(n1, n2):F2}";

            string resultado =
                $"Suma: {calc.Sumar(n1, n2):F2}\n" +
                $"Resta: {calc.Restar(n1, n2):F2}\n" +
                $"Multiplicación: {calc.Multiplicar(n1, n2):F2}\n" +
                division;

            MessageBox.Show(
                resultado,
                "Resultados de las operaciones",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        private void btnEncerar_Click(object sender, EventArgs e)
        {
            txtN1.Clear();
            txtN2.Clear();
            txtN1.Focus();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

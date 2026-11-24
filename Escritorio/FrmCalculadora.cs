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
    public partial class FrmCalculadora : Form
    {
        ClsCalculadora calc = new ClsCalculadora();

        public double ValorGuardado = 0;
        public string operacion = "";
        public bool limpiarPantalla = false;
        public double memoria = 0;

        public FrmCalculadora()
        {
            InitializeComponent();
            AplicarEstilo();
            this.Resize += (s, e) => CentrarCalculadora();
        }

        // ==============================
        // DISEÑO DE LA CALCULADORA
        // ==============================

        private void AplicarEstilo()
        {
            this.Text = "Calculadora";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.ClientSize = new Size(430, 590);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.BackColor = Color.FromArgb(22, 32, 48);
            this.Font = new Font("Segoe UI", 10F);

            // Pantalla
            txtPantalla.SetBounds(25, 25, 380, 75);
            txtPantalla.Font = new Font("Segoe UI", 25F, FontStyle.Bold);
            txtPantalla.BackColor = Color.FromArgb(239, 244, 250);
            txtPantalla.ForeColor = Color.FromArgb(25, 40, 60);
            txtPantalla.BorderStyle = BorderStyle.FixedSingle;
            txtPantalla.TextAlign = HorizontalAlignment.Right;
            txtPantalla.ReadOnly = true;

            // Distribución de botones
            int ancho = 68;
            int alto = 65;
            int espacio = 10;
            int inicioX = 25;
            int inicioY = 120;

            Button[,] botones =
            {
                { btnOFF, btnMRC, btnMMENOS, btnMMAS, btnDividir },
                { btnPorcentaje, btn7, btn8, btn9, btnMultiplicar },
                { btnRaiz, btn4, btn5, btn6, btnResta },
                { btnC, btn1, btn2, btn3, btnSumar },
                { btnAC, btn0, btnPunto, btnIgual, null }
            };

            for (int fila = 0; fila < 5; fila++)
            {
                for (int columna = 0; columna < 5; columna++)
                {
                    Button boton = botones[fila, columna];

                    if (boton == null)
                        continue;

                    boton.SetBounds(
                        inicioX + columna * (ancho + espacio),
                        inicioY + fila * (alto + espacio),
                        ancho,
                        alto
                    );

                    boton.FlatStyle = FlatStyle.Flat;
                    boton.FlatAppearance.BorderSize = 0;
                    boton.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
                    boton.Cursor = Cursors.Hand;
                    boton.BackColor = Color.FromArgb(48, 65, 88);
                    boton.ForeColor = Color.White;
                }
            }

            // Operaciones
            EstilizarBoton(btnDividir,
                Color.FromArgb(245, 158, 11), Color.White);

            EstilizarBoton(btnMultiplicar,
                Color.FromArgb(245, 158, 11), Color.White);

            EstilizarBoton(btnResta,
                Color.FromArgb(245, 158, 11), Color.White);

            EstilizarBoton(btnSumar,
                Color.FromArgb(245, 158, 11), Color.White);

            EstilizarBoton(btnIgual,
                Color.FromArgb(37, 99, 235), Color.White);

            // Limpieza
            EstilizarBoton(btnOFF,
                Color.FromArgb(220, 53, 69), Color.White);

            EstilizarBoton(btnC,
                Color.FromArgb(239, 125, 85), Color.White);

            EstilizarBoton(btnAC,
                Color.FromArgb(239, 125, 85), Color.White);

            // Memoria
            EstilizarBoton(btnMRC,
                Color.FromArgb(71, 85, 105), Color.White);

            EstilizarBoton(btnMMENOS,
                Color.FromArgb(71, 85, 105), Color.White);

            EstilizarBoton(btnMMAS,
                Color.FromArgb(71, 85, 105), Color.White);

            // Funciones adicionales
            EstilizarBoton(btnPorcentaje,
                Color.FromArgb(219, 234, 254),
                Color.FromArgb(30, 64, 175));

            EstilizarBoton(btnRaiz,
                Color.FromArgb(219, 234, 254),
                Color.FromArgb(30, 64, 175));
        }

        private void EstilizarBoton(
            Button boton, Color fondo, Color texto)
        {
            boton.BackColor = fondo;
            boton.ForeColor = texto;
            boton.FlatStyle = FlatStyle.Flat;
            boton.FlatAppearance.BorderSize = 0;
            boton.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            boton.Cursor = Cursors.Hand;
        }

        // ==============================
        // INGRESO DE NÚMEROS
        // ==============================

        private void AgregarNumero(string numero)
        {
            if (limpiarPantalla)
            {
                txtPantalla.Text = "";
                limpiarPantalla = false;
            }

            txtPantalla.Text += numero;
        }

        private double ObtenerValor()
        {
            double valor;

            if (!double.TryParse(
                txtPantalla.Text,
                NumberStyles.Float,
                CultureInfo.CurrentCulture,
                out valor))
            {
                throw new Exception("Ingrese un número válido.");
            }

            return valor;
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            AgregarNumero("0");
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            AgregarNumero("1");
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            AgregarNumero("2");
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            AgregarNumero("3");
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            AgregarNumero("4");
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            AgregarNumero("5");
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            AgregarNumero("6");
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            AgregarNumero("7");
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            AgregarNumero("8");
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            AgregarNumero("9");
        }

        // ==============================
        // OPERACIONES
        // ==============================

        private void PrepararOperacion(string signo)
        {
            if (string.IsNullOrWhiteSpace(txtPantalla.Text))
                return;

            try
            {
                ValorGuardado = ObtenerValor();
                operacion = signo;
                limpiarPantalla = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSumar_Click(object sender, EventArgs e)
        {
            PrepararOperacion("+");
        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            PrepararOperacion("-");
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            PrepararOperacion("*");
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            PrepararOperacion("/");
        }

        private void btnIgual_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPantalla.Text))
                return;

            try
            {
                double actual = ObtenerValor();
                double resultado = 0;

                switch (operacion)
                {
                    case "+":
                        resultado = calc.Sumar(ValorGuardado, actual);
                        break;

                    case "-":
                        resultado = calc.Restar(ValorGuardado, actual);
                        break;

                    case "*":
                        resultado = calc.Multiplicar(ValorGuardado, actual);
                        break;

                    case "/":
                        if (actual == 0)
                            throw new Exception("No se puede dividir para cero.");

                        resultado = calc.Dividir(ValorGuardado, actual);
                        break;

                    default:
                        return;
                }

                txtPantalla.Text = resultado.ToString("F2");
                operacion = "";
                limpiarPantalla = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            }
        }

        // ==============================
        // FUNCIONES ESPECIALES
        // ==============================

        private void btnPorcentaje_Click_1(object sender, EventArgs e)
        {
            try
            {
                double valor = ObtenerValor() / 100;
                txtPantalla.Text = valor.ToString();
                limpiarPantalla = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnRaiz_Click_1(object sender, EventArgs e)
        {
            try
            {
                double numero = ObtenerValor();

                if (numero < 0)
                    throw new Exception("No se puede calcular la raíz de un número negativo.");

                txtPantalla.Text =
                    calc.RaizCuadrada(numero).ToString("F2");

                limpiarPantalla = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            }
        }

        private void btnPunto_Click(object sender, EventArgs e)
        {
            if (limpiarPantalla)
            {
                txtPantalla.Text = "0";
                limpiarPantalla = false;
            }

            string separador =
                CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator;

            if (string.IsNullOrEmpty(txtPantalla.Text))
                txtPantalla.Text = "0";

            if (!txtPantalla.Text.Contains(separador))
                txtPantalla.Text += separador;
        }

        // ==============================
        // MEMORIA
        // ==============================

        private void btnMC_Click(object sender, EventArgs e)
        {
            memoria = 0;
            calc.MemoriaClear();
        }

        private void btnMRC_Click(object sender, EventArgs e)
        {
            txtPantalla.Text = memoria.ToString();
            limpiarPantalla = true;
        }

        private void btnMMENOS_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(txtPantalla.Text))
                    memoria -= ObtenerValor();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnMMAS_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(txtPantalla.Text))
                    memoria += ObtenerValor();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // ==============================
        // LIMPIEZA Y SALIDA
        // ==============================

        private void btnC_Click_1(object sender, EventArgs e)
        {
            if (txtPantalla.Text.Length > 0)
            {
                txtPantalla.Text =
                    txtPantalla.Text.Remove(txtPantalla.Text.Length - 1);
            }
        }

        private void btnAC_Click_1(object sender, EventArgs e)
        {
            txtPantalla.Clear();
            ValorGuardado = 0;
            operacion = "";
            memoria = 0;
            limpiarPantalla = false;
        }

        private void btnOFF_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // ==============================
        // EVENTO LOAD
        // ==============================

        private void FrmCalculadora_Load(object sender, EventArgs e)
        {
            txtPantalla.Text = "0";
            CentrarCalculadora();
        }

        private void CentrarCalculadora()
        {
            if (Controls.Count == 0)
                return;

            int izquierda = int.MaxValue;
            int arriba = int.MaxValue;
            int derecha = int.MinValue;
            int abajo = int.MinValue;

            // Obtener los límites de todos los controles
            foreach (Control control in Controls)
            {
                izquierda = Math.Min(izquierda, control.Left);
                arriba = Math.Min(arriba, control.Top);
                derecha = Math.Max(derecha, control.Right);
                abajo = Math.Max(abajo, control.Bottom);
            }

            int ancho = derecha - izquierda;
            int alto = abajo - arriba;

            // Calcular el desplazamiento para centrar
            int moverX = (ClientSize.Width - ancho) / 2 - izquierda;
            int moverY = (ClientSize.Height - alto) / 2 - arriba;

            // Mover todos los controles
            foreach (Control control in Controls)
            {
                control.Left += moverX;
                control.Top += moverY;
            }
        }

    }
}



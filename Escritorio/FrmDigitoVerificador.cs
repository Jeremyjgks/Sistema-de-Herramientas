
using Biblioteca;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Escritorio
{
    public partial class FrmDigitoVerificador : Form
    {
        private readonly string rutaArchivo =
            Path.Combine(Application.StartupPath, "registros.txt");

        private bool cedulaVerificada = false;

        public FrmDigitoVerificador()
        {
            InitializeComponent();
            AplicarEstilo();
        }


        private void AplicarEstilo()
        {
            // Ventana principal
            this.SuspendLayout();

            this.Text = "Digito Verificador";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.WindowState = FormWindowState.Normal;
            this.ClientSize = new Size(1100, 780);
            this.MinimumSize = new Size(950, 700);
            this.BackColor = Color.FromArgb(244, 247, 252);
            this.Font = new Font("Segoe UI", 10F);

            // Encabezado superior
            Panel encabezado = new Panel();
            encabezado.Name = "pnlEncabezado";
            encabezado.Dock = DockStyle.Top;
            encabezado.Height = 100;
            encabezado.BackColor = Color.FromArgb(25, 55, 109);

            Label titulo = new Label();
            titulo.Text = "Verificación de Identidad";
            titulo.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            titulo.ForeColor = Color.White;
            titulo.AutoSize = true;
            titulo.Location = new Point(30, 15);

            Label subtitulo = new Label();
            subtitulo.Text = "Registro y validación de cédulas";
            subtitulo.Font = new Font("Segoe UI", 10F);
            subtitulo.ForeColor = Color.FromArgb(219, 234, 254);
            subtitulo.AutoSize = true;
            subtitulo.Location = new Point(34, 62);

            encabezado.Controls.Add(titulo);
            encabezado.Controls.Add(subtitulo);
            this.Controls.Add(encabezado);
            encabezado.BringToFront();

            // Títulos de las secciones
            Label lblSeccionDatos = new Label();
            lblSeccionDatos.Text = "DATOS PERSONALES";
            lblSeccionDatos.Font =
                new Font("Segoe UI", 11F, FontStyle.Bold);
            lblSeccionDatos.ForeColor =
                Color.FromArgb(25, 55, 109);
            lblSeccionDatos.SetBounds(30, 115, 400, 28);
            this.Controls.Add(lblSeccionDatos);
            lblSeccionDatos.BringToFront();

            Label lblSeccionRegistros = new Label();
            lblSeccionRegistros.Text = "REGISTROS GUARDADOS";
            lblSeccionRegistros.Font =
                new Font("Segoe UI", 11F, FontStyle.Bold);
            lblSeccionRegistros.ForeColor =
                Color.FromArgb(25, 55, 109);
            lblSeccionRegistros.SetBounds(30, 445, 400, 28);
            this.Controls.Add(lblSeccionRegistros);
            lblSeccionRegistros.BringToFront();

            // Etiquetas del formulario
            lblIdentificacion.Text = "Número de cédula";
            lblNombres.Text = "Nombres";
            lblApellidos.Text = "Apellidos";
            lblFechaNacimiento.Text = "Fecha de nacimiento";
            lblGenero.Text = "Género";

            lblIdentificacion.SetBounds(35, 160, 190, 25);
            lblNombres.SetBounds(35, 215, 190, 25);
            lblApellidos.SetBounds(35, 270, 190, 25);
            lblFechaNacimiento.SetBounds(35, 325, 190, 25);
            lblGenero.SetBounds(35, 380, 190, 25);

            Label[] etiquetas =
            {
        lblIdentificacion,
        lblNombres,
        lblApellidos,
        lblFechaNacimiento,
        lblGenero
    };

            foreach (Label etiqueta in etiquetas)
            {
                etiqueta.Font =
                    new Font("Segoe UI", 10F, FontStyle.Bold);
                etiqueta.ForeColor =
                    Color.FromArgb(51, 65, 85);
            }

            // Campos de entrada
            txtCedula.SetBounds(235, 155, 330, 35);
            txtNombres.SetBounds(235, 210, 330, 35);
            txtApellidos.SetBounds(235, 265, 330, 35);
            dtpFechaNacimiento.SetBounds(235, 320, 200, 35);
            cboGenero.SetBounds(235, 375, 200, 35);

            EstilizarTexto(txtCedula);
            EstilizarTexto(txtNombres);
            EstilizarTexto(txtApellidos);

            txtCedula.MaxLength = 10;

            dtpFechaNacimiento.Font =
                new Font("Segoe UI", 10F);
            dtpFechaNacimiento.Format =
                DateTimePickerFormat.Short;
            dtpFechaNacimiento.MaxDate = DateTime.Today;

            cboGenero.Font = new Font("Segoe UI", 10F);
            cboGenero.DropDownStyle =
                ComboBoxStyle.DropDownList;
            cboGenero.BackColor = Color.White;

            // Botones de acción
            btnVerificar.Text = "Verificar cédula";
            btnIngresar.Text = "Guardar registro";
            btnLimpiar.Text = "Limpiar formulario";
            btnVolver.Text = "Volver";

            btnVerificar.SetBounds(650, 155, 400, 45);
            btnIngresar.SetBounds(650, 215, 400, 45);
            btnLimpiar.SetBounds(650, 275, 400, 45);
            btnVolver.SetBounds(650, 335, 400, 45);

            EstilizarBoton(
                btnVerificar, Color.FromArgb(37, 99, 235));

            EstilizarBoton(
                btnIngresar, Color.FromArgb(22, 163, 100));

            EstilizarBoton(
                btnLimpiar, Color.FromArgb(100, 116, 139));

            EstilizarBoton(
                btnVolver, Color.FromArgb(220, 53, 69));

            // Tabla de registros
            dgvRegistros.Dock = DockStyle.None;
            dgvRegistros.Anchor =
                AnchorStyles.Top |
                AnchorStyles.Left |
                AnchorStyles.Right |
                AnchorStyles.Bottom;

            dgvRegistros.SetBounds(30, 480, 1040, 255);

            dgvRegistros.BackgroundColor = Color.White;
            dgvRegistros.BorderStyle = BorderStyle.None;
            dgvRegistros.GridColor =
                Color.FromArgb(226, 232, 240);

            dgvRegistros.EnableHeadersVisualStyles = false;

            dgvRegistros.ColumnHeadersDefaultCellStyle.BackColor =
                Color.FromArgb(25, 55, 109);

            dgvRegistros.ColumnHeadersDefaultCellStyle.ForeColor =
                Color.White;

            dgvRegistros.ColumnHeadersDefaultCellStyle.Font =
                new Font("Segoe UI", 10F, FontStyle.Bold);

            dgvRegistros.ColumnHeadersDefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleLeft;

            dgvRegistros.DefaultCellStyle.Font =
                new Font("Segoe UI", 9.5F);

            dgvRegistros.DefaultCellStyle.ForeColor =
                Color.FromArgb(51, 65, 85);

            dgvRegistros.DefaultCellStyle.SelectionBackColor =
                Color.FromArgb(219, 234, 254);

            dgvRegistros.DefaultCellStyle.SelectionForeColor =
                Color.FromArgb(25, 55, 109);

            dgvRegistros.AlternatingRowsDefaultCellStyle.BackColor =
                Color.FromArgb(239, 246, 255);

            dgvRegistros.RowTemplate.Height = 32;
            dgvRegistros.ColumnHeadersHeight = 40;

            dgvRegistros.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            dgvRegistros.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            dgvRegistros.MultiSelect = false;
            dgvRegistros.ReadOnly = true;
            dgvRegistros.AllowUserToAddRows = false;
            dgvRegistros.AllowUserToResizeRows = false;
            dgvRegistros.RowHeadersVisible = false;

            // Nombres de las columnas
            colCedula.HeaderText = "Cédula";
            colApellidos.HeaderText = "Apellidos";
            colNombres.HeaderText = "Nombres";
            colFechaNacimiento.HeaderText = "Fecha de nacimiento";
            colGenero.HeaderText = "Género";

            this.ResumeLayout(true);
        }

        private void EstilizarBoton(Button boton, Color color)
        {
            boton.BackColor = color;
            boton.ForeColor = Color.White;
            boton.FlatStyle = FlatStyle.Flat;
            boton.FlatAppearance.BorderSize = 0;
            boton.Font = new Font(
                "Segoe UI", 10F, FontStyle.Bold);
            boton.Cursor = Cursors.Hand;
            boton.UseVisualStyleBackColor = false;
        }

        private void EstilizarTexto(TextBox texto)
        {
            texto.Font = new Font("Segoe UI", 11F);
            texto.BackColor = Color.White;
            texto.ForeColor = Color.FromArgb(31, 41, 55);
            texto.BorderStyle = BorderStyle.FixedSingle;
        }

        private bool CedulaRegistrada(string cedula)
        {
            foreach (DataGridViewRow fila in dgvRegistros.Rows)
            {
                if (fila.IsNewRow)
                    continue;

                object valor = fila.Cells["colCedula"].Value;

                if (valor != null &&
                    valor.ToString() == cedula)
                {
                    return true;
                }
            }

            return false;
        }

        private void HabilitarDatos(bool habilitar)
        {
            txtNombres.Enabled = habilitar;
            txtApellidos.Enabled = habilitar;
            dtpFechaNacimiento.Enabled = habilitar;
            cboGenero.Enabled = habilitar;
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            string cedula = txtCedula.Text.Trim();

            cedulaVerificada = false;
            HabilitarDatos(false);

            if (cedula.Length != 10)
            {
                MessageBox.Show(
                    "Ingresa una cédula de 10 dígitos.",
                    "Cédula",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtCedula.Focus();
                return;
            }

            if (CedulaRegistrada(cedula))
            {
                MessageBox.Show(
                    "Esta cédula ya está registrada.",
                    "Registro duplicado",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            if (!ClsDigitoVerificador.ValidarCedula(cedula))
            {
                MessageBox.Show(
                    "La cédula no es válida.",
                    "Error de validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                txtCedula.Focus();
                return;
            }

            cedulaVerificada = true;
            HabilitarDatos(true);

            MessageBox.Show(
                "Cédula válida. Puedes completar los datos.",
                "Verificación correcta",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            txtNombres.Focus();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string cedula = txtCedula.Text.Trim();

            if (!cedulaVerificada ||
                !ClsDigitoVerificador.ValidarCedula(cedula))
            {
                MessageBox.Show(
                    "Primero verifica una cédula válida.",
                    "Atención",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            if (CedulaRegistrada(cedula))
            {
                MessageBox.Show(
                    "Esta cédula ya está registrada.",
                    "Registro duplicado",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            string nombres = txtNombres.Text.Trim();
            string apellidos = txtApellidos.Text.Trim();
            string genero = cboGenero.Text;

            if (string.IsNullOrWhiteSpace(nombres) ||
                string.IsNullOrWhiteSpace(apellidos) ||
                string.IsNullOrWhiteSpace(genero))
            {
                MessageBox.Show(
                    "Completa todos los campos.",
                    "Datos incompletos",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            if (dtpFechaNacimiento.Value.Date > DateTime.Today)
            {
                MessageBox.Show(
                    "La fecha de nacimiento no puede ser futura.",
                    "Fecha incorrecta",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            string fecha = dtpFechaNacimiento.Value.ToShortDateString();

            // Evitar separadores que alteren el formato del archivo.
            if (nombres.Contains(";") || apellidos.Contains(";"))
            {
                MessageBox.Show(
                    "Los nombres y apellidos no pueden contener punto y coma.",
                    "Dato incorrecto",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            string registro = string.Join(";",
                cedula, apellidos, nombres, fecha, genero);

            try
            {
                File.AppendAllText(
                    rutaArchivo,
                    registro + Environment.NewLine);

                int indice = dgvRegistros.Rows.Add();

                DataGridViewRow fila = dgvRegistros.Rows[indice];

                fila.Cells["colCedula"].Value = cedula;
                fila.Cells["colApellidos"].Value = apellidos;
                fila.Cells["colNombres"].Value = nombres;
                fila.Cells["colFechaNacimiento"].Value = fecha;
                fila.Cells["colGenero"].Value = genero;

                MessageBox.Show(
                    "Registro guardado correctamente.",
                    "Éxito",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                LimpiarFormulario();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "No se pudo guardar el registro.\n" + ex.Message,
                    "Error de archivo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void FrmDigitoVerificador_Load(
            object sender, EventArgs e)
        {
            cboGenero.Items.Clear();
            cboGenero.Items.Add("Masculino");
            cboGenero.Items.Add("Femenino");
            cboGenero.Items.Add("Otro");
            cboGenero.SelectedIndex = -1;

            HabilitarDatos(false);

            try
            {
                if (File.Exists(rutaArchivo))
                {
                    foreach (string linea in File.ReadAllLines(rutaArchivo))
                    {
                        string[] datos = linea.Split(';');

                        if (datos.Length != 5)
                            continue;

                        if (CedulaRegistrada(datos[0]))
                            continue;

                        int indice = dgvRegistros.Rows.Add();

                        DataGridViewRow fila =
                            dgvRegistros.Rows[indice];

                        fila.Cells["colCedula"].Value = datos[0];
                        fila.Cells["colApellidos"].Value = datos[1];
                        fila.Cells["colNombres"].Value = datos[2];
                        fila.Cells["colFechaNacimiento"].Value = datos[3];
                        fila.Cells["colGenero"].Value = datos[4];
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "No se pudieron cargar los registros.\n" + ex.Message,
                    "Error de lectura",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }

        private void LimpiarFormulario()
        {
            txtCedula.Clear();
            txtNombres.Clear();
            txtApellidos.Clear();

            dtpFechaNacimiento.Value = DateTime.Today;
            cboGenero.SelectedIndex = -1;

            cedulaVerificada = false;
            HabilitarDatos(false);

            txtCedula.Focus();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(
            object sender, EventArgs e)
        {
        }

        private void dateTimePicker1_ValueChanged(
            object sender, EventArgs e)
        {
        }
    }
}

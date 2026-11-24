using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Escritorio
{
    public partial class FrmAcercaDe : Form
    {
        public FrmAcercaDe()
        {
            InitializeComponent();

            this.Text = "Acerca de nuestro sistema";

            labelProductName.Text = "Sistema de Herramientas Matemáticas";
            labelVersion.Text = "Versión 1.0";
            labelCopyright.Text = "Copyright © 2026";
            labelCompanyName.Text = "UTLVTE";

            textBoxDescription.Text =
                "Sistema de Herramientas Matemáticas\n\n" +
                "Aplicación de escritorio desarrollada en C# " +
                "utilizando Windows Forms en Microsoft Visual Studio.\n\n" +
                "El sistema cuenta con las siguientes herramientas:\n\n" +
                "• Operaciones básicas: suma, resta, multiplicación y división.\n" +
                "• Calculadora: permite realizar diferentes operaciones matemáticas.\n" +
                "• Dígito verificador: permite realizar la validación correspondiente.\n\n" +
                "Esta aplicación tiene como finalidad facilitar los cálculos " +
                "matemáticos mediante una interfaz gráfica sencilla y fácil de utilizar.";
        }
    }
}

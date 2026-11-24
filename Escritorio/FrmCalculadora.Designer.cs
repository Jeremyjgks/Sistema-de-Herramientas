using Biblioteca;
using System;
using System.Windows.Forms;

namespace Escritorio
{
    partial class FrmCalculadora
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
            this.btnIgual = new System.Windows.Forms.Button();
            this.btnPunto = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btnAC = new System.Windows.Forms.Button();
            this.btnSumar = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btnC = new System.Windows.Forms.Button();
            this.btnResta = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btnRaiz = new System.Windows.Forms.Button();
            this.btnMultiplicar = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btnPorcentaje = new System.Windows.Forms.Button();
            this.btnDividir = new System.Windows.Forms.Button();
            this.btnMMAS = new System.Windows.Forms.Button();
            this.btnMMENOS = new System.Windows.Forms.Button();
            this.btnMRC = new System.Windows.Forms.Button();
            this.btnOFF = new System.Windows.Forms.Button();
            this.txtPantalla = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnIgual
            // 
            this.btnIgual.BackColor = System.Drawing.Color.DarkOrange;
            this.btnIgual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIgual.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIgual.Location = new System.Drawing.Point(234, 409);
            this.btnIgual.Name = "btnIgual";
            this.btnIgual.Size = new System.Drawing.Size(56, 60);
            this.btnIgual.TabIndex = 49;
            this.btnIgual.Text = "=";
            this.btnIgual.UseVisualStyleBackColor = false;
            this.btnIgual.Click += new System.EventHandler(this.btnIgual_Click_1);
            // 
            // btnPunto
            // 
            this.btnPunto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPunto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPunto.Location = new System.Drawing.Point(162, 409);
            this.btnPunto.Name = "btnPunto";
            this.btnPunto.Size = new System.Drawing.Size(56, 60);
            this.btnPunto.TabIndex = 48;
            this.btnPunto.Text = ".";
            this.btnPunto.UseVisualStyleBackColor = true;
            this.btnPunto.Click += new System.EventHandler(this.btnPunto_Click);
            // 
            // btn0
            // 
            this.btn0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn0.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn0.Location = new System.Drawing.Point(90, 409);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(56, 60);
            this.btn0.TabIndex = 47;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.btn0_Click);
            // 
            // btnAC
            // 
            this.btnAC.BackColor = System.Drawing.Color.Salmon;
            this.btnAC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAC.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAC.ForeColor = System.Drawing.Color.DarkRed;
            this.btnAC.Location = new System.Drawing.Point(16, 409);
            this.btnAC.Name = "btnAC";
            this.btnAC.Size = new System.Drawing.Size(68, 60);
            this.btnAC.TabIndex = 46;
            this.btnAC.Text = "AC";
            this.btnAC.UseVisualStyleBackColor = false;
            this.btnAC.Click += new System.EventHandler(this.btnAC_Click_1);
            // 
            // btnSumar
            // 
            this.btnSumar.BackColor = System.Drawing.Color.DarkOrange;
            this.btnSumar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSumar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSumar.ForeColor = System.Drawing.Color.Transparent;
            this.btnSumar.Location = new System.Drawing.Point(306, 326);
            this.btnSumar.Name = "btnSumar";
            this.btnSumar.Size = new System.Drawing.Size(56, 143);
            this.btnSumar.TabIndex = 45;
            this.btnSumar.Text = "+";
            this.btnSumar.UseVisualStyleBackColor = false;
            this.btnSumar.Click += new System.EventHandler(this.btnSumar_Click);
            // 
            // btn3
            // 
            this.btn3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3.Location = new System.Drawing.Point(234, 326);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(56, 60);
            this.btn3.TabIndex = 44;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btn2
            // 
            this.btn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2.Location = new System.Drawing.Point(162, 326);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(56, 60);
            this.btn2.TabIndex = 43;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn1
            // 
            this.btn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.Location = new System.Drawing.Point(90, 326);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(56, 60);
            this.btn1.TabIndex = 42;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btnC
            // 
            this.btnC.BackColor = System.Drawing.Color.Salmon;
            this.btnC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnC.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnC.ForeColor = System.Drawing.Color.DarkRed;
            this.btnC.Location = new System.Drawing.Point(16, 326);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(68, 60);
            this.btnC.TabIndex = 41;
            this.btnC.Text = "C";
            this.btnC.UseVisualStyleBackColor = false;
            this.btnC.Click += new System.EventHandler(this.btnC_Click_1);
            // 
            // btnResta
            // 
            this.btnResta.BackColor = System.Drawing.Color.DarkOrange;
            this.btnResta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResta.ForeColor = System.Drawing.Color.Transparent;
            this.btnResta.Location = new System.Drawing.Point(306, 234);
            this.btnResta.Name = "btnResta";
            this.btnResta.Size = new System.Drawing.Size(56, 60);
            this.btnResta.TabIndex = 40;
            this.btnResta.Text = "-";
            this.btnResta.UseVisualStyleBackColor = false;
            this.btnResta.Click += new System.EventHandler(this.btnResta_Click);
            // 
            // btn6
            // 
            this.btn6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn6.Location = new System.Drawing.Point(234, 234);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(56, 60);
            this.btn6.TabIndex = 39;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.btn6_Click);
            // 
            // btn5
            // 
            this.btn5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn5.Location = new System.Drawing.Point(162, 234);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(56, 60);
            this.btn5.TabIndex = 38;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // btn4
            // 
            this.btn4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn4.Location = new System.Drawing.Point(90, 234);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(56, 60);
            this.btn4.TabIndex = 37;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btnRaiz
            // 
            this.btnRaiz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRaiz.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRaiz.Location = new System.Drawing.Point(16, 234);
            this.btnRaiz.Name = "btnRaiz";
            this.btnRaiz.Size = new System.Drawing.Size(68, 60);
            this.btnRaiz.TabIndex = 36;
            this.btnRaiz.Text = "Raiz";
            this.btnRaiz.UseVisualStyleBackColor = true;
            this.btnRaiz.Click += new System.EventHandler(this.btnRaiz_Click_1);
            // 
            // btnMultiplicar
            // 
            this.btnMultiplicar.BackColor = System.Drawing.Color.DarkOrange;
            this.btnMultiplicar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMultiplicar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMultiplicar.ForeColor = System.Drawing.Color.Transparent;
            this.btnMultiplicar.Location = new System.Drawing.Point(306, 138);
            this.btnMultiplicar.Name = "btnMultiplicar";
            this.btnMultiplicar.Size = new System.Drawing.Size(56, 60);
            this.btnMultiplicar.TabIndex = 35;
            this.btnMultiplicar.Text = "x";
            this.btnMultiplicar.UseVisualStyleBackColor = false;
            this.btnMultiplicar.Click += new System.EventHandler(this.btnMultiplicar_Click);
            // 
            // btn9
            // 
            this.btn9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn9.Location = new System.Drawing.Point(234, 138);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(56, 60);
            this.btn9.TabIndex = 34;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.btn9_Click);
            // 
            // btn8
            // 
            this.btn8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn8.Location = new System.Drawing.Point(162, 138);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(56, 60);
            this.btn8.TabIndex = 33;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.btn8_Click);
            // 
            // btn7
            // 
            this.btn7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn7.Location = new System.Drawing.Point(90, 138);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(56, 60);
            this.btn7.TabIndex = 32;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.btn7_Click);
            // 
            // btnPorcentaje
            // 
            this.btnPorcentaje.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPorcentaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPorcentaje.Location = new System.Drawing.Point(16, 138);
            this.btnPorcentaje.Name = "btnPorcentaje";
            this.btnPorcentaje.Size = new System.Drawing.Size(68, 60);
            this.btnPorcentaje.TabIndex = 31;
            this.btnPorcentaje.Text = "%";
            this.btnPorcentaje.UseVisualStyleBackColor = true;
            this.btnPorcentaje.Click += new System.EventHandler(this.btnPorcentaje_Click_1);
            // 
            // btnDividir
            // 
            this.btnDividir.BackColor = System.Drawing.Color.DarkOrange;
            this.btnDividir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDividir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDividir.ForeColor = System.Drawing.Color.Transparent;
            this.btnDividir.Location = new System.Drawing.Point(306, 49);
            this.btnDividir.Name = "btnDividir";
            this.btnDividir.Size = new System.Drawing.Size(56, 60);
            this.btnDividir.TabIndex = 30;
            this.btnDividir.Text = "/";
            this.btnDividir.UseVisualStyleBackColor = false;
            this.btnDividir.Click += new System.EventHandler(this.btnDividir_Click);
            // 
            // btnMMAS
            // 
            this.btnMMAS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMMAS.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMMAS.Location = new System.Drawing.Point(234, 49);
            this.btnMMAS.Name = "btnMMAS";
            this.btnMMAS.Size = new System.Drawing.Size(56, 60);
            this.btnMMAS.TabIndex = 29;
            this.btnMMAS.Text = "M+";
            this.btnMMAS.UseVisualStyleBackColor = true;
            this.btnMMAS.Click += new System.EventHandler(this.btnMMAS_Click);
            // 
            // btnMMENOS
            // 
            this.btnMMENOS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMMENOS.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMMENOS.Location = new System.Drawing.Point(162, 49);
            this.btnMMENOS.Name = "btnMMENOS";
            this.btnMMENOS.Size = new System.Drawing.Size(56, 60);
            this.btnMMENOS.TabIndex = 28;
            this.btnMMENOS.Text = "M-";
            this.btnMMENOS.UseVisualStyleBackColor = true;
            this.btnMMENOS.Click += new System.EventHandler(this.btnMMENOS_Click_1);
            // 
            // btnMRC
            // 
            this.btnMRC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMRC.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMRC.Location = new System.Drawing.Point(90, 49);
            this.btnMRC.Name = "btnMRC";
            this.btnMRC.Size = new System.Drawing.Size(56, 60);
            this.btnMRC.TabIndex = 27;
            this.btnMRC.Text = "MRC";
            this.btnMRC.UseVisualStyleBackColor = true;
            this.btnMRC.Click += new System.EventHandler(this.btnMRC_Click);
            // 
            // btnOFF
            // 
            this.btnOFF.BackColor = System.Drawing.Color.Firebrick;
            this.btnOFF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOFF.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOFF.Location = new System.Drawing.Point(16, 49);
            this.btnOFF.Name = "btnOFF";
            this.btnOFF.Size = new System.Drawing.Size(68, 60);
            this.btnOFF.TabIndex = 26;
            this.btnOFF.Text = "OFF";
            this.btnOFF.UseVisualStyleBackColor = false;
            this.btnOFF.Click += new System.EventHandler(this.btnOFF_Click);
            // 
            // txtPantalla
            // 
            this.txtPantalla.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPantalla.Font = new System.Drawing.Font("Consolas", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPantalla.ForeColor = System.Drawing.Color.Black;
            this.txtPantalla.Location = new System.Drawing.Point(16, 17);
            this.txtPantalla.Name = "txtPantalla";
            this.txtPantalla.Size = new System.Drawing.Size(346, 26);
            this.txtPantalla.TabIndex = 25;
            this.txtPantalla.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // FrmCalculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 700);
            this.Controls.Add(this.btnIgual);
            this.Controls.Add(this.btnPunto);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btnAC);
            this.Controls.Add(this.btnSumar);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btnC);
            this.Controls.Add(this.btnResta);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btnRaiz);
            this.Controls.Add(this.btnMultiplicar);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btnPorcentaje);
            this.Controls.Add(this.btnDividir);
            this.Controls.Add(this.btnMMAS);
            this.Controls.Add(this.btnMMENOS);
            this.Controls.Add(this.btnMRC);
            this.Controls.Add(this.btnOFF);
            this.Controls.Add(this.txtPantalla);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmCalculadora";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCalculadora";
            this.Load += new System.EventHandler(this.FrmCalculadora_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            
        }

        #endregion

        private System.Windows.Forms.Button btnIgual;
        private System.Windows.Forms.Button btnPunto;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btnAC;
        private System.Windows.Forms.Button btnSumar;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btnC;
        private System.Windows.Forms.Button btnResta;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btnRaiz;
        private System.Windows.Forms.Button btnMultiplicar;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btnPorcentaje;
        private System.Windows.Forms.Button btnDividir;
        private System.Windows.Forms.Button btnMMAS;
        private System.Windows.Forms.Button btnMMENOS;
        private System.Windows.Forms.Button btnMRC;
        private System.Windows.Forms.Button btnOFF;
        private System.Windows.Forms.TextBox txtPantalla;
    }
}
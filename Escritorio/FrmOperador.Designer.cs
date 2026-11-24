using System;

namespace Escritorio
{
    partial class FrmOperador
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
            this.txtN2 = new System.Windows.Forms.TextBox();
            this.txtN1 = new System.Windows.Forms.TextBox();
            this.lblN2 = new System.Windows.Forms.Label();
            this.lbln1 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnEncerar = new System.Windows.Forms.Button();
            this.btnProcesar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtN2
            // 
            this.txtN2.Location = new System.Drawing.Point(198, 50);
            this.txtN2.Name = "txtN2";
            this.txtN2.Size = new System.Drawing.Size(133, 26);
            this.txtN2.TabIndex = 13;
            // 
            // txtN1
            // 
            this.txtN1.Location = new System.Drawing.Point(198, 9);
            this.txtN1.Name = "txtN1";
            this.txtN1.Size = new System.Drawing.Size(133, 26);
            this.txtN1.TabIndex = 12;
            // 
            // lblN2
            // 
            this.lblN2.AutoSize = true;
            this.lblN2.Location = new System.Drawing.Point(16, 56);
            this.lblN2.Name = "lblN2";
            this.lblN2.Size = new System.Drawing.Size(136, 20);
            this.lblN2.TabIndex = 11;
            this.lblN2.Text = "Ingresa Numero 2";
            // 
            // lbln1
            // 
            this.lbln1.AutoSize = true;
            this.lbln1.Location = new System.Drawing.Point(12, 9);
            this.lbln1.Name = "lbln1";
            this.lbln1.Size = new System.Drawing.Size(136, 20);
            this.lbln1.TabIndex = 10;
            this.lbln1.Text = "Ingrese Numero 1";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(232, 145);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(99, 35);
            this.btnSalir.TabIndex = 9;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnEncerar
            // 
            this.btnEncerar.Location = new System.Drawing.Point(116, 145);
            this.btnEncerar.Name = "btnEncerar";
            this.btnEncerar.Size = new System.Drawing.Size(110, 35);
            this.btnEncerar.TabIndex = 8;
            this.btnEncerar.Text = "Encerar";
            this.btnEncerar.UseVisualStyleBackColor = true;
            this.btnEncerar.Click += new System.EventHandler(this.btnEncerar_Click);
            // 
            // btnProcesar
            // 
            this.btnProcesar.Location = new System.Drawing.Point(12, 145);
            this.btnProcesar.Name = "btnProcesar";
            this.btnProcesar.Size = new System.Drawing.Size(98, 35);
            this.btnProcesar.TabIndex = 7;
            this.btnProcesar.Text = "Procesar";
            this.btnProcesar.UseVisualStyleBackColor = true;
            this.btnProcesar.Click += new System.EventHandler(this.btnProcesar_Click);
            // 
            // FrmOperador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 191);
            this.Controls.Add(this.txtN2);
            this.Controls.Add(this.txtN1);
            this.Controls.Add(this.lblN2);
            this.Controls.Add(this.lbln1);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnEncerar);
            this.Controls.Add(this.btnProcesar);
            this.Name = "FrmOperador";
            this.Text = "FrmOperador";
            this.Load += new System.EventHandler(this.FrmOperador_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void FrmOperador_Load(object sender, EventArgs e)
        {
            
        }

        #endregion

        private System.Windows.Forms.TextBox txtN2;
        private System.Windows.Forms.TextBox txtN1;
        private System.Windows.Forms.Label lblN2;
        private System.Windows.Forms.Label lbln1;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnEncerar;
        private System.Windows.Forms.Button btnProcesar;
    }
}
namespace Monto
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbPrecio = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblMonto = new System.Windows.Forms.Label();
            this.btnCalcularRef = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Precio";
            // 
            // tbPrecio
            // 
            this.tbPrecio.Location = new System.Drawing.Point(106, 73);
            this.tbPrecio.Name = "tbPrecio";
            this.tbPrecio.Size = new System.Drawing.Size(196, 26);
            this.tbPrecio.TabIndex = 1;
            this.tbPrecio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbPrecio.TextChanged += new System.EventHandler(this.tbPrecio_TextChanged);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(106, 137);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(196, 63);
            this.btnCalcular.TabIndex = 2;
            this.btnCalcular.Text = "Calcular Monto con IVA";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblMonto
            // 
            this.lblMonto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMonto.Location = new System.Drawing.Point(27, 314);
            this.lblMonto.Name = "lblMonto";
            this.lblMonto.Size = new System.Drawing.Size(275, 116);
            this.lblMonto.TabIndex = 3;
            this.lblMonto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCalcularRef
            // 
            this.btnCalcularRef.Location = new System.Drawing.Point(106, 216);
            this.btnCalcularRef.Name = "btnCalcularRef";
            this.btnCalcularRef.Size = new System.Drawing.Size(196, 63);
            this.btnCalcularRef.TabIndex = 4;
            this.btnCalcularRef.Text = "Calcular Monto con IVA - Ref";
            this.btnCalcularRef.UseVisualStyleBackColor = true;
            this.btnCalcularRef.Click += new System.EventHandler(this.btnCalcularRef_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 450);
            this.Controls.Add(this.btnCalcularRef);
            this.Controls.Add(this.lblMonto);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.tbPrecio);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calcular Monto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbPrecio;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblMonto;
        private System.Windows.Forms.Button btnCalcularRef;
    }
}


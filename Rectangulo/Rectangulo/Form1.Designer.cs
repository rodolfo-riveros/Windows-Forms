namespace Rectangulo
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.LblAltura = new System.Windows.Forms.Label();
            this.LblBase = new System.Windows.Forms.Label();
            this.TxtAltura = new System.Windows.Forms.TextBox();
            this.TxtBase = new System.Windows.Forms.TextBox();
            this.LblRectangulo = new System.Windows.Forms.Label();
            this.LblTitle = new System.Windows.Forms.Label();
            this.BtnCalcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblAltura
            // 
            this.LblAltura.AutoSize = true;
            this.LblAltura.Location = new System.Drawing.Point(167, 133);
            this.LblAltura.Name = "LblAltura";
            this.LblAltura.Size = new System.Drawing.Size(44, 16);
            this.LblAltura.TabIndex = 0;
            this.LblAltura.Text = "Altura:";
            // 
            // LblBase
            // 
            this.LblBase.AutoSize = true;
            this.LblBase.Location = new System.Drawing.Point(167, 195);
            this.LblBase.Name = "LblBase";
            this.LblBase.Size = new System.Drawing.Size(42, 16);
            this.LblBase.TabIndex = 1;
            this.LblBase.Text = "Base:";
            // 
            // TxtAltura
            // 
            this.TxtAltura.Location = new System.Drawing.Point(217, 127);
            this.TxtAltura.Name = "TxtAltura";
            this.TxtAltura.Size = new System.Drawing.Size(182, 22);
            this.TxtAltura.TabIndex = 2;
            // 
            // TxtBase
            // 
            this.TxtBase.Location = new System.Drawing.Point(217, 189);
            this.TxtBase.Name = "TxtBase";
            this.TxtBase.Size = new System.Drawing.Size(182, 22);
            this.TxtBase.TabIndex = 3;
            // 
            // LblRectangulo
            // 
            this.LblRectangulo.AutoSize = true;
            this.LblRectangulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblRectangulo.Location = new System.Drawing.Point(144, 329);
            this.LblRectangulo.Name = "LblRectangulo";
            this.LblRectangulo.Size = new System.Drawing.Size(0, 20);
            this.LblRectangulo.TabIndex = 4;
            // 
            // LblTitle
            // 
            this.LblTitle.AutoSize = true;
            this.LblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitle.Location = new System.Drawing.Point(142, 56);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(289, 32);
            this.LblTitle.TabIndex = 5;
            this.LblTitle.Text = "Calculadora de área";
            // 
            // BtnCalcular
            // 
            this.BtnCalcular.BackColor = System.Drawing.Color.DarkGreen;
            this.BtnCalcular.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCalcular.ForeColor = System.Drawing.Color.Transparent;
            this.BtnCalcular.Location = new System.Drawing.Point(170, 239);
            this.BtnCalcular.Name = "BtnCalcular";
            this.BtnCalcular.Size = new System.Drawing.Size(229, 54);
            this.BtnCalcular.TabIndex = 6;
            this.BtnCalcular.Text = "Calcular";
            this.BtnCalcular.UseVisualStyleBackColor = false;
            this.BtnCalcular.Click += new System.EventHandler(this.BtnCalcular_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 450);
            this.Controls.Add(this.BtnCalcular);
            this.Controls.Add(this.LblTitle);
            this.Controls.Add(this.LblRectangulo);
            this.Controls.Add(this.TxtBase);
            this.Controls.Add(this.TxtAltura);
            this.Controls.Add(this.LblBase);
            this.Controls.Add(this.LblAltura);
            this.Name = "Form1";
            this.Text = "Calculadora de área";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblAltura;
        private System.Windows.Forms.Label LblBase;
        private System.Windows.Forms.TextBox TxtAltura;
        private System.Windows.Forms.TextBox TxtBase;
        private System.Windows.Forms.Label LblRectangulo;
        private System.Windows.Forms.Label LblTitle;
        private System.Windows.Forms.Button BtnCalcular;
    }
}


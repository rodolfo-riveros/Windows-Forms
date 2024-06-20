namespace Estudiante
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEstudiante = new System.Windows.Forms.TextBox();
            this.txtCalificacion = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lblPromedio = new System.Windows.Forms.Label();
            this.tablaEstudiante = new System.Windows.Forms.DataGridView();
            this.Estudiante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Calificacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tablaEstudiante)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Estudiante:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 233);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Calificacion:";
            // 
            // txtEstudiante
            // 
            this.txtEstudiante.Location = new System.Drawing.Point(59, 173);
            this.txtEstudiante.Name = "txtEstudiante";
            this.txtEstudiante.Size = new System.Drawing.Size(281, 22);
            this.txtEstudiante.TabIndex = 2;
            // 
            // txtCalificacion
            // 
            this.txtCalificacion.Location = new System.Drawing.Point(59, 264);
            this.txtCalificacion.Name = "txtCalificacion";
            this.txtCalificacion.Size = new System.Drawing.Size(280, 22);
            this.txtCalificacion.TabIndex = 3;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnAgregar.ForeColor = System.Drawing.Color.Transparent;
            this.btnAgregar.Location = new System.Drawing.Point(59, 304);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(281, 51);
            this.btnAgregar.TabIndex = 4;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lblPromedio
            // 
            this.lblPromedio.AutoSize = true;
            this.lblPromedio.Location = new System.Drawing.Point(387, 386);
            this.lblPromedio.Name = "lblPromedio";
            this.lblPromedio.Size = new System.Drawing.Size(80, 16);
            this.lblPromedio.TabIndex = 5;
            this.lblPromedio.Text = "lblPromedio";
            // 
            // tablaEstudiante
            // 
            this.tablaEstudiante.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaEstudiante.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Estudiante,
            this.Calificacion});
            this.tablaEstudiante.Location = new System.Drawing.Point(390, 145);
            this.tablaEstudiante.Name = "tablaEstudiante";
            this.tablaEstudiante.RowHeadersWidth = 51;
            this.tablaEstudiante.RowTemplate.Height = 24;
            this.tablaEstudiante.Size = new System.Drawing.Size(410, 210);
            this.tablaEstudiante.TabIndex = 6;
            // 
            // Estudiante
            // 
            this.Estudiante.HeaderText = "ESTUDIANTE";
            this.Estudiante.MinimumWidth = 6;
            this.Estudiante.Name = "Estudiante";
            this.Estudiante.Width = 125;
            // 
            // Calificacion
            // 
            this.Calificacion.HeaderText = "CALIFICACION";
            this.Calificacion.MinimumWidth = 6;
            this.Calificacion.Name = "Calificacion";
            this.Calificacion.Width = 125;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(312, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(260, 32);
            this.label3.TabIndex = 7;
            this.label3.Text = "CALIFICACIONES";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tablaEstudiante);
            this.Controls.Add(this.lblPromedio);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtCalificacion);
            this.Controls.Add(this.txtEstudiante);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Calificaciones";
            ((System.ComponentModel.ISupportInitialize)(this.tablaEstudiante)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEstudiante;
        private System.Windows.Forms.TextBox txtCalificacion;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label lblPromedio;
        private System.Windows.Forms.DataGridView tablaEstudiante;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estudiante;
        private System.Windows.Forms.DataGridViewTextBoxColumn Calificacion;
        private System.Windows.Forms.Label label3;
    }
}


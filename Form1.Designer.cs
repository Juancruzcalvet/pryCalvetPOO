namespace pryCalvetPOO
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
            this.cmdCrear = new System.Windows.Forms.Button();
            this.txtFuerza = new System.Windows.Forms.TextBox();
            this.txtDestreza = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.mrcCrear = new System.Windows.Forms.GroupBox();
            this.lblDatos = new System.Windows.Forms.Label();
            this.mrcCrear.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmdCrear
            // 
            this.cmdCrear.Location = new System.Drawing.Point(56, 104);
            this.cmdCrear.Name = "cmdCrear";
            this.cmdCrear.Size = new System.Drawing.Size(100, 23);
            this.cmdCrear.TabIndex = 3;
            this.cmdCrear.Text = "Crear personaje";
            this.cmdCrear.UseVisualStyleBackColor = true;
            this.cmdCrear.Click += new System.EventHandler(this.cmdCrear_Click);
            // 
            // txtFuerza
            // 
            this.txtFuerza.Location = new System.Drawing.Point(91, 52);
            this.txtFuerza.Name = "txtFuerza";
            this.txtFuerza.Size = new System.Drawing.Size(56, 20);
            this.txtFuerza.TabIndex = 1;
            // 
            // txtDestreza
            // 
            this.txtDestreza.Location = new System.Drawing.Point(91, 78);
            this.txtDestreza.Name = "txtDestreza";
            this.txtDestreza.Size = new System.Drawing.Size(56, 20);
            this.txtDestreza.TabIndex = 2;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(56, 26);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(127, 20);
            this.txtNombre.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Fuerza";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Destreza";
            // 
            // mrcCrear
            // 
            this.mrcCrear.Controls.Add(this.label1);
            this.mrcCrear.Controls.Add(this.label3);
            this.mrcCrear.Controls.Add(this.cmdCrear);
            this.mrcCrear.Controls.Add(this.label2);
            this.mrcCrear.Controls.Add(this.txtFuerza);
            this.mrcCrear.Controls.Add(this.txtDestreza);
            this.mrcCrear.Controls.Add(this.txtNombre);
            this.mrcCrear.Location = new System.Drawing.Point(12, 12);
            this.mrcCrear.Name = "mrcCrear";
            this.mrcCrear.Size = new System.Drawing.Size(203, 148);
            this.mrcCrear.TabIndex = 7;
            this.mrcCrear.TabStop = false;
            this.mrcCrear.Text = "Creador";
            // 
            // lblDatos
            // 
            this.lblDatos.AutoSize = true;
            this.lblDatos.Location = new System.Drawing.Point(13, 167);
            this.lblDatos.Name = "lblDatos";
            this.lblDatos.Size = new System.Drawing.Size(165, 13);
            this.lblDatos.TabIndex = 8;
            this.lblDatos.Text = "Aquí los datos de lo que creamos";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 475);
            this.Controls.Add(this.lblDatos);
            this.Controls.Add(this.mrcCrear);
            this.Name = "Form1";
            this.Text = "Creación de personajes";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.mrcCrear.ResumeLayout(false);
            this.mrcCrear.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdCrear;
        private System.Windows.Forms.TextBox txtFuerza;
        private System.Windows.Forms.TextBox txtDestreza;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox mrcCrear;
        private System.Windows.Forms.Label lblDatos;
    }
}


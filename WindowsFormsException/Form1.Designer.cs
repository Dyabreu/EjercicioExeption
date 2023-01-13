namespace WindowsFormsException
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
            this.btn_nombre_largo = new System.Windows.Forms.Button();
            this.btn_no_nombre = new System.Windows.Forms.Button();
            this.nombre_valido = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_nombre_largo
            // 
            this.btn_nombre_largo.Location = new System.Drawing.Point(292, 120);
            this.btn_nombre_largo.Name = "btn_nombre_largo";
            this.btn_nombre_largo.Size = new System.Drawing.Size(151, 23);
            this.btn_nombre_largo.TabIndex = 0;
            this.btn_nombre_largo.Text = "Nombre largo";
            this.btn_nombre_largo.UseVisualStyleBackColor = true;
            this.btn_nombre_largo.Click += new System.EventHandler(this.btn_nombre_largo_Click);
            // 
            // btn_no_nombre
            // 
            this.btn_no_nombre.Location = new System.Drawing.Point(292, 202);
            this.btn_no_nombre.Name = "btn_no_nombre";
            this.btn_no_nombre.Size = new System.Drawing.Size(151, 23);
            this.btn_no_nombre.TabIndex = 1;
            this.btn_no_nombre.Text = "Ningún nombre";
            this.btn_no_nombre.UseVisualStyleBackColor = true;
            this.btn_no_nombre.Click += new System.EventHandler(this.btn_no_nombre_Click);
            // 
            // nombre_valido
            // 
            this.nombre_valido.Location = new System.Drawing.Point(292, 285);
            this.nombre_valido.Name = "nombre_valido";
            this.nombre_valido.Size = new System.Drawing.Size(151, 23);
            this.nombre_valido.TabIndex = 2;
            this.nombre_valido.Text = "Nombre válido";
            this.nombre_valido.UseVisualStyleBackColor = true;
            this.nombre_valido.Click += new System.EventHandler(this.nombre_valido_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.nombre_valido);
            this.Controls.Add(this.btn_no_nombre);
            this.Controls.Add(this.btn_nombre_largo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_nombre_largo;
        private System.Windows.Forms.Button btn_no_nombre;
        private System.Windows.Forms.Button nombre_valido;
    }
}


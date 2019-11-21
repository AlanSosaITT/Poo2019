namespace Practica_14_11_2019_Exceptions
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
            this.components = new System.ComponentModel.Container();
            this.Baceptar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TBMatricula = new System.Windows.Forms.TextBox();
            this.TBNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TBSemestre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TBCarrera = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TBTelefono = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.EP = new System.Windows.Forms.ErrorProvider(this.components);
            this.TBCalificacion = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.EP)).BeginInit();
            this.SuspendLayout();
            // 
            // Baceptar
            // 
            this.Baceptar.Location = new System.Drawing.Point(153, 199);
            this.Baceptar.Name = "Baceptar";
            this.Baceptar.Size = new System.Drawing.Size(75, 23);
            this.Baceptar.TabIndex = 0;
            this.Baceptar.Text = "Aceptar";
            this.Baceptar.UseVisualStyleBackColor = true;
            this.Baceptar.Click += new System.EventHandler(this.Baceptar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Matricula";
            // 
            // TBMatricula
            // 
            this.TBMatricula.Location = new System.Drawing.Point(15, 42);
            this.TBMatricula.Name = "TBMatricula";
            this.TBMatricula.Size = new System.Drawing.Size(100, 20);
            this.TBMatricula.TabIndex = 3;
            // 
            // TBNombre
            // 
            this.TBNombre.Location = new System.Drawing.Point(15, 82);
            this.TBNombre.Name = "TBNombre";
            this.TBNombre.Size = new System.Drawing.Size(100, 20);
            this.TBNombre.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nombre";
            // 
            // TBSemestre
            // 
            this.TBSemestre.Location = new System.Drawing.Point(15, 122);
            this.TBSemestre.Name = "TBSemestre";
            this.TBSemestre.Size = new System.Drawing.Size(100, 20);
            this.TBSemestre.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Semestre";
            // 
            // TBCarrera
            // 
            this.TBCarrera.Location = new System.Drawing.Point(15, 162);
            this.TBCarrera.Name = "TBCarrera";
            this.TBCarrera.Size = new System.Drawing.Size(100, 20);
            this.TBCarrera.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Carrera";
            // 
            // TBTelefono
            // 
            this.TBTelefono.Location = new System.Drawing.Point(15, 202);
            this.TBTelefono.Name = "TBTelefono";
            this.TBTelefono.Size = new System.Drawing.Size(100, 20);
            this.TBTelefono.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Telefono";
            // 
            // EP
            // 
            this.EP.ContainerControl = this;
            // 
            // TBCalificacion
            // 
            this.TBCalificacion.Location = new System.Drawing.Point(17, 242);
            this.TBCalificacion.Name = "TBCalificacion";
            this.TBCalificacion.Size = new System.Drawing.Size(100, 20);
            this.TBCalificacion.TabIndex = 13;
            this.TBCalificacion.TextChanged += new System.EventHandler(this.TBCalificacion_TextChanged);
            this.TBCalificacion.Validating += new System.ComponentModel.CancelEventHandler(this.TBCalificacion_Validating);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 225);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 13);
            this.label6.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 226);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Calificacion";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(240, 283);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TBCalificacion);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TBTelefono);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TBCarrera);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TBSemestre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TBNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TBMatricula);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Baceptar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.EP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Baceptar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TBMatricula;
        private System.Windows.Forms.TextBox TBNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TBSemestre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TBCarrera;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TBTelefono;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ErrorProvider EP;
        private System.Windows.Forms.TextBox TBCalificacion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}


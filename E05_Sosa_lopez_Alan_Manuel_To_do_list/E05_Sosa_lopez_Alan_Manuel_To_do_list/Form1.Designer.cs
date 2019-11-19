namespace E05_Sosa_lopez_Alan_Manuel_To_do_list
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
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.MCBusuario = new System.Windows.Forms.ComboBox();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.MTAgregartarea = new MetroFramework.Controls.MetroButton();
            this.htmlLabel1 = new MetroFramework.Drawing.Html.HtmlLabel();
            this.MBAgregarusuario = new MetroFramework.Controls.MetroButton();
            this.MBVer = new MetroFramework.Controls.MetroButton();
            this.DGV = new System.Windows.Forms.DataGridView();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).BeginInit();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.MCBusuario);
            this.metroPanel1.Controls.Add(this.metroButton1);
            this.metroPanel1.Controls.Add(this.MTAgregartarea);
            this.metroPanel1.Controls.Add(this.htmlLabel1);
            this.metroPanel1.Controls.Add(this.MBAgregarusuario);
            this.metroPanel1.Controls.Add(this.MBVer);
            this.metroPanel1.Controls.Add(this.DGV);
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(23, 74);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(887, 455);
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // MCBusuario
            // 
            this.MCBusuario.FormattingEnabled = true;
            this.MCBusuario.Location = new System.Drawing.Point(4, 33);
            this.MCBusuario.Name = "MCBusuario";
            this.MCBusuario.Size = new System.Drawing.Size(121, 24);
            this.MCBusuario.TabIndex = 12;
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(709, 401);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(160, 51);
            this.metroButton1.TabIndex = 11;
            this.metroButton1.Text = "Salir";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.MetroButton1_Click);
            // 
            // MTAgregartarea
            // 
            this.MTAgregartarea.Location = new System.Drawing.Point(709, 281);
            this.MTAgregartarea.Name = "MTAgregartarea";
            this.MTAgregartarea.Size = new System.Drawing.Size(160, 49);
            this.MTAgregartarea.TabIndex = 9;
            this.MTAgregartarea.Text = "Agregar Tarea";
            this.MTAgregartarea.UseSelectable = true;
            this.MTAgregartarea.Click += new System.EventHandler(this.MTAgregartarea_Click);
            // 
            // htmlLabel1
            // 
            this.htmlLabel1.AutoScroll = true;
            this.htmlLabel1.AutoScrollMinSize = new System.Drawing.Size(49, 23);
            this.htmlLabel1.AutoSize = false;
            this.htmlLabel1.BackColor = System.Drawing.SystemColors.Window;
            this.htmlLabel1.Location = new System.Drawing.Point(4, 3);
            this.htmlLabel1.Name = "htmlLabel1";
            this.htmlLabel1.Size = new System.Drawing.Size(164, 23);
            this.htmlLabel1.TabIndex = 8;
            this.htmlLabel1.Text = "Usuario";
            // 
            // MBAgregarusuario
            // 
            this.MBAgregarusuario.Location = new System.Drawing.Point(709, 169);
            this.MBAgregarusuario.Name = "MBAgregarusuario";
            this.MBAgregarusuario.Size = new System.Drawing.Size(160, 49);
            this.MBAgregarusuario.TabIndex = 5;
            this.MBAgregarusuario.Text = "Agregar Usuario";
            this.MBAgregarusuario.UseSelectable = true;
            this.MBAgregarusuario.Click += new System.EventHandler(this.MBAgregarusuario_Click);
            // 
            // MBVer
            // 
            this.MBVer.Location = new System.Drawing.Point(709, 58);
            this.MBVer.Name = "MBVer";
            this.MBVer.Size = new System.Drawing.Size(160, 49);
            this.MBVer.TabIndex = 4;
            this.MBVer.Text = "Ver";
            this.MBVer.UseSelectable = true;
            this.MBVer.Click += new System.EventHandler(this.MBVer_Click);
            // 
            // DGV
            // 
            this.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV.Location = new System.Drawing.Point(4, 58);
            this.DGV.Name = "DGV";
            this.DGV.Size = new System.Drawing.Size(681, 394);
            this.DGV.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 554);
            this.Controls.Add(this.metroPanel1);
            this.Font = new System.Drawing.Font("Bradley Hand ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(23, 74, 23, 25);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.metroPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroButton MBAgregarusuario;
        private MetroFramework.Controls.MetroButton MBVer;
        private System.Windows.Forms.DataGridView DGV;
        private MetroFramework.Drawing.Html.HtmlLabel htmlLabel1;
        private MetroFramework.Controls.MetroButton MTAgregartarea;
        private MetroFramework.Controls.MetroButton metroButton1;
        private System.Windows.Forms.ComboBox MCBusuario;
    }
}


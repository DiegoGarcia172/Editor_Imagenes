
namespace Editor_Imagenes
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnFiltro1 = new System.Windows.Forms.Button();
            this.btnFiltro2 = new System.Windows.Forms.Button();
            this.btnFiltro_3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.redbar = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.greenbar = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.bluebar = new System.Windows.Forms.TrackBar();
            this.btnGuardar_Imagen = new System.Windows.Forms.Button();
            this.btnAbrir_Imagen = new System.Windows.Forms.Button();
            this.bnt_Borrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.redbar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenbar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bluebar)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Location = new System.Drawing.Point(15, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(862, 479);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnFiltro1
            // 
            this.btnFiltro1.Location = new System.Drawing.Point(993, 12);
            this.btnFiltro1.Name = "btnFiltro1";
            this.btnFiltro1.Size = new System.Drawing.Size(130, 37);
            this.btnFiltro1.TabIndex = 1;
            this.btnFiltro1.Text = "button1";
            this.btnFiltro1.UseVisualStyleBackColor = true;
            this.btnFiltro1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnFiltro2
            // 
            this.btnFiltro2.Location = new System.Drawing.Point(993, 55);
            this.btnFiltro2.Name = "btnFiltro2";
            this.btnFiltro2.Size = new System.Drawing.Size(130, 37);
            this.btnFiltro2.TabIndex = 2;
            this.btnFiltro2.Text = "button2";
            this.btnFiltro2.UseVisualStyleBackColor = true;
            this.btnFiltro2.Click += new System.EventHandler(this.btnFiltro2_Click);
            // 
            // btnFiltro_3
            // 
            this.btnFiltro_3.Location = new System.Drawing.Point(993, 98);
            this.btnFiltro_3.Name = "btnFiltro_3";
            this.btnFiltro_3.Size = new System.Drawing.Size(130, 37);
            this.btnFiltro_3.TabIndex = 3;
            this.btnFiltro_3.Text = "button3";
            this.btnFiltro_3.UseVisualStyleBackColor = true;
            this.btnFiltro_3.Click += new System.EventHandler(this.btnFiltro_3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(993, 141);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(130, 37);
            this.button4.TabIndex = 4;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(993, 184);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(130, 37);
            this.button5.TabIndex = 5;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(993, 227);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(130, 37);
            this.button6.TabIndex = 6;
            this.button6.Text = "button6";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(993, 270);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(130, 37);
            this.button7.TabIndex = 7;
            this.button7.Text = "button7";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 499);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Red";
            // 
            // redbar
            // 
            this.redbar.Location = new System.Drawing.Point(53, 499);
            this.redbar.Maximum = 255;
            this.redbar.Name = "redbar";
            this.redbar.Size = new System.Drawing.Size(543, 45);
            this.redbar.TabIndex = 9;
            this.redbar.Scroll += new System.EventHandler(this.redbar_Scroll);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 540);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Green";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // greenbar
            // 
            this.greenbar.Location = new System.Drawing.Point(53, 531);
            this.greenbar.Maximum = 255;
            this.greenbar.Name = "greenbar";
            this.greenbar.Size = new System.Drawing.Size(543, 45);
            this.greenbar.TabIndex = 11;
            this.greenbar.Scroll += new System.EventHandler(this.greenbar_Scroll);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 586);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Blue";
            // 
            // bluebar
            // 
            this.bluebar.Location = new System.Drawing.Point(53, 565);
            this.bluebar.Maximum = 255;
            this.bluebar.Name = "bluebar";
            this.bluebar.Size = new System.Drawing.Size(543, 45);
            this.bluebar.TabIndex = 13;
            this.bluebar.Scroll += new System.EventHandler(this.bluebar_Scroll);
            // 
            // btnGuardar_Imagen
            // 
            this.btnGuardar_Imagen.Location = new System.Drawing.Point(939, 440);
            this.btnGuardar_Imagen.Name = "btnGuardar_Imagen";
            this.btnGuardar_Imagen.Size = new System.Drawing.Size(196, 77);
            this.btnGuardar_Imagen.TabIndex = 14;
            this.btnGuardar_Imagen.Text = "Guardar Imagen";
            this.btnGuardar_Imagen.UseVisualStyleBackColor = true;
            this.btnGuardar_Imagen.Click += new System.EventHandler(this.button8_Click);
            // 
            // btnAbrir_Imagen
            // 
            this.btnAbrir_Imagen.Location = new System.Drawing.Point(939, 521);
            this.btnAbrir_Imagen.Name = "btnAbrir_Imagen";
            this.btnAbrir_Imagen.Size = new System.Drawing.Size(196, 71);
            this.btnAbrir_Imagen.TabIndex = 15;
            this.btnAbrir_Imagen.Text = "Abrir Imagen";
            this.btnAbrir_Imagen.UseVisualStyleBackColor = true;
            this.btnAbrir_Imagen.Click += new System.EventHandler(this.button9_Click);
            // 
            // bnt_Borrar
            // 
            this.bnt_Borrar.Location = new System.Drawing.Point(939, 346);
            this.bnt_Borrar.Name = "bnt_Borrar";
            this.bnt_Borrar.Size = new System.Drawing.Size(196, 77);
            this.bnt_Borrar.TabIndex = 16;
            this.bnt_Borrar.Text = "Borrar Imagen";
            this.bnt_Borrar.UseVisualStyleBackColor = true;
            this.bnt_Borrar.Click += new System.EventHandler(this.bnt_Borrar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1146, 622);
            this.Controls.Add(this.bnt_Borrar);
            this.Controls.Add(this.btnAbrir_Imagen);
            this.Controls.Add(this.btnGuardar_Imagen);
            this.Controls.Add(this.bluebar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.greenbar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.redbar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnFiltro_3);
            this.Controls.Add(this.btnFiltro2);
            this.Controls.Add(this.btnFiltro1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.redbar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenbar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bluebar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnFiltro1;
        private System.Windows.Forms.Button btnFiltro2;
        private System.Windows.Forms.Button btnFiltro_3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar redbar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar greenbar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TrackBar bluebar;
        private System.Windows.Forms.Button btnGuardar_Imagen;
        private System.Windows.Forms.Button btnAbrir_Imagen;
        private System.Windows.Forms.Button bnt_Borrar;
    }
}


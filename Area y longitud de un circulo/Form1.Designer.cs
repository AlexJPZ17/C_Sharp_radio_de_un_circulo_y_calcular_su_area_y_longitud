namespace Area_y_longitud_de_un_circulo
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.PictureBox2 = new System.Windows.Forms.PictureBox();
            this.Label_Longitud = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label_Area = new System.Windows.Forms.Label();
            this.TextBox_Radio = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.Button_Run = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // PictureBox2
            // 
            this.PictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox2.Image")));
            this.PictureBox2.Location = new System.Drawing.Point(70, 12);
            this.PictureBox2.Name = "PictureBox2";
            this.PictureBox2.Size = new System.Drawing.Size(129, 136);
            this.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox2.TabIndex = 17;
            this.PictureBox2.TabStop = false;
            // 
            // Label_Longitud
            // 
            this.Label_Longitud.AutoSize = true;
            this.Label_Longitud.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.150944F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Longitud.Location = new System.Drawing.Point(88, 252);
            this.Label_Longitud.Name = "Label_Longitud";
            this.Label_Longitud.Size = new System.Drawing.Size(16, 16);
            this.Label_Longitud.TabIndex = 16;
            this.Label_Longitud.Text = "0";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.150944F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.Location = new System.Drawing.Point(11, 252);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(71, 16);
            this.Label4.TabIndex = 15;
            this.Label4.Text = "Longitud:";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.150944F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.Location = new System.Drawing.Point(33, 222);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(49, 16);
            this.Label3.TabIndex = 14;
            this.Label3.Text = "Area :";
            // 
            // Label_Area
            // 
            this.Label_Area.AutoSize = true;
            this.Label_Area.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.150944F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Area.Location = new System.Drawing.Point(88, 222);
            this.Label_Area.Name = "Label_Area";
            this.Label_Area.Size = new System.Drawing.Size(16, 16);
            this.Label_Area.TabIndex = 13;
            this.Label_Area.Text = "0";
            // 
            // TextBox_Radio
            // 
            this.TextBox_Radio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.150944F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox_Radio.Location = new System.Drawing.Point(79, 187);
            this.TextBox_Radio.Name = "TextBox_Radio";
            this.TextBox_Radio.Size = new System.Drawing.Size(100, 21);
            this.TextBox_Radio.TabIndex = 12;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.150944F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(76, 158);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(117, 16);
            this.Label1.TabIndex = 11;
            this.Label1.Text = "Ingrese el radio";
            // 
            // Button_Run
            // 
            this.Button_Run.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.150944F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Run.Location = new System.Drawing.Point(96, 288);
            this.Button_Run.Name = "Button_Run";
            this.Button_Run.Size = new System.Drawing.Size(75, 23);
            this.Button_Run.TabIndex = 10;
            this.Button_Run.Text = "Run";
            this.Button_Run.UseVisualStyleBackColor = true;
            this.Button_Run.Click += new System.EventHandler(this.Button_Run_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(263, 323);
            this.Controls.Add(this.PictureBox2);
            this.Controls.Add(this.Label_Longitud);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label_Area);
            this.Controls.Add(this.TextBox_Radio);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.Button_Run);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.PictureBox PictureBox2;
        internal System.Windows.Forms.Label Label_Longitud;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label_Area;
        internal System.Windows.Forms.TextBox TextBox_Radio;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Button Button_Run;
    }
}


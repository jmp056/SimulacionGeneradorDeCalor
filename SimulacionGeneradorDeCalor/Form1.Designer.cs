namespace SimulacionGeneradorDeCalor
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.CorreaTimer = new System.Windows.Forms.Timer(this.components);
            this.ControlesGroupBox = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.CantidadLabel = new System.Windows.Forms.Label();
            this.MenosCantidadButton = new System.Windows.Forms.Button();
            this.MasCantidadButton = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.CombustibleComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.VelocidadLabel = new System.Windows.Forms.Label();
            this.MenosVelocidadButton = new System.Windows.Forms.Button();
            this.MasVelocidadButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BandaButton = new System.Windows.Forms.Button();
            this.PuertaButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.CorreaPictureBox = new System.Windows.Forms.PictureBox();
            this.CasillaPictureBox = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.TemperaturaLabel = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.ControlesGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CorreaPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CasillaPictureBox)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // CorreaTimer
            // 
            this.CorreaTimer.Interval = 1000;
            this.CorreaTimer.Tick += new System.EventHandler(this.CorreaTimer_Tick);
            // 
            // ControlesGroupBox
            // 
            this.ControlesGroupBox.Controls.Add(this.groupBox1);
            this.ControlesGroupBox.Controls.Add(this.label7);
            this.ControlesGroupBox.Controls.Add(this.label9);
            this.ControlesGroupBox.Controls.Add(this.label10);
            this.ControlesGroupBox.Controls.Add(this.label6);
            this.ControlesGroupBox.Controls.Add(this.CantidadLabel);
            this.ControlesGroupBox.Controls.Add(this.MenosCantidadButton);
            this.ControlesGroupBox.Controls.Add(this.MasCantidadButton);
            this.ControlesGroupBox.Controls.Add(this.label8);
            this.ControlesGroupBox.Controls.Add(this.label5);
            this.ControlesGroupBox.Controls.Add(this.CombustibleComboBox);
            this.ControlesGroupBox.Controls.Add(this.label4);
            this.ControlesGroupBox.Controls.Add(this.VelocidadLabel);
            this.ControlesGroupBox.Controls.Add(this.MenosVelocidadButton);
            this.ControlesGroupBox.Controls.Add(this.MasVelocidadButton);
            this.ControlesGroupBox.Controls.Add(this.label3);
            this.ControlesGroupBox.Controls.Add(this.label2);
            this.ControlesGroupBox.Controls.Add(this.label1);
            this.ControlesGroupBox.Controls.Add(this.BandaButton);
            this.ControlesGroupBox.Controls.Add(this.PuertaButton);
            this.ControlesGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ControlesGroupBox.Location = new System.Drawing.Point(12, 275);
            this.ControlesGroupBox.Name = "ControlesGroupBox";
            this.ControlesGroupBox.Size = new System.Drawing.Size(538, 182);
            this.ControlesGroupBox.TabIndex = 3;
            this.ControlesGroupBox.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(299, 157);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 20);
            this.label7.TabIndex = 18;
            this.label7.Text = "m/s";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(257, 148);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 29);
            this.label9.TabIndex = 17;
            this.label9.Text = "3.0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(248, 114);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(88, 20);
            this.label10.TabIndex = 16;
            this.label10.Text = "Velocidad";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(133, 159);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "kg/s";
            // 
            // CantidadLabel
            // 
            this.CantidadLabel.AutoSize = true;
            this.CantidadLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CantidadLabel.Location = new System.Drawing.Point(91, 150);
            this.CantidadLabel.Name = "CantidadLabel";
            this.CantidadLabel.Size = new System.Drawing.Size(48, 29);
            this.CantidadLabel.TabIndex = 14;
            this.CantidadLabel.Text = "3.0";
            // 
            // MenosCantidadButton
            // 
            this.MenosCantidadButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenosCantidadButton.ForeColor = System.Drawing.SystemColors.Control;
            this.MenosCantidadButton.Image = global::SimulacionGeneradorDeCalor.Properties.Resources.Menos;
            this.MenosCantidadButton.Location = new System.Drawing.Point(50, 147);
            this.MenosCantidadButton.Name = "MenosCantidadButton";
            this.MenosCantidadButton.Size = new System.Drawing.Size(35, 35);
            this.MenosCantidadButton.TabIndex = 13;
            this.MenosCantidadButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.MenosCantidadButton.UseVisualStyleBackColor = true;
            // 
            // MasCantidadButton
            // 
            this.MasCantidadButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MasCantidadButton.ForeColor = System.Drawing.SystemColors.Control;
            this.MasCantidadButton.Image = global::SimulacionGeneradorDeCalor.Properties.Resources.Mas;
            this.MasCantidadButton.Location = new System.Drawing.Point(173, 147);
            this.MasCantidadButton.Name = "MasCantidadButton";
            this.MasCantidadButton.Size = new System.Drawing.Size(35, 35);
            this.MasCantidadButton.TabIndex = 12;
            this.MasCantidadButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.MasCantidadButton.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(82, 116);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 20);
            this.label8.TabIndex = 11;
            this.label8.Text = "Velocidad";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(406, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Combustible";
            // 
            // CombustibleComboBox
            // 
            this.CombustibleComboBox.FormattingEnabled = true;
            this.CombustibleComboBox.Items.AddRange(new object[] {
            "Madera blanda",
            "Madera dura",
            "Roble",
            "Pino"});
            this.CombustibleComboBox.Location = new System.Drawing.Point(394, 57);
            this.CombustibleComboBox.Name = "CombustibleComboBox";
            this.CombustibleComboBox.Size = new System.Drawing.Size(121, 28);
            this.CombustibleComboBox.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(301, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "m/s";
            // 
            // VelocidadLabel
            // 
            this.VelocidadLabel.AutoSize = true;
            this.VelocidadLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VelocidadLabel.Location = new System.Drawing.Point(259, 56);
            this.VelocidadLabel.Name = "VelocidadLabel";
            this.VelocidadLabel.Size = new System.Drawing.Size(48, 29);
            this.VelocidadLabel.TabIndex = 7;
            this.VelocidadLabel.Text = "3.0";
            // 
            // MenosVelocidadButton
            // 
            this.MenosVelocidadButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenosVelocidadButton.ForeColor = System.Drawing.SystemColors.Control;
            this.MenosVelocidadButton.Image = global::SimulacionGeneradorDeCalor.Properties.Resources.Menos;
            this.MenosVelocidadButton.Location = new System.Drawing.Point(218, 53);
            this.MenosVelocidadButton.Name = "MenosVelocidadButton";
            this.MenosVelocidadButton.Size = new System.Drawing.Size(35, 35);
            this.MenosVelocidadButton.TabIndex = 6;
            this.MenosVelocidadButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.MenosVelocidadButton.UseVisualStyleBackColor = true;
            this.MenosVelocidadButton.Click += new System.EventHandler(this.MenosButton_Click);
            // 
            // MasVelocidadButton
            // 
            this.MasVelocidadButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MasVelocidadButton.ForeColor = System.Drawing.SystemColors.Control;
            this.MasVelocidadButton.Image = global::SimulacionGeneradorDeCalor.Properties.Resources.Mas;
            this.MasVelocidadButton.Location = new System.Drawing.Point(341, 53);
            this.MasVelocidadButton.Name = "MasVelocidadButton";
            this.MasVelocidadButton.Size = new System.Drawing.Size(35, 35);
            this.MasVelocidadButton.TabIndex = 5;
            this.MasVelocidadButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.MasVelocidadButton.UseVisualStyleBackColor = true;
            this.MasVelocidadButton.Click += new System.EventHandler(this.MasButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(250, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Velocidad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(124, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Banda ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Puerta";
            // 
            // BandaButton
            // 
            this.BandaButton.Image = global::SimulacionGeneradorDeCalor.Properties.Resources.Apagado;
            this.BandaButton.Location = new System.Drawing.Point(118, 45);
            this.BandaButton.Name = "BandaButton";
            this.BandaButton.Size = new System.Drawing.Size(75, 43);
            this.BandaButton.TabIndex = 1;
            this.BandaButton.UseVisualStyleBackColor = true;
            this.BandaButton.Click += new System.EventHandler(this.BandaButton_Click);
            // 
            // PuertaButton
            // 
            this.PuertaButton.Image = global::SimulacionGeneradorDeCalor.Properties.Resources.Apagado;
            this.PuertaButton.Location = new System.Drawing.Point(8, 45);
            this.PuertaButton.Name = "PuertaButton";
            this.PuertaButton.Size = new System.Drawing.Size(75, 43);
            this.PuertaButton.TabIndex = 0;
            this.PuertaButton.UseVisualStyleBackColor = true;
            this.PuertaButton.Click += new System.EventHandler(this.PuertaButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(-60, 42);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(224, 124);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // CorreaPictureBox
            // 
            this.CorreaPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.CorreaPictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CorreaPictureBox.BackgroundImage")));
            this.CorreaPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CorreaPictureBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.CorreaPictureBox.InitialImage = null;
            this.CorreaPictureBox.Location = new System.Drawing.Point(20, 202);
            this.CorreaPictureBox.Name = "CorreaPictureBox";
            this.CorreaPictureBox.Size = new System.Drawing.Size(315, 35);
            this.CorreaPictureBox.TabIndex = 0;
            this.CorreaPictureBox.TabStop = false;
            // 
            // CasillaPictureBox
            // 
            this.CasillaPictureBox.BackgroundImage = global::SimulacionGeneradorDeCalor.Properties.Resources.CasillaCerrada;
            this.CasillaPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CasillaPictureBox.Location = new System.Drawing.Point(315, 12);
            this.CasillaPictureBox.Name = "CasillaPictureBox";
            this.CasillaPictureBox.Size = new System.Drawing.Size(235, 243);
            this.CasillaPictureBox.TabIndex = 1;
            this.CasillaPictureBox.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Controls.Add(this.TemperaturaLabel);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Location = new System.Drawing.Point(384, 100);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(148, 82);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(19, 14);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(111, 20);
            this.label11.TabIndex = 20;
            this.label11.Text = "Temperatura";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(104, 50);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(27, 20);
            this.label12.TabIndex = 21;
            this.label12.Text = "C°";
            // 
            // TemperaturaLabel
            // 
            this.TemperaturaLabel.AutoSize = true;
            this.TemperaturaLabel.Location = new System.Drawing.Point(59, 47);
            this.TemperaturaLabel.Name = "TemperaturaLabel";
            this.TemperaturaLabel.Size = new System.Drawing.Size(29, 20);
            this.TemperaturaLabel.TabIndex = 22;
            this.TemperaturaLabel.Text = "28";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(10, 37);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(36, 33);
            this.pictureBox2.TabIndex = 23;
            this.pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(666, 469);
            this.Controls.Add(this.ControlesGroupBox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.CorreaPictureBox);
            this.Controls.Add(this.CasillaPictureBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ControlesGroupBox.ResumeLayout(false);
            this.ControlesGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CorreaPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CasillaPictureBox)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox CorreaPictureBox;
        private System.Windows.Forms.PictureBox CasillaPictureBox;
        private System.Windows.Forms.Timer CorreaTimer;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox ControlesGroupBox;
        private System.Windows.Forms.Button PuertaButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BandaButton;
        private System.Windows.Forms.Button MenosVelocidadButton;
        private System.Windows.Forms.Button MasVelocidadButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label VelocidadLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox CombustibleComboBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label CantidadLabel;
        private System.Windows.Forms.Button MenosCantidadButton;
        private System.Windows.Forms.Button MasCantidadButton;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label TemperaturaLabel;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
    }
}


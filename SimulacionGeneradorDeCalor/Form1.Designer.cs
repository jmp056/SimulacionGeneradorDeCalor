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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.MenosButton = new System.Windows.Forms.Button();
            this.MasButton = new System.Windows.Forms.Button();
            this.BandaButton = new System.Windows.Forms.Button();
            this.PuertaButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.CorreaPictureBox = new System.Windows.Forms.PictureBox();
            this.CasillaPictureBox = new System.Windows.Forms.PictureBox();
            this.VelocidadLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ControlesGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CorreaPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CasillaPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // CorreaTimer
            // 
            this.CorreaTimer.Interval = 1000;
            this.CorreaTimer.Tick += new System.EventHandler(this.CorreaTimer_Tick);
            // 
            // ControlesGroupBox
            // 
            this.ControlesGroupBox.Controls.Add(this.label4);
            this.ControlesGroupBox.Controls.Add(this.VelocidadLabel);
            this.ControlesGroupBox.Controls.Add(this.MenosButton);
            this.ControlesGroupBox.Controls.Add(this.MasButton);
            this.ControlesGroupBox.Controls.Add(this.label3);
            this.ControlesGroupBox.Controls.Add(this.label2);
            this.ControlesGroupBox.Controls.Add(this.label1);
            this.ControlesGroupBox.Controls.Add(this.BandaButton);
            this.ControlesGroupBox.Controls.Add(this.PuertaButton);
            this.ControlesGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ControlesGroupBox.Location = new System.Drawing.Point(12, 275);
            this.ControlesGroupBox.Name = "ControlesGroupBox";
            this.ControlesGroupBox.Size = new System.Drawing.Size(538, 105);
            this.ControlesGroupBox.TabIndex = 3;
            this.ControlesGroupBox.TabStop = false;
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
            // MenosButton
            // 
            this.MenosButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenosButton.ForeColor = System.Drawing.SystemColors.Control;
            this.MenosButton.Image = global::SimulacionGeneradorDeCalor.Properties.Resources.Menos;
            this.MenosButton.Location = new System.Drawing.Point(218, 53);
            this.MenosButton.Name = "MenosButton";
            this.MenosButton.Size = new System.Drawing.Size(35, 35);
            this.MenosButton.TabIndex = 6;
            this.MenosButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.MenosButton.UseVisualStyleBackColor = true;
            this.MenosButton.Click += new System.EventHandler(this.MenosButton_Click);
            // 
            // MasButton
            // 
            this.MasButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MasButton.ForeColor = System.Drawing.SystemColors.Control;
            this.MasButton.Image = global::SimulacionGeneradorDeCalor.Properties.Resources.Mas;
            this.MasButton.Location = new System.Drawing.Point(341, 53);
            this.MasButton.Name = "MasButton";
            this.MasButton.Size = new System.Drawing.Size(35, 35);
            this.MasButton.TabIndex = 5;
            this.MasButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.MasButton.UseVisualStyleBackColor = true;
            this.MasButton.Click += new System.EventHandler(this.MasButton_Click);
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
            // VelocidadLabel
            // 
            this.VelocidadLabel.AutoSize = true;
            this.VelocidadLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VelocidadLabel.Location = new System.Drawing.Point(259, 56);
            this.VelocidadLabel.Name = "VelocidadLabel";
            this.VelocidadLabel.Size = new System.Drawing.Size(48, 29);
            this.VelocidadLabel.TabIndex = 7;
            this.VelocidadLabel.Text = "5.0";
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(561, 392);
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
        private System.Windows.Forms.Button MenosButton;
        private System.Windows.Forms.Button MasButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label VelocidadLabel;
    }
}


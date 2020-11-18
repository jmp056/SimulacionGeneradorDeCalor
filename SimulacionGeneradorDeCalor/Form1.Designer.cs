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
            this.CorreaPictureBox = new System.Windows.Forms.PictureBox();
            this.CasillaPictureBox = new System.Windows.Forms.PictureBox();
            this.CorreaTimer = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.CorreaPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CasillaPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // CorreaPictureBox
            // 
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
            this.CasillaPictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CasillaPictureBox.BackgroundImage")));
            this.CasillaPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CasillaPictureBox.Location = new System.Drawing.Point(315, 12);
            this.CasillaPictureBox.Name = "CasillaPictureBox";
            this.CasillaPictureBox.Size = new System.Drawing.Size(235, 243);
            this.CasillaPictureBox.TabIndex = 1;
            this.CasillaPictureBox.TabStop = false;
            // 
            // CorreaTimer
            // 
            this.CorreaTimer.Interval = 1000;
            this.CorreaTimer.Tick += new System.EventHandler(this.CorreaTimer_Tick);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(561, 279);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.CorreaPictureBox);
            this.Controls.Add(this.CasillaPictureBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CorreaPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CasillaPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox CorreaPictureBox;
        private System.Windows.Forms.PictureBox CasillaPictureBox;
        private System.Windows.Forms.Timer CorreaTimer;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}


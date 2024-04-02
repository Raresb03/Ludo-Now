
namespace Ludo_Now
{
    partial class Inceput
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inceput));
            this.Start = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Exit = new System.Windows.Forms.Button();
            this.Logo = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Start
            // 
            this.Start.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Start.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Start.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.Start.FlatAppearance.BorderSize = 0;
            this.Start.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Start.Location = new System.Drawing.Point(117, 367);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(153, 64);
            this.Start.TabIndex = 0;
            this.Start.Text = "Start Game";
            this.Start.UseVisualStyleBackColor = false;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-53, -41);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(474, 660);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Exit
            // 
            this.Exit.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.Location = new System.Drawing.Point(140, 456);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(105, 52);
            this.Exit.TabIndex = 2;
            this.Exit.Text = "Exit Game";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Logo
            // 
            this.Logo.BackColor = System.Drawing.Color.DarkBlue;
            this.Logo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Logo.Cursor = System.Windows.Forms.Cursors.Default;
            this.Logo.Font = new System.Drawing.Font("Imprint MT Shadow", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Logo.ForeColor = System.Drawing.Color.Ivory;
            this.Logo.Location = new System.Drawing.Point(-8, 53);
            this.Logo.Multiline = true;
            this.Logo.Name = "Logo";
            this.Logo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Logo.Size = new System.Drawing.Size(392, 108);
            this.Logo.TabIndex = 3;
            this.Logo.Text = "NU TE SUPARA, FRATE!";
            this.Logo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Inceput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 560);
            this.Controls.Add(this.Logo);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Inceput";
            this.Text = "Inceput";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.TextBox Logo;
    }
}
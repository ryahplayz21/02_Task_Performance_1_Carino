namespace _02_Task_Performance_1
{
    partial class DisplayCurrentServing
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DisplayCurrentServing));
            this.DescriptionLabel = new System.Windows.Forms.Label();
            this.QueueNumber = new System.Windows.Forms.Label();
            this.MessageLabel = new System.Windows.Forms.Label();
            this.RefreshTimer = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.AutoSize = true;
            this.DescriptionLabel.Font = new System.Drawing.Font("Bookman Old Style", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescriptionLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.DescriptionLabel.Location = new System.Drawing.Point(202, 140);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(442, 75);
            this.DescriptionLabel.TabIndex = 0;
            this.DescriptionLabel.Text = "Now Serving";
            // 
            // QueueNumber
            // 
            this.QueueNumber.AutoSize = true;
            this.QueueNumber.Font = new System.Drawing.Font("Bookman Old Style", 45F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QueueNumber.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.QueueNumber.Location = new System.Drawing.Point(254, 235);
            this.QueueNumber.Name = "QueueNumber";
            this.QueueNumber.Size = new System.Drawing.Size(332, 70);
            this.QueueNumber.TabIndex = 0;
            this.QueueNumber.Text = "P - 10000";
            this.QueueNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.QueueNumber.Visible = false;
            this.QueueNumber.Click += new System.EventHandler(this.QueueNumber_Click);
            // 
            // MessageLabel
            // 
            this.MessageLabel.AutoSize = true;
            this.MessageLabel.Font = new System.Drawing.Font("Book Antiqua", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MessageLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.MessageLabel.Location = new System.Drawing.Point(210, 320);
            this.MessageLabel.Name = "MessageLabel";
            this.MessageLabel.Size = new System.Drawing.Size(422, 28);
            this.MessageLabel.TabIndex = 0;
            this.MessageLabel.Text = "Please claim your order at the counter.\r\n";
            // 
            // RefreshTimer
            // 
            this.RefreshTimer.Tick += new System.EventHandler(this.RefreshTimer_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(1, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(204, 145);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // DisplayCurrentServing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(66)))), ((int)(((byte)(26)))));
            this.ClientSize = new System.Drawing.Size(816, 489);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.MessageLabel);
            this.Controls.Add(this.QueueNumber);
            this.Controls.Add(this.DescriptionLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(500, 90);
            this.Name = "DisplayCurrentServing";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "DiplayCurrentServing";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label DescriptionLabel;
        private System.Windows.Forms.Label QueueNumber;
        private System.Windows.Forms.Label MessageLabel;
        private System.Windows.Forms.Timer RefreshTimer;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
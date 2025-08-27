namespace _02_Task_Performance_1
{
    partial class QueuingForm
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
            this.positionLabel = new System.Windows.Forms.Label();
            this.lblQueue = new System.Windows.Forms.Label();
            this.btnCashier = new System.Windows.Forms.Button();
            this.reminderLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // positionLabel
            // 
            this.positionLabel.AutoSize = true;
            this.positionLabel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.positionLabel.Font = new System.Drawing.Font("Bookman Old Style", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.positionLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.positionLabel.Location = new System.Drawing.Point(252, 37);
            this.positionLabel.Name = "positionLabel";
            this.positionLabel.Size = new System.Drawing.Size(343, 45);
            this.positionLabel.TabIndex = 0;
            this.positionLabel.Text = "Position in Queue";
            // 
            // lblQueue
            // 
            this.lblQueue.AutoSize = true;
            this.lblQueue.Font = new System.Drawing.Font("Bookman Old Style", 60F, System.Drawing.FontStyle.Bold);
            this.lblQueue.Location = new System.Drawing.Point(242, 115);
            this.lblQueue.Name = "lblQueue";
            this.lblQueue.Size = new System.Drawing.Size(441, 93);
            this.lblQueue.TabIndex = 0;
            this.lblQueue.Text = "P - 10000";
            this.lblQueue.Visible = false;
            // 
            // btnCashier
            // 
            this.btnCashier.BackColor = System.Drawing.Color.Black;
            this.btnCashier.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCashier.Font = new System.Drawing.Font("Bahnschrift", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCashier.ForeColor = System.Drawing.Color.White;
            this.btnCashier.Location = new System.Drawing.Point(26, 40);
            this.btnCashier.Name = "btnCashier";
            this.btnCashier.Size = new System.Drawing.Size(190, 119);
            this.btnCashier.TabIndex = 1;
            this.btnCashier.Text = "Cashier";
            this.btnCashier.UseVisualStyleBackColor = false;
            this.btnCashier.Click += new System.EventHandler(this.btnCashier_Click);
            // 
            // reminderLabel
            // 
            this.reminderLabel.AutoSize = true;
            this.reminderLabel.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reminderLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.reminderLabel.Location = new System.Drawing.Point(22, 174);
            this.reminderLabel.Name = "reminderLabel";
            this.reminderLabel.Size = new System.Drawing.Size(214, 20);
            this.reminderLabel.TabIndex = 0;
            this.reminderLabel.Text = "*Click to get your number";
            // 
            // QueuingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(686, 308);
            this.Controls.Add(this.btnCashier);
            this.Controls.Add(this.reminderLabel);
            this.Controls.Add(this.lblQueue);
            this.Controls.Add(this.positionLabel);
            this.Location = new System.Drawing.Point(950, 560);
            this.Name = "QueuingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "QueuingForm";
            this.Load += new System.EventHandler(this.QueuingForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label positionLabel;
        private System.Windows.Forms.Label lblQueue;
        private System.Windows.Forms.Button btnCashier;
        private System.Windows.Forms.Label reminderLabel;
    }
}


namespace AAPIS
{
    partial class Reports
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
            this.UseHistoryByEventButton = new System.Windows.Forms.Button();
            this.UseHistoryByItemButton = new System.Windows.Forms.Button();
            this.RemovalHistory = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UseHistoryByEventButton
            // 
            this.UseHistoryByEventButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.UseHistoryByEventButton.Location = new System.Drawing.Point(301, 154);
            this.UseHistoryByEventButton.Name = "UseHistoryByEventButton";
            this.UseHistoryByEventButton.Size = new System.Drawing.Size(200, 30);
            this.UseHistoryByEventButton.TabIndex = 0;
            this.UseHistoryByEventButton.Text = "Use History by Event";
            this.UseHistoryByEventButton.UseVisualStyleBackColor = true;
            this.UseHistoryByEventButton.Click += new System.EventHandler(this.UseHistoryByEventButton_Click);
            // 
            // UseHistoryByItemButton
            // 
            this.UseHistoryByItemButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.UseHistoryByItemButton.Location = new System.Drawing.Point(301, 199);
            this.UseHistoryByItemButton.Name = "UseHistoryByItemButton";
            this.UseHistoryByItemButton.Size = new System.Drawing.Size(200, 30);
            this.UseHistoryByItemButton.TabIndex = 1;
            this.UseHistoryByItemButton.Text = "Use History by Item";
            this.UseHistoryByItemButton.UseVisualStyleBackColor = true;
            this.UseHistoryByItemButton.Click += new System.EventHandler(this.UseHistoryByItemButton_Click);
            // 
            // RemovalHistory
            // 
            this.RemovalHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.RemovalHistory.Location = new System.Drawing.Point(301, 244);
            this.RemovalHistory.Name = "RemovalHistory";
            this.RemovalHistory.Size = new System.Drawing.Size(200, 30);
            this.RemovalHistory.TabIndex = 2;
            this.RemovalHistory.Text = "Removal History";
            this.RemovalHistory.UseVisualStyleBackColor = true;
            this.RemovalHistory.Click += new System.EventHandler(this.RemovalHistory_Click);
            // 
            // BackButton
            // 
            this.BackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.BackButton.Location = new System.Drawing.Point(12, 408);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(144, 30);
            this.BackButton.TabIndex = 3;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.RemovalHistory);
            this.Controls.Add(this.UseHistoryByItemButton);
            this.Controls.Add(this.UseHistoryByEventButton);
            this.Name = "Reports";
            this.Text = "Reports";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button UseHistoryByEventButton;
        private System.Windows.Forms.Button UseHistoryByItemButton;
        private System.Windows.Forms.Button RemovalHistory;
        private System.Windows.Forms.Button BackButton;
    }
}
namespace AAPIS
{
    partial class EditItem
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
            this.EditQuantityButton = new System.Windows.Forms.Button();
            this.EditOtherInfoButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // EditQuantityButton
            // 
            this.EditQuantityButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.EditQuantityButton.Location = new System.Drawing.Point(332, 157);
            this.EditQuantityButton.Name = "EditQuantityButton";
            this.EditQuantityButton.Size = new System.Drawing.Size(144, 30);
            this.EditQuantityButton.TabIndex = 0;
            this.EditQuantityButton.Text = "Edit Quantity";
            this.EditQuantityButton.UseVisualStyleBackColor = true;
            this.EditQuantityButton.Click += new System.EventHandler(this.EditQuantityButton_Click);
            // 
            // EditOtherInfoButton
            // 
            this.EditOtherInfoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.EditOtherInfoButton.Location = new System.Drawing.Point(332, 244);
            this.EditOtherInfoButton.Name = "EditOtherInfoButton";
            this.EditOtherInfoButton.Size = new System.Drawing.Size(144, 30);
            this.EditOtherInfoButton.TabIndex = 1;
            this.EditOtherInfoButton.Text = "Edit Other Info";
            this.EditOtherInfoButton.UseVisualStyleBackColor = true;
            this.EditOtherInfoButton.Click += new System.EventHandler(this.EditOtherInfoButton_Click);
            // 
            // BackButton
            // 
            this.BackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.BackButton.Location = new System.Drawing.Point(12, 408);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(144, 30);
            this.BackButton.TabIndex = 2;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // EditItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.EditOtherInfoButton);
            this.Controls.Add(this.EditQuantityButton);
            this.Name = "EditItem";
            this.Text = "Edit Item";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button EditQuantityButton;
        private System.Windows.Forms.Button EditOtherInfoButton;
        private System.Windows.Forms.Button BackButton;
    }
}
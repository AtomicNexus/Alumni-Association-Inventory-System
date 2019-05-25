namespace AAPIS
{
    partial class EditItemQuantity
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
            this.IncreaseQuantityButton = new System.Windows.Forms.Button();
            this.DecreaseQuantityButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // IncreaseQuantityButton
            // 
            this.IncreaseQuantityButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.IncreaseQuantityButton.Location = new System.Drawing.Point(329, 152);
            this.IncreaseQuantityButton.Name = "IncreaseQuantityButton";
            this.IncreaseQuantityButton.Size = new System.Drawing.Size(144, 30);
            this.IncreaseQuantityButton.TabIndex = 0;
            this.IncreaseQuantityButton.Text = "Increase Quantity";
            this.IncreaseQuantityButton.UseVisualStyleBackColor = true;
            this.IncreaseQuantityButton.Click += new System.EventHandler(this.IncreaseQuantityButton_Click);
            // 
            // DecreaseQuantityButton
            // 
            this.DecreaseQuantityButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.DecreaseQuantityButton.Location = new System.Drawing.Point(329, 242);
            this.DecreaseQuantityButton.Name = "DecreaseQuantityButton";
            this.DecreaseQuantityButton.Size = new System.Drawing.Size(144, 30);
            this.DecreaseQuantityButton.TabIndex = 1;
            this.DecreaseQuantityButton.Text = "Decrease Quantity";
            this.DecreaseQuantityButton.UseVisualStyleBackColor = true;
            this.DecreaseQuantityButton.Click += new System.EventHandler(this.DecreaseQuantityButton_Click);
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
            // EditItemQuantity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.DecreaseQuantityButton);
            this.Controls.Add(this.IncreaseQuantityButton);
            this.Name = "EditItemQuantity";
            this.Text = "Edit Item Quantity";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button IncreaseQuantityButton;
        private System.Windows.Forms.Button DecreaseQuantityButton;
        private System.Windows.Forms.Button BackButton;
    }
}
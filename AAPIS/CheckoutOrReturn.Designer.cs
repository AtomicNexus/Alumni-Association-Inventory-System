namespace AAPIS
{
    partial class CheckoutOrReturn
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
            this.CheckoutItemButton = new System.Windows.Forms.Button();
            this.ViewItemCheckoutButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CheckoutItemButton
            // 
            this.CheckoutItemButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.CheckoutItemButton.Location = new System.Drawing.Point(329, 155);
            this.CheckoutItemButton.Name = "CheckoutItemButton";
            this.CheckoutItemButton.Size = new System.Drawing.Size(144, 30);
            this.CheckoutItemButton.TabIndex = 0;
            this.CheckoutItemButton.Text = "Checkout";
            this.CheckoutItemButton.UseVisualStyleBackColor = true;
            this.CheckoutItemButton.Click += new System.EventHandler(this.CheckoutItemButton_Click);
            // 
            // ViewItemCheckoutButton
            // 
            this.ViewItemCheckoutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ViewItemCheckoutButton.Location = new System.Drawing.Point(329, 245);
            this.ViewItemCheckoutButton.Name = "ViewItemCheckoutButton";
            this.ViewItemCheckoutButton.Size = new System.Drawing.Size(144, 30);
            this.ViewItemCheckoutButton.TabIndex = 2;
            this.ViewItemCheckoutButton.Text = "View Checkouts";
            this.ViewItemCheckoutButton.UseVisualStyleBackColor = true;
            this.ViewItemCheckoutButton.Click += new System.EventHandler(this.ViewItemCheckoutButton_Click);
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
            // CheckoutOrReturn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.ViewItemCheckoutButton);
            this.Controls.Add(this.CheckoutItemButton);
            this.Name = "CheckoutOrReturn";
            this.Text = "Checkout Or Return";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CheckoutItemButton;
        private System.Windows.Forms.Button ViewItemCheckoutButton;
        private System.Windows.Forms.Button BackButton;
    }
}
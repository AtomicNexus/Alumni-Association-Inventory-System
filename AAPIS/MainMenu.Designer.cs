namespace AAPIS
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.AboutButton = new System.Windows.Forms.Button();
            this.InventoryButton = new System.Windows.Forms.Button();
            this.EventsButton = new System.Windows.Forms.Button();
            this.ReportsButton = new System.Windows.Forms.Button();
            this.CheckoutReturnButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.MainMenuLabel = new System.Windows.Forms.Label();
            this.AALogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.AALogo)).BeginInit();
            this.SuspendLayout();
            // 
            // AboutButton
            // 
            this.AboutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.AboutButton.Location = new System.Drawing.Point(12, 162);
            this.AboutButton.Name = "AboutButton";
            this.AboutButton.Size = new System.Drawing.Size(144, 30);
            this.AboutButton.TabIndex = 0;
            this.AboutButton.Text = "About";
            this.AboutButton.UseVisualStyleBackColor = true;
            this.AboutButton.Click += new System.EventHandler(this.AboutButton_Click);
            // 
            // InventoryButton
            // 
            this.InventoryButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.InventoryButton.Location = new System.Drawing.Point(232, 162);
            this.InventoryButton.Name = "InventoryButton";
            this.InventoryButton.Size = new System.Drawing.Size(144, 30);
            this.InventoryButton.TabIndex = 1;
            this.InventoryButton.Text = "Inventory";
            this.InventoryButton.UseVisualStyleBackColor = true;
            this.InventoryButton.Click += new System.EventHandler(this.InventoryButton_Click);
            // 
            // EventsButton
            // 
            this.EventsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.EventsButton.Location = new System.Drawing.Point(445, 162);
            this.EventsButton.Name = "EventsButton";
            this.EventsButton.Size = new System.Drawing.Size(144, 30);
            this.EventsButton.TabIndex = 2;
            this.EventsButton.Text = "Events";
            this.EventsButton.UseVisualStyleBackColor = true;
            this.EventsButton.Click += new System.EventHandler(this.EventsButton_Click);
            // 
            // ReportsButton
            // 
            this.ReportsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ReportsButton.Location = new System.Drawing.Point(232, 249);
            this.ReportsButton.Name = "ReportsButton";
            this.ReportsButton.Size = new System.Drawing.Size(144, 30);
            this.ReportsButton.TabIndex = 3;
            this.ReportsButton.Text = "Reports";
            this.ReportsButton.UseVisualStyleBackColor = true;
            this.ReportsButton.Click += new System.EventHandler(this.ReportsButton_Click);
            // 
            // CheckoutReturnButton
            // 
            this.CheckoutReturnButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.CheckoutReturnButton.Location = new System.Drawing.Point(445, 249);
            this.CheckoutReturnButton.Name = "CheckoutReturnButton";
            this.CheckoutReturnButton.Size = new System.Drawing.Size(144, 30);
            this.CheckoutReturnButton.TabIndex = 4;
            this.CheckoutReturnButton.Text = "Checkout/Return";
            this.CheckoutReturnButton.UseVisualStyleBackColor = true;
            this.CheckoutReturnButton.Click += new System.EventHandler(this.CheckoutReturnButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ExitButton.Location = new System.Drawing.Point(644, 408);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(144, 30);
            this.ExitButton.TabIndex = 5;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // MainMenuLabel
            // 
            this.MainMenuLabel.AutoSize = true;
            this.MainMenuLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuLabel.Location = new System.Drawing.Point(181, 12);
            this.MainMenuLabel.Name = "MainMenuLabel";
            this.MainMenuLabel.Size = new System.Drawing.Size(607, 31);
            this.MainMenuLabel.TabIndex = 6;
            this.MainMenuLabel.Text = "Alumni Association Pavilion Inventory System";
            // 
            // AALogo
            // 
            this.AALogo.Image = ((System.Drawing.Image)(resources.GetObject("AALogo.Image")));
            this.AALogo.Location = new System.Drawing.Point(12, 12);
            this.AALogo.Name = "AALogo";
            this.AALogo.Size = new System.Drawing.Size(144, 144);
            this.AALogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.AALogo.TabIndex = 7;
            this.AALogo.TabStop = false;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AALogo);
            this.Controls.Add(this.MainMenuLabel);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.CheckoutReturnButton);
            this.Controls.Add(this.ReportsButton);
            this.Controls.Add(this.EventsButton);
            this.Controls.Add(this.InventoryButton);
            this.Controls.Add(this.AboutButton);
            this.Name = "MainMenu";
            this.Text = "AAPIS";
            ((System.ComponentModel.ISupportInitialize)(this.AALogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AboutButton;
        private System.Windows.Forms.Button InventoryButton;
        private System.Windows.Forms.Button EventsButton;
        private System.Windows.Forms.Button ReportsButton;
        private System.Windows.Forms.Button CheckoutReturnButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Label MainMenuLabel;
        private System.Windows.Forms.PictureBox AALogo;
    }
}


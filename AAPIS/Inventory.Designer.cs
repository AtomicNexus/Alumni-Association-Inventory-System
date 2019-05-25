namespace AAPIS
{
    partial class Inventory
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
            this.AddItemButton = new System.Windows.Forms.Button();
            this.SearchItemsButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddItemButton
            // 
            this.AddItemButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.AddItemButton.Location = new System.Drawing.Point(329, 143);
            this.AddItemButton.Name = "AddItemButton";
            this.AddItemButton.Size = new System.Drawing.Size(144, 30);
            this.AddItemButton.TabIndex = 0;
            this.AddItemButton.Text = "Add Item";
            this.AddItemButton.UseVisualStyleBackColor = true;
            this.AddItemButton.Click += new System.EventHandler(this.AddItemButton_Click);
            // 
            // SearchItemsButton
            // 
            this.SearchItemsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.SearchItemsButton.Location = new System.Drawing.Point(329, 253);
            this.SearchItemsButton.Name = "SearchItemsButton";
            this.SearchItemsButton.Size = new System.Drawing.Size(144, 30);
            this.SearchItemsButton.TabIndex = 3;
            this.SearchItemsButton.Text = "Search Items";
            this.SearchItemsButton.UseVisualStyleBackColor = true;
            this.SearchItemsButton.Click += new System.EventHandler(this.SearchItemsButton_Click);
            // 
            // BackButton
            // 
            this.BackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.BackButton.Location = new System.Drawing.Point(12, 408);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(144, 30);
            this.BackButton.TabIndex = 4;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // Inventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.SearchItemsButton);
            this.Controls.Add(this.AddItemButton);
            this.Name = "Inventory";
            this.Text = "Inventory";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AddItemButton;
        private System.Windows.Forms.Button SearchItemsButton;
        private System.Windows.Forms.Button BackButton;
    }
}
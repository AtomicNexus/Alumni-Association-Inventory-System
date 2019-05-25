namespace AAPIS
{
    partial class CheckoutItemQuantity
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
            this.EventTableLabel = new System.Windows.Forms.Label();
            this.CheckoutQuantityLabel = new System.Windows.Forms.Label();
            this.CheckoutQuantityUpDown = new System.Windows.Forms.NumericUpDown();
            this.EventsDataGridView = new System.Windows.Forms.DataGridView();
            this.CheckoutItemButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.UseHistoryIDLabel = new System.Windows.Forms.Label();
            this.GenerateRandomIntButton = new System.Windows.Forms.Button();
            this.UseHistoryIDTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.CheckoutQuantityUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EventsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // EventTableLabel
            // 
            this.EventTableLabel.AutoSize = true;
            this.EventTableLabel.Location = new System.Drawing.Point(164, 48);
            this.EventTableLabel.Name = "EventTableLabel";
            this.EventTableLabel.Size = new System.Drawing.Size(95, 13);
            this.EventTableLabel.TabIndex = 0;
            this.EventTableLabel.Text = "Event for Item Use";
            // 
            // CheckoutQuantityLabel
            // 
            this.CheckoutQuantityLabel.AutoSize = true;
            this.CheckoutQuantityLabel.Location = new System.Drawing.Point(129, 272);
            this.CheckoutQuantityLabel.Name = "CheckoutQuantityLabel";
            this.CheckoutQuantityLabel.Size = new System.Drawing.Size(130, 13);
            this.CheckoutQuantityLabel.TabIndex = 1;
            this.CheckoutQuantityLabel.Text = "Item Quantity to Checkout";
            // 
            // CheckoutQuantityUpDown
            // 
            this.CheckoutQuantityUpDown.Location = new System.Drawing.Point(265, 270);
            this.CheckoutQuantityUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.CheckoutQuantityUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.CheckoutQuantityUpDown.Name = "CheckoutQuantityUpDown";
            this.CheckoutQuantityUpDown.Size = new System.Drawing.Size(144, 20);
            this.CheckoutQuantityUpDown.TabIndex = 2;
            this.CheckoutQuantityUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // EventsDataGridView
            // 
            this.EventsDataGridView.AllowUserToAddRows = false;
            this.EventsDataGridView.AllowUserToDeleteRows = false;
            this.EventsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.EventsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EventsDataGridView.Location = new System.Drawing.Point(265, 48);
            this.EventsDataGridView.MultiSelect = false;
            this.EventsDataGridView.Name = "EventsDataGridView";
            this.EventsDataGridView.ReadOnly = true;
            this.EventsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.EventsDataGridView.Size = new System.Drawing.Size(400, 150);
            this.EventsDataGridView.TabIndex = 3;
            // 
            // CheckoutItemButton
            // 
            this.CheckoutItemButton.Enabled = false;
            this.CheckoutItemButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.CheckoutItemButton.Location = new System.Drawing.Point(644, 408);
            this.CheckoutItemButton.Name = "CheckoutItemButton";
            this.CheckoutItemButton.Size = new System.Drawing.Size(144, 30);
            this.CheckoutItemButton.TabIndex = 4;
            this.CheckoutItemButton.Text = "Checkout";
            this.CheckoutItemButton.UseVisualStyleBackColor = true;
            this.CheckoutItemButton.Click += new System.EventHandler(this.CheckoutItemButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.CancelButton.Location = new System.Drawing.Point(12, 408);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(144, 30);
            this.CancelButton.TabIndex = 5;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // UseHistoryIDLabel
            // 
            this.UseHistoryIDLabel.AutoSize = true;
            this.UseHistoryIDLabel.Location = new System.Drawing.Point(184, 328);
            this.UseHistoryIDLabel.Name = "UseHistoryIDLabel";
            this.UseHistoryIDLabel.Size = new System.Drawing.Size(75, 13);
            this.UseHistoryIDLabel.TabIndex = 6;
            this.UseHistoryIDLabel.Text = "Use History ID";
            // 
            // GenerateRandomIntButton
            // 
            this.GenerateRandomIntButton.Location = new System.Drawing.Point(415, 323);
            this.GenerateRandomIntButton.Name = "GenerateRandomIntButton";
            this.GenerateRandomIntButton.Size = new System.Drawing.Size(75, 23);
            this.GenerateRandomIntButton.TabIndex = 7;
            this.GenerateRandomIntButton.Text = "Generate";
            this.GenerateRandomIntButton.UseVisualStyleBackColor = true;
            this.GenerateRandomIntButton.Click += new System.EventHandler(this.GenerateRandomIntButton_Click);
            // 
            // UseHistoryIDTextBox
            // 
            this.UseHistoryIDTextBox.Location = new System.Drawing.Point(265, 325);
            this.UseHistoryIDTextBox.Name = "UseHistoryIDTextBox";
            this.UseHistoryIDTextBox.ReadOnly = true;
            this.UseHistoryIDTextBox.Size = new System.Drawing.Size(144, 20);
            this.UseHistoryIDTextBox.TabIndex = 8;
            this.UseHistoryIDTextBox.TextChanged += new System.EventHandler(this.UseHistoryIDTextBox_TextChanged);
            // 
            // CheckoutItemQuantity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.UseHistoryIDTextBox);
            this.Controls.Add(this.GenerateRandomIntButton);
            this.Controls.Add(this.UseHistoryIDLabel);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.CheckoutItemButton);
            this.Controls.Add(this.EventsDataGridView);
            this.Controls.Add(this.CheckoutQuantityUpDown);
            this.Controls.Add(this.CheckoutQuantityLabel);
            this.Controls.Add(this.EventTableLabel);
            this.Name = "CheckoutItemQuantity";
            this.Text = "Checkout Item Quantity";
            this.Load += new System.EventHandler(this.CheckoutItemQuantity_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CheckoutQuantityUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EventsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label EventTableLabel;
        private System.Windows.Forms.Label CheckoutQuantityLabel;
        private System.Windows.Forms.NumericUpDown CheckoutQuantityUpDown;
        private System.Windows.Forms.DataGridView EventsDataGridView;
        private System.Windows.Forms.Button CheckoutItemButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Label UseHistoryIDLabel;
        private System.Windows.Forms.Button GenerateRandomIntButton;
        private System.Windows.Forms.TextBox UseHistoryIDTextBox;
    }
}
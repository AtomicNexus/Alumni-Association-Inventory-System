namespace AAPIS
{
    partial class ViewCheckouts
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
            this.SearchByItemLabel = new System.Windows.Forms.Label();
            this.SearchByItemTextBox = new System.Windows.Forms.TextBox();
            this.CheckedOutItemsDataGridView = new System.Windows.Forms.DataGridView();
            this.BackButton = new System.Windows.Forms.Button();
            this.SearchByEventLabel = new System.Windows.Forms.Label();
            this.SearchByEventTextBox = new System.Windows.Forms.TextBox();
            this.ReturnItemButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.CheckedOutItemsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // SearchByItemLabel
            // 
            this.SearchByItemLabel.AutoSize = true;
            this.SearchByItemLabel.Location = new System.Drawing.Point(12, 30);
            this.SearchByItemLabel.Name = "SearchByItemLabel";
            this.SearchByItemLabel.Size = new System.Drawing.Size(109, 13);
            this.SearchByItemLabel.TabIndex = 8;
            this.SearchByItemLabel.Text = "Search by Item Name";
            // 
            // SearchByItemTextBox
            // 
            this.SearchByItemTextBox.Location = new System.Drawing.Point(127, 27);
            this.SearchByItemTextBox.Name = "SearchByItemTextBox";
            this.SearchByItemTextBox.Size = new System.Drawing.Size(169, 20);
            this.SearchByItemTextBox.TabIndex = 7;
            this.SearchByItemTextBox.TextChanged += new System.EventHandler(this.SearchByItemTextBox_TextChanged);
            // 
            // CheckedOutItemsDataGridView
            // 
            this.CheckedOutItemsDataGridView.AllowUserToAddRows = false;
            this.CheckedOutItemsDataGridView.AllowUserToDeleteRows = false;
            this.CheckedOutItemsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.CheckedOutItemsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CheckedOutItemsDataGridView.Cursor = System.Windows.Forms.Cursors.Default;
            this.CheckedOutItemsDataGridView.Location = new System.Drawing.Point(12, 59);
            this.CheckedOutItemsDataGridView.MultiSelect = false;
            this.CheckedOutItemsDataGridView.Name = "CheckedOutItemsDataGridView";
            this.CheckedOutItemsDataGridView.ReadOnly = true;
            this.CheckedOutItemsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CheckedOutItemsDataGridView.Size = new System.Drawing.Size(776, 343);
            this.CheckedOutItemsDataGridView.TabIndex = 1;
            // 
            // BackButton
            // 
            this.BackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.BackButton.Location = new System.Drawing.Point(12, 408);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(144, 30);
            this.BackButton.TabIndex = 5;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // SearchByEventLabel
            // 
            this.SearchByEventLabel.AutoSize = true;
            this.SearchByEventLabel.Location = new System.Drawing.Point(496, 30);
            this.SearchByEventLabel.Name = "SearchByEventLabel";
            this.SearchByEventLabel.Size = new System.Drawing.Size(117, 13);
            this.SearchByEventLabel.TabIndex = 10;
            this.SearchByEventLabel.Text = "Search by Event Name";
            // 
            // SearchByEventTextBox
            // 
            this.SearchByEventTextBox.Location = new System.Drawing.Point(619, 27);
            this.SearchByEventTextBox.Name = "SearchByEventTextBox";
            this.SearchByEventTextBox.Size = new System.Drawing.Size(169, 20);
            this.SearchByEventTextBox.TabIndex = 9;
            this.SearchByEventTextBox.TextChanged += new System.EventHandler(this.SearchByEventTextBox_TextChanged);
            // 
            // ReturnItemButton
            // 
            this.ReturnItemButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ReturnItemButton.Location = new System.Drawing.Point(644, 408);
            this.ReturnItemButton.Name = "ReturnItemButton";
            this.ReturnItemButton.Size = new System.Drawing.Size(144, 30);
            this.ReturnItemButton.TabIndex = 11;
            this.ReturnItemButton.Text = "Return";
            this.ReturnItemButton.UseVisualStyleBackColor = true;
            this.ReturnItemButton.Click += new System.EventHandler(this.ReturnItemButton_Click);
            // 
            // ViewCheckouts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ReturnItemButton);
            this.Controls.Add(this.SearchByEventLabel);
            this.Controls.Add(this.SearchByEventTextBox);
            this.Controls.Add(this.SearchByItemLabel);
            this.Controls.Add(this.SearchByItemTextBox);
            this.Controls.Add(this.CheckedOutItemsDataGridView);
            this.Controls.Add(this.BackButton);
            this.Name = "ViewCheckouts";
            this.Text = "View Checkouts";
            this.Load += new System.EventHandler(this.ViewCheckouts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CheckedOutItemsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SearchByItemLabel;
        private System.Windows.Forms.TextBox SearchByItemTextBox;
        private System.Windows.Forms.DataGridView CheckedOutItemsDataGridView;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Label SearchByEventLabel;
        private System.Windows.Forms.TextBox SearchByEventTextBox;
        private System.Windows.Forms.Button ReturnItemButton;
    }
}
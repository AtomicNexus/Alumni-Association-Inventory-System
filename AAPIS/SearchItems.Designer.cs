namespace AAPIS
{
    partial class SearchItems
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
            this.BackButton = new System.Windows.Forms.Button();
            this.SearchItemsDataGridView = new System.Windows.Forms.DataGridView();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.SearchItemLabel = new System.Windows.Forms.Label();
            this.ItemPictureBox = new System.Windows.Forms.PictureBox();
            this.EditItemButton = new System.Windows.Forms.Button();
            this.DeleteItemButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.SearchItemsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // BackButton
            // 
            this.BackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.BackButton.Location = new System.Drawing.Point(12, 419);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(144, 30);
            this.BackButton.TabIndex = 0;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // SearchItemsDataGridView
            // 
            this.SearchItemsDataGridView.AllowUserToAddRows = false;
            this.SearchItemsDataGridView.AllowUserToDeleteRows = false;
            this.SearchItemsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.SearchItemsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SearchItemsDataGridView.Location = new System.Drawing.Point(12, 79);
            this.SearchItemsDataGridView.MultiSelect = false;
            this.SearchItemsDataGridView.Name = "SearchItemsDataGridView";
            this.SearchItemsDataGridView.ReadOnly = true;
            this.SearchItemsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.SearchItemsDataGridView.Size = new System.Drawing.Size(906, 334);
            this.SearchItemsDataGridView.TabIndex = 1;
            this.SearchItemsDataGridView.SelectionChanged += new System.EventHandler(this.SearchItemsDataGridView_SelectionChanged);
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Location = new System.Drawing.Point(127, 41);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(169, 20);
            this.SearchTextBox.TabIndex = 2;
            this.SearchTextBox.TextChanged += new System.EventHandler(this.SearchTextBox_TextChanged);
            // 
            // SearchItemLabel
            // 
            this.SearchItemLabel.AutoSize = true;
            this.SearchItemLabel.Location = new System.Drawing.Point(12, 44);
            this.SearchItemLabel.Name = "SearchItemLabel";
            this.SearchItemLabel.Size = new System.Drawing.Size(109, 13);
            this.SearchItemLabel.TabIndex = 4;
            this.SearchItemLabel.Text = "Search by Item Name";
            // 
            // ItemPictureBox
            // 
            this.ItemPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ItemPictureBox.Location = new System.Drawing.Point(924, 79);
            this.ItemPictureBox.Name = "ItemPictureBox";
            this.ItemPictureBox.Size = new System.Drawing.Size(328, 334);
            this.ItemPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ItemPictureBox.TabIndex = 6;
            this.ItemPictureBox.TabStop = false;
            // 
            // EditItemButton
            // 
            this.EditItemButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.EditItemButton.Location = new System.Drawing.Point(624, 419);
            this.EditItemButton.Name = "EditItemButton";
            this.EditItemButton.Size = new System.Drawing.Size(144, 30);
            this.EditItemButton.TabIndex = 7;
            this.EditItemButton.Text = "Edit";
            this.EditItemButton.UseVisualStyleBackColor = true;
            this.EditItemButton.Click += new System.EventHandler(this.EditItemButton_Click);
            // 
            // DeleteItemButton
            // 
            this.DeleteItemButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.DeleteItemButton.Location = new System.Drawing.Point(774, 419);
            this.DeleteItemButton.Name = "DeleteItemButton";
            this.DeleteItemButton.Size = new System.Drawing.Size(144, 30);
            this.DeleteItemButton.TabIndex = 8;
            this.DeleteItemButton.Text = "Delete";
            this.DeleteItemButton.UseVisualStyleBackColor = true;
            this.DeleteItemButton.Click += new System.EventHandler(this.DeleteItemButton_Click);
            // 
            // SearchItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 461);
            this.Controls.Add(this.DeleteItemButton);
            this.Controls.Add(this.EditItemButton);
            this.Controls.Add(this.ItemPictureBox);
            this.Controls.Add(this.SearchItemLabel);
            this.Controls.Add(this.SearchTextBox);
            this.Controls.Add(this.SearchItemsDataGridView);
            this.Controls.Add(this.BackButton);
            this.Name = "SearchItems";
            this.Text = "Search Items";
            this.Load += new System.EventHandler(this.SearchItems_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SearchItemsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.DataGridView SearchItemsDataGridView;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.Label SearchItemLabel;
        private System.Windows.Forms.PictureBox ItemPictureBox;
        private System.Windows.Forms.Button EditItemButton;
        private System.Windows.Forms.Button DeleteItemButton;
    }
}
namespace AAPIS
{
    partial class UseHistoryByItemSelect
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
            this.ItemPictureBox = new System.Windows.Forms.PictureBox();
            this.SearchItemLabel = new System.Windows.Forms.Label();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.SearchItemsDataGridView = new System.Windows.Forms.DataGridView();
            this.BackButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ItemPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SearchItemsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ItemPictureBox
            // 
            this.ItemPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ItemPictureBox.Location = new System.Drawing.Point(924, 79);
            this.ItemPictureBox.Name = "ItemPictureBox";
            this.ItemPictureBox.Size = new System.Drawing.Size(328, 334);
            this.ItemPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ItemPictureBox.TabIndex = 18;
            this.ItemPictureBox.TabStop = false;
            // 
            // SearchItemLabel
            // 
            this.SearchItemLabel.AutoSize = true;
            this.SearchItemLabel.Location = new System.Drawing.Point(12, 53);
            this.SearchItemLabel.Name = "SearchItemLabel";
            this.SearchItemLabel.Size = new System.Drawing.Size(109, 13);
            this.SearchItemLabel.TabIndex = 17;
            this.SearchItemLabel.Text = "Search by Item Name";
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Location = new System.Drawing.Point(127, 50);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(169, 20);
            this.SearchTextBox.TabIndex = 16;
            this.SearchTextBox.TextChanged += new System.EventHandler(this.SearchTextBox_TextChanged);
            // 
            // SearchItemsDataGridView
            // 
            this.SearchItemsDataGridView.AllowUserToAddRows = false;
            this.SearchItemsDataGridView.AllowUserToDeleteRows = false;
            this.SearchItemsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.SearchItemsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SearchItemsDataGridView.Location = new System.Drawing.Point(12, 79);
            this.SearchItemsDataGridView.Name = "SearchItemsDataGridView";
            this.SearchItemsDataGridView.ReadOnly = true;
            this.SearchItemsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.SearchItemsDataGridView.Size = new System.Drawing.Size(906, 334);
            this.SearchItemsDataGridView.TabIndex = 15;
            this.SearchItemsDataGridView.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.SearchItemsDataGridView_CellMouseDoubleClick);
            this.SearchItemsDataGridView.SelectionChanged += new System.EventHandler(this.SearchItemsDataGridView_SelectionChanged);
            // 
            // BackButton
            // 
            this.BackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.BackButton.Location = new System.Drawing.Point(12, 419);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(144, 30);
            this.BackButton.TabIndex = 14;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // UseHistoryByItemSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 461);
            this.Controls.Add(this.ItemPictureBox);
            this.Controls.Add(this.SearchItemLabel);
            this.Controls.Add(this.SearchTextBox);
            this.Controls.Add(this.SearchItemsDataGridView);
            this.Controls.Add(this.BackButton);
            this.Name = "UseHistoryByItemSelect";
            this.Text = "Use History By Item";
            this.Load += new System.EventHandler(this.UseHistoryByItemSelect_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ItemPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SearchItemsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ItemPictureBox;
        private System.Windows.Forms.Label SearchItemLabel;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.DataGridView SearchItemsDataGridView;
        private System.Windows.Forms.Button BackButton;
    }
}
namespace AAPIS
{
    partial class RemovalHistory
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
            this.RemovalHistoryDataGridView = new System.Windows.Forms.DataGridView();
            this.SearchLabel = new System.Windows.Forms.Label();
            this.SearchByItemNameTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.RemovalHistoryDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // BackButton
            // 
            this.BackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.BackButton.Location = new System.Drawing.Point(12, 408);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(144, 30);
            this.BackButton.TabIndex = 0;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // RemovalHistoryDataGridView
            // 
            this.RemovalHistoryDataGridView.AllowUserToAddRows = false;
            this.RemovalHistoryDataGridView.AllowUserToDeleteRows = false;
            this.RemovalHistoryDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.RemovalHistoryDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RemovalHistoryDataGridView.Location = new System.Drawing.Point(12, 73);
            this.RemovalHistoryDataGridView.MultiSelect = false;
            this.RemovalHistoryDataGridView.Name = "RemovalHistoryDataGridView";
            this.RemovalHistoryDataGridView.ReadOnly = true;
            this.RemovalHistoryDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.RemovalHistoryDataGridView.Size = new System.Drawing.Size(776, 329);
            this.RemovalHistoryDataGridView.TabIndex = 1;
            // 
            // SearchLabel
            // 
            this.SearchLabel.AutoSize = true;
            this.SearchLabel.Location = new System.Drawing.Point(12, 50);
            this.SearchLabel.Name = "SearchLabel";
            this.SearchLabel.Size = new System.Drawing.Size(109, 13);
            this.SearchLabel.TabIndex = 2;
            this.SearchLabel.Text = "Search by Item Name";
            // 
            // SearchByItemNameTextBox
            // 
            this.SearchByItemNameTextBox.Location = new System.Drawing.Point(127, 47);
            this.SearchByItemNameTextBox.Name = "SearchByItemNameTextBox";
            this.SearchByItemNameTextBox.Size = new System.Drawing.Size(144, 20);
            this.SearchByItemNameTextBox.TabIndex = 3;
            this.SearchByItemNameTextBox.TextChanged += new System.EventHandler(SearchByItemNameTextBox_TextChanged);
            // 
            // RemovalHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SearchByItemNameTextBox);
            this.Controls.Add(this.SearchLabel);
            this.Controls.Add(this.RemovalHistoryDataGridView);
            this.Controls.Add(this.BackButton);
            this.Name = "RemovalHistory";
            this.Text = "Removal History";
            this.Load += new System.EventHandler(this.RemovalHistory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RemovalHistoryDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.DataGridView RemovalHistoryDataGridView;
        private System.Windows.Forms.Label SearchLabel;
        private System.Windows.Forms.TextBox SearchByItemNameTextBox;
    }
}
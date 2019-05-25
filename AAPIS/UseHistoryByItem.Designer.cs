namespace AAPIS
{
    partial class UseHistoryByItem
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
            this.UseHistoryByItemDataGridView = new System.Windows.Forms.DataGridView();
            this.BackButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.UseHistoryByItemDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // UseHistoryByItemDataGridView
            // 
            this.UseHistoryByItemDataGridView.AllowUserToAddRows = false;
            this.UseHistoryByItemDataGridView.AllowUserToDeleteRows = false;
            this.UseHistoryByItemDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.UseHistoryByItemDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UseHistoryByItemDataGridView.Location = new System.Drawing.Point(44, 56);
            this.UseHistoryByItemDataGridView.MultiSelect = false;
            this.UseHistoryByItemDataGridView.Name = "UseHistoryByItemDataGridView";
            this.UseHistoryByItemDataGridView.ReadOnly = true;
            this.UseHistoryByItemDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.UseHistoryByItemDataGridView.Size = new System.Drawing.Size(709, 307);
            this.UseHistoryByItemDataGridView.TabIndex = 0;
            // 
            // BackButton
            // 
            this.BackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.BackButton.Location = new System.Drawing.Point(12, 408);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(144, 30);
            this.BackButton.TabIndex = 1;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // UseHistoryByItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.UseHistoryByItemDataGridView);
            this.Name = "UseHistoryByItem";
            this.Text = "Use History By Item";
            this.Load += new System.EventHandler(this.UseHistoryByItem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UseHistoryByItemDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView UseHistoryByItemDataGridView;
        private System.Windows.Forms.Button BackButton;
    }
}
namespace AAPIS
{
    partial class UseHistoryByEvent
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
            this.ItemUseHistoryDataGridView = new System.Windows.Forms.DataGridView();
            this.EventDataGridView = new System.Windows.Forms.DataGridView();
            this.EventLabel = new System.Windows.Forms.Label();
            this.ItemUseHistoryLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ItemUseHistoryDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EventDataGridView)).BeginInit();
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
            // ItemUseHistoryDataGridView
            // 
            this.ItemUseHistoryDataGridView.AllowUserToAddRows = false;
            this.ItemUseHistoryDataGridView.AllowUserToDeleteRows = false;
            this.ItemUseHistoryDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ItemUseHistoryDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ItemUseHistoryDataGridView.Location = new System.Drawing.Point(255, 233);
            this.ItemUseHistoryDataGridView.MultiSelect = false;
            this.ItemUseHistoryDataGridView.Name = "ItemUseHistoryDataGridView";
            this.ItemUseHistoryDataGridView.ReadOnly = true;
            this.ItemUseHistoryDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ItemUseHistoryDataGridView.Size = new System.Drawing.Size(533, 169);
            this.ItemUseHistoryDataGridView.TabIndex = 1;
            // 
            // EventDataGridView
            // 
            this.EventDataGridView.AllowUserToAddRows = false;
            this.EventDataGridView.AllowUserToDeleteRows = false;
            this.EventDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.EventDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EventDataGridView.Location = new System.Drawing.Point(255, 39);
            this.EventDataGridView.MultiSelect = false;
            this.EventDataGridView.Name = "EventDataGridView";
            this.EventDataGridView.ReadOnly = true;
            this.EventDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.EventDataGridView.Size = new System.Drawing.Size(533, 150);
            this.EventDataGridView.TabIndex = 2;
            this.EventDataGridView.SelectionChanged += new System.EventHandler(EventDataGridView_SelectionChanged);
            // 
            // EventLabel
            // 
            this.EventLabel.AutoSize = true;
            this.EventLabel.Location = new System.Drawing.Point(214, 39);
            this.EventLabel.Name = "EventLabel";
            this.EventLabel.Size = new System.Drawing.Size(35, 13);
            this.EventLabel.TabIndex = 3;
            this.EventLabel.Text = "Event";
            // 
            // ItemUseHistoryLabel
            // 
            this.ItemUseHistoryLabel.AutoSize = true;
            this.ItemUseHistoryLabel.Location = new System.Drawing.Point(165, 233);
            this.ItemUseHistoryLabel.Name = "ItemUseHistoryLabel";
            this.ItemUseHistoryLabel.Size = new System.Drawing.Size(84, 13);
            this.ItemUseHistoryLabel.TabIndex = 4;
            this.ItemUseHistoryLabel.Text = "Item Use History";
            // 
            // UseHistoryByEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ItemUseHistoryLabel);
            this.Controls.Add(this.EventLabel);
            this.Controls.Add(this.EventDataGridView);
            this.Controls.Add(this.ItemUseHistoryDataGridView);
            this.Controls.Add(this.BackButton);
            this.Name = "UseHistoryByEvent";
            this.Text = "Use History By Event";
            this.Load += new System.EventHandler(this.UseHistoryByEvent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ItemUseHistoryDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EventDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.DataGridView ItemUseHistoryDataGridView;
        private System.Windows.Forms.DataGridView EventDataGridView;
        private System.Windows.Forms.Label EventLabel;
        private System.Windows.Forms.Label ItemUseHistoryLabel;
    }
}
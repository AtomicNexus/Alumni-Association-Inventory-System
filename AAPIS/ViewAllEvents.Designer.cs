namespace AAPIS
{
    partial class ViewAllEvents
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
            this.EventsGridView = new System.Windows.Forms.DataGridView();
            this.BackButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.EventsGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // EventsGridView
            // 
            this.EventsGridView.AllowUserToAddRows = false;
            this.EventsGridView.AllowUserToDeleteRows = false;
            this.EventsGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.EventsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EventsGridView.Location = new System.Drawing.Point(236, 12);
            this.EventsGridView.MultiSelect = false;
            this.EventsGridView.Name = "EventsGridView";
            this.EventsGridView.ReadOnly = true;
            this.EventsGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.EventsGridView.Size = new System.Drawing.Size(324, 426);
            this.EventsGridView.TabIndex = 0;
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
            // ViewAllEvents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.EventsGridView);
            this.Name = "ViewAllEvents";
            this.Text = "All Events";
            this.Load += new System.EventHandler(this.ViewAllEvents_Load);
            ((System.ComponentModel.ISupportInitialize)(this.EventsGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView EventsGridView;
        private System.Windows.Forms.Button BackButton;
    }
}
namespace AAPIS
{
    partial class DeleteEvent
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
            this.DeleteButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.EventsComboBox = new System.Windows.Forms.ComboBox();
            this.EventLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // DeleteButton
            // 
            this.DeleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.DeleteButton.Location = new System.Drawing.Point(644, 408);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(144, 30);
            this.DeleteButton.TabIndex = 0;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.CancelButton.Location = new System.Drawing.Point(12, 408);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(144, 30);
            this.CancelButton.TabIndex = 1;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // EventsComboBox
            // 
            this.EventsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.EventsComboBox.FormattingEnabled = true;
            this.EventsComboBox.Location = new System.Drawing.Point(331, 132);
            this.EventsComboBox.Name = "EventsComboBox";
            this.EventsComboBox.Size = new System.Drawing.Size(169, 21);
            this.EventsComboBox.TabIndex = 2;
            // 
            // EventLabel
            // 
            this.EventLabel.AutoSize = true;
            this.EventLabel.Location = new System.Drawing.Point(290, 135);
            this.EventLabel.Name = "EventLabel";
            this.EventLabel.Size = new System.Drawing.Size(35, 13);
            this.EventLabel.TabIndex = 3;
            this.EventLabel.Text = "Event";
            // 
            // DeleteEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.EventLabel);
            this.Controls.Add(this.EventsComboBox);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.DeleteButton);
            this.Name = "DeleteEvent";
            this.Text = "Delete Event";
            this.Load += new System.EventHandler(this.DeleteEvent_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.ComboBox EventsComboBox;
        private System.Windows.Forms.Label EventLabel;
    }
}
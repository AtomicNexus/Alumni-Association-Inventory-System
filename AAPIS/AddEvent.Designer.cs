namespace AAPIS
{
    partial class AddEvent
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
            this.EventIDLabel = new System.Windows.Forms.Label();
            this.EventNameLabel = new System.Windows.Forms.Label();
            this.AddButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.EventIDTextBox = new System.Windows.Forms.TextBox();
            this.EventNameTextBox = new System.Windows.Forms.TextBox();
            this.RandomIntButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // EventIDLabel
            // 
            this.EventIDLabel.AutoSize = true;
            this.EventIDLabel.Location = new System.Drawing.Point(313, 158);
            this.EventIDLabel.Name = "EventIDLabel";
            this.EventIDLabel.Size = new System.Drawing.Size(49, 13);
            this.EventIDLabel.TabIndex = 0;
            this.EventIDLabel.Text = "Event ID";
            // 
            // EventNameLabel
            // 
            this.EventNameLabel.AutoSize = true;
            this.EventNameLabel.Location = new System.Drawing.Point(296, 226);
            this.EventNameLabel.Name = "EventNameLabel";
            this.EventNameLabel.Size = new System.Drawing.Size(66, 13);
            this.EventNameLabel.TabIndex = 1;
            this.EventNameLabel.Text = "Event Name";
            // 
            // AddButton
            // 
            this.AddButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.AddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.AddButton.Location = new System.Drawing.Point(644, 408);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(144, 30);
            this.AddButton.TabIndex = 2;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.CancelButton.Location = new System.Drawing.Point(12, 408);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(144, 30);
            this.CancelButton.TabIndex = 3;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // EventIDTextBox
            // 
            this.EventIDTextBox.Location = new System.Drawing.Point(368, 155);
            this.EventIDTextBox.Name = "EventIDTextBox";
            this.EventIDTextBox.ReadOnly = true;
            this.EventIDTextBox.Size = new System.Drawing.Size(169, 20);
            this.EventIDTextBox.TabIndex = 4;
            this.EventIDTextBox.TextChanged += new System.EventHandler(this.EventIDTextBox_TextChanged);
            // 
            // EventNameTextBox
            // 
            this.EventNameTextBox.Location = new System.Drawing.Point(368, 223);
            this.EventNameTextBox.Name = "EventNameTextBox";
            this.EventNameTextBox.Size = new System.Drawing.Size(169, 20);
            this.EventNameTextBox.TabIndex = 5;
            this.EventNameTextBox.TextChanged += new System.EventHandler(this.EventNameTextBox_TextChanged);
            // 
            // RandomIntButton
            // 
            this.RandomIntButton.Location = new System.Drawing.Point(543, 153);
            this.RandomIntButton.Name = "RandomIntButton";
            this.RandomIntButton.Size = new System.Drawing.Size(75, 23);
            this.RandomIntButton.TabIndex = 6;
            this.RandomIntButton.Text = "Generate";
            this.RandomIntButton.UseVisualStyleBackColor = true;
            this.RandomIntButton.Click += new System.EventHandler(this.RandomIntButton_Click);
            // 
            // AddEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.RandomIntButton);
            this.Controls.Add(this.EventNameTextBox);
            this.Controls.Add(this.EventIDTextBox);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.EventNameLabel);
            this.Controls.Add(this.EventIDLabel);
            this.Name = "AddEvent";
            this.Text = "Add Event";
            this.Load += new System.EventHandler(this.AddEvent_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label EventIDLabel;
        private System.Windows.Forms.Label EventNameLabel;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.TextBox EventIDTextBox;
        private System.Windows.Forms.TextBox EventNameTextBox;
        private System.Windows.Forms.Button RandomIntButton;
    }
}
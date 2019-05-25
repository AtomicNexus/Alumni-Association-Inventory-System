namespace AAPIS
{
    partial class Events
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
            this.AddEventButton = new System.Windows.Forms.Button();
            this.RemoveEventButton = new System.Windows.Forms.Button();
            this.ViewEventsButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddEventButton
            // 
            this.AddEventButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.AddEventButton.Location = new System.Drawing.Point(325, 151);
            this.AddEventButton.Name = "AddEventButton";
            this.AddEventButton.Size = new System.Drawing.Size(144, 30);
            this.AddEventButton.TabIndex = 0;
            this.AddEventButton.Text = "Add Event";
            this.AddEventButton.UseVisualStyleBackColor = true;
            this.AddEventButton.Click += new System.EventHandler(this.AddEventButton_Click);
            // 
            // RemoveEventButton
            // 
            this.RemoveEventButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.RemoveEventButton.Location = new System.Drawing.Point(325, 196);
            this.RemoveEventButton.Name = "RemoveEventButton";
            this.RemoveEventButton.Size = new System.Drawing.Size(144, 30);
            this.RemoveEventButton.TabIndex = 1;
            this.RemoveEventButton.Text = "Remove Event";
            this.RemoveEventButton.UseVisualStyleBackColor = true;
            this.RemoveEventButton.Click += new System.EventHandler(this.RemoveEventButton_Click);
            // 
            // ViewEventsButton
            // 
            this.ViewEventsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ViewEventsButton.Location = new System.Drawing.Point(325, 241);
            this.ViewEventsButton.Name = "ViewEventsButton";
            this.ViewEventsButton.Size = new System.Drawing.Size(144, 30);
            this.ViewEventsButton.TabIndex = 2;
            this.ViewEventsButton.Text = "View All Events";
            this.ViewEventsButton.UseVisualStyleBackColor = true;
            this.ViewEventsButton.Click += new System.EventHandler(this.ViewEventsButton_Click);
            // 
            // BackButton
            // 
            this.BackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.BackButton.Location = new System.Drawing.Point(12, 408);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(144, 30);
            this.BackButton.TabIndex = 3;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // Events
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.ViewEventsButton);
            this.Controls.Add(this.RemoveEventButton);
            this.Controls.Add(this.AddEventButton);
            this.Name = "Events";
            this.Text = "Events";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AddEventButton;
        private System.Windows.Forms.Button RemoveEventButton;
        private System.Windows.Forms.Button ViewEventsButton;
        private System.Windows.Forms.Button BackButton;
    }
}
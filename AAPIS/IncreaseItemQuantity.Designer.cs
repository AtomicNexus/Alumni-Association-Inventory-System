namespace AAPIS
{
    partial class IncreaseItemQuantity
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
            this.IncreaseButton = new System.Windows.Forms.Button();
            this.IncreaseNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.IncreaseLabel = new System.Windows.Forms.Label();
            this.CancelButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.IncreaseNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // IncreaseButton
            // 
            this.IncreaseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.IncreaseButton.Location = new System.Drawing.Point(485, 207);
            this.IncreaseButton.Name = "IncreaseButton";
            this.IncreaseButton.Size = new System.Drawing.Size(75, 23);
            this.IncreaseButton.TabIndex = 0;
            this.IncreaseButton.Text = "Increase";
            this.IncreaseButton.UseVisualStyleBackColor = true;
            this.IncreaseButton.Click += new System.EventHandler(this.IncreaseButton_Click);
            // 
            // IncreaseNumericUpDown
            // 
            this.IncreaseNumericUpDown.Location = new System.Drawing.Point(359, 210);
            this.IncreaseNumericUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.IncreaseNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.IncreaseNumericUpDown.Name = "IncreaseNumericUpDown";
            this.IncreaseNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.IncreaseNumericUpDown.TabIndex = 1;
            this.IncreaseNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // IncreaseLabel
            // 
            this.IncreaseLabel.AutoSize = true;
            this.IncreaseLabel.Location = new System.Drawing.Point(226, 212);
            this.IncreaseLabel.Name = "IncreaseLabel";
            this.IncreaseLabel.Size = new System.Drawing.Size(127, 13);
            this.IncreaseLabel.TabIndex = 2;
            this.IncreaseLabel.Text = "Increase item quantity by:";
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
            // IncreaseItemQuantity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.IncreaseLabel);
            this.Controls.Add(this.IncreaseNumericUpDown);
            this.Controls.Add(this.IncreaseButton);
            this.Name = "IncreaseItemQuantity";
            this.Text = "Increase Item Quantity";
            ((System.ComponentModel.ISupportInitialize)(this.IncreaseNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button IncreaseButton;
        private System.Windows.Forms.NumericUpDown IncreaseNumericUpDown;
        private System.Windows.Forms.Label IncreaseLabel;
        private System.Windows.Forms.Button CancelButton;
    }
}
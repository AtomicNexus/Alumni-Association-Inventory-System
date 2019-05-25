namespace AAPIS
{
    partial class DecreaseItemQuantity
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
            this.DecreaseButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.DecreaseNumericUpDown = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.DecreaseNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // DecreaseButton
            // 
            this.DecreaseButton.Location = new System.Drawing.Point(485, 209);
            this.DecreaseButton.Name = "DecreaseButton";
            this.DecreaseButton.Size = new System.Drawing.Size(75, 23);
            this.DecreaseButton.TabIndex = 0;
            this.DecreaseButton.Text = "Decrease";
            this.DecreaseButton.UseVisualStyleBackColor = true;
            this.DecreaseButton.Click += new System.EventHandler(this.DecreaseButton_Click);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(221, 214);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Decrease item quantity by:";
            // 
            // DecreaseNumericUpDown
            // 
            this.DecreaseNumericUpDown.Location = new System.Drawing.Point(359, 212);
            this.DecreaseNumericUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.DecreaseNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.DecreaseNumericUpDown.Name = "DecreaseNumericUpDown";
            this.DecreaseNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.DecreaseNumericUpDown.TabIndex = 3;
            this.DecreaseNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // DecreaseItemQuantity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DecreaseNumericUpDown);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.DecreaseButton);
            this.Name = "DecreaseItemQuantity";
            this.Text = "Decrease Item Quantity";
            ((System.ComponentModel.ISupportInitialize)(this.DecreaseNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button DecreaseButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown DecreaseNumericUpDown;
    }
}
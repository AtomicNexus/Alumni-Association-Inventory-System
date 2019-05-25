namespace AAPIS
{
    partial class AddItem
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
            this.ItemIDTextBox = new System.Windows.Forms.TextBox();
            this.ItemNameTextBox = new System.Windows.Forms.TextBox();
            this.ItemNoteTextBox = new System.Windows.Forms.TextBox();
            this.ItemPicFileNameTextBox = new System.Windows.Forms.TextBox();
            this.ItemPicFilePathTextBox = new System.Windows.Forms.TextBox();
            this.ItemIDLabel = new System.Windows.Forms.Label();
            this.ItemNameLabel = new System.Windows.Forms.Label();
            this.ItemQuantityLabel = new System.Windows.Forms.Label();
            this.ItemPicLabel = new System.Windows.Forms.Label();
            this.ItemNoteLabel = new System.Windows.Forms.Label();
            this.RandomIntButton = new System.Windows.Forms.Button();
            this.OpenFileButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.OpenImageFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.ItemQuantityUpDown = new System.Windows.Forms.NumericUpDown();
            this.ItemPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ItemQuantityUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // ItemIDTextBox
            // 
            this.ItemIDTextBox.Location = new System.Drawing.Point(126, 15);
            this.ItemIDTextBox.Name = "ItemIDTextBox";
            this.ItemIDTextBox.ReadOnly = true;
            this.ItemIDTextBox.Size = new System.Drawing.Size(225, 20);
            this.ItemIDTextBox.TabIndex = 0;
            this.ItemIDTextBox.TextChanged += new System.EventHandler(this.ItemIDTextBox_TextChanged);
            // 
            // ItemNameTextBox
            // 
            this.ItemNameTextBox.Location = new System.Drawing.Point(126, 51);
            this.ItemNameTextBox.Name = "ItemNameTextBox";
            this.ItemNameTextBox.Size = new System.Drawing.Size(225, 20);
            this.ItemNameTextBox.TabIndex = 1;
            this.ItemNameTextBox.TextChanged += new System.EventHandler(this.ItemNameTextBox_TextChanged);
            // 
            // ItemNoteTextBox
            // 
            this.ItemNoteTextBox.Location = new System.Drawing.Point(126, 175);
            this.ItemNoteTextBox.Multiline = true;
            this.ItemNoteTextBox.Name = "ItemNoteTextBox";
            this.ItemNoteTextBox.Size = new System.Drawing.Size(306, 102);
            this.ItemNoteTextBox.TabIndex = 3;
            // 
            // ItemPicFileNameTextBox
            // 
            this.ItemPicFileNameTextBox.Location = new System.Drawing.Point(126, 123);
            this.ItemPicFileNameTextBox.Name = "ItemPicFileNameTextBox";
            this.ItemPicFileNameTextBox.ReadOnly = true;
            this.ItemPicFileNameTextBox.Size = new System.Drawing.Size(225, 20);
            this.ItemPicFileNameTextBox.TabIndex = 4;
            // 
            // ItemPicFilePathTextBox
            // 
            this.ItemPicFilePathTextBox.Location = new System.Drawing.Point(126, 149);
            this.ItemPicFilePathTextBox.Name = "ItemPicFilePathTextBox";
            this.ItemPicFilePathTextBox.ReadOnly = true;
            this.ItemPicFilePathTextBox.Size = new System.Drawing.Size(306, 20);
            this.ItemPicFilePathTextBox.TabIndex = 5;
            // 
            // ItemIDLabel
            // 
            this.ItemIDLabel.AutoSize = true;
            this.ItemIDLabel.Location = new System.Drawing.Point(79, 18);
            this.ItemIDLabel.Name = "ItemIDLabel";
            this.ItemIDLabel.Size = new System.Drawing.Size(41, 13);
            this.ItemIDLabel.TabIndex = 6;
            this.ItemIDLabel.Text = "Item ID";
            // 
            // ItemNameLabel
            // 
            this.ItemNameLabel.AutoSize = true;
            this.ItemNameLabel.Location = new System.Drawing.Point(62, 54);
            this.ItemNameLabel.Name = "ItemNameLabel";
            this.ItemNameLabel.Size = new System.Drawing.Size(58, 13);
            this.ItemNameLabel.TabIndex = 7;
            this.ItemNameLabel.Text = "Item Name";
            // 
            // ItemQuantityLabel
            // 
            this.ItemQuantityLabel.AutoSize = true;
            this.ItemQuantityLabel.Location = new System.Drawing.Point(51, 90);
            this.ItemQuantityLabel.Name = "ItemQuantityLabel";
            this.ItemQuantityLabel.Size = new System.Drawing.Size(69, 13);
            this.ItemQuantityLabel.TabIndex = 8;
            this.ItemQuantityLabel.Text = "Item Quantity";
            // 
            // ItemPicLabel
            // 
            this.ItemPicLabel.AutoSize = true;
            this.ItemPicLabel.Location = new System.Drawing.Point(9, 126);
            this.ItemPicLabel.Name = "ItemPicLabel";
            this.ItemPicLabel.Size = new System.Drawing.Size(111, 13);
            this.ItemPicLabel.TabIndex = 9;
            this.ItemPicLabel.Text = "Item Picture (Optional)";
            // 
            // ItemNoteLabel
            // 
            this.ItemNoteLabel.AutoSize = true;
            this.ItemNoteLabel.Location = new System.Drawing.Point(19, 178);
            this.ItemNoteLabel.Name = "ItemNoteLabel";
            this.ItemNoteLabel.Size = new System.Drawing.Size(101, 13);
            this.ItemNoteLabel.TabIndex = 10;
            this.ItemNoteLabel.Text = "Item Note (Optional)";
            // 
            // RandomIntButton
            // 
            this.RandomIntButton.Location = new System.Drawing.Point(357, 13);
            this.RandomIntButton.Name = "RandomIntButton";
            this.RandomIntButton.Size = new System.Drawing.Size(75, 23);
            this.RandomIntButton.TabIndex = 11;
            this.RandomIntButton.Text = "Generate";
            this.RandomIntButton.UseVisualStyleBackColor = true;
            this.RandomIntButton.Click += new System.EventHandler(this.RandomIntButton_Click);
            // 
            // OpenFileButton
            // 
            this.OpenFileButton.Location = new System.Drawing.Point(357, 121);
            this.OpenFileButton.Name = "OpenFileButton";
            this.OpenFileButton.Size = new System.Drawing.Size(75, 23);
            this.OpenFileButton.TabIndex = 12;
            this.OpenFileButton.Text = "Choose";
            this.OpenFileButton.UseVisualStyleBackColor = true;
            this.OpenFileButton.Click += new System.EventHandler(this.OpenFileButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.CancelButton.Location = new System.Drawing.Point(12, 408);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(144, 30);
            this.CancelButton.TabIndex = 13;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.AddButton.Location = new System.Drawing.Point(644, 408);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(144, 30);
            this.AddButton.TabIndex = 14;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // OpenImageFileDialog
            // 
            this.OpenImageFileDialog.FileName = "Select an Image";
            this.OpenImageFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.OpenImageFileDialog_FileOk);
            // 
            // ItemQuantityUpDown
            // 
            this.ItemQuantityUpDown.Location = new System.Drawing.Point(126, 88);
            this.ItemQuantityUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.ItemQuantityUpDown.Name = "ItemQuantityUpDown";
            this.ItemQuantityUpDown.Size = new System.Drawing.Size(225, 20);
            this.ItemQuantityUpDown.TabIndex = 15;
            // 
            // ItemPictureBox
            // 
            this.ItemPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ItemPictureBox.Location = new System.Drawing.Point(438, 40);
            this.ItemPictureBox.Name = "ItemPictureBox";
            this.ItemPictureBox.Size = new System.Drawing.Size(258, 201);
            this.ItemPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ItemPictureBox.TabIndex = 16;
            this.ItemPictureBox.TabStop = false;
            // 
            // AddItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ItemPictureBox);
            this.Controls.Add(this.ItemQuantityUpDown);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.OpenFileButton);
            this.Controls.Add(this.RandomIntButton);
            this.Controls.Add(this.ItemNoteLabel);
            this.Controls.Add(this.ItemPicLabel);
            this.Controls.Add(this.ItemQuantityLabel);
            this.Controls.Add(this.ItemNameLabel);
            this.Controls.Add(this.ItemIDLabel);
            this.Controls.Add(this.ItemPicFilePathTextBox);
            this.Controls.Add(this.ItemPicFileNameTextBox);
            this.Controls.Add(this.ItemNoteTextBox);
            this.Controls.Add(this.ItemNameTextBox);
            this.Controls.Add(this.ItemIDTextBox);
            this.Name = "AddItem";
            this.Text = "Add Item";
            this.Load += new System.EventHandler(this.AddItem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ItemQuantityUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ItemIDTextBox;
        private System.Windows.Forms.TextBox ItemNameTextBox;
        private System.Windows.Forms.TextBox ItemNoteTextBox;
        private System.Windows.Forms.TextBox ItemPicFileNameTextBox;
        private System.Windows.Forms.TextBox ItemPicFilePathTextBox;
        private System.Windows.Forms.Label ItemIDLabel;
        private System.Windows.Forms.Label ItemNameLabel;
        private System.Windows.Forms.Label ItemQuantityLabel;
        private System.Windows.Forms.Label ItemPicLabel;
        private System.Windows.Forms.Label ItemNoteLabel;
        private System.Windows.Forms.Button RandomIntButton;
        private System.Windows.Forms.Button OpenFileButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.OpenFileDialog OpenImageFileDialog;
        private System.Windows.Forms.NumericUpDown ItemQuantityUpDown;
        private System.Windows.Forms.PictureBox ItemPictureBox;
    }
}
namespace AAPIS
{
    partial class EditOtherItemInfo
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
            this.ItemPictureBox = new System.Windows.Forms.PictureBox();
            this.EditButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.OpenFileButton = new System.Windows.Forms.Button();
            this.ItemNoteLabel = new System.Windows.Forms.Label();
            this.ItemPicLabel = new System.Windows.Forms.Label();
            this.ItemNameLabel = new System.Windows.Forms.Label();
            this.ItemIDLabel = new System.Windows.Forms.Label();
            this.ItemPicFilePathTextBox = new System.Windows.Forms.TextBox();
            this.ItemPicFileNameTextBox = new System.Windows.Forms.TextBox();
            this.ItemNoteTextBox = new System.Windows.Forms.TextBox();
            this.ItemNameTextBox = new System.Windows.Forms.TextBox();
            this.ItemIDTextBox = new System.Windows.Forms.TextBox();
            this.DeleteItemPicButton = new System.Windows.Forms.Button();
            this.OpenImageFileDialog = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.ItemPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // ItemPictureBox
            // 
            this.ItemPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ItemPictureBox.Location = new System.Drawing.Point(440, 40);
            this.ItemPictureBox.Name = "ItemPictureBox";
            this.ItemPictureBox.Size = new System.Drawing.Size(258, 201);
            this.ItemPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ItemPictureBox.TabIndex = 32;
            this.ItemPictureBox.TabStop = false;
            // 
            // EditButton
            // 
            this.EditButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.EditButton.Location = new System.Drawing.Point(646, 408);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(144, 30);
            this.EditButton.TabIndex = 30;
            this.EditButton.Text = "Edit";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.CancelButton.Location = new System.Drawing.Point(14, 408);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(144, 30);
            this.CancelButton.TabIndex = 29;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // OpenFileButton
            // 
            this.OpenFileButton.Location = new System.Drawing.Point(359, 75);
            this.OpenFileButton.Name = "OpenFileButton";
            this.OpenFileButton.Size = new System.Drawing.Size(75, 23);
            this.OpenFileButton.TabIndex = 28;
            this.OpenFileButton.Text = "Choose";
            this.OpenFileButton.UseVisualStyleBackColor = true;
            this.OpenFileButton.Click += new System.EventHandler(this.OpenFileButton_Click);
            // 
            // ItemNoteLabel
            // 
            this.ItemNoteLabel.AutoSize = true;
            this.ItemNoteLabel.Location = new System.Drawing.Point(21, 178);
            this.ItemNoteLabel.Name = "ItemNoteLabel";
            this.ItemNoteLabel.Size = new System.Drawing.Size(101, 13);
            this.ItemNoteLabel.TabIndex = 26;
            this.ItemNoteLabel.Text = "Item Note (Optional)";
            // 
            // ItemPicLabel
            // 
            this.ItemPicLabel.AutoSize = true;
            this.ItemPicLabel.Location = new System.Drawing.Point(11, 80);
            this.ItemPicLabel.Name = "ItemPicLabel";
            this.ItemPicLabel.Size = new System.Drawing.Size(111, 13);
            this.ItemPicLabel.TabIndex = 25;
            this.ItemPicLabel.Text = "Item Picture (Optional)";
            // 
            // ItemNameLabel
            // 
            this.ItemNameLabel.AutoSize = true;
            this.ItemNameLabel.Location = new System.Drawing.Point(64, 54);
            this.ItemNameLabel.Name = "ItemNameLabel";
            this.ItemNameLabel.Size = new System.Drawing.Size(58, 13);
            this.ItemNameLabel.TabIndex = 23;
            this.ItemNameLabel.Text = "Item Name";
            // 
            // ItemIDLabel
            // 
            this.ItemIDLabel.AutoSize = true;
            this.ItemIDLabel.Location = new System.Drawing.Point(81, 18);
            this.ItemIDLabel.Name = "ItemIDLabel";
            this.ItemIDLabel.Size = new System.Drawing.Size(41, 13);
            this.ItemIDLabel.TabIndex = 22;
            this.ItemIDLabel.Text = "Item ID";
            // 
            // ItemPicFilePathTextBox
            // 
            this.ItemPicFilePathTextBox.Location = new System.Drawing.Point(128, 103);
            this.ItemPicFilePathTextBox.Name = "ItemPicFilePathTextBox";
            this.ItemPicFilePathTextBox.ReadOnly = true;
            this.ItemPicFilePathTextBox.Size = new System.Drawing.Size(306, 20);
            this.ItemPicFilePathTextBox.TabIndex = 21;
            // 
            // ItemPicFileNameTextBox
            // 
            this.ItemPicFileNameTextBox.Location = new System.Drawing.Point(128, 77);
            this.ItemPicFileNameTextBox.Name = "ItemPicFileNameTextBox";
            this.ItemPicFileNameTextBox.ReadOnly = true;
            this.ItemPicFileNameTextBox.Size = new System.Drawing.Size(225, 20);
            this.ItemPicFileNameTextBox.TabIndex = 20;
            // 
            // ItemNoteTextBox
            // 
            this.ItemNoteTextBox.Location = new System.Drawing.Point(128, 175);
            this.ItemNoteTextBox.Multiline = true;
            this.ItemNoteTextBox.Name = "ItemNoteTextBox";
            this.ItemNoteTextBox.Size = new System.Drawing.Size(306, 102);
            this.ItemNoteTextBox.TabIndex = 19;
            // 
            // ItemNameTextBox
            // 
            this.ItemNameTextBox.Location = new System.Drawing.Point(128, 51);
            this.ItemNameTextBox.Name = "ItemNameTextBox";
            this.ItemNameTextBox.Size = new System.Drawing.Size(225, 20);
            this.ItemNameTextBox.TabIndex = 18;
            this.ItemNameTextBox.TextChanged += new System.EventHandler(this.ItemNameTextBox_TextChanged);
            // 
            // ItemIDTextBox
            // 
            this.ItemIDTextBox.Location = new System.Drawing.Point(128, 15);
            this.ItemIDTextBox.Name = "ItemIDTextBox";
            this.ItemIDTextBox.ReadOnly = true;
            this.ItemIDTextBox.Size = new System.Drawing.Size(225, 20);
            this.ItemIDTextBox.TabIndex = 17;
            // 
            // DeleteItemPicButton
            // 
            this.DeleteItemPicButton.Location = new System.Drawing.Point(359, 129);
            this.DeleteItemPicButton.Name = "DeleteItemPicButton";
            this.DeleteItemPicButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteItemPicButton.TabIndex = 33;
            this.DeleteItemPicButton.Text = "Delete";
            this.DeleteItemPicButton.UseVisualStyleBackColor = true;
            this.DeleteItemPicButton.Click += new System.EventHandler(this.DeleteItemPicButton_Click);
            // 
            // OpenImageFileDialog
            // 
            this.OpenImageFileDialog.FileName = "Select an Image";
            this.OpenImageFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.OpenImageFileDialog_FileOk);
            // 
            // EditOtherItemInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DeleteItemPicButton);
            this.Controls.Add(this.ItemPictureBox);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.OpenFileButton);
            this.Controls.Add(this.ItemNoteLabel);
            this.Controls.Add(this.ItemPicLabel);
            this.Controls.Add(this.ItemNameLabel);
            this.Controls.Add(this.ItemIDLabel);
            this.Controls.Add(this.ItemPicFilePathTextBox);
            this.Controls.Add(this.ItemPicFileNameTextBox);
            this.Controls.Add(this.ItemNoteTextBox);
            this.Controls.Add(this.ItemNameTextBox);
            this.Controls.Add(this.ItemIDTextBox);
            this.Name = "EditOtherItemInfo";
            this.Text = "Edit Other Item Information";
            this.Load += new System.EventHandler(this.EditOtherItemInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ItemPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ItemPictureBox;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button OpenFileButton;
        private System.Windows.Forms.Label ItemNoteLabel;
        private System.Windows.Forms.Label ItemPicLabel;
        private System.Windows.Forms.Label ItemNameLabel;
        private System.Windows.Forms.Label ItemIDLabel;
        private System.Windows.Forms.TextBox ItemPicFilePathTextBox;
        private System.Windows.Forms.TextBox ItemPicFileNameTextBox;
        private System.Windows.Forms.TextBox ItemNoteTextBox;
        private System.Windows.Forms.TextBox ItemNameTextBox;
        private System.Windows.Forms.TextBox ItemIDTextBox;
        private System.Windows.Forms.Button DeleteItemPicButton;
        private System.Windows.Forms.OpenFileDialog OpenImageFileDialog;
    }
}
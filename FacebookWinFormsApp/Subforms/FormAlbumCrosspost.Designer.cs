namespace BasicFacebookFeatures.Subforms
{
    partial class FormAlbumCrosspost
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAlbumCrosspost));
            this.listBoxSelectedFromAlbum = new System.Windows.Forms.ListBox();
            this.listBoxSelectedPicture = new System.Windows.Forms.ListBox();
            this.pictureBoxShowAlbumPictureAdd = new System.Windows.Forms.PictureBox();
            this.ListBoxSelectedToAlbum = new System.Windows.Forms.ListBox();
            this.buttonAddPictureTo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxShowAlbumPictureAdd)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxSelectedFromAlbum
            // 
            this.listBoxSelectedFromAlbum.BackColor = System.Drawing.Color.White;
            this.listBoxSelectedFromAlbum.ForeColor = System.Drawing.Color.Black;
            this.listBoxSelectedFromAlbum.FormattingEnabled = true;
            this.listBoxSelectedFromAlbum.ItemHeight = 16;
            this.listBoxSelectedFromAlbum.Location = new System.Drawing.Point(23, 26);
            this.listBoxSelectedFromAlbum.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBoxSelectedFromAlbum.Name = "listBoxSelectedFromAlbum";
            this.listBoxSelectedFromAlbum.Size = new System.Drawing.Size(112, 148);
            this.listBoxSelectedFromAlbum.TabIndex = 0;
            this.listBoxSelectedFromAlbum.SelectedIndexChanged += new System.EventHandler(this.listBoxFromAlbum_SelectedIndexChanged);
            // 
            // listBoxSelectedPicture
            // 
            this.listBoxSelectedPicture.BackColor = System.Drawing.Color.White;
            this.listBoxSelectedPicture.ForeColor = System.Drawing.Color.Black;
            this.listBoxSelectedPicture.FormattingEnabled = true;
            this.listBoxSelectedPicture.ItemHeight = 16;
            this.listBoxSelectedPicture.Location = new System.Drawing.Point(200, 26);
            this.listBoxSelectedPicture.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBoxSelectedPicture.Name = "listBoxSelectedPicture";
            this.listBoxSelectedPicture.Size = new System.Drawing.Size(112, 148);
            this.listBoxSelectedPicture.TabIndex = 1;
            this.listBoxSelectedPicture.SelectedIndexChanged += new System.EventHandler(this.listBoxSelectedPicture_SelectedIndexChanged);
            // 
            // pictureBoxShowAlbumPictureAdd
            // 
            this.pictureBoxShowAlbumPictureAdd.BackColor = System.Drawing.Color.White;
            this.pictureBoxShowAlbumPictureAdd.ForeColor = System.Drawing.Color.Black;
            this.pictureBoxShowAlbumPictureAdd.Location = new System.Drawing.Point(73, 198);
            this.pictureBoxShowAlbumPictureAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxShowAlbumPictureAdd.Name = "pictureBoxShowAlbumPictureAdd";
            this.pictureBoxShowAlbumPictureAdd.Size = new System.Drawing.Size(188, 147);
            this.pictureBoxShowAlbumPictureAdd.TabIndex = 2;
            this.pictureBoxShowAlbumPictureAdd.TabStop = false;
            // 
            // ListBoxSelectedToAlbum
            // 
            this.ListBoxSelectedToAlbum.BackColor = System.Drawing.Color.White;
            this.ListBoxSelectedToAlbum.Enabled = false;
            this.ListBoxSelectedToAlbum.ForeColor = System.Drawing.Color.Black;
            this.ListBoxSelectedToAlbum.FormattingEnabled = true;
            this.ListBoxSelectedToAlbum.ItemHeight = 16;
            this.ListBoxSelectedToAlbum.Location = new System.Drawing.Point(372, 26);
            this.ListBoxSelectedToAlbum.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ListBoxSelectedToAlbum.Name = "ListBoxSelectedToAlbum";
            this.ListBoxSelectedToAlbum.Size = new System.Drawing.Size(112, 148);
            this.ListBoxSelectedToAlbum.TabIndex = 5;
            this.ListBoxSelectedToAlbum.SelectedIndexChanged += new System.EventHandler(this.ListBoxSelectedToAlbum_SelectedIndexChanged);
            // 
            // buttonAddPictureTo
            // 
            this.buttonAddPictureTo.BackColor = System.Drawing.Color.White;
            this.buttonAddPictureTo.Enabled = false;
            this.buttonAddPictureTo.ForeColor = System.Drawing.Color.Black;
            this.buttonAddPictureTo.Location = new System.Drawing.Point(372, 198);
            this.buttonAddPictureTo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAddPictureTo.Name = "buttonAddPictureTo";
            this.buttonAddPictureTo.Size = new System.Drawing.Size(111, 41);
            this.buttonAddPictureTo.TabIndex = 6;
            this.buttonAddPictureTo.Text = "Add Picture";
            this.buttonAddPictureTo.UseVisualStyleBackColor = false;
            this.buttonAddPictureTo.Click += new System.EventHandler(this.buttonAddPictureTo_Click);
            // 
            // FormAlbumCrosspost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 360);
            this.Controls.Add(this.buttonAddPictureTo);
            this.Controls.Add(this.ListBoxSelectedToAlbum);
            this.Controls.Add(this.pictureBoxShowAlbumPictureAdd);
            this.Controls.Add(this.listBoxSelectedPicture);
            this.Controls.Add(this.listBoxSelectedFromAlbum);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormAlbumCrosspost";
            this.Text = "Facebook - Add Picture";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxShowAlbumPictureAdd)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxSelectedFromAlbum;
        private System.Windows.Forms.ListBox listBoxSelectedPicture;
        private System.Windows.Forms.PictureBox pictureBoxShowAlbumPictureAdd;
        private System.Windows.Forms.ListBox ListBoxSelectedToAlbum;
        private System.Windows.Forms.Button buttonAddPictureTo;
    }
}
namespace BasicFacebookFeatures.Subforms
{
    partial class FormUserDetails
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label birthdayLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label firstNameLabel;
            System.Windows.Forms.Label imageNormalLabel;
            System.Windows.Forms.Label lastNameLabel;
            System.Windows.Forms.Label localeLabelText;
            System.Windows.Forms.Label nameLabelText;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUserDetails));
            this.cityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labelWelcomBack = new System.Windows.Forms.Label();
            this.labelAgeText = new System.Windows.Forms.Label();
            this.labelGenderText = new System.Windows.Forms.Label();
            this.labelAge = new System.Windows.Forms.Label();
            this.labelGender = new System.Windows.Forms.Label();
            this.labelFriendCount = new System.Windows.Forms.Label();
            this.labelFriendCountText = new System.Windows.Forms.Label();
            this.labelRalashionshipText = new System.Windows.Forms.Label();
            this.labelRelashionship = new System.Windows.Forms.Label();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.birthdayLabel1 = new System.Windows.Forms.Label();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.imageNormalPictureBox = new System.Windows.Forms.PictureBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.localeLabel = new System.Windows.Forms.Label();
            this.nameLabel2 = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            birthdayLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            firstNameLabel = new System.Windows.Forms.Label();
            imageNormalLabel = new System.Windows.Forms.Label();
            lastNameLabel = new System.Windows.Forms.Label();
            localeLabelText = new System.Windows.Forms.Label();
            nameLabelText = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cityBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageNormalPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // birthdayLabel
            // 
            birthdayLabel.AutoSize = true;
            birthdayLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            birthdayLabel.ForeColor = System.Drawing.Color.Black;
            birthdayLabel.Location = new System.Drawing.Point(38, 64);
            birthdayLabel.Name = "birthdayLabel";
            birthdayLabel.Size = new System.Drawing.Size(59, 16);
            birthdayLabel.TabIndex = 19;
            birthdayLabel.Text = "Birthday:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            emailLabel.ForeColor = System.Drawing.Color.Black;
            emailLabel.Location = new System.Drawing.Point(38, 108);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(44, 16);
            emailLabel.TabIndex = 21;
            emailLabel.Text = "Email:";
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            firstNameLabel.ForeColor = System.Drawing.Color.Black;
            firstNameLabel.Location = new System.Drawing.Point(393, 78);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new System.Drawing.Size(75, 16);
            firstNameLabel.TabIndex = 23;
            firstNameLabel.Text = "First Name:";
            // 
            // imageNormalLabel
            // 
            imageNormalLabel.AutoEllipsis = true;
            imageNormalLabel.AutoSize = true;
            imageNormalLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            imageNormalLabel.ForeColor = System.Drawing.Color.Black;
            imageNormalLabel.Location = new System.Drawing.Point(38, 223);
            imageNormalLabel.Name = "imageNormalLabel";
            imageNormalLabel.Size = new System.Drawing.Size(48, 16);
            imageNormalLabel.TabIndex = 25;
            imageNormalLabel.Text = "Image:";
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            lastNameLabel.ForeColor = System.Drawing.Color.Black;
            lastNameLabel.Location = new System.Drawing.Point(393, 116);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new System.Drawing.Size(75, 16);
            lastNameLabel.TabIndex = 27;
            lastNameLabel.Text = "Last Name:";
            // 
            // localeLabelText
            // 
            localeLabelText.AutoSize = true;
            localeLabelText.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            localeLabelText.ForeColor = System.Drawing.Color.Black;
            localeLabelText.Location = new System.Drawing.Point(393, 188);
            localeLabelText.Name = "localeLabelText";
            localeLabelText.Size = new System.Drawing.Size(51, 16);
            localeLabelText.TabIndex = 29;
            localeLabelText.Text = "Locale:";
            // 
            // cityBindingSource
            // 
            this.cityBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.City);
            // 
            // labelWelcomBack
            // 
            this.labelWelcomBack.AutoSize = true;
            this.labelWelcomBack.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelWelcomBack.ForeColor = System.Drawing.Color.Black;
            this.labelWelcomBack.Location = new System.Drawing.Point(12, 21);
            this.labelWelcomBack.Name = "labelWelcomBack";
            this.labelWelcomBack.Size = new System.Drawing.Size(128, 20);
            this.labelWelcomBack.TabIndex = 0;
            this.labelWelcomBack.Text = "Welcome Back,";
            // 
            // labelAgeText
            // 
            this.labelAgeText.AutoSize = true;
            this.labelAgeText.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelAgeText.ForeColor = System.Drawing.Color.Black;
            this.labelAgeText.Location = new System.Drawing.Point(38, 188);
            this.labelAgeText.Name = "labelAgeText";
            this.labelAgeText.Size = new System.Drawing.Size(35, 16);
            this.labelAgeText.TabIndex = 2;
            this.labelAgeText.Text = "Age:";
            // 
            // labelGenderText
            // 
            this.labelGenderText.AutoSize = true;
            this.labelGenderText.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelGenderText.ForeColor = System.Drawing.Color.Black;
            this.labelGenderText.Location = new System.Drawing.Point(393, 323);
            this.labelGenderText.Name = "labelGenderText";
            this.labelGenderText.Size = new System.Drawing.Size(55, 16);
            this.labelGenderText.TabIndex = 4;
            this.labelGenderText.Text = "Gender:";
            // 
            // labelAge
            // 
            this.labelAge.AutoSize = true;
            this.labelAge.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelAge.ForeColor = System.Drawing.Color.Black;
            this.labelAge.Location = new System.Drawing.Point(122, 188);
            this.labelAge.Name = "labelAge";
            this.labelAge.Size = new System.Drawing.Size(32, 16);
            this.labelAge.TabIndex = 7;
            this.labelAge.Text = "Age";
            // 
            // labelGender
            // 
            this.labelGender.AutoSize = true;
            this.labelGender.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelGender.ForeColor = System.Drawing.Color.Black;
            this.labelGender.Location = new System.Drawing.Point(512, 323);
            this.labelGender.Name = "labelGender";
            this.labelGender.Size = new System.Drawing.Size(52, 16);
            this.labelGender.TabIndex = 9;
            this.labelGender.Text = "Gender";
            // 
            // labelFriendCount
            // 
            this.labelFriendCount.AutoSize = true;
            this.labelFriendCount.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelFriendCount.ForeColor = System.Drawing.Color.Black;
            this.labelFriendCount.Location = new System.Drawing.Point(512, 293);
            this.labelFriendCount.Name = "labelFriendCount";
            this.labelFriendCount.Size = new System.Drawing.Size(52, 16);
            this.labelFriendCount.TabIndex = 12;
            this.labelFriendCount.Text = "Friends";
            // 
            // labelFriendCountText
            // 
            this.labelFriendCountText.AutoSize = true;
            this.labelFriendCountText.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelFriendCountText.ForeColor = System.Drawing.Color.Black;
            this.labelFriendCountText.Location = new System.Drawing.Point(393, 293);
            this.labelFriendCountText.Name = "labelFriendCountText";
            this.labelFriendCountText.Size = new System.Drawing.Size(85, 16);
            this.labelFriendCountText.TabIndex = 11;
            this.labelFriendCountText.Text = "Friend Count:";
            // 
            // labelRalashionshipText
            // 
            this.labelRalashionshipText.AutoSize = true;
            this.labelRalashionshipText.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelRalashionshipText.ForeColor = System.Drawing.Color.Black;
            this.labelRalashionshipText.Location = new System.Drawing.Point(393, 232);
            this.labelRalashionshipText.Name = "labelRalashionshipText";
            this.labelRalashionshipText.Size = new System.Drawing.Size(96, 16);
            this.labelRalashionshipText.TabIndex = 15;
            this.labelRalashionshipText.Text = "Relashionship:";
            // 
            // labelRelashionship
            // 
            this.labelRelashionship.AutoSize = true;
            this.labelRelashionship.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelRelashionship.ForeColor = System.Drawing.Color.Black;
            this.labelRelashionship.Location = new System.Drawing.Point(512, 232);
            this.labelRelashionship.Name = "labelRelashionship";
            this.labelRelashionship.Size = new System.Drawing.Size(86, 16);
            this.labelRelashionship.TabIndex = 16;
            this.labelRelashionship.Text = "Relahionship";
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.User);
            // 
            // birthdayLabel1
            // 
            this.birthdayLabel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.birthdayLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "Birthday", true));
            this.birthdayLabel1.ForeColor = System.Drawing.Color.Black;
            this.birthdayLabel1.Location = new System.Drawing.Point(122, 64);
            this.birthdayLabel1.Name = "birthdayLabel1";
            this.birthdayLabel1.Size = new System.Drawing.Size(200, 20);
            this.birthdayLabel1.TabIndex = 20;
            this.birthdayLabel1.Text = "[Birthday]";
            // 
            // emailTextBox
            // 
            this.emailTextBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "Email", true));
            this.emailTextBox.ForeColor = System.Drawing.Color.Black;
            this.emailTextBox.Location = new System.Drawing.Point(122, 105);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(200, 22);
            this.emailTextBox.TabIndex = 22;
            this.emailTextBox.Text = "[Email]";
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.firstNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "FirstName", true));
            this.firstNameTextBox.ForeColor = System.Drawing.Color.Black;
            this.firstNameTextBox.Location = new System.Drawing.Point(506, 75);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(109, 22);
            this.firstNameTextBox.TabIndex = 24;
            this.firstNameTextBox.Text = "[First Name]";
            // 
            // imageNormalPictureBox
            // 
            this.imageNormalPictureBox.BackColor = System.Drawing.Color.White;
            this.imageNormalPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.userBindingSource, "ImageNormal", true));
            this.imageNormalPictureBox.ForeColor = System.Drawing.Color.Black;
            this.imageNormalPictureBox.Location = new System.Drawing.Point(122, 223);
            this.imageNormalPictureBox.Name = "imageNormalPictureBox";
            this.imageNormalPictureBox.Size = new System.Drawing.Size(200, 139);
            this.imageNormalPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.imageNormalPictureBox.TabIndex = 26;
            this.imageNormalPictureBox.TabStop = false;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lastNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "LastName", true));
            this.lastNameTextBox.ForeColor = System.Drawing.Color.Black;
            this.lastNameTextBox.Location = new System.Drawing.Point(506, 113);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(109, 22);
            this.lastNameTextBox.TabIndex = 28;
            this.lastNameTextBox.Text = "[last Name]";
            // 
            // localeLabel
            // 
            this.localeLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.localeLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "Locale", true));
            this.localeLabel.ForeColor = System.Drawing.Color.Black;
            this.localeLabel.Location = new System.Drawing.Point(512, 188);
            this.localeLabel.Name = "localeLabel";
            this.localeLabel.Size = new System.Drawing.Size(103, 22);
            this.localeLabel.TabIndex = 30;
            this.localeLabel.Text = "[Locale]";
            // 
            // nameLabel2
            // 
            this.nameLabel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.nameLabel2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "Name", true));
            this.nameLabel2.ForeColor = System.Drawing.Color.Black;
            this.nameLabel2.Location = new System.Drawing.Point(146, 21);
            this.nameLabel2.Name = "nameLabel2";
            this.nameLabel2.Size = new System.Drawing.Size(100, 20);
            this.nameLabel2.TabIndex = 33;
            this.nameLabel2.Text = "NameUser";
            // 
            // nameLabelText
            // 
            nameLabelText.AutoSize = true;
            nameLabelText.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            nameLabelText.Location = new System.Drawing.Point(38, 148);
            nameLabelText.Name = "nameLabelText";
            nameLabelText.Size = new System.Drawing.Size(61, 16);
            nameLabelText.TabIndex = 33;
            nameLabelText.Text = "Location:";
            // 
            // nameLabel
            // 
            this.nameLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.nameLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cityBindingSource, "Name", true));
            this.nameLabel.Location = new System.Drawing.Point(122, 148);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(103, 16);
            this.nameLabel.TabIndex = 34;
            this.nameLabel.Text = "[Location]";
            // 
            // FormUserDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 488);
            this.Controls.Add(nameLabelText);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.nameLabel2);
            this.Controls.Add(birthdayLabel);
            this.Controls.Add(this.birthdayLabel1);
            this.Controls.Add(emailLabel);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(firstNameLabel);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(imageNormalLabel);
            this.Controls.Add(this.imageNormalPictureBox);
            this.Controls.Add(lastNameLabel);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(localeLabelText);
            this.Controls.Add(this.localeLabel);
            this.Controls.Add(this.labelRelashionship);
            this.Controls.Add(this.labelRalashionshipText);
            this.Controls.Add(this.labelFriendCount);
            this.Controls.Add(this.labelFriendCountText);
            this.Controls.Add(this.labelGender);
            this.Controls.Add(this.labelAge);
            this.Controls.Add(this.labelGenderText);
            this.Controls.Add(this.labelAgeText);
            this.Controls.Add(this.labelWelcomBack);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormUserDetails";
            this.Text = "FormUserDetails";
            ((System.ComponentModel.ISupportInitialize)(this.cityBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageNormalPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelWelcomBack;
        private System.Windows.Forms.Label labelAgeText;
        private System.Windows.Forms.Label labelGenderText;
        private System.Windows.Forms.Label labelAge;
        private System.Windows.Forms.Label labelGender;
        private System.Windows.Forms.Label labelFriendCount;
        private System.Windows.Forms.Label labelFriendCountText;
        private System.Windows.Forms.Label labelRalashionshipText;
        private System.Windows.Forms.Label labelRelashionship;
        private System.Windows.Forms.BindingSource userBindingSource;
        private System.Windows.Forms.BindingSource cityBindingSource;
        private System.Windows.Forms.Label birthdayLabel1;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.PictureBox imageNormalPictureBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.Label localeLabel;
        private System.Windows.Forms.Label nameLabel2;
        private System.Windows.Forms.Label nameLabel;
    }
}
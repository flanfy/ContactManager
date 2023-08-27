namespace ContactManager
{
    partial class FormAddContact
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
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.pcbContact = new System.Windows.Forms.PictureBox();
            this.btnAddPhoto = new System.Windows.Forms.Button();
            this.grbPhone = new System.Windows.Forms.GroupBox();
            this.cboPhoneType = new System.Windows.Forms.ComboBox();
            this.mskPhone = new System.Windows.Forms.MaskedTextBox();
            this.lblPhoneType = new System.Windows.Forms.Label();
            this.grbEmail = new System.Windows.Forms.GroupBox();
            this.cboEmailType = new System.Windows.Forms.ComboBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmailType = new System.Windows.Forms.Label();
            this.grbAddress = new System.Windows.Forms.GroupBox();
            this.cboAddressType = new System.Windows.Forms.ComboBox();
            this.mskZip = new System.Windows.Forms.MaskedTextBox();
            this.cboProvince = new System.Windows.Forms.ComboBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtStreet = new System.Windows.Forms.TextBox();
            this.lblZip = new System.Windows.Forms.Label();
            this.lblProvince = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblStreet = new System.Windows.Forms.Label();
            this.lblAddressType = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.pickPicture = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pcbContact)).BeginInit();
            this.grbPhone.SuspendLayout();
            this.grbEmail.SuspendLayout();
            this.grbAddress.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(203, 41);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(100, 20);
            this.txtLastName.TabIndex = 19;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(203, 15);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(100, 20);
            this.txtFirstName.TabIndex = 18;
            // 
            // pcbContact
            // 
            this.pcbContact.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pcbContact.Image = global::ContactManager.Properties.Resources.iconfinder_Artboard_18_3030707;
            this.pcbContact.InitialImage = global::ContactManager.Properties.Resources.iconfinder_Artboard_18_3030707;
            this.pcbContact.Location = new System.Drawing.Point(12, 12);
            this.pcbContact.Name = "pcbContact";
            this.pcbContact.Size = new System.Drawing.Size(114, 109);
            this.pcbContact.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbContact.TabIndex = 17;
            this.pcbContact.TabStop = false;
            // 
            // btnAddPhoto
            // 
            this.btnAddPhoto.Location = new System.Drawing.Point(228, 67);
            this.btnAddPhoto.Name = "btnAddPhoto";
            this.btnAddPhoto.Size = new System.Drawing.Size(75, 23);
            this.btnAddPhoto.TabIndex = 16;
            this.btnAddPhoto.Text = "Add Photo";
            this.btnAddPhoto.UseVisualStyleBackColor = true;
            this.btnAddPhoto.Click += new System.EventHandler(this.btnAddPhoto_Click);
            // 
            // grbPhone
            // 
            this.grbPhone.Controls.Add(this.cboPhoneType);
            this.grbPhone.Controls.Add(this.mskPhone);
            this.grbPhone.Controls.Add(this.lblPhoneType);
            this.grbPhone.Location = new System.Drawing.Point(12, 361);
            this.grbPhone.Name = "grbPhone";
            this.grbPhone.Size = new System.Drawing.Size(366, 77);
            this.grbPhone.TabIndex = 15;
            this.grbPhone.TabStop = false;
            this.grbPhone.Text = "Phone";
            // 
            // cboPhoneType
            // 
            this.cboPhoneType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPhoneType.FormattingEnabled = true;
            this.cboPhoneType.Items.AddRange(new object[] {
            "Business",
            "Personal"});
            this.cboPhoneType.Location = new System.Drawing.Point(259, 31);
            this.cboPhoneType.Name = "cboPhoneType";
            this.cboPhoneType.Size = new System.Drawing.Size(101, 21);
            this.cboPhoneType.TabIndex = 2;
            // 
            // mskPhone
            // 
            this.mskPhone.Location = new System.Drawing.Point(9, 32);
            this.mskPhone.Mask = "(000) 000-0000";
            this.mskPhone.Name = "mskPhone";
            this.mskPhone.Size = new System.Drawing.Size(105, 20);
            this.mskPhone.TabIndex = 1;
            // 
            // lblPhoneType
            // 
            this.lblPhoneType.AutoSize = true;
            this.lblPhoneType.Location = new System.Drawing.Point(219, 34);
            this.lblPhoneType.Name = "lblPhoneType";
            this.lblPhoneType.Size = new System.Drawing.Size(34, 13);
            this.lblPhoneType.TabIndex = 0;
            this.lblPhoneType.Text = "Type:";
            // 
            // grbEmail
            // 
            this.grbEmail.Controls.Add(this.cboEmailType);
            this.grbEmail.Controls.Add(this.txtEmail);
            this.grbEmail.Controls.Add(this.lblEmailType);
            this.grbEmail.Location = new System.Drawing.Point(12, 255);
            this.grbEmail.Name = "grbEmail";
            this.grbEmail.Size = new System.Drawing.Size(366, 100);
            this.grbEmail.TabIndex = 14;
            this.grbEmail.TabStop = false;
            this.grbEmail.Text = "Email";
            // 
            // cboEmailType
            // 
            this.cboEmailType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEmailType.FormattingEnabled = true;
            this.cboEmailType.Items.AddRange(new object[] {
            "Business",
            "Personal"});
            this.cboEmailType.Location = new System.Drawing.Point(259, 46);
            this.cboEmailType.Name = "cboEmailType";
            this.cboEmailType.Size = new System.Drawing.Size(101, 21);
            this.cboEmailType.TabIndex = 3;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(9, 46);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(204, 20);
            this.txtEmail.TabIndex = 2;
            // 
            // lblEmailType
            // 
            this.lblEmailType.AutoSize = true;
            this.lblEmailType.Location = new System.Drawing.Point(219, 50);
            this.lblEmailType.Name = "lblEmailType";
            this.lblEmailType.Size = new System.Drawing.Size(34, 13);
            this.lblEmailType.TabIndex = 0;
            this.lblEmailType.Text = "Type:";
            // 
            // grbAddress
            // 
            this.grbAddress.Controls.Add(this.cboAddressType);
            this.grbAddress.Controls.Add(this.mskZip);
            this.grbAddress.Controls.Add(this.cboProvince);
            this.grbAddress.Controls.Add(this.txtCity);
            this.grbAddress.Controls.Add(this.txtStreet);
            this.grbAddress.Controls.Add(this.lblZip);
            this.grbAddress.Controls.Add(this.lblProvince);
            this.grbAddress.Controls.Add(this.lblCity);
            this.grbAddress.Controls.Add(this.lblStreet);
            this.grbAddress.Controls.Add(this.lblAddressType);
            this.grbAddress.Location = new System.Drawing.Point(12, 127);
            this.grbAddress.Name = "grbAddress";
            this.grbAddress.Size = new System.Drawing.Size(366, 122);
            this.grbAddress.TabIndex = 13;
            this.grbAddress.TabStop = false;
            this.grbAddress.Text = "Address";
            // 
            // cboAddressType
            // 
            this.cboAddressType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAddressType.FormattingEnabled = true;
            this.cboAddressType.Items.AddRange(new object[] {
            "Business",
            "Personal"});
            this.cboAddressType.Location = new System.Drawing.Point(46, 14);
            this.cboAddressType.Name = "cboAddressType";
            this.cboAddressType.Size = new System.Drawing.Size(121, 21);
            this.cboAddressType.TabIndex = 12;
            // 
            // mskZip
            // 
            this.mskZip.Location = new System.Drawing.Point(312, 84);
            this.mskZip.Mask = ">L0L 0L0";
            this.mskZip.Name = "mskZip";
            this.mskZip.Size = new System.Drawing.Size(48, 20);
            this.mskZip.TabIndex = 11;
            // 
            // cboProvince
            // 
            this.cboProvince.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboProvince.FormattingEnabled = true;
            this.cboProvince.Items.AddRange(new object[] {
            "AB",
            "BC",
            "MB",
            "NB",
            "NL",
            "NS",
            "NT",
            "NU",
            "ON",
            "PE",
            "QC",
            "SK",
            "YT"});
            this.cboProvince.Location = new System.Drawing.Point(202, 84);
            this.cboProvince.Name = "cboProvince";
            this.cboProvince.Size = new System.Drawing.Size(60, 21);
            this.cboProvince.TabIndex = 10;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(47, 84);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(91, 20);
            this.txtCity.TabIndex = 7;
            // 
            // txtStreet
            // 
            this.txtStreet.Location = new System.Drawing.Point(47, 50);
            this.txtStreet.Name = "txtStreet";
            this.txtStreet.Size = new System.Drawing.Size(313, 20);
            this.txtStreet.TabIndex = 6;
            // 
            // lblZip
            // 
            this.lblZip.AutoSize = true;
            this.lblZip.Location = new System.Drawing.Point(281, 87);
            this.lblZip.Name = "lblZip";
            this.lblZip.Size = new System.Drawing.Size(25, 13);
            this.lblZip.TabIndex = 4;
            this.lblZip.Text = "Zip:";
            // 
            // lblProvince
            // 
            this.lblProvince.AutoSize = true;
            this.lblProvince.Location = new System.Drawing.Point(144, 87);
            this.lblProvince.Name = "lblProvince";
            this.lblProvince.Size = new System.Drawing.Size(52, 13);
            this.lblProvince.TabIndex = 3;
            this.lblProvince.Text = "Province:";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(6, 87);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(27, 13);
            this.lblCity.TabIndex = 2;
            this.lblCity.Text = "City:";
            // 
            // lblStreet
            // 
            this.lblStreet.AutoSize = true;
            this.lblStreet.Location = new System.Drawing.Point(6, 53);
            this.lblStreet.Name = "lblStreet";
            this.lblStreet.Size = new System.Drawing.Size(38, 13);
            this.lblStreet.TabIndex = 1;
            this.lblStreet.Text = "Street:";
            // 
            // lblAddressType
            // 
            this.lblAddressType.AutoSize = true;
            this.lblAddressType.Location = new System.Drawing.Point(6, 20);
            this.lblAddressType.Name = "lblAddressType";
            this.lblAddressType.Size = new System.Drawing.Size(34, 13);
            this.lblAddressType.TabIndex = 0;
            this.lblAddressType.Text = "Type:";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(139, 44);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(61, 13);
            this.lblLastName.TabIndex = 12;
            this.lblLastName.Text = "Last Name:";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(139, 18);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(60, 13);
            this.lblFirstName.TabIndex = 11;
            this.lblFirstName.Text = "First Name:";
            // 
            // btnSave
            // 
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSave.Location = new System.Drawing.Point(159, 463);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 20;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // FormAddContact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 509);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.pcbContact);
            this.Controls.Add(this.btnAddPhoto);
            this.Controls.Add(this.grbPhone);
            this.Controls.Add(this.grbEmail);
            this.Controls.Add(this.grbAddress);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblFirstName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormAddContact";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add Contact";
            ((System.ComponentModel.ISupportInitialize)(this.pcbContact)).EndInit();
            this.grbPhone.ResumeLayout(false);
            this.grbPhone.PerformLayout();
            this.grbEmail.ResumeLayout(false);
            this.grbEmail.PerformLayout();
            this.grbAddress.ResumeLayout(false);
            this.grbAddress.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.PictureBox pcbContact;
        private System.Windows.Forms.Button btnAddPhoto;
        private System.Windows.Forms.GroupBox grbPhone;
        private System.Windows.Forms.Label lblPhoneType;
        private System.Windows.Forms.GroupBox grbEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmailType;
        private System.Windows.Forms.GroupBox grbAddress;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtStreet;
        private System.Windows.Forms.Label lblZip;
        private System.Windows.Forms.Label lblProvince;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblStreet;
        private System.Windows.Forms.Label lblAddressType;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.ComboBox cboPhoneType;
        private System.Windows.Forms.MaskedTextBox mskPhone;
        private System.Windows.Forms.ComboBox cboEmailType;
        private System.Windows.Forms.MaskedTextBox mskZip;
        private System.Windows.Forms.ComboBox cboProvince;
        private System.Windows.Forms.ComboBox cboAddressType;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.OpenFileDialog pickPicture;
    }
}
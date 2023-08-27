namespace ContactManager
{
    partial class FormContactManager
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
            this.lstContacts = new System.Windows.Forms.ListBox();
            this.btnAddContact = new System.Windows.Forms.Button();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.grbAddress = new System.Windows.Forms.GroupBox();
            this.txtZip = new System.Windows.Forms.TextBox();
            this.txtProvince = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtStreet = new System.Windows.Forms.TextBox();
            this.txtAddressType = new System.Windows.Forms.TextBox();
            this.lblZip = new System.Windows.Forms.Label();
            this.lblProvince = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblStreet = new System.Windows.Forms.Label();
            this.lblAddressType = new System.Windows.Forms.Label();
            this.grbEmail = new System.Windows.Forms.GroupBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtEmailType = new System.Windows.Forms.TextBox();
            this.lblEmailType = new System.Windows.Forms.Label();
            this.grbPhone = new System.Windows.Forms.GroupBox();
            this.txtPhoneType = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblPhoneType = new System.Windows.Forms.Label();
            this.btnEditContact = new System.Windows.Forms.Button();
            this.pcbContact = new System.Windows.Forms.PictureBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.grbTakeNote = new System.Windows.Forms.GroupBox();
            this.btnAddNote = new System.Windows.Forms.Button();
            this.txtAddNote = new System.Windows.Forms.TextBox();
            this.grbNotes = new System.Windows.Forms.GroupBox();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.pnlContactDetails = new System.Windows.Forms.Panel();
            this.grbAddress.SuspendLayout();
            this.grbEmail.SuspendLayout();
            this.grbPhone.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbContact)).BeginInit();
            this.grbTakeNote.SuspendLayout();
            this.grbNotes.SuspendLayout();
            this.pnlContactDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstContacts
            // 
            this.lstContacts.FormattingEnabled = true;
            this.lstContacts.Location = new System.Drawing.Point(12, 12);
            this.lstContacts.Name = "lstContacts";
            this.lstContacts.Size = new System.Drawing.Size(120, 394);
            this.lstContacts.TabIndex = 0;
            this.lstContacts.SelectedIndexChanged += new System.EventHandler(this.lstContacts_SelectedIndexChanged);
            // 
            // btnAddContact
            // 
            this.btnAddContact.Location = new System.Drawing.Point(12, 415);
            this.btnAddContact.Name = "btnAddContact";
            this.btnAddContact.Size = new System.Drawing.Size(120, 23);
            this.btnAddContact.TabIndex = 1;
            this.btnAddContact.Text = "Add Contact";
            this.btnAddContact.UseVisualStyleBackColor = true;
            this.btnAddContact.Click += new System.EventHandler(this.btnAddContact_Click);
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(123, 11);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(60, 13);
            this.lblFirstName.TabIndex = 2;
            this.lblFirstName.Text = "First Name:";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(123, 37);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(61, 13);
            this.lblLastName.TabIndex = 3;
            this.lblLastName.Text = "Last Name:";
            // 
            // grbAddress
            // 
            this.grbAddress.Controls.Add(this.txtZip);
            this.grbAddress.Controls.Add(this.txtProvince);
            this.grbAddress.Controls.Add(this.txtCity);
            this.grbAddress.Controls.Add(this.txtStreet);
            this.grbAddress.Controls.Add(this.txtAddressType);
            this.grbAddress.Controls.Add(this.lblZip);
            this.grbAddress.Controls.Add(this.lblProvince);
            this.grbAddress.Controls.Add(this.lblCity);
            this.grbAddress.Controls.Add(this.lblStreet);
            this.grbAddress.Controls.Add(this.lblAddressType);
            this.grbAddress.Location = new System.Drawing.Point(3, 118);
            this.grbAddress.Name = "grbAddress";
            this.grbAddress.Size = new System.Drawing.Size(306, 122);
            this.grbAddress.TabIndex = 4;
            this.grbAddress.TabStop = false;
            this.grbAddress.Text = "Address";
            // 
            // txtZip
            // 
            this.txtZip.Location = new System.Drawing.Point(229, 76);
            this.txtZip.Name = "txtZip";
            this.txtZip.ReadOnly = true;
            this.txtZip.Size = new System.Drawing.Size(71, 20);
            this.txtZip.TabIndex = 9;
            // 
            // txtProvince
            // 
            this.txtProvince.Location = new System.Drawing.Point(156, 76);
            this.txtProvince.Name = "txtProvince";
            this.txtProvince.ReadOnly = true;
            this.txtProvince.Size = new System.Drawing.Size(31, 20);
            this.txtProvince.TabIndex = 8;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(47, 76);
            this.txtCity.Name = "txtCity";
            this.txtCity.ReadOnly = true;
            this.txtCity.Size = new System.Drawing.Size(51, 20);
            this.txtCity.TabIndex = 7;
            // 
            // txtStreet
            // 
            this.txtStreet.Location = new System.Drawing.Point(47, 47);
            this.txtStreet.Name = "txtStreet";
            this.txtStreet.ReadOnly = true;
            this.txtStreet.Size = new System.Drawing.Size(253, 20);
            this.txtStreet.TabIndex = 6;
            // 
            // txtAddressType
            // 
            this.txtAddressType.Location = new System.Drawing.Point(47, 17);
            this.txtAddressType.Name = "txtAddressType";
            this.txtAddressType.ReadOnly = true;
            this.txtAddressType.Size = new System.Drawing.Size(100, 20);
            this.txtAddressType.TabIndex = 5;
            // 
            // lblZip
            // 
            this.lblZip.AutoSize = true;
            this.lblZip.Location = new System.Drawing.Point(198, 79);
            this.lblZip.Name = "lblZip";
            this.lblZip.Size = new System.Drawing.Size(25, 13);
            this.lblZip.TabIndex = 4;
            this.lblZip.Text = "Zip:";
            // 
            // lblProvince
            // 
            this.lblProvince.AutoSize = true;
            this.lblProvince.Location = new System.Drawing.Point(104, 79);
            this.lblProvince.Name = "lblProvince";
            this.lblProvince.Size = new System.Drawing.Size(52, 13);
            this.lblProvince.TabIndex = 3;
            this.lblProvince.Text = "Province:";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(6, 79);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(27, 13);
            this.lblCity.TabIndex = 2;
            this.lblCity.Text = "City:";
            // 
            // lblStreet
            // 
            this.lblStreet.AutoSize = true;
            this.lblStreet.Location = new System.Drawing.Point(6, 50);
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
            // grbEmail
            // 
            this.grbEmail.Controls.Add(this.txtEmail);
            this.grbEmail.Controls.Add(this.txtEmailType);
            this.grbEmail.Controls.Add(this.lblEmailType);
            this.grbEmail.Location = new System.Drawing.Point(3, 246);
            this.grbEmail.Name = "grbEmail";
            this.grbEmail.Size = new System.Drawing.Size(306, 100);
            this.grbEmail.TabIndex = 5;
            this.grbEmail.TabStop = false;
            this.grbEmail.Text = "Email";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(9, 47);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.ReadOnly = true;
            this.txtEmail.Size = new System.Drawing.Size(144, 20);
            this.txtEmail.TabIndex = 2;
            // 
            // txtEmailType
            // 
            this.txtEmailType.Location = new System.Drawing.Point(200, 47);
            this.txtEmailType.Name = "txtEmailType";
            this.txtEmailType.ReadOnly = true;
            this.txtEmailType.Size = new System.Drawing.Size(100, 20);
            this.txtEmailType.TabIndex = 1;
            // 
            // lblEmailType
            // 
            this.lblEmailType.AutoSize = true;
            this.lblEmailType.Location = new System.Drawing.Point(159, 50);
            this.lblEmailType.Name = "lblEmailType";
            this.lblEmailType.Size = new System.Drawing.Size(34, 13);
            this.lblEmailType.TabIndex = 0;
            this.lblEmailType.Text = "Type:";
            // 
            // grbPhone
            // 
            this.grbPhone.Controls.Add(this.txtPhoneType);
            this.grbPhone.Controls.Add(this.txtPhone);
            this.grbPhone.Controls.Add(this.lblPhoneType);
            this.grbPhone.Location = new System.Drawing.Point(3, 352);
            this.grbPhone.Name = "grbPhone";
            this.grbPhone.Size = new System.Drawing.Size(306, 91);
            this.grbPhone.TabIndex = 6;
            this.grbPhone.TabStop = false;
            this.grbPhone.Text = "Phone";
            // 
            // txtPhoneType
            // 
            this.txtPhoneType.Location = new System.Drawing.Point(201, 42);
            this.txtPhoneType.Name = "txtPhoneType";
            this.txtPhoneType.ReadOnly = true;
            this.txtPhoneType.Size = new System.Drawing.Size(100, 20);
            this.txtPhoneType.TabIndex = 2;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(9, 42);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.ReadOnly = true;
            this.txtPhone.Size = new System.Drawing.Size(144, 20);
            this.txtPhone.TabIndex = 1;
            // 
            // lblPhoneType
            // 
            this.lblPhoneType.AutoSize = true;
            this.lblPhoneType.Location = new System.Drawing.Point(159, 45);
            this.lblPhoneType.Name = "lblPhoneType";
            this.lblPhoneType.Size = new System.Drawing.Size(34, 13);
            this.lblPhoneType.TabIndex = 0;
            this.lblPhoneType.Text = "Type:";
            // 
            // btnEditContact
            // 
            this.btnEditContact.Location = new System.Drawing.Point(234, 89);
            this.btnEditContact.Name = "btnEditContact";
            this.btnEditContact.Size = new System.Drawing.Size(75, 23);
            this.btnEditContact.TabIndex = 7;
            this.btnEditContact.Text = "Edit Contact";
            this.btnEditContact.UseVisualStyleBackColor = true;
            this.btnEditContact.Click += new System.EventHandler(this.btnEditContact_Click);
            // 
            // pcbContact
            // 
            this.pcbContact.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pcbContact.Image = global::ContactManager.Properties.Resources.iconfinder_Artboard_18_30307071;
            this.pcbContact.Location = new System.Drawing.Point(3, 3);
            this.pcbContact.Name = "pcbContact";
            this.pcbContact.Size = new System.Drawing.Size(114, 109);
            this.pcbContact.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbContact.TabIndex = 8;
            this.pcbContact.TabStop = false;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(189, 8);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.ReadOnly = true;
            this.txtFirstName.Size = new System.Drawing.Size(120, 20);
            this.txtFirstName.TabIndex = 9;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(189, 34);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.ReadOnly = true;
            this.txtLastName.Size = new System.Drawing.Size(120, 20);
            this.txtLastName.TabIndex = 10;
            // 
            // grbTakeNote
            // 
            this.grbTakeNote.Controls.Add(this.btnAddNote);
            this.grbTakeNote.Controls.Add(this.txtAddNote);
            this.grbTakeNote.Location = new System.Drawing.Point(315, 6);
            this.grbTakeNote.Name = "grbTakeNote";
            this.grbTakeNote.Size = new System.Drawing.Size(369, 234);
            this.grbTakeNote.TabIndex = 11;
            this.grbTakeNote.TabStop = false;
            this.grbTakeNote.Text = "Take a Note";
            // 
            // btnAddNote
            // 
            this.btnAddNote.Location = new System.Drawing.Point(288, 211);
            this.btnAddNote.Name = "btnAddNote";
            this.btnAddNote.Size = new System.Drawing.Size(75, 23);
            this.btnAddNote.TabIndex = 1;
            this.btnAddNote.Text = "Add note";
            this.btnAddNote.UseVisualStyleBackColor = true;
            this.btnAddNote.Click += new System.EventHandler(this.btnAddNote_Click);
            // 
            // txtAddNote
            // 
            this.txtAddNote.Location = new System.Drawing.Point(6, 19);
            this.txtAddNote.Multiline = true;
            this.txtAddNote.Name = "txtAddNote";
            this.txtAddNote.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtAddNote.Size = new System.Drawing.Size(357, 185);
            this.txtAddNote.TabIndex = 0;
            // 
            // grbNotes
            // 
            this.grbNotes.Controls.Add(this.txtNotes);
            this.grbNotes.Location = new System.Drawing.Point(315, 246);
            this.grbNotes.Name = "grbNotes";
            this.grbNotes.Size = new System.Drawing.Size(369, 197);
            this.grbNotes.TabIndex = 12;
            this.grbNotes.TabStop = false;
            this.grbNotes.Text = "Notes";
            // 
            // txtNotes
            // 
            this.txtNotes.Location = new System.Drawing.Point(6, 19);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.ReadOnly = true;
            this.txtNotes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtNotes.Size = new System.Drawing.Size(357, 172);
            this.txtNotes.TabIndex = 0;
            // 
            // pnlContactDetails
            // 
            this.pnlContactDetails.Controls.Add(this.grbAddress);
            this.pnlContactDetails.Controls.Add(this.grbNotes);
            this.pnlContactDetails.Controls.Add(this.lblFirstName);
            this.pnlContactDetails.Controls.Add(this.grbTakeNote);
            this.pnlContactDetails.Controls.Add(this.lblLastName);
            this.pnlContactDetails.Controls.Add(this.txtLastName);
            this.pnlContactDetails.Controls.Add(this.grbEmail);
            this.pnlContactDetails.Controls.Add(this.txtFirstName);
            this.pnlContactDetails.Controls.Add(this.grbPhone);
            this.pnlContactDetails.Controls.Add(this.pcbContact);
            this.pnlContactDetails.Controls.Add(this.btnEditContact);
            this.pnlContactDetails.Enabled = false;
            this.pnlContactDetails.Location = new System.Drawing.Point(138, 12);
            this.pnlContactDetails.Name = "pnlContactDetails";
            this.pnlContactDetails.Size = new System.Drawing.Size(694, 450);
            this.pnlContactDetails.TabIndex = 13;
            // 
            // FormContactManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 467);
            this.Controls.Add(this.pnlContactDetails);
            this.Controls.Add(this.btnAddContact);
            this.Controls.Add(this.lstContacts);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormContactManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contact Manager";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormContactManager_Close);
            this.Load += new System.EventHandler(this.FormContactManager_Load);
            this.grbAddress.ResumeLayout(false);
            this.grbAddress.PerformLayout();
            this.grbEmail.ResumeLayout(false);
            this.grbEmail.PerformLayout();
            this.grbPhone.ResumeLayout(false);
            this.grbPhone.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbContact)).EndInit();
            this.grbTakeNote.ResumeLayout(false);
            this.grbTakeNote.PerformLayout();
            this.grbNotes.ResumeLayout(false);
            this.grbNotes.PerformLayout();
            this.pnlContactDetails.ResumeLayout(false);
            this.pnlContactDetails.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstContacts;
        private System.Windows.Forms.Button btnAddContact;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.GroupBox grbAddress;
        private System.Windows.Forms.TextBox txtZip;
        private System.Windows.Forms.TextBox txtProvince;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtStreet;
        private System.Windows.Forms.TextBox txtAddressType;
        private System.Windows.Forms.Label lblZip;
        private System.Windows.Forms.Label lblProvince;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblStreet;
        private System.Windows.Forms.Label lblAddressType;
        private System.Windows.Forms.GroupBox grbEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtEmailType;
        private System.Windows.Forms.Label lblEmailType;
        private System.Windows.Forms.GroupBox grbPhone;
        private System.Windows.Forms.TextBox txtPhoneType;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblPhoneType;
        private System.Windows.Forms.Button btnEditContact;
        private System.Windows.Forms.PictureBox pcbContact;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.GroupBox grbTakeNote;
        private System.Windows.Forms.Button btnAddNote;
        private System.Windows.Forms.TextBox txtAddNote;
        private System.Windows.Forms.GroupBox grbNotes;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.Panel pnlContactDetails;
    }
}


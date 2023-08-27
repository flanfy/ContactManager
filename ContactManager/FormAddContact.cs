/* FormAddContact.cs
 * Form that lets a user enter information about a contact
 * 
 * Revision History
 *      Phillip Lu, 2020.08.04: Created
 * 
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContactManager
{
    /// <summary>
    /// form that accepts user input for a new contact or editing an existing contact
    /// </summary>
    public partial class FormAddContact : Form
    {
        //constructors
        /// <summary>
        /// Constructor - form that accepts user input for contact info
        /// </summary>
        public FormAddContact()
        {
            InitializeComponent();
        }

        //properties
        private StringBuilder contactInfo = new StringBuilder();
        /// <summary>
        /// string containing all contact info entered by user
        /// </summary>
        public StringBuilder ContactInfo
        {
            get => contactInfo;
        }

        private string photoFileName = "";

        //methods
        /// <summary>
        /// fills fields with info of currently selected contact  
        /// </summary>
        /// <param name="SelectedContact"></param>
        public void Edit(Contact SelectedContact)
        {
            this.Text = "Edit Contact";

            //name
            txtFirstName.Text = SelectedContact.FirstName;
            txtLastName.Text = SelectedContact.LastName;

            //photo
            if (SelectedContact.PhotoFileName != "")
            {
                photoFileName = SelectedContact.PhotoFileName;
                pcbContact.Image = Image.FromFile(photoFileName);
            }

            //address
            cboAddressType.SelectedItem = SelectedContact.AddressType;
            txtStreet.Text = SelectedContact.Street;
            txtCity.Text = SelectedContact.City;
            cboProvince.SelectedItem = SelectedContact.Province;
            mskZip.Text = SelectedContact.Zip;

            //email
            cboEmailType.SelectedItem = SelectedContact.EmailType;
            txtEmail.Text = SelectedContact.Email;

            //phone
            cboPhoneType.SelectedItem = SelectedContact.PhoneType;
            mskPhone.Text = SelectedContact.Phone;
        }

        /// <summary>
        /// adds all contact info to a string delimited by |
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            //Error message appears if name not entered
            if (txtFirstName.TextLength == 0 || txtLastName.TextLength == 0)
            {
                DialogResult = DialogResult.None;
                DialogResult result = MessageBox.Show($"Please fill first and last name fields", "Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else
            {
                //convert contact info to a string
                //name textboxes + picture 
                contactInfo.Append($"{txtFirstName.Text}|");
                contactInfo.Append($"{txtLastName.Text}|");
                contactInfo.Append($"{photoFileName}|");

                //comboboxes
                List<ComboBox> cboList = new List<ComboBox>(4) {cboAddressType, cboProvince, cboEmailType, cboPhoneType};
                List<string> cboStrings = new List<string>(4) {"", "", "", ""};

                //checks if an option has been selected for all combo boxes
                for (int i = 0; i < 4; i++)
                {
                    if (cboList[i].SelectedIndex != -1)
                    {
                        cboStrings[i] = cboList[i].SelectedItem.ToString();
                    }

                    contactInfo.Append($"{cboStrings[i]}|");

                    //remaining textboxes
                    switch (i)
                    {
                        case 0: //addresstype
                            contactInfo.Append($"{txtStreet.Text}|");
                            contactInfo.Append($"{txtCity.Text}|");
                            break;

                        case 1: //province
                            contactInfo.Append($"{mskZip.Text}|");
                            break;

                        case 2: //emailtype
                            contactInfo.Append($"{txtEmail.Text}|");
                            break;

                        case 3: //phonetype
                            contactInfo.Append($"{mskPhone.Text}|");
                            break;
                    }
                }
            }
        }

        /// <summary>
        /// Lets user choose a picture for the contact
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddPhoto_Click(object sender, EventArgs e)
        {
            pickPicture.Filter = "Image Files (*.jpeg;*.jpg;*.png)|*.jpeg;*.jpg;*.png";

            if (pickPicture.ShowDialog() == DialogResult.OK)
            {
                //get photo filename
                photoFileName = pickPicture.FileName;
                pcbContact.Image = Image.FromFile(photoFileName);
            }
        }
    }
}

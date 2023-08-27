/* FormContactManager.cs
 * contact manager program that allows users to create and view contacts and add notes
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
using System.IO;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContactManager
{
    /// <summary>
    /// form that shows contact info and notes;
    /// allows for adding/editing contacts and adding notes;
    /// writes all info to file upon exit
    /// </summary>
    internal partial class FormContactManager : Form
    {
        //constructors
        /// <summary>
        /// Constructor - creates form list of contacts and binds it to lstContacts
        /// </summary>
        internal FormContactManager()
        {
            InitializeComponent();
            contactList = new BindingList<Contact>();
            lstContacts.DataSource = contactList;
        }

        //properties
        private BindingList<Contact> contactList;
        /// <summary>
        /// list of contacts; tied to lstContacts
        /// </summary>
        internal BindingList<Contact> ContactList
        {
            get => contactList;
        }

        private Contact selectedContact;
        /// <summary>
        /// currently selected contact in lstContacts
        /// </summary>
        internal Contact SelectedContact
        {
            get => selectedContact;
        }

        private bool edit = false; //changes FormAddContact to edit mode if true
        private ContactRecord contactRecord = new ContactRecord();

        //methods
        /// <summary>
        /// Displays FormAddContact in add contact mode if edit is false; 
        /// displays form in edit mode otherwise
        /// </summary>
        private void DisplayChildForm()
        {
            FormAddContact child = new FormAddContact();

            //edit mode
            if (edit == true)
            {
                child.Edit(SelectedContact); 
            }

            if (child.ShowDialog(this) == DialogResult.OK)
            {
                if (edit == true)
                {
                    //if name was edited, does not update in listbox until program restarted, not sure how to fix
                    ContactList[lstContacts.SelectedIndex].OverwriteContact(child.ContactInfo);
                }

                else
                {
                    //split contact info string and create object
                    string[] contactFields = new string[12];
                    contactFields = child.ContactInfo.ToString().Split('|');

                    Contact contact = new Contact(
                    contactFields[0],
                    contactFields[1],
                    contactFields[2],
                    contactFields[3],
                    contactFields[4],
                    contactFields[5],
                    contactFields[6],
                    contactFields[7],
                    contactFields[8],
                    contactFields[9],
                    contactFields[10],
                    contactFields[11]);

                    contactList.Add(contact);
                    lstContacts.SelectedIndex = ContactList.Count - 1; //focus on new contact
                }
            }
            DisplayContactInfo();
        }

        /// <summary>
        /// Displays info of currently selected contact in lstContacts;
        /// displays blank fields and default contact picture if fields empty
        /// </summary>
        private void DisplayContactInfo()
        {
            selectedContact = lstContacts.SelectedItem as Contact;

            //name
            txtFirstName.Text = selectedContact.FirstName;
            txtLastName.Text = selectedContact.LastName;

            //photo
            if (selectedContact.PhotoFileName != "")
            {
                pcbContact.Image = Image.FromFile(selectedContact.PhotoFileName);
            }
            else
            {
                pcbContact.Image = ContactManager.Properties.Resources.iconfinder_Artboard_18_30307071;
            }

            //address
            txtStreet.Text = selectedContact.Street;
            txtAddressType.Text = selectedContact.AddressType.ToString();
            txtCity.Text = selectedContact.City;
            txtProvince.Text = selectedContact.Province;
            txtZip.Text = selectedContact.Zip;

            //email
            txtEmailType.Text = selectedContact.EmailType.ToString();
            txtEmail.Text = selectedContact.Email;

            //phone
            txtPhoneType.Text = selectedContact.PhoneType.ToString();
            txtPhone.Text = selectedContact.Phone;

            //notes
            DisplayNotes();

            pnlContactDetails.Enabled = true;
        }

        /// <summary>
        /// Displays current contact's notes from newest to oldest
        /// </summary>
        private void DisplayNotes()
        {
            txtNotes.Clear();
            ContactList[lstContacts.SelectedIndex].NoteList.Reverse(); //reverse list to newest - oldest

            foreach (Note line in ContactList[lstContacts.SelectedIndex].NoteList)
            {
                txtNotes.Text += $"{line.ToString()}\r\n\r\n";
            }

            ContactList[lstContacts.SelectedIndex].NoteList.Reverse(); //reset list to oldest - newest
        }

        /// <summary>
        /// opens FormAddContact and lets user enters contact info
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddContact_Click(object sender, EventArgs e)
        {
            edit = false;
            DisplayChildForm();
        }

        /// <summary>
        /// opens FormAddContact in edit mode
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEditContact_Click(object sender, EventArgs e)
        {
            edit = true;
            DisplayChildForm();
        }

        /// <summary>
        /// updates boxes with info of currently selected contact
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lstContacts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstContacts.SelectedIndex != -1)
            {
                txtAddNote.Clear();
                DisplayContactInfo();
            }
        }

        /// <summary>
        /// Adds note to contact's note list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddNote_Click(object sender, EventArgs e)
        {
            ContactList[lstContacts.SelectedIndex].AddNote(
                ContactList, 
                txtAddNote.Text, 
                DateTime.Now.ToString(), 
                lstContacts.SelectedIndex);

            txtAddNote.Clear();
            DisplayNotes();
        }

        /// <summary>
        /// Loads contacts and notes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormContactManager_Load(object sender, EventArgs e)
        {
            if (File.Exists("contact_record.txt"))
            {
                contactRecord.LoadContacts(ContactList);   
                if (ContactList.Count != 0)
                {
                    DisplayContactInfo();
                }
            }
        }

        /// <summary>
        /// Saves contacts and notes when FormContactManager is closed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormContactManager_Close(object sender, FormClosingEventArgs e)
        {
            contactRecord.SaveContacts(ContactList);
        }
    }
}

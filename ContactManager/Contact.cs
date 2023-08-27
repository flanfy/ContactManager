/* Contact.cs
 * Contains information about each contact
 * 
 * Revision History
 *      Phillip Lu, 2020.08.04: Created
 * 
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ContactManager
{
    /// <summary>
    /// holds contact objects with contact info and methods for editing contacts and adding notes
    /// </summary>
    public class Contact
    {
        //constructors
        /// <summary>
        /// Constructor - creates contact with user provided info for:
        /// first and last name, picture, address, email and phone
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="photoFileName"></param>
        /// <param name="addressType"></param>
        /// <param name="street"></param>
        /// <param name="city"></param>
        /// <param name="province"></param>
        /// <param name="zip"></param>
        /// <param name="emailType"></param>
        /// <param name="email"></param>
        /// <param name="phoneType"></param>
        /// <param name="phone"></param>
        public Contact(string firstName,
            string lastName,
            string photoFileName,
            string addressType,
            string street,
            string city,
            string province,
            string zip,
            string emailType,
            string email,
            string phoneType,
            string phone)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.photoFileName = photoFileName;
            this.addressType = addressType;
            this.street = street;
            this.city = city;
            this.province = province;
            this.zip = zip;
            this.emailType = emailType;
            this.email = email;
            this.phoneType = phoneType;
            this.phone = phone;
        }

        //properties
        private List<Note> noteList = new List<Note>();
        /// <summary>
        /// creates a list of notes for a contact
        /// </summary>
        public List<Note> NoteList
        {
            get => noteList;
        }

        private string firstName;
        /// <summary>
        /// contact's first name; required
        /// </summary>
        public string FirstName
        {
            get => firstName;
        }

        private string lastName;
        /// <summary>
        /// contact's last name; required
        /// </summary>
        public string LastName
        {
            get => lastName;
        }

        private string photoFileName;
        /// <summary>
        /// user selected image file filename; optional
        /// </summary>
        public string PhotoFileName
        {
            get => photoFileName;
        }
        
        private string addressType;
        /// <summary>
        /// business/personal; optional
        /// </summary>
        public string AddressType
        {
            get => addressType;
        }

        private string street;
        /// <summary>
        /// contact's street address; optional
        /// </summary>
        public string Street
        {
            get => street;
        }

        private string city;
        /// <summary>
        /// contact's city; optional
        /// </summary>
        public string City 
        {
            get => city;
        }

        private string province;
        /// <summary>
        /// contact's province; optional
        /// </summary>
        public string Province
        {
            get => province;
        }

        private string zip;
        /// <summary>
        /// contact's ZIP code; format N1N 1N1 required; optional
        /// </summary>
        public string Zip
        {
            get => zip;
        }

        private string email;
        /// <summary>
        /// contact's email; optional
        /// </summary>
        public string Email
        {
            get => email;
        }

        private string emailType;
        /// <summary>
        /// business/personal; optional
        /// </summary>
        public string EmailType
        {
            get => emailType;
        }

        private string phone;
        /// <summary>
        /// contact's phone number; format (111) 111-1111 required; optional
        /// </summary>
        public string Phone
        {
            get => phone;
        }

        private string phoneType;
        /// <summary>
        /// business/personal; optional
        /// </summary>
        public string PhoneType
        {
            get => phoneType;
        }

        //methods
        /// <summary>
        /// ToString override for lstContacts
        /// </summary>
        /// <returns>last name, first name</returns>
        public override string ToString()
        {
            return $"{lastName}, {firstName}";
        }

        /// <summary>
        /// updates contact fields 
        /// </summary>
        public void OverwriteContact(StringBuilder ContactInfo)
        {
            string[] contactFields = new string[12];
            contactFields = ContactInfo.ToString().Split('|');
            firstName = contactFields[0];
            lastName = contactFields[1];
            photoFileName = contactFields[2];
            addressType = contactFields[3];
            street = contactFields[4];
            city = contactFields[5];
            province = contactFields[6];
            zip = contactFields[7];
            emailType = contactFields[8];
            email = contactFields[9];
            phoneType = contactFields[10];
            phone = contactFields[11];
        }

        /// <summary>
        /// adds note to contact's note list
        /// </summary>
        /// <param name="ContactList">list of contacts</param>
        /// <param name="noteText">text of note</param>
        /// <param name="noteDate">time when note was taken</param>
        /// <param name="currentContact">currently selected contact in lstContacts</param>
        public void AddNote(BindingList<Contact> ContactList, string noteText, string noteDate, int currentContact)
        {
            Note note = new Note(noteText, noteDate);
            ContactList[currentContact].NoteList.Add(note);
        }
    }
}

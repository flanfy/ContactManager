/* ContactRecord.cs
 * contains info related to the text files including saving/loading
 * 
 * Revision History
 *      Phillip Lu, 2020.08.04: Created
 * 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ContactManager
{
    /// <summary>
    /// holds contact record object that contains contact record filename 
    /// and methods for saving/loading contacts/notes from file
    /// </summary>
    class ContactRecord
    {
        //constructors
        /// <summary>
        /// Constructor - empty
        /// </summary>
        public ContactRecord()
        {

        }

        //properties
        private string fileName = "contact_record.txt";
        /// <summary>
        /// Filename of text file where contact details are saved in
        /// </summary>
        public string FileName
        {
            get => fileName;
        }

        //methods
        /// <summary>
        /// Save all contacts into a file and each contact's notes into separate files
        /// </summary>
        /// <param name="ContactList">list of contacts</param>
        public void SaveContacts(BindingList<Contact> ContactList)
        {
            //contacts
            OverwriteFile(FileName);

            //write to file
            using (StreamWriter writer = new StreamWriter(FileName, true))
            {
                foreach (var contact in ContactList)
                {
                    writer.WriteLine($"{contact.FirstName}|" +
                        $"{contact.LastName}|" +
                        $"{contact.PhotoFileName}|" +
                        $"{contact.AddressType}|" +
                        $"{contact.Street}|" +
                        $"{contact.City}|" +
                        $"{contact.Province}|" +
                        $"{contact.Zip}|" +
                        $"{contact.EmailType}|" +
                        $"{contact.Email}|" +
                        $"{contact.PhoneType}|" +
                        $"{contact.Phone}");
                }
            }

            //notes
            for (int i = 0; i < ContactList.Count; i++)
            {
                OverwriteFile($"contact_notes-{ContactList[i].LastName},{ContactList[i].FirstName}.txt");
                OverwriteFile($"contact{i}_notes.txt");

                //write to file
                using (StreamWriter writer = new StreamWriter($"contact{i}_notes.txt", true))
                {
                    foreach (var note in ContactList[i].NoteList)
                    {
                        writer.WriteLine($"{note.NoteDate}|{note.NoteText}");
                    }
                }
            }
        }

        /// <summary>
        /// Retrieve contacts and notes from files and populate list
        /// </summary>
        /// <param name="ContactList">list of contacts</param>
        public void LoadContacts(BindingList<Contact> ContactList)
        {
            //load contacts
            string[] contacts = File.ReadAllLines(FileName);
            string[] contactFields = new string[contacts.Length];

            if (contacts.Length != 0)
            {
                for (int i = 0; i < contacts.Length; i++)
                {
                    contactFields = contacts[i].Split('|');
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
                    ContactList.Add(contact);

                    //load notes
                    if (File.Exists($"contact{i}_notes.txt"))
                    {
                        string[] notes = File.ReadAllLines($"contact{i}_notes.txt");
                        int noteCount = notes.Length;
                        string[] noteFields = new string[noteCount];

                        for (int j = 0; j < noteCount; j++)
                        {
                            noteFields = notes[j].Split('|');
                            Note note = new Note(noteFields[1], noteFields[0]);
                            ContactList[i].NoteList.Add(note);
                        }
                    }
                }
            } 
        }

        /// <summary>
        /// Clears all text in file
        /// </summary>
        /// <param name="FileName">contact's photo filename</param>
        private void OverwriteFile(string FileName)
        {
            if (File.Exists(FileName))
            {
                File.WriteAllText(FileName, String.Empty);
            }
        }
    }
}

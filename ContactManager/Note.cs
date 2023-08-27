/* Note.cs
 * Contains note text and timestamps
 * 
 * Revision History
 *      Phillip Lu, 2020.08.04: Created
 * 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactManager
{
    /// <summary>
    /// holds separate note objects for a contact
    /// </summary>
    public class Note
    {
        //constructors
        /// <summary>
        /// Constructor - creates note with user provided text and current timestamp
        /// </summary>
        /// <param name="noteText">text of note</param>
        /// <param name="noteDate">date note was taken</param>
        public Note(string noteText, string noteDate)
        {
            this.noteText = noteText;
            this.noteDate = noteDate;
        }

        //properties
        private string noteDate;
        /// <summary>
        /// date when note was recorded
        /// </summary>
        public string NoteDate
        {
            get => noteDate;
        }

        private string noteText;
        /// <summary>
        /// usuer inputted note for a contact
        /// </summary>
        public string NoteText
        {
            get => noteText;
        }

        //methods
        /// <summary>
        /// ToString override for txtNotes
        /// </summary>
        /// <returns>date and text</returns>
        public override string ToString()
        {
            return $"{noteDate}\r\n{noteText}";
        }
    }
}

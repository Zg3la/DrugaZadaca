using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadaca2
{
    public class NoteCollection
    {
        public string Author { get; private set; }
        public List<Note> notes;

        public NoteCollection(string author)
        {
            Author = author;
            notes = new List<Note>();
        }

        public void Add(Note note)
        {
            notes.Add(note);
        }

    }
}

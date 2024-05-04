using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadaca2
{
    public class Note
    {
        public string Title { get; set; }
        public string Text { get; set; }
        public DateTime Creation { get; private set; }

        public Note(string title, string text)
        {
            Title = title;
            Text = text;
            Creation = DateTime.Now;
        }

    }
}

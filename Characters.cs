using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadaca2
{
    public class Characters
    {
        public List<char> FineUniques(string text)
        {
            List<char> Uniques = new List<char>();
            for (int i = 0;i< text.Length;i++)
            {
                if (CountOccurence(text, text[i]) == 1)
                {
                    Uniques.Add(text[i]);
                }
            }
            return Uniques;
        }

        public int CountOccurence(string text, char letter) 
        {
            int occurrenceCount = 0;
            for(int i = 0;i < text.Length;i++)
            {
                if (text[i] == letter)
                {
                    occurrenceCount += 1;
                }

            }
            return occurrenceCount;
        }
    }
}

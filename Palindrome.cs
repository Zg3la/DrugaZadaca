using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadaca2
{
    public class Palindrome
    {
        public List<string> FindPalindromes(List<string> words)
        {
            List<string> Palindromes = new List<string>();
                
            foreach (string word in words)
            {
                if(IsPalindrome(word))
                {
                    Palindromes.Add(word);
                }
               
            }
            return Palindromes;
        }

        public bool IsPalindrome(string word )
        {
            string normal = word.Replace(" ", "").ToLower();
            string reversed = new string(normal.Reverse().ToArray());

            return normal.Equals(reversed);

        }
    }

    
}

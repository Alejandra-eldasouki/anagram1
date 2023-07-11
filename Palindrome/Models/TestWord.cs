using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Palindrome.Models
{
    public class TestWord
    {
        public string Word { get; set; }
        
        public TestWord(string input)
        {
            Word = input;
        }

        public string IsPalindrome()
        {
             return Word.ToLower(); 
        }
    }
}
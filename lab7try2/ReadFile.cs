using System;
using System.Collections.Generic;
using System.Linq;

namespace lab7try2
{
    public class ReadFile
    {
        private string[] lines;
        
        public ReadFile(string fileName)
        {
            lines = System.IO.File.ReadAllLines(fileName);
        }

       
        
        public List<string> SearchInDictionary(string[] words)
        {
            List<string> list_of_strings = new List<string>(); 
           // foreach (var line in lines)
           // {
                foreach (var word in words)
                {
                    if (lines.Contains(word))
                    {
                        list_of_strings.Add(word);
                    }
                }
           // }
            return list_of_strings;
        }

        public void PrintOddWords(List<string> list_of_strings)
        {
            foreach (var single_string in list_of_strings)
            {
                Console.WriteLine(single_string);
            }
        }
        
      
    }
}
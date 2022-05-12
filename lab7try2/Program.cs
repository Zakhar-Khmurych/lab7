using System;

namespace lab7try2
{
    class Program
    {
        
        public static string fileName = @"C:\Users\HP\RiderProjects\lab6try1\data_edited.txt";

        static void Main(string[] args)
        {
            
            ReadFile text_to_analyze = new ReadFile(fileName);

            string input_text;
            input_text = Console.ReadLine();
            
            
            string[] words = input_text.Split(" ");

          //  Console.WriteLine(text_to_analyze.SearchInDictionary(words));
          
            //text_to_analyze.SearchInDictionary(words);
            text_to_analyze.PrintOddWords(text_to_analyze.SearchInDictionary(words));

        }
    }
}
using System;

namespace lab7try2
{
    public class TableOfCommons
    {
        private int[,] Table;
        

        public TableOfCommons(int length)
        {
            
            Table = new int[length,length];

            for(int row = 0; row < length; row++)
            {
                for (int column = 0; column < length; column++)
                {
                    Console.Write(Table[row,column] + " ");
                }
                Console.WriteLine("");
                
            }
        }
        
    }
}
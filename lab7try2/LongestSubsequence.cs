namespace lab7try2
{
    public class LongestSubsequence
    {
        
        public static string FindCommon(string a, string b)
        {
            int maxlength;

            if (a.Length > b.Length)
            {
                maxlength = a.Length;
            }
            else
            {
                maxlength = b.Length;
            }

            char[] copyA;
            char[] copyB;

            copyA = new char[maxlength];
            copyB = new char[maxlength];


            for (int i = 0; i < maxlength; i++)
            {
                copyA[i] = a[i];
            }
            for (int i = 0; i < maxlength; i++)
            {
                copyB[i] = b[i];
            }

            string res = "";


            for (int i = 0; i < maxlength; i++)
            {
                for (int j = 0; j < maxlength; j++)
                {
                    if (copyA[i] == copyB[j])
                    {
                        res += copyA[i];
                    }
                }
                
            }

            return res;
            
            
            


            // string aCopy = new string[];

        } 
    }
}
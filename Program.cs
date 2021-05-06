using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace encrypte_1
{
    static class Program
    {
        static string password = "7612803954";
        static char[] letter = password.ToCharArray();
        static char[] input = null;
        static string output = null;

     public static int get_kay(string kay)
        {
            int r=0;
            input = kay.ToCharArray();
            for (int i =0; i< input.Length;i++)
            {
                for(int j =0; j<10;j++)
                {
                    if (input[i] == letter[j])
                    { r = j; }
                }

            }
            return r;
        }
        public static string encryption (string plain_text , int key)
        {
            input = plain_text.ToCharArray();
            for (int i = 0; i < input.Length; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (input[i] == letter[j])
                    { 
                        input[i] = letter[(i + key) % 10];
                        break;
                    }
                }

            }
            output = new string(input);
            return output;
        }
    }
}

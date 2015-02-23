using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Guess what I think about:  ");
            Dictionary<int, string> searchWithinThis = new Dictionary<int, string>();
            searchWithinThis.Add(0, "program");
            searchWithinThis.Add(1, "developer");
            searchWithinThis.Add(2, "adm");
            searchWithinThis.Add(3, "play");
            searchWithinThis.Add(4, "student");
            string str = "";
            char[] ch = new char[searchWithinThis.Count];
            string st = "";
            char st_ch = ' ';

            List<char> temp = new List<char>();
            //to fix a proper place , find a word in dictionary by chance & put the word in a string variable

            Random ran = new Random();
            int result = ran.Next(0, searchWithinThis.Count);
            str = searchWithinThis[result];
            for (int p = 0; p < str.Length; p++)
            {
                Console.SetCursorPosition(p, 3);
                Console.Write("-");
            }

            Console.WriteLine();
            //convert string to char

            ch = str.ToCharArray();
            //enter the characters , here you have 2 more possibility to enter characters
            int correctAnswer = 0;
            int counter = str.Length + 2;
            for (int j = 0; (j <= str.Length + 1) && (correctAnswer != str.Length); j++)
            {
                Console.SetCursorPosition(j, 5);
                st = Console.ReadLine();
                counter--;
                while (st == "")
                {

                    st = Console.ReadLine();
                }

                //if (st=="")
                //{ continue; }
                st_ch = st.First();

                for (int k = 0; k < ch.Length; k++)
                {
                    if (ch[k] == st_ch)
                    {
                        correctAnswer++;
                        int te = str.IndexOf(st_ch, k);
                        Console.SetCursorPosition(k, 3);
                        Console.Write(st_ch);
                        Console.WriteLine();
                    }
                }

                Console.SetCursorPosition(0, 8);
                Console.Write("How many times are left: {0:d2}" , counter);
            }
            Console.SetCursorPosition(0, 15);
            if (correctAnswer == str.Length)
            {
                Console.Write("Congratulation");
            }
            else
            {
                Console.Write(" this is what i think to: " + str);
            }
            Console.Read();
        }
    }
}

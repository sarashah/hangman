using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace with_list
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Guess what I think about:  ");
            string searchWithinThis = "saa";
            char[] ch = new char[searchWithinThis.Length];

            string st = "";
            char st_ch = ' ';

            for (int x = 0; x < searchWithinThis.Length; x++)
            {
                Console.SetCursorPosition(x, 3);
                Console.Write("-");
            }
            Console.WriteLine();

            for (int i = 0; i < searchWithinThis.Length; i++)
            {

                ch = searchWithinThis.ToCharArray();
            }

            for (int j = 0; j < searchWithinThis.Length + 1; j++)
            {
                st = Console.ReadLine();
                
                if (char.TryParse(st, out st_ch))
                {
                    st_ch = st.First();
                    for (int k = 0; k < ch.Length; k++)
                    {

                        if (ch[k] == st_ch)
                        {

                            int te = searchWithinThis.IndexOf(st_ch, k);

                            Console.SetCursorPosition(k, 3);
                            Console.WriteLine(st_ch);
                            Console.WriteLine();
                        }
                    }
                }
                else Console.WriteLine("try again!");
            }
           
            Console.WriteLine("This is that I thought about : " + searchWithinThis);

            Console.Read();
        }
    }
}

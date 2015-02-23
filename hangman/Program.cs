using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hangman
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Guess what I think about: ");
            char[] ch = new char[6] { 's', 'a', 'r', 'a',' ',' ' };
            char[] ch2 = new char[6];
            

            for (int j = 0; j <= 5; j++)
            {
                string input = Console.ReadLine();
                char char_input = Convert.ToChar(input);

                for (int i = 0; i < ch.Count(); i++)
                {
                    if (ch[i] == char_input)
                    {
                        ch2[i] = char_input;

                    }
                   
                }
            }
            
            Console.Write("These alphabets are right: ");
            for (int k = 0; k < ch2.Count(); k++)
            {
                if (ch2[k] == ch[k])
                {

                    Console.Write(ch2[k]);
                }
            }

            

            Console.WriteLine("The word that I guess:");
            foreach (var m in ch)
            {
                Console.Write(m);
            }

            Console.Read();

        }


    }
}

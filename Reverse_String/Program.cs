using System;

namespace Reverse_String
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Your Name Or Favourite Quote");
            var str = Console.ReadLine();

            Console.WriteLine("You Entered : {0}",str);
            Char[] ch = str.ToCharArray();
            Console.WriteLine("\n**************String After Reverse************\n");

            int Counter = 0;

            for(int i=ch.Length-1; i>0; i--)
            {
                if (ch[i] !=' ')
                {
                    Counter++;
                }
                else if (ch[i] == ' ')
                {
                    for (int j =i+1; Counter > 0; j++,Counter--)
                    {
                        Console.Write(ch[j]);
                    }
                    Console.Write(" ");
                }
            }

            for(int j=0; j<=Counter; j++)
            {
                Console.Write(ch[j]);
            }

            Console.ReadKey();
        }
    }
}

using System;
using LanguageChecker;

namespace TSLA_lab1
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.Write("Please enter your word: ");
            string str = Console.ReadLine();

            Checker checker = new Checker(str);
            while(true)
            {
                if (checker.Check())
                {
                    Console.WriteLine("This word belongs to the language!\nN: {0}; M: {1}\n", checker.n, checker.m);
                }
                else
                {
                    Console.WriteLine("This word doesn't belong to the language!\n");
                }

                Console.Write("____________________________\n\nEnter another word to check: ");
                str = Console.ReadLine();
                checker.str = str;
            }
        }
    }
}

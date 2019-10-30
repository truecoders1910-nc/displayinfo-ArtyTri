using System;

namespace DisplayInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            int favnumb;
            string fname;
            string lname;
            string favan;

            Console.WriteLine("What is your first name?");
            fname = Console.ReadLine();

            Console.WriteLine("What is your last name?");
            lname = Console.ReadLine();

            Console.WriteLine("What is your favorite number");
            favnumb = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("What is your favorite animal?");
            favan = Console.ReadLine();


            if (favnumb > 10)
            {
                Console.ForegroundColor = ConsoleColor.Green;
            }
            if (favnumb < 5)
            {
                Console.ForegroundColor = ConsoleColor.Red;
            }

            Console.WriteLine($"Hello {fname} {lname}! Your favorite number is {favnumb} and your favorite animal is {favan}!");

        }
    }
}

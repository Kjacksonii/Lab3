using System;

namespace NumberAnalyzer
{
    class Program
    {
        static void Main(string[] args)
        {

            int num;

            Console.WriteLine("Enter a number between 1 and 100");
            num = Convert.ToInt32(Console.ReadLine());

            if (num % 2 == 0 && num < 25)
            {
                Console.WriteLine("Even and less than 25", num);
            }
            else if (num % 2 == 0 && num >= 26 && num <= 60)
            {
                Console.WriteLine("Even");
            }
            else if (num % 2 == 0 && num > 60)
            {
                Console.WriteLine("{0} Even", num);
            }
            else if (num % 2 != 0 && num > 60)
            {
                Console.WriteLine("{0} Odd", num);
            }
            else if (num % 2 != 0)
            {
                Console.WriteLine("{0} Odd", num);
            }
        }

    }
}


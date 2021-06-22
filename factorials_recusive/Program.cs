using System;

namespace factorials_recusive
{
    class Program
    {
        static void Main(string[] args)
        {
            int no;


            Console.WriteLine("Enter a number");
            no = Int16.Parse(Console.ReadLine());

            //int fact = factorials(no);

            Console.WriteLine("Factorials of " + no + " is " + factorials(no));

        }

        private static int factorials(int number)
        {
            if (number == 0)
            {
                return 1;
            }
            else
            {
                return number * factorials(number - 1);
            }
        }
    }
}

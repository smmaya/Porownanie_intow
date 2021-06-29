using System;

namespace Nauka
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 12;
            int num2 = 11;

            if (num1 < num2)
            {
                Console.WriteLine(num1 + " jest mniejsze od " + num2);
            }
            else if (num1 == num2)
            {
                Console.WriteLine(num1 + " jest równe " + num2);
            }
            else
            {
                Console.WriteLine(num1 + " jest większe od " + num2);
            }
        }
    }
}

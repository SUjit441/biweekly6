using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace biweekly6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Addition Claculator");
            //Ask the user to enter the first number
            Console.Write("Enter the first number: ");
            int a = Convert.ToInt32(Console.ReadLine());
            //Ask the user to enter the second number
            Console.Write("Enter the second number: ");
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(COnsole.ReadLine());
            int result = a * b * c;
            Console.WriteLine("The total is:" + result);
            Console.Read();

        }
    }
}

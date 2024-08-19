using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Add2Num
{
    public class Add2Num
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter first number: ");
            string num1 = Console.ReadLine();
            while (num1 == "")
            {
                Console.WriteLine("Number is empty, plase enter again: ");
                num1 = Console.ReadLine();
            }
            Console.Write("Enter second number: ");
            string num2 = Console.ReadLine();
            while (num2 == "")
            {
                Console.WriteLine("Number is empty, plase enter again: ");
                num2 = Console.ReadLine();
            }
            Console.WriteLine();
            Console.WriteLine("Solution:");
            MyBigNumber myBigNumber = new MyBigNumber();
            Console.WriteLine("Sum of two numbers: " + myBigNumber.num(num1, num2));
        }
    }
}

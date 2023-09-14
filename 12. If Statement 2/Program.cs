using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.If_Statement_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
          

            Console.WriteLine("Enter new number: ");
            int num2 = Convert.ToInt32(Console.Read());

            Console.WriteLine("Enter new number 1");
            int num1 = Convert.ToInt32(Console.Read());

            Console.WriteLine(GetMax(num1, num2));

            //Freeze Console
            Console.ReadLine();
        }

        static int GetMax(int num1, int num2)
        {
            if (num1 > num2)
            {

                Console.WriteLine("The max number is ");
                return num1;
            }

            else
            {
                Console.WriteLine("The max number is ");
                return num2;
            }
        }
    }
}

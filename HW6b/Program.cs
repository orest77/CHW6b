using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW6b
{
    class Program
    {
        static void Main(string[] args)
        {

            int numbers;
            int start = 0;
            int end = 100;
            try
            {
                Console.WriteLine("Enter 10 numbers: \n");
                //Numbers num = new Numbers();
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine("Input  numbers:{0} ", i + 1);
                    numbers = ReadNumber(start, end);

                }
            }
            catch (Exception e)
            {
                Console.Error.WriteLine("Wrong{0}:::::{1}", e.GetType(), e.Message);
            }
            Console.ReadKey();

        }

        static int ReadNumber(int start, int end)
        {

            int number = Convert.ToInt32(Console.ReadLine());
            if (number > start && number <= end)
            {
                return number;
            }
            else
            {
                throw new OverflowException("Number not in the range 1 to 100");
            }

        }
    }
}

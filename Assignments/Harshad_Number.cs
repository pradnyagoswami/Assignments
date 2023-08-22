using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Assignments
{
    public class Harshad_Number
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter Number");
            int num = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            int digit = 0;
            int temp = num;

            while (num != 0)
            {

                digit = num % 10;
                sum = digit + sum;
                num = num / 10;


            }
            Console.WriteLine(sum);

            if (temp % sum == 0)
            {
                Console.WriteLine("its Harshad number");



            }
            else
            {
                Console.WriteLine("It is not Harshad Number");

            }




        }
    }


}


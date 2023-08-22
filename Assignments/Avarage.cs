using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    public class Avarage
    {


        public static void Main(string[] args)
        {

            Console.WriteLine("Enter Number");
            int num=Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            int count = 0;
            while (num != 0)
            {

                int digit = num % 10;
                sum = digit + sum;
                num = num / 10;
                count++;
            
            }
            double avg = sum / count;
            Console.WriteLine(avg);

        }




    }
}

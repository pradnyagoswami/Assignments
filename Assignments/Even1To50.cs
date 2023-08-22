using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    public class Even1To50
    {

        public static void Main(String[] args)
        {

            for (int i = 1; i <= 50; i++)
            {
                if (i % 2 == 0)
                {

                    Console.WriteLine(i*i);

                }
                else 
                {
                    Console.WriteLine(-i);

                }


            }
        
        
        
        
        }




    }
}

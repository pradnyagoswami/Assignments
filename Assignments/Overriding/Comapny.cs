using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Assignments.Overriding
{
   // 2) WAP to create class company with method address.create class eBay which extends company implement address() differently in eBay class.
   // Here the method address()has been overridden in child class.
    public class Comapny
    {
        public virtual void Address()
        {
            Console.WriteLine("This is parent class");

        }


    }
    public class EBay : Comapny
    {
        public override void Address()
        {
            Console.WriteLine("This is child class");

        }

        public static void Main(string[] args) 
        {
            EBay eb = new EBay();
            eb.Address();
        
        
        }


    }
}

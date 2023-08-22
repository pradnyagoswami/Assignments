using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments.Inheritance
{
   // 4. Create Class Laptop which has variables noOfUSBPort, processorSpeed of type int. Create getter,
   // setter methods for the variables.In main method,
   // 1> create Laptop object 2> set values of variables noOfUSBPort,processorSpeed using setter methods.
   // 3> print variables noOfUSBPort,
   // processorSpeed using getter methods
    public class Laptop
    {
        private int noOfUSBPort;
        private int processorSpeed;

        public int NoOfUSBPort
        {
            get { return noOfUSBPort; }
            set  { noOfUSBPort = value; } 
        }
        public int ProcessorSpeed
        {
            get { return processorSpeed; }
            set { processorSpeed = value; }
        
        }
        


        public static void Main(string[] args)
        {
            Laptop l = new Laptop();
            Console.WriteLine(l.NoOfUSBPort = 66);
            Console.WriteLine(l.ProcessorSpeed = 200);
        
        
        }





    }
}

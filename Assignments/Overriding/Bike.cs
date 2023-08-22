using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments.Overriding
{

    //5)WAP to create class Bike with fields color ,speed and  method bikeInfo() which is show color and speed of bike .
    //create class Pulsar which extends Bike implement bikeInfo() differently child 
    public class Bike
    {
        protected string color;
        protected int spedd;


        public virtual string Bikeinfo(string color,int speed)
        { 
         return $"{color},{spedd}";
        
        }

    }
    public class pulsar : Bike
    {
        public override string Bikeinfo(string color, int speed)
        {
            return $"{color},{speed}";

        }

        public static void Main(string[] args) 
        {


            pulsar p = new pulsar();
            Console.WriteLine(p.Bikeinfo("black",200));
        
        }



    }
}

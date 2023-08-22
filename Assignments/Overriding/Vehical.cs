using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments.Overriding
{
    //3)WAP to create class Vehicle with methods accelerate(long mph) with long type parameter ,stop(),run() all method return string type of value.
    //Create class car which extends Vehicle implement accelerate(long mph)differently in car class.
    public class Vehical
    {
        public  virtual void Accelarate()
        {
            Console.WriteLine("This is parent class Accelarate");


        }
        public string Stop(long Speed)
        {
            return "This is speed";
        
        }
        public string Run()
        {

            return "Vehichal running";
        }



    }
    public class Car : Vehical
    {
        public override  void Accelarate()
        {

            Console.WriteLine("This is child class Accelarate");

        }


        public static void Main(string[] args) 
        {
            Car c1 = new Car();
            c1.Accelarate();
            Console.WriteLine(c1.Stop(102364));
            Console.WriteLine(c1.Run());
        
        }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments.Inheritance
{ 

    //7. Create interface IceCream with method eat and Juice with method drink.
    //Create class Mastani which implements both interfaces
    public interface Icecream
    {
        public void eat();

    }
    public interface Juice
    {
        public void drink();

    }
    public class Mastani : Icecream, Juice
    {
        public void eat()
        {
            Console.WriteLine("Eating  Icecream in  interface Icecrea ");
        }
        public void drink()
        {
            Console.WriteLine("Drinking juice in Interface Juice");

        }

        public static void Main(String[] args)
        {
            Icecream i = new Mastani();
            i.eat();
            Juice j = new Mastani();
            j.drink();
        
        
        
        
        }





    }

    }


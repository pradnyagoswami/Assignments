using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Assignments.Polymorphism
{
    //1. WAJP2 create a class Kid with method readBook() and another method readBook() with 2 parameters.
    //The method readBook here is over-loaded(same method name but different parameters)

    // 2. Create a class BigKid which extends Kid created above.Implement readBook()
    // differently in BigKid class. Here the method readBook() has been over-ridden in the child class BigKid()

    //3. Create a class Teenager which extends Kid created above (#14). Implement readBook() differently in Teenager class.
    //In main method, declare 2 variables k1,k2 of type Kid.Create objects of type BigKid and Teenager such that K1 should
    //reference objeof class BigKid and K2 should reference object of class Teenager.Call their respective readBook() methods.
    //The output is different from both themethod calls even if the variable type is the same i.e.Kid.This is compile timepolymorphism example.

    public class Kid
    {
        public virtual  void ReadBook()
        {
            Console.WriteLine("Kid is reading book");

        }
        public  void ReadBook(int id,String name)
        {
            Console.WriteLine("pradnya is reading a book");
        }
    }
    public class BigKid : Kid
    {

        public override  void ReadBook() 
        {
            Console.WriteLine("This is from BigKid");
        }
        public static void Main(string[] args)
        {

            Kid k1 = new BigKid();
            Kid k2 = new Teenager();
            k1.ReadBook();
            k2.ReadBook();

        }



    }
    public class Teenager:Kid
    {

        public override void ReadBook()
        {
            Console.WriteLine("Teenagers reading books");

        }

       


    }
   
    
}

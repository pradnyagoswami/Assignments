using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments.Overriding
{
    //8)WAP to create class Person with method readScript().create class Actor which extends Person implement readScript() differently in child.
    public class Person
    {

        public  virtual void ReadScript()
        {
            Console.WriteLine("person reading script");

        }



    }
    public class Actor : Person
    {


        public override void ReadScript()
        {
            Console.WriteLine("Actor reading script");

        }

        public static void Main(String[] args)
        { 
        
            Actor a=new Actor();
            a.ReadScript();
        
        
        }
    
    }
}

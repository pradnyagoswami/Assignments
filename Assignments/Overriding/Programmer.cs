using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments.Overriding
{
    //5)WAP to create class Programmer with Method workingHours().create class Employee which extends Programmer implement workingHours()differently in child.

    public class Programmer
    {
        public virtual void WorkingHours()
        {

            Console.WriteLine("Working hours for programmer");

        }


    }
    public  class Employee : Programmer
    {
        public override void WorkingHours()
        {
            Console.WriteLine("Workinghour for Employee");

        }


        public static void Main(String[] args)
        { 
        
        
            Employee emp=new Employee();
            emp.WorkingHours();
        
        }
    
    
    }
}

using Assignments.Overriding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace Assignments.Methods
{
    //add method displayData inside Student class change values of id name in that method & also print the changed values in same method.Call
    //displayData method from main method and see the output.Observe displayData can only be called by creating object of Student

    public class ChangeValue
    {
        private int id;
        private String name;


        public ChangeValue(int id,string name)
        {
            this.id = id;
            this.name = name;
        
        
        }
        public void DisplyData()
        {
            id = 101;
            name = "siya";
            Console.WriteLine($"{id},{name}");

        }


        public static void Main(string[] args) 
        {

            ChangeValue ch = new ChangeValue(100,"tina");
           ch.DisplyData();
        
        
        }


    }
}

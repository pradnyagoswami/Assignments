using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments.Inheritance
{
    //6. Create interface Cake with a method declared as bake.Create 2 classes
    //Strawberry, BlackForest both implementing Cake interface

    public interface Icake
    {
        void bake();
    }
    public class Strawberry:Icake
    { 
    
        public void bake() 
        {
            Console.WriteLine($"In strawberry class");

        }

    
    }
    public class BlackForest:Icake
    {

        public void bake()
        {
            Console.WriteLine($"In Blackberry Class");

        }
         public static void Main(String[] args)  
        { 
            Icake cake=new Strawberry();
            cake.bake();
            Icake cake1 = new BlackForest();
            cake1.bake();   
        
        
        }
    
    }
}

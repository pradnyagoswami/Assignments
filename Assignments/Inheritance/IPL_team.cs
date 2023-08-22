using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments.Inheritance
{

    //5. Create class IPLTeam with method play. Create child classes of IPLTeam
    //called as CSK, RCB.In main, call play from child class objects
    public class IPL_team
    {    
        public void IPL_play()
        {
            Console.WriteLine("plyers are playing");

        }

    }
    public class Rcb : IPL_team
    {

        public Rcb()
        { 

        }
    
    }
    public class Csk : IPL_team
    {
        public Csk()
        { 
        
        
        }


        public static void Main(string[] args)
        {
            Rcb r = new Rcb();
            r.IPL_play();
            Csk c = new Csk();
            c.IPL_play();

        }

    }
    
    
}

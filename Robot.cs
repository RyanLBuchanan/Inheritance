using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Robot
    {
        protected int maxSpeed;
        protected string robotType;
        
        public Robot() 
        { 
            this.maxSpeed = 1;
            this.robotType = "Pleasure Bot";
        }

        public virtual void Travel()
        {
            Console.WriteLine($"The {robotType} robot moves {maxSpeed} units.");
        }
    }
}

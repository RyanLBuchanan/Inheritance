using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class HoverBot : Robot
    {
        private string purpose = "spy on the neighbors";

        public HoverBot(int maxSpeed)
        {
            this.maxSpeed = maxSpeed;
            this.robotType = "Hover Bot";
        }

        public override void Travel()
        {
            Console.WriteLine($"The {robotType} robot flies {maxSpeed} units to {purpose}.");
        }
    }
}

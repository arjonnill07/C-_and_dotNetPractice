using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopExamples
{
    public class AsusZenbook : Laptop
    {
        public override bool TouchScreen => true ;

        // as the method TurnOn had virtual keyword ,we are able to override the fuction
        public override void TurnOn()
        {
            Console.WriteLine("Turning on specific to asus zeenbook");
        }
    }
}

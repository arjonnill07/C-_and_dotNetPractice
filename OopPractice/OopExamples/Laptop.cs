using System;
namespace OopExamples
{
    public abstract class Laptop
    {   
        //virtual keyword gives the ability to override a method
        public virtual void TurnOn()
        {
            Console.WriteLine("Turning on.");
        }

        public void TurnOff()
        {
            Console.WriteLine("Turning off.");
        }

        // each class that inherits this class must define this property
        public abstract bool TouchScreen { get; }
    }
}

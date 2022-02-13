using System;

namespace OopExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            Laptop macbookAir = new MacbookAir();
            Laptop asusZenbook = new AsusZenbook();

            macbookAir.TurnOn();
            macbookAir.TurnOff();

            asusZenbook.TurnOn();
            asusZenbook.TurnOff();

            Console.WriteLine(macbookAir.TouchScreen);
            Console.WriteLine(asusZenbook.TouchScreen);

            Console.ReadLine();
        }
    }

    /*
     *concreate class
        #used to create full on blueprints to create object from
     
     
    public class A
    {

    }

    /*
     *Abstract class 
         
        # used to create base fuctionalities and attributes
        #allows inheriting classes to implement their own behaviour and attributes
        #cannot be instantiated itself
        #just be inherited from
        
        
     
     
    public abstract class B
    {

    }
    
     *interface
        #simillar to  abstract class 
        #cannot have pre-written behaviour
        #can have only empty method signatures which the inheriting classes have to implement them selves
        #can not have any methods with full on implementations
        #cheaper to use as far as concerned with cpu and memory
     
     
    public interface C
    {

    }
    */
    
}

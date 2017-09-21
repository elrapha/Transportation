using System;
using Transportation.Interfaces;
using Transportation.Services;

namespace Transportation
{
    public class Program
    {
        public static void Main(string[] args)
        {
            IWriter writer = new ConsoleWriter();
//            IWriter writer = new JsonFileWriter("JsonOutput/output");

            var car1 = new Car("NF123456", 147, 200, "green", "saloon", writer);
            var car2 = new Car("NF654321", 150, 195, "blue", "saloon");
            var plane = new Plane("LN1234", 1000, 30, 2, 10, FlyingClass.Business,writer);
            var boat = new Boat("ABC123", 100, 30, 500);
   

            writer.Write(car1);
            Console.WriteLine();
            Console.WriteLine();


            writer.Write(car2);
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine($"Car1 == Car2? {car1 == car2}");
            Console.WriteLine();
            Console.WriteLine();

            writer.Write(plane);
            Console.WriteLine();
            Console.WriteLine();

            car1.Drive();
            Console.WriteLine();
            Console.WriteLine();

            plane.Fly();
            Console.WriteLine();
            Console.WriteLine();

            writer.Write(boat);
        }
    }
}

/******
 * WHAT WILL IT TAKE TO CHANGE CONSOLE OUTPUT TO JSON EXPORT?
 * ==>It will take the implementation of an interface to satisfy multiple ouputs (console,text,json...etc)
 * ==> Due to my introduction of the IWriter interface, we can have different impelemntations of Write()
 * ==> This way, all we need to do is to change the instance or IWriter to JsonFileWriter 
 * ==> Also we can extend the Implement Iwriter for TextFileWriter as well and this makes chosing output flexible
 * 
 * How TO MAKE CODE MORE TESTABLE
 * ==> We primarily try to maintain the single responsibility principle classes.
 * ==> Each class should do only one thing (simple thing) 
 * ==> The responsibility and logic to print to console or file is given to Iwriter instead of Car,Plane or Boat
 */
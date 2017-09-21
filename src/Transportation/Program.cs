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

            var car1 = new Car("NF123456", 147, 200, "green", "saloon");
            var car2 = new Car("NF654321", 150, 195, "blue", "saloon");
            var plane = new Plane("LN1234", 1000, 30, 2, 10, FlyingClass.Business);
            var boat = new Boat("ABC123", 100, 30, 500);

            writer.Write(car1);
            Console.WriteLine("\n");

            writer.Write(car2);
            Console.WriteLine("\n");

            Console.WriteLine($"Car1 == Car2? {car1 == car2}");
            Console.WriteLine("\n");

            writer.Write(plane);
            Console.WriteLine("\n");

            car1.Drive(writer);
            Console.WriteLine("\n");

            plane.Fly(writer);
            Console.WriteLine("\n");

            writer.Write(boat);
        }
    }
}

/******
 * WHAT WILL IT TAKE TO CHANGE CONSOLE OUTPUT TO JSON EXPORT?
 * ==> Due to my introduction of IWriter, we can have different impelemntations of Write()
 * ==> This way, all we need to do is to change the instance or IWriter to JsonFileWriter instead of ConsoleWriter
 * ==> Also we can extend the Implement Iwriter for TextFileWriter as well and this makes chosing output flexible
 * 
 * How TO MAKE CODE MORE TESTABLE
 * ==> 
 */
using System;
using Transportation.Interfaces;

namespace Transportation.Services
{
    public class ConsoleWriter : IWriter
    {
        public void Write(IVehicle vehicle)
        {
            Console.WriteLine(vehicle);
        }


        public void Write(string s)
        {
            Console.WriteLine(s);
        }
    }
}
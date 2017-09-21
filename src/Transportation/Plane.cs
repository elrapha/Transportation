using System.IO;
using Transportation.Interfaces;

namespace Transportation
{
    public class Plane : IVehicle
    {
        private readonly IWriter logger;

        public Plane(string registration, int endinePower, int wingSpan, int loadCapacity, int netWeight,
            FlyingClass flyingClass) :
            this(registration, endinePower, wingSpan, loadCapacity, netWeight, flyingClass, null)
        {
        }

        public Plane(string registration, int endinePower, int wingSpan, int loadCapacity, int netWeight,
            FlyingClass flyingClass, IWriter writer)
        {
            Registration = registration;
            EnginePower = endinePower;
            WingSpan = wingSpan;
            LoadCapacity = loadCapacity;
            NetWeight = netWeight;
            FlyingClass = flyingClass;
            logger = writer;
        }

        public string Registration { get; set; }
        public int EnginePower { get; set; }
        public int MaxSpeed { get; set; }
        public int NetWeight { get; set; }
        public int WingSpan { get; set; }
        public int LoadCapacity { get; set; }
        public FlyingClass FlyingClass { get; set; }

        public override string ToString()
        {
            return
                $@"Registration: {Registration}
Engine Power: {EnginePower} kW
Maximum Speed: {MaxSpeed} knot/h
Net Weight: {NetWeight} t
Wing Span: {WingSpan} m
Load Capacity: {LoadCapacity}t
Flight Class: {FlyingClass}";
        }


        public void Fly()
        {
            // logic for flying goes here
            logger?.Write($"Flying Plane with Plate:{Registration}");
        }

        public static implicit operator string(Plane v)
        {
            return v.ToString();
        }
    }
}
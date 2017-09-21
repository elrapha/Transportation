using System.IO;
using Transportation.Interfaces;

namespace Transportation
{
    public class Plane : IVehicle
    {
       
        public Plane(string registration, int endinePower, int wingSpan, int loadCapacity, int netWeight,
            FlyingClass flyingClass)
        {
            Registration = registration;
            EnginePower = endinePower;
            WingSpan = wingSpan;
            LoadCapacity = loadCapacity;
            NetWeight = netWeight;
            FlyingClass = flyingClass;
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
Engine Power: {EnginePower}
Maximum Speed: {MaxSpeed}
Net Weight: {NetWeight}
Wing Span: {WingSpan}
Load Capacity: {LoadCapacity}
Flight Class: {FlyingClass}";

        }


        public void Fly(IWriter writer)
        {
            writer.Write($"Flying Plane with Plate:{Registration}");
        }

        public static implicit operator string(Plane v) { return v.ToString(); }

    }
}
using Transportation.Interfaces;

namespace Transportation
{
    public class Boat : IVehicle
    {
        public Boat(string registration, int enginePower, int maxSpeed, int netWeight)
        {
            Registration = registration;
            EnginePower = enginePower;
            MaxSpeed = maxSpeed;
            NetWeight = netWeight;
        }

        public string Registration { get; set; }
        public int EnginePower { get; set; }
        public int MaxSpeed { get; set; }
        public int NetWeight { get; set; }

        public override string ToString()
        {
            return
                $@"Registration: {Registration}
Engine Power: {EnginePower}
Maximum Speed: {MaxSpeed}
Net Weight: {NetWeight}";
        }
        public static implicit operator string(Boat v) { return v.ToString(); }

    }
}
using Transportation.Interfaces;

namespace Transportation
{
    public class Boat : IVehicle
    {
        private readonly IWriter _logger;

        public Boat(string registration, int enginePower, int maxSpeed, int netWeight)
            : this(registration, enginePower, maxSpeed, netWeight, null)
        {
        }

        public Boat(string registration, int enginePower, int maxSpeed, int netWeight, IWriter writer)
        {
            Registration = registration;
            EnginePower = enginePower;
            MaxSpeed = maxSpeed;
            NetWeight = netWeight;
            _logger = writer;
        }

        public string Registration { get; set; }
        public int EnginePower { get; set; }
        public int MaxSpeed { get; set; }
        public int NetWeight { get; set; }

        public void Drive()
        {
            //          log to console 
            _logger?.Write($"Driving Car with Plate:{Registration}");
        }

        public override string ToString()
        {
            return
                $@"Registration: {Registration}
Engine Power: {EnginePower} kW/h
Maximum Speed: {MaxSpeed} knot/h
Net Weight: {NetWeight} kg";
        }

        public static implicit operator string(Boat v)
        {
            return v.ToString();
        }
    }
}
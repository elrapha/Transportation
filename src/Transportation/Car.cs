using System;
using System.IO;
using Transportation.Interfaces;

namespace Transportation
{
    public class Car : IVehicle
    {
        public Car(string registration, int enginePower, int maxSpeed, string color, string vehicleType)
        {
            Registration = registration;
            EnginePower = enginePower;
            MaxSpeed = maxSpeed;
            Color = color;
            VehicleType = vehicleType;
        }

        public string Registration { get; }
        public int EnginePower { get; set; }
        public int MaxSpeed { get; set; }
        public int NetWeight { get; set; }
        public string Color { get; set; }
        public string VehicleType { get; set; }


        public override bool Equals(object obj)
        {
            //Two cars are equal only if their registration ID is equal. 
            // Assuming Two cars cannot have the same registration

            if (obj == null)
                return false;
            if (ReferenceEquals(obj, this))
                return true;
            if (obj.GetType() != GetType())
                return false;

            var rhs = obj as Car;
            return rhs != null && string.Equals(Registration, rhs.Registration, StringComparison.OrdinalIgnoreCase);
        }


        public override int GetHashCode()
        {
            return Registration.GetHashCode();
        }

        public static bool operator ==(Car x, Car y)
        {
            return Equals(x, y);
        }

        public static bool operator !=(Car x, Car y)
        {
            return !Equals(x, y);
            ;
        }

        public override string ToString()
        {
            return
                $@"License Plate: {Registration}
Engine Power: {EnginePower}
Maximum Speed: {MaxSpeed}
Color: {Color}
Vehicle Type: {VehicleType}";
        }

        public void Drive(IWriter writer)
        {
            writer.Write($"Driving Car with Plate:{Registration}");
        }

        public static implicit operator string(Car v)
        {
            return v.ToString();
        }
    }
}
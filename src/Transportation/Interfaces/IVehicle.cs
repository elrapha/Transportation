namespace Transportation.Interfaces
{
    public interface IVehicle
    {
        string Registration { get; }
        int EnginePower { get; set; }
        int MaxSpeed { get; set; }
        int NetWeight { get; set; }
    }
}
public class RentalVehicle
{
    public int RentalId { get; set; }
    public string CurrentRenter { get; set; }
    public decimal PricePerday { get; set; }
    public int NumberOfPassangers { get; set; }

    public void StartEngin()
    {
        Console.WriteLine("Turn key to ignition setting");
        Console.WriteLine("Turn Key to on");
    }
    public void StopEngin()
    {
        Console.WriteLine("Turn Key to off");
    }
}

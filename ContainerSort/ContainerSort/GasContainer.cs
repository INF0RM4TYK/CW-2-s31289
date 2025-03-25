namespace ContainerSort;

public class GasContainer : Kontener, IHazardNotifier
{
    
    public double AtmosphericPressure { get; set; }


    public GasContainer(double height, double tareWeight, double depth, double maxLoad, double atmosphericPressure) : base('G', height, tareWeight, depth, maxLoad)
    {
        AtmosphericPressure = atmosphericPressure;
    }


    public override void Empty()
    {
        
    }


    public void NotifyHazard(string message, string containerSerialNumber)
    {
        Console.WriteLine($"Wysyłam notyfikację: {message} dla kontenera {containerSerialNumber}");
       
    }
}
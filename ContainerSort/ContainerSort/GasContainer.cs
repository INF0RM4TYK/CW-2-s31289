namespace ContainerSort;

public class GasContainer : Kontener, IHazardNotifier
{
    
    public double AtmosphericPressure { get; set; }


    public GasContainer(double height, double tareWeight, double depth, double maxLoad) : base('G', height, tareWeight, depth, maxLoad)
    {
        
        
        
        
    }


    public override void Empty()
    {
        Weight *= 0.05;
    }


    public void NotifyHazard(string message, string containerSerialNumber)
    {
        Console.WriteLine($"Wysyłam notyfikację: {message} dla kontenera {containerSerialNumber}");
       
    }
}
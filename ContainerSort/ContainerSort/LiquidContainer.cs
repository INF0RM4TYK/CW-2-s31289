namespace ContainerSort;

public class LiquidContainer : Kontener, IHazardNotifier
{
    
    public bool IsDangerous { get; set; }

    public LiquidContainer(double height, double tareWeight, double depth, double maxLoad, bool isDangerous)
        : base('L', height, tareWeight, depth, maxLoad)    // L - Liquid
    {
        IsDangerous = isDangerous;
    }


    public override void Load(double weight)
    {

        double maxFill = IsDangerous ? MaxLoad * 0.5 : MaxLoad * 0.9;
        
        if (weight > maxFill)
        {
            string message = "[Próba przeładowania kontenera]";
            NotifyHazard(message, SerialNumber);
            throw new OverfillException(message);
            
        }

        base.Load(weight);
        Console.WriteLine($"Zaladowano kontener plynem o ilosci {weight}");
        
    }


    public void NotifyHazard(string message, string containerSerialNumber)
    {
        Console.WriteLine($"Wysyłam notyfikację: {message} dla kontenera {containerSerialNumber}");
    }
}
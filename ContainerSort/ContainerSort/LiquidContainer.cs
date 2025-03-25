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
        

        base.Load(weight);


        if (LoadWeight > maxFill)
        {
            LoadWeight -= weight;
            string message = $"Próba przeładowania kontenera! Max: {maxFill} kg, Aktualnie kontener posiada: {LoadWeight} kg";
            NotifyHazard(message, SerialNumber);
            throw new OverfillException(message);
            
        }

        Console.WriteLine($"Zaladowano kontener {SerialNumber} plynem o wadze {weight}");
        
        
        
    }


    public void NotifyHazard(string message, string containerSerialNumber)
    {
        Console.WriteLine($"Wysyłam notyfikację: {message} dla kontenera {containerSerialNumber}");
    }
    
    
    public override string ToString()
    {
        string isDanger = IsDangerous ? " niebezpieczny ladunek (max 50%)" : " bezpieczny ladunek (max 90%)";
        return base.ToString() + $". Jest to{isDanger}";
    }
    
    
}
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
        LoadWeight *= 0.05; 
        Console.WriteLine($"Oprozniono kontener {SerialNumber}, aktualna ilosc gazu [{LoadWeight}] wynoszaca 5% ladunku");
        
    }


    public override void Load(double weight)
    {

        if (weight > MaxLoad)
        {
            string message = $"Próba przeładowania kontenera! Max: {MaxLoad} kg, Aktualna proba: {weight} kg";
            NotifyHazard(message, SerialNumber);
            
        }


        base.Load(weight);
        Console.WriteLine($"Zaladowano kontener {SerialNumber} gazem o wadze {weight}");
    }

    public void NotifyHazard(string message, string containerSerialNumber)
    {
        Console.WriteLine($"Wysyłam notyfikację: {message} dla kontenera {containerSerialNumber}");
       
    }
    
    
    public override string ToString()
    {
        return base.ToString() + $". Ciśnienie: {AtmosphericPressure} atm";
    }
}
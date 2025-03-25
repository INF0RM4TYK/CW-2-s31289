namespace ContainerSort;

public class RefrigeratedContainer : Kontener, IHazardNotifier
{
    public string ProductType { get; set; }
    public double Temperature { get; set; }


    public RefrigeratedContainer(double height, double tareWeight, double depth, double maxLoad, string productType, double temperature) : base('C', height, tareWeight, depth, maxLoad)
    {
        ProductType = productType;
        Temperature = temperature;
    }


    public override void Load(double weight)
    {
        base.Load(weight);
        //NotifyHazard("",SerialNumber);
    }

    public override string ToString()
    {
        return base.ToString() + $". Typ produktu: {ProductType}, Temperatura: {Temperature}°C";
    }
    
    

    public void NotifyHazard(string message, string containerSerialNumber)
    {
        
        Console.WriteLine($"Wysyłam notyfikację: {message} dla kontenera {containerSerialNumber}");
    }
}
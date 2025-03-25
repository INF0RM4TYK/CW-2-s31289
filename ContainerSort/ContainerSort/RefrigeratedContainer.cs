namespace ContainerSort;

public class RefrigeratedContainer : Kontener
{
    public string ProductType { get; set; }
    public double Temperature { get; set; }

    public Dictionary<string, double> TempOfExacItem = new Dictionary<string, double>()
    {
        { "Bananas", 13.3 },
        { "Chocolate", 18 },
        { "Fish", 2 },
        { "Meat", -15 },
        { "Ice Cream", -18 },
        { "Frozen pizza", -30 },
        { "Cheese", 7.2 },
        { "Sausages", 5 },
        { "Buuter", 20.5 },
        { "Eggs", 19 },
    };
    
    // dodamy takze rodzaje produktow ktore moga zostac przechowywane 
    
    

    public RefrigeratedContainer(double height, double tareWeight, double depth, double maxLoad, string productType, double temperature) : base('C', height, tareWeight, depth, maxLoad)
    {
        ProductType = productType;
        Temperature = temperature;
    }


    public override void Load(double weight)
    {
        base.Load(weight);
        
        
        
        
        if (LoadWeight > MaxLoad)
        {
            LoadWeight -= weight;
            string message = $"Próba przeładowania kontenera! Max: {MaxLoad} kg, Aktualnie kontener posiada: {LoadWeight} kg";

        }
        
        Console.WriteLine($"Zaladowano kontener {SerialNumber} produktami o wadze {weight}");
    }

    public override string ToString()
    {
        return base.ToString() + $". Typ produktu: {ProductType}, Temperatura: {Temperature}°C";
    }
    
    

   
}
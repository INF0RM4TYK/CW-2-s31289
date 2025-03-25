namespace ContainerSort;

public class RefrigeratedContainer : Kontener
{
    public string? ProductType { get; set; }
    public double Temperature { get; set; }

    public Dictionary<string?, double> TempOfExacItem = new Dictionary<string?, double>()
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
    
    

    public RefrigeratedContainer(double height, double tareWeight, double depth, double maxLoad, string? productType, double temperature) : base('C', height, tareWeight, depth, maxLoad)
    {
        ProductType = productType;
        Temperature = temperature;
        CheckTemperature();  // -> trzeba sprawdzic temperature
    }


    public override void Load(double weight)
    {
        if (ProductType != GetProductType())
        {
            throw new WrongItemsException(
                $"W kontenerze {SerialNumber} moga znajdowac sie tylko produkty typu {ProductType}");
        }

        base.Load(weight);
        
        
        if (LoadWeight > MaxLoad)
        {
            LoadWeight -= weight;
            string message = $"Próba przeładowania kontenera! Max: {MaxLoad} kg, Aktualnie kontener posiada: {LoadWeight} kg";

        }
        
        Console.WriteLine($"Zaladowano kontener {SerialNumber} produktem {ProductType} o wadze {weight} kg");
    }


    private void CheckTemperature()
    {

        if (this.Temperature > TempOfExacItem[ProductType])
        {
            throw new WrongTempException($"Temperatura dla produktu {ProductType} powinna wynosic conajmniej {TempOfExacItem[ProductType]}°C. Zadana temperatura {Temperature}");
        }
    }

    public void SetProductType(string? productType)
    {
        ProductType = productType;
        CheckTemperature();
    }


    public string GetProductType()
    {
        return LoadWeight > 0 ? ProductType : null;
    }

    public override string ToString()
    {
        return base.ToString() + $". Typ produktu: {ProductType}, Temperatura: {Temperature}°C";
    }
    
    

   
}

public class WrongItemsException : Exception
{
    public WrongItemsException(string message) : base(message) { }
}   

public class WrongTempException : Exception
{
    public WrongTempException(string message) : base(message) { }
}   

namespace ContainerSort;

public class RefrigeratedContainer : Kontener
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

        if (weight > MaxLoad)
        {
            throw new OverfillException($"Za duzo produktu w kontenerze {SerialNumber}");
        }
        
        

        base.Load(weight);
      
    }

    public override string ToString()
    {
        return base.ToString() + $". Typ produktu: {ProductType}, Temperatura: {Temperature}°C";
    }
    
    

   
}
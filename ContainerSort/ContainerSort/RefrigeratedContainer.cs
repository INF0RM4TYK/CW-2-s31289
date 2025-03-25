namespace ContainerSort;

public class RefrigeratedContainer : Kontener, IHazardNotifier
{
    public string ProductType { get; set; }
    public double Temperature { get; set; }


    public RefrigeratedContainer(char type, double height, double tareWeight, double depth, double maxLoad) : base(type, height, tareWeight, depth, maxLoad)
    {
        
        
        
        
    }
    
    
    

    public void NotifyHazard(string message, string containerSerialNumber)
    {
        throw new NotImplementedException();
    }
}
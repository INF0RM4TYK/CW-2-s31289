

namespace ContainerSort;

public abstract class Kontener
{



    private static int nextSerial = 0;

    protected double LoadWeight { get; set; }
    public double Height { get; set; }
    public double TareWeight { get; set; }
    public double Depth { get; set; }
    public string SerialNumber { get; set; }
    public double MaxLoad { get; set; }



    public Kontener(char type, double height, double tareWeight, double depth, double maxLoad)
    {
        Height = height;
        TareWeight = tareWeight;
        Depth = depth;
        SerialNumber = $"KON-{type}-{nextSerial++}";
        MaxLoad = maxLoad;
    }



    public virtual void Empty()
    {
        LoadWeight = 0;
    }

    
    public virtual void Load(double weight)
    {
        if (weight < 0 || weight > MaxLoad)
        {
            throw new OverfillException("Za duzo ladunku lub niepoprawna wartosc!");
        }
        
        LoadWeight += weight;

    }
    
    // public virtual void Unload(double weight)
    // {
    //     if (weight < 0 || weight > MaxLoad)
    //     {
    //         throw new OverfillException("Za duzo ladunku lub niepoprawna wartosc!");
    //     }
    //     
    //     Weight -= weight;
    // }

    public double getLoad()
    {
        return LoadWeight;
    }
}

public class OverfillException : Exception
{
    public OverfillException(string message) : base(message) { }
}   
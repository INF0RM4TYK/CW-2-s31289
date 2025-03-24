

namespace ContainerSort;

public abstract class Kontener
{



    private static int nextSerial = 0;

    public double Weight { get; set; }
    public double Height { get; set; }
    public double TareWeight { get; set; }
    public double Depth { get; set; }
    public string SerialNumber { get; set; }
    public double MaxLoad { get; set; }



    public Kontener(double weight, double height, double tareWeight, double depth, string serialNumber ,double maxLoad)
    {
        Weight = weight;
        Height = height;
        TareWeight = tareWeight;
        Depth = depth;
        SerialNumber = serialNumber;
        MaxLoad = maxLoad;
    }



    public virtual void empty()
    {
        Weight = 0;
    }


    public virtual void load(double weight)
    {
        
        
        
    }



}
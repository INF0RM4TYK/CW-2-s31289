namespace ContainerSort;

public class LiquidContainer : Kontener, IHazardNotifier
{
    
    public bool IsDangerous { get; set; }

    public LiquidContainer(double height, double tareWeight, double depth, double maxLoad, bool isDangerous)
        : base('L', height, tareWeight, depth, maxLoad)    // L - Liquid
    {
        IsDangerous = IsDangerous;
    }

    

    public void NotifyHazard(string message)
    {
        throw new NotImplementedException();
    }
}
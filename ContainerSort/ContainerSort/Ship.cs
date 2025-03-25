namespace ContainerSort;

public class Ship
{
    
    public string ShipSerialNumber { get; set; }
    public double MaxSpeed { get; set; }
    public int MaxContainers { get; set; }
    public double MaxContainersLoadWeight { get; set; }
    private List<Kontener> _konteners = new List<Kontener>();
   


    public Ship(string shipSerialNumber, double maxSpeed, int maxContainers, double maxContainersLoadWeight)
    { 
        ShipSerialNumber = shipSerialNumber;
        MaxSpeed = maxSpeed;
        MaxContainers = maxContainers;
        MaxContainersLoadWeight = maxContainersLoadWeight;
    }


    public void AddKontener(Kontener kontener)
    {

        if (_konteners.Count >= MaxContainers)
        {
            throw new OverflowException($"Statek {ShipSerialNumber} is full");

        }

        double totalWeightAfterAdding = _konteners.Sum(k => k.GetLoad() + k.TareWeight) + kontener.GetLoad() + kontener.TareWeight;
        if (totalWeightAfterAdding > MaxContainersLoadWeight * 1000)  // -> razy 1000 poniewaz Containers sa w [kg] a statek w [t] tonach
        {
            throw new InvalidOperationException($"Dodanie kontenera {kontener.SerialNumber} przekroczy limit wagi statku {ShipSerialNumber}");
        }
        
        
        
        
        



        _konteners.Add(kontener);
        Console.WriteLine($"Dodano kontener {kontener.SerialNumber} - aktualna waga kontenerow wynosi {totalWeightAfterAdding} - Statek: {ShipSerialNumber}");

    }


    public void AddKonteners(List<Kontener> kontenersToAdd)
    {
        foreach (var kontener in kontenersToAdd)
        {
            AddKontener(kontener);
        }
    }
    
    
    






}
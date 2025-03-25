namespace ContainerSort;

public class Ship
{
    
    public string ShipSerialNumber { get; set; }
    public double MaxSpeed { get; set; }
    public int MaxContainers { get; set; }
    public double MaxContainersLoadWeight { get; set; }
    public List<Kontener?> _konteners = new List<Kontener?>();
   


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


    public void AddKonteners(List<Kontener?> kontenersToAdd)
    {
        foreach (var kontener in kontenersToAdd)
        {
            AddKontener(kontener);
        }
    }

    public void RemoveKontener(string serialNumber)
    {
        Kontener? kontenerDoUsuniecia = _konteners.FirstOrDefault(k => k.SerialNumber == serialNumber);
        if (kontenerDoUsuniecia != null)
        {
            Console.WriteLine($"Usunieto kontener {kontenerDoUsuniecia} ze statku {ShipSerialNumber}");
            _konteners.Remove(kontenerDoUsuniecia);
        }
        else
        {
            throw new ArgumentException($"Kontener {serialNumber} nie znajduje sie na statku {ShipSerialNumber}");
        }
    }


    public void ZamienKontener(string kontenerSerialNumber, Kontener nowyKontener)
    {
        RemoveKontener(kontenerSerialNumber);
        AddKontener(nowyKontener);
        Console.WriteLine($"Zastapiono kontener {kontenerSerialNumber} kontenerem {nowyKontener.SerialNumber} na statku o numerze {ShipSerialNumber}");
        
    }


    public void PrzeniesNaInnyStatek(Ship shipDoKtoregoChcemyPrzeniesc, string kontenerSerialNumber)
    {
        
        Kontener kontenerDoTransferowania = _konteners.FirstOrDefault(k => k.SerialNumber == kontenerSerialNumber);// iterujemy ziomeczka i znajdujemy ten ktory ma same serial number 

        if (kontenerDoTransferowania != null)
        {
            try
            {
                shipDoKtoregoChcemyPrzeniesc.AddKontener(kontenerDoTransferowania);
                _konteners.Remove(kontenerDoTransferowania);
                Console.WriteLine(
                    $"Przeniesiono kontener {kontenerSerialNumber} ze statku {ShipSerialNumber} na statek {shipDoKtoregoChcemyPrzeniesc.ShipSerialNumber}");
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine(e.Message);
            }
        }
        
    }

    public void EmptyStatekFromKontener(string kontenerSerialNumber)
    {
        Kontener kontenerDoEmptyowania = _konteners.FirstOrDefault(k => k.SerialNumber == kontenerSerialNumber);

        if (kontenerDoEmptyowania != null)
        {
            kontenerDoEmptyowania.Empty();
        }


    }


    public void WypisujInfoOStatku()
    {
        
        Console.WriteLine($"Statek: {ShipSerialNumber}");
        Console.WriteLine($"V-max: {MaxSpeed} wezlow");
        Console.WriteLine($"Max kontenerow: {MaxContainers}");
        Console.WriteLine($"Max ladownosc: {MaxContainersLoadWeight} t");
        Console.WriteLine("Lista kontenerow na statku: ");

        foreach (var kontener in _konteners)
        {
            Console.WriteLine(kontener);
        }
        
        
        Console.WriteLine($"Lacznie kontenerow: {_konteners.Count} o wadze {_konteners.Sum(k => k.GetLoad() + k.TareWeight) / 1000 } tons na statku {ShipSerialNumber}");
    }




    public Kontener GetKooontener(string kontenerSerialNumber)
    {
        return _konteners.FirstOrDefault(c => c.SerialNumber == kontenerSerialNumber);
    }






}
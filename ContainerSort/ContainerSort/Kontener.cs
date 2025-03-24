

namespace ContainerSort;

public class Kontener
{
    
    public double Masa {get; set;}
    public double Wyskosc {get; set;}
    public double WagaWlasna {get; set;}
    public double Glebokosc {get; set;} 
    public string NumerSeryjny {get; set;}
    public double MaxLadownosc {get; set;} 
    
    
    
    public Kontener(double masa, double wyskosc, double wagaWlasna, double glebokosc, string numerSeryjny, double maxLadownosc)
    { 
        Masa = masa;
        Wyskosc = wyskosc;
        WagaWlasna = wagaWlasna;
        Glebokosc = glebokosc;   
        NumerSeryjny = numerSeryjny;
        MaxLadownosc = maxLadownosc;
    }

    
    
    
    

}
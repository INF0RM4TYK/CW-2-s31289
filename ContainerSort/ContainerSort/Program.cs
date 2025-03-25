namespace ContainerSort;

class Program
{
    static void Main(string[] args)
    {
        TestLiquidContainer();
        
    }

    static void TestLiquidContainer()
    {
        try
        {
            LiquidContainer container = new LiquidContainer(250, 500, 200, 10000, true);
            GasContainer gasContainer = new GasContainer(250, 500, 200, 10000, 12);
            
            // container.Empty();
            container.Load(3000);
            
            gasContainer.Load(1000);
            Console.WriteLine("Ilosc ladunku dla danego kontenera " + container.GetLoad() + " " + container.ToString());
            Console.WriteLine("Ilosc ladunku dla danego kontenera " + gasContainer.GetLoad() + " " + gasContainer.ToString());
            container.Empty();
            gasContainer.Empty();
         
        }
        catch (OverfillException ex)
        {
            Console.WriteLine($"Test OK: {ex.Message}");
        }

        // ... więcej testów
    }
}
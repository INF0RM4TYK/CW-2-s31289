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
            
            // container.Empty();
            container.Load(3000);
            Console.WriteLine("Ilosc ladunku dla danego kontenera " + container.getLoad());
         
        }
        catch (OverfillException ex)
        {
            Console.WriteLine($"Test OK: {ex.Message}");
        }

        // ... więcej testów
    }
}
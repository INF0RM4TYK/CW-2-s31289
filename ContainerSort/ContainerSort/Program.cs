namespace ContainerSort;

class Program
{
    static void Main(string[] args)
    {
        TestLiquidContainer();

        // Console.ReadKey(); 
    }

    static void TestLiquidContainer()
    {
        try
        {
            LiquidContainer container = new LiquidContainer(250, 500, 200, 10000, true);
            container.Empty();
            container.Load(5100);
            Console.WriteLine("Test nie powiódł się - brak wyjątku!"); 
        }
        catch (OverfillException ex)
        {
            Console.WriteLine($"Test OK: {ex.Message}");
        }

        // ... więcej testów
    }
}
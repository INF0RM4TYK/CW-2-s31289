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
            
            RefrigeratedContainer refrigeratedContainer = new RefrigeratedContainer(250, 500, 200, 10000, "Bananas",0);
            refrigeratedContainer.Load(2000);
            refrigeratedContainer.SetProductType("Fish");
            refrigeratedContainer.Load(2000);
        }
        
        catch (WrongItemsException ex)
        {
            Console.WriteLine(ex.Message);
        }

        // ... więcej testów
    }
}
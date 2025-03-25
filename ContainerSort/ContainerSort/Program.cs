namespace ContainerSort;

class Program
{
    static void Main(string[] args)
    {
        TestContainer();
        
    }

    static void TestContainer()
    {
        // try
        // {
        //     LiquidContainer container = new LiquidContainer(250, 500, 200, 10000, true);
        //     
        //     RefrigeratedContainer refrigeratedContainer = new RefrigeratedContainer(250, 500, 200, 10000, "Bananas",0);
        //     refrigeratedContainer.Load(2000);
        //     refrigeratedContainer.SetProductType("Fish");
        //     refrigeratedContainer.Load(2000);
        // }
        //
        // catch (WrongItemsException ex)
        // {
        //     Console.WriteLine(ex.Message);
        // }

        // ... więcej testów
        
        
        
        Ship ship1 = new Ship("B-1", 20, 100, 5000);


        // -> Tworze kontenery
        LiquidContainer liquidContainer = new LiquidContainer(250, 500, 200, 10000, true);
        GasContainer gasContainer = new GasContainer(200, 400, 150, 8000, 10);
        RefrigeratedContainer refrigeratedContainer = new RefrigeratedContainer(250, 500, 200, 10000, "Bananas", 10);

        // -> Dodawaje kontenerów do statku
        ship1.AddKontener(liquidContainer);
        ship1.AddKontener(gasContainer);
        ship1.AddKontener(refrigeratedContainer);
        
        // -> Wypisywanie informacji o statku
        Console.WriteLine("------------------------------------------"); 
        Console.WriteLine();
        Console.WriteLine();
        ship1.WypisujInfoOStatku();
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("------------------------------------------"); 
        // -> Tworze drugi statek
        
        Ship ship2 = new Ship("B-2", 25, 150, 7000);

        
        Console.WriteLine("Przenoszenie:");
        Console.WriteLine();
        // -> Przenoszenie kontenera między statkami
        ship1.PrzeniesNaInnyStatek(ship2, refrigeratedContainer.SerialNumber);
        
        Console.WriteLine();
        Console.WriteLine("------------------------------------------");
        Console.WriteLine();
        ship2.WypisujInfoOStatku();
        Console.WriteLine();

        
        ship1.EmptyStatekFromKontener(liquidContainer.SerialNumber);
        
        Console.WriteLine();
        Console.WriteLine("------------------------------------------");
        Console.WriteLine("Zamiana");
        Console.WriteLine();
        ship1.ZamienKontener(gasContainer.SerialNumber, refrigeratedContainer); // Powinno zastapic gasContainer -> refrigerated
        Console.WriteLine();
        Console.WriteLine(); 
        ship1.WypisujInfoOStatku();
        Console.WriteLine();
        Console.WriteLine("------------------------------------------");
        Console.WriteLine();
        ship2.WypisujInfoOStatku();
        
        
        Console.WriteLine("------------------------------------------"); 
        Console.WriteLine();
        
        
        
        
        ship1.EmptyStatekFromKontener(refrigeratedContainer.SerialNumber);
        // ship1.WypisujInfoOStatku();
        // ship2.WypisujInfoOStatku();


        Console.WriteLine(ship1.GetKooontener("KON-C-1"));

        
        
        
        
    }
}
using System;
using Conteners;

class Program
{
    static void Main(string[] args)
    {
        
        // tworzenie kontenerow
        LiquidContainer container1 = new(500, 5000, 250, 600);
        LiquidContainer container2 = new(500, 5000, 250, 600);
        CoolingContainer container3 = new(500, 5000, 250, 600, "Ice cream", -18);
        LiquidContainer container4 = new(8000, 5000, 250, 600);
        GasContainer container5 = new(500, 5000, 250, 600, 1.5);
        LiquidContainer container6 = new(500, 5000, 250, 600);
        GasContainer container7 = new(500, 5000, 250, 600, 2);
        CoolingContainer container8 = new(500, 5000, 250, 600, "Bananas", 13.3);

        Container[] allContainers = [container1, container2, container3, container4, container5, container6, container7, container8];

        CoolingContainer singleContainer = new(500, 5000, 250, 650, "Chocolate", 18);
        LiquidContainer singleContainer2 = new(500, 5000, 250, 650);

        System.Console.WriteLine("numery seryjne kontenerow");
        foreach (var item in allContainers)
        {
            System.Console.WriteLine(item.SerialNumber);
        }

        System.Console.WriteLine("informacje o kontenerze i proba zaladowania zlego towaru do kontenera");
        
        container8.PrintContainerInfo();
        System.Console.WriteLine();
        container8.LoadContainerCargo(1000, "Bananas", 15);
        container8.LoadContainerCargo(1000, "Chocolate", 0);

        System.Console.WriteLine("\n--------------------------------------------");

        
        // zaladowanie i rozladowanie roznych kontenerow
        System.Console.WriteLine("\nwaga kontenerow przed zaladowaniem: ");
        System.Console.WriteLine(container1.WeightInKg);
        System.Console.WriteLine(container3.WeightInKg);
        System.Console.WriteLine(container5.WeightInKg);
        
        container1.LoadContainerCargo(2000, true);
        container3.LoadContainerCargo(3000, "Ice cream", -20);
        container5.LoadContainerCargo(4000);

        System.Console.WriteLine("\nwaga kontenerow po zaladowaniu: ");
        System.Console.WriteLine(container1.WeightInKg);
        System.Console.WriteLine(container3.WeightInKg);
        System.Console.WriteLine(container5.WeightInKg);

        container1.EmptyContainer();
        container3.EmptyContainer();
        container5.EmptyContainer();

        System.Console.WriteLine("\nwaga kontenerow po rozladowaniu: ");
        System.Console.WriteLine(container1.WeightInKg);
        System.Console.WriteLine(container3.WeightInKg);
        System.Console.WriteLine(container5.WeightInKg + " (kontener na gaz, wiec zostaje 5% ladunku)\n");


        // utworzenie statkow i proba zaladowanie na nie kontenerow
        System.Console.WriteLine("--------------------------------------------\n");

        Ship ship1 = new(15, 5, 10);
        Ship ship2 = new(10, 10, 20);

        System.Console.WriteLine("informacje o kontenerach, ktore nie zostaly dodane:");
        ship1.LoadContainerList(allContainers);
        System.Console.WriteLine("\ninformacje o pierwszym statku i jego ladunku:\n");
        ship1.PrintShipAndLoadInfo();

        ship2.LoadContainer(singleContainer);
        System.Console.WriteLine("\ninformacje o drugim statku i jego ladunku:\n");
        ship2.PrintShipAndLoadInfo();
        
        
        // zastapienie kontenera innym i usuniecie kontenera ze statku
        System.Console.WriteLine("\n--------------------------------------------");
        
        ship2.replaceContener("KON-C-9", singleContainer2);
        System.Console.WriteLine("\nzastapienie kontenera innym:\n");
        ship2.PrintShipAndLoadInfo();
        
        ship2.UnloadContainer(singleContainer2);
        System.Console.WriteLine("\nusuniecie kontenera ze statku:\n");
        ship2.PrintShipAndLoadInfo();
        

        // przeniesienie kontenera z ship1 na ship2

        System.Console.WriteLine("--------------------------------------------");
        System.Console.WriteLine("\nstatki przed przeniesieniem kontenerow:\n");
        ship1.PrintShipAndLoadInfo();
        ship2.PrintShipAndLoadInfo();
        
        ship1.TransferContainerToAnotherShip(container1, ship2);
        ship1.TransferContainerToAnotherShip(container2, ship2);
        ship1.TransferContainerToAnotherShip(container3, ship2);

        System.Console.WriteLine("\nstatki po przeniesieniu kontenerow:\n");
        ship1.PrintShipAndLoadInfo();
        ship2.PrintShipAndLoadInfo();
    }
}


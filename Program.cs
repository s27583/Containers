using System;
using Conteners;

class Program
{
    static void Main(string[] args)
    {
        LiquidContainer container0 = new(5000, 5000, 250, 600);
        LiquidContainer container1 = new(500, 5000, 250, 600);
        LiquidContainer container2 = new(500, 5000, 250, 600);
        GasContainer container6 = new(500, 5000, 250, 600, 2);
        CoolingContainer container7 = new(500, 5000, 250, 600, "Bananas", 13.3);

        System.Console.WriteLine(container7.WeightInKg);
        container7.LoadContainerCargo(4000, "Bananas", 13.2);
        System.Console.WriteLine(container7.WeightInKg);
        container7.EmptyContainer();
        System.Console.WriteLine(container7.WeightInKg);

        Ship ship = new(20,50,10);
        Ship ship2 = new(30,40,15);

        Container[] containers = [container0, container1];

        ship.LoadContainerList(containers);

        // ship.PrintShipAndLoadInfo();

        // ship.UnloadContainer(container1);

        ship.replaceContener("KON-L-1", container6);

        // ship.PrintShipAndLoadInfo();

        ship.TransferContainerToAnotherShip(container6, ship2);
        ship.TransferContainerToAnotherShip(container1, ship2);
        ship.TransferContainerToAnotherShip(container7, ship2);
        

        ship.PrintShipAndLoadInfo();
        System.Console.WriteLine("-=-=-=-=-=-=-=-=-");
        ship2.PrintShipAndLoadInfo();
    }
}


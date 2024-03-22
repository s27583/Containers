using System;
using Conteners;

class Program
{
    static void Main(string[] args)
    {
        LiquidContainer container0 = new(500, 5000, 250, 600);
        LiquidContainer container1 = new(500, 5000, 250, 600);
        LiquidContainer container2 = new(500, 5000, 250, 600);
        GasContainer container6 = new(500, 5000, 250, 600, 2);
        CoolingContainer container7 = new(500, 5000, 250, 600, "Bananas", 13.3);

        System.Console.WriteLine(container7.WeightInKg);
        container7.LoadContainerCargo(4000, "Bananas", 13.5);
        System.Console.WriteLine(container7.WeightInKg);
        container7.EmptyContainer();
        System.Console.WriteLine(container7.WeightInKg);

        Ship ship = new(50,50,10);

        Container[] containers = [container0, container1, container2];

        for (int i = 0; i < containers.Length; i++)
        {
            ship.LoadContainer(containers[i]);
        }

        foreach (var container in ship.Containers)
        {
            Console.WriteLine(container.SerialNumber);
        }
    }
}


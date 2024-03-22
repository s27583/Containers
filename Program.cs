using System;
using Conteners;

class Program
{
    static void Main(string[] args)
    {
        LiquidContainer container0 = new(5000, 500, 500, 500, 50);
        LiquidContainer container1 = new(5000, 500, 500, 500, 50);
        LiquidContainer container2 = new(5000, 500, 500, 500, 50);
        CoolingContainer container3 = new(5000, 500, 500, 500, 50);
        LiquidContainer container4 = new(5000, 500, 500, 500, 50);
        CoolingContainer container5 = new(5000, 500, 500, 500, 50);
        System.Console.WriteLine(container0.SerialNumber);
        System.Console.WriteLine(container1.SerialNumber);
        System.Console.WriteLine(container2.SerialNumber);
        System.Console.WriteLine(container3.SerialNumber);
        System.Console.WriteLine(container4.SerialNumber);
        System.Console.WriteLine(container5.SerialNumber);
System.Console.WriteLine();

        Ship ship = new(50,50,1000);

        Container[] containers = { container0, container1, container2, container3, container4, container5 };

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


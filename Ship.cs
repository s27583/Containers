using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Transactions;

namespace Conteners
{
    public class Ship
    {
        public int containerCounter { get; set; }
        public double shipLoadWeight { get; set; }
        public Ship(int speedInKnots, int maxContainers, double maxFullWeightInTones)
        {
            SpeedInKnots = speedInKnots;
            MaxContainers = maxContainers;
            MaxFullWeightInTones = maxFullWeightInTones;
            Containers = new List<Container>();
            containerCounter = 0;
            shipLoadWeight = 0;
        }

        public int SpeedInKnots { get; set; }
        public int MaxContainers { get; set; }
        public double MaxFullWeightInTones { get; set; }
        public List<Container> Containers { get; set; }

        public void LoadContainer(Container container)
        {
            if (containerCounter >= MaxContainers)
            {
                System.Console.WriteLine("too many containers - container " + container.SerialNumber + " has not been added");
                return;
            }

            if (shipLoadWeight + container.WeightInKg > MaxFullWeightInTones * 1000)
            {
                System.Console.WriteLine("too heavy container - container " + container.SerialNumber + " has not been added");
                return;
            }

            Containers.Add(container);
            containerCounter++;
            shipLoadWeight += container.WeightInKg;
        }

        public void UnloadContainer(Container container)
        {
            Containers.Remove(container);
            containerCounter--;
            shipLoadWeight -= container.WeightInKg;
        }

        public void LoadContainerList(Container[] containers)
        {
            for (int i = 0; i < containers.Length; i++)
            {
                LoadContainer(containers[i]);
            }
        }

        public void PrintShipAndLoadInfo()
        {
            System.Console.WriteLine("ship speed in knots = " + SpeedInKnots);
            System.Console.WriteLine("ship's max containers = " + MaxContainers);
            System.Console.WriteLine("ship max weight in tones = " + MaxFullWeightInTones * 1000);
            System.Console.WriteLine("ship's current load weight in kg = " + shipLoadWeight);
            System.Console.WriteLine("amount of containers on ship = " + containerCounter + "\n");
            if (Containers.Count != 0) {
                System.Console.WriteLine("ship's load:");
                foreach (var c in Containers)
                {
                    System.Console.WriteLine(c.SerialNumber + ", " + c.WeightInKg + "kg");
                }
            } else {
                System.Console.WriteLine("this ship doesn't have any containers");
            }
            System.Console.WriteLine();
        }

        public void replaceContener(string containerNumber, Container container)
        {
            for (int i = 0; i < Containers.Count(); i++)
            {
                if (Containers[i].SerialNumber.Equals(containerNumber))
                {
                    Containers[i] = container;
                }
            }
        }

        public void TransferContainerToAnotherShip(Container container, Ship ship)
        {
            if (this.Containers.Contains(container)) {
                this.Containers.Remove(container);
                ship.LoadContainer(container);
                containerCounter--;
            } else {
                System.Console.WriteLine("ship doesn't have this container loaded on so it can't be transfered");
            }
        }
    }
}

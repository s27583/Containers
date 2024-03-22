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
        public Ship(int speedInKnots, int maxContainers, double maxFullWeightInTones)
        {
            SpeedInKnots = speedInKnots;
            MaxContainers = maxContainers;
            MaxFullWeightInTones = maxFullWeightInTones;
            Containers = new List<Container>();
            containerCounter = 0;
        }

        public int SpeedInKnots { get; set; }
        public int MaxContainers { get; set; }
        public double MaxFullWeightInTones { get; set; }
        public List<Container> Containers { get; set; }

        public void LoadContainer(Container container) {
            if (containerCounter < MaxContainers) {
                System.Console.WriteLine("too many containers - container has not been added");
                return;
            }

            if (container.WeightInKg > MaxFullWeightInTones*1000) {
                System.Console.WriteLine("too heavy container - container has not been added");
                return;
            }            
            
            Containers.Add(container);
            containerCounter++;
            MaxFullWeightInTones += container.WeightInKg/1000;
        }

    }
}
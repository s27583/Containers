using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Transactions;

namespace Conteners
{
    public class Ship
    {
        public Ship(int speedInKnots, int maxContainers, int maxFullWeightInTones)
        {
            SpeedInKnots = speedInKnots;
            MaxContainers = maxContainers;
            MaxFullWeightInTones = maxFullWeightInTones;
            Containers = new List<Container>();
        }

        public int SpeedInKnots { get; set; }
        public int MaxContainers { get; set; }
        public int MaxFullWeightInTones { get; set; }
        public List<Container> Containers { get; set; }

        public void LoadContainer(Container container) {
            Containers.Add(container);
        }

    }
}
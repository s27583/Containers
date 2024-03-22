using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Conteners
{
    public class GasContainer : Container, IHazardNotifier
    {
        public double PressureInAtm { get; set; }
        public GasContainer(int weightInKg, int capacity, int heightInCm, int depthInCm, double pressureInAtm)
         : base(weightInKg, capacity, heightInCm, depthInCm)
        {
            PressureInAtm = pressureInAtm;
            SerialNumber = $"KON-G-{nextSerialNumber++}";
        }

        public void EmptyContainer() {
            WeightInKg = (int)(WeightInKg* 0.05);
            NotifyDanger(SerialNumber);
        }

        public void NotifyDanger(string containerNumber)
        {
            System.Console.WriteLine("dangerous situation in Gas container " + containerNumber + " - 5% of container's load is still in container");
        }

    }
}
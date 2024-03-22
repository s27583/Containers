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

        public override void PrintContainerInfo() 
        {
            System.Console.WriteLine("\ncontainer serial number = " + SerialNumber);
            System.Console.WriteLine("container weight in kg = " + WeightInKg);
            System.Console.WriteLine("container capacity = " + Capacity);
            System.Console.WriteLine("container height in cm = " + HeightInCm);
            System.Console.WriteLine("container depth in cm = " + DepthInCm);
            System.Console.WriteLine("container pressure in atm = " + PressureInAtm);
        }

        public void NotifyDanger(string containerNumber)
        {
            System.Console.WriteLine("dangerous situation in Gas container " + containerNumber + " - 5% of container's load is still in container");
        }

    }
}
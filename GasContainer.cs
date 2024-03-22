using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Conteners
{
    public class GasContainer : Container, IHazardNotifier
    {
        public double Pressure { get; set; }
        public GasContainer(int heightInCm, int weightInKg, int depthInCm, int capacity, double pressure)
         : base(weightInKg, capacity, heightInCm, depthInCm)
        {
            Pressure = pressure;
            SerialNumber = $"KON-G-{nextSerialNumber++}";
        }

        public void NotifyDanger(string containerNumber)
        {
            System.Console.WriteLine("dangerous situation in Gas container" + containerNumber);
        }

    }
}
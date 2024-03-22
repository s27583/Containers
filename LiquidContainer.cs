using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace Conteners
{
    public class LiquidContainer : Container, IHazardNotifier
    {
        public bool IsLoadDangerous { get; set; }
        public LiquidContainer(int weightInKg, int capacity, int heightInCm, int depthInCm)
         : base(weightInKg, capacity, heightInCm, depthInCm)
        {
            SerialNumber = $"KON-L-{nextSerialNumber++}";
        }

        public void LoadContainerCargo(int massWeight, bool IsLoadDangerous) {
            if (IsLoadDangerous) {
                massWeight = (int)(massWeight * 0.5);
            } else {
                massWeight = (int)(massWeight * 0.9);
            }

            if (WeightInKg + massWeight > Capacity) {
                NotifyDanger(SerialNumber);
            } else {
                WeightInKg += massWeight;
            }
        }

        public void NotifyDanger(string containerNumber)
        {
            System.Console.WriteLine("dangerous situation in Liquid container" + containerNumber);
        }
    }
}
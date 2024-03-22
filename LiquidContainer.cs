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


            if (massWeight > Capacity) {
                throw new OverfillException(SerialNumber);
            }

            if (IsLoadDangerous) {
                Capacity = (int)(Capacity * 0.5);
            } else {
                Capacity = (int)(Capacity * 0.9);
            }

            if (WeightInKg + massWeight > Capacity) {
                NotifyDanger(SerialNumber);
            } else {
                WeightInKg += massWeight;
            }

        }

        public void NotifyDanger(string containerNumber)
        {
            System.Console.WriteLine("dangerous situation in Liquid container " + containerNumber + " - cargo has not been loaded");
        }

    }
}
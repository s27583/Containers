using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Conteners
{
    public class LiquidContainer : Container, IHazardNotifier
    {
        public LiquidContainer(int massInKg, int heightInCm, int containerWeightInKg, int depthInCm, int maxCapacity)
         : base(massInKg, heightInCm, containerWeightInKg, depthInCm, maxCapacity)
        {
            SerialNumber = $"KON-L-{nextSerialNumber++}";
        }

        public override void EmptyContainer()
        {
            throw new NotImplementedException();
        }

        public override void LoadContainer(int massWeight)
        {
            throw new NotImplementedException();
        }

        public void NotifyDanger(string containerNumber)
        {
            System.Console.WriteLine(this);
        }
    }
}
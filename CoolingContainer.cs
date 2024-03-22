using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Conteners
{
    public class CoolingContainer : Container
    {
        public CoolingContainer(int massInKg, int heightInCm, int rWeightInKg, int depthInCm, int maxCapacity)
         : base(massInKg, heightInCm, rWeightInKg, depthInCm, maxCapacity)
        {
            SerialNumber = $"KON-C-{nextSerialNumber++}";
        }

    }
}
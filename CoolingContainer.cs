using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Conteners
{
    public class CoolingContainer : Container
    {
        public CoolingContainer(int heightInCm, int weightInKg, int depthInCm, int capacity)
         : base(weightInKg, capacity, heightInCm, depthInCm)
        {
            SerialNumber = $"KON-C-{nextSerialNumber++}";
        }

    }
}
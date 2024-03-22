using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

public class OverfillException : Exception
{
    public OverfillException(string container) : base ("Too much load in container " + container){
        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

public abstract class Container
{
    public static int nextSerialNumber = 1;

    public int MassInKg { get; set; }
    public int HeightInCm { get; set; }
    public int WeightInKg { get; set; }
    public int DepthInCm { get; set; }
    public int MaxCapacity { get; set; }
    public string SerialNumber { get; set; }


    public Container(int massInKg, int heightInCm, int rWeightInKg, int depthInCm, int maxCapacity)
    {
        MassInKg = massInKg;
        HeightInCm = heightInCm;
        WeightInKg = WeightInKg;
        DepthInCm = depthInCm;
        MaxCapacity = maxCapacity;
        SerialNumber = $"KON-C-{nextSerialNumber}";
    }

    public abstract void EmptyContainer();
    public void LoadContainer(int massWeight){
        if (MaxCapacity < MassInKg) {
            throw new OverfillException();
        }
        
    }

    
}
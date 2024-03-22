using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

public abstract class Container
{
    public static int nextSerialNumber = 1;

    public int CargoMassInKg { get; set; }
    public int HeightInCm { get; set; }
    public int WeightInKg { get; set; }
    public int DepthInCm { get; set; }
    public int Capacity { get; set; }
    public string SerialNumber { get; set; }


    public Container(int weightInKg, int capacity, int heightInCm, int depthInCm)
    {
        HeightInCm = heightInCm;
        WeightInKg = weightInKg;
        DepthInCm = depthInCm;
        Capacity = capacity;
        SerialNumber = $"KON-C-{nextSerialNumber}";
    }

    public void EmptyContainer() {
        CargoMassInKg = 0;
    }
    public void LoadContainerCargo(int massWeight){
        if (Capacity < massWeight) {
            throw new OverfillException();
        }

        WeightInKg += massWeight;
        
    }

    
}
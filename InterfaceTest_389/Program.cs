using System;

namespace InterfaceTest_389
{
    class Program
    {
        static void Main(string[] args)
        {
            IClown.CarCapacit = 18;
            Console.WriteLine(IClown.ClownCarDescription());

            IClown fingersTheClown = new ScaryScary("big red nose", 14);
            fingersTheClown.Honk();
           if(fingersTheClown is IScaryClown newScaryCloen)
            {
                newScaryCloen.ScareLittleChildren();
            }
        
        }
    }
}

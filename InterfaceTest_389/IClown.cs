using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceTest_389
{
    interface IClown
    {
        string FunnyThingUHave { get; }
        void Honk();
        protected static Random random = new Random();
        private static int carCapacity = 12;
        public static int CarCapacit 
        { 
            get { return carCapacity; }
            set
            {
                if (value > 10) carCapacity = value;
                else Console.Error.WriteLine($"Warning: Car capacity {value} is too small");
            }
        }
        public static string ClownCarDescription()
        {
            return $"A clown car with {random.Next(CarCapacit / 2, CarCapacit)} clowns";
        }
    }
}

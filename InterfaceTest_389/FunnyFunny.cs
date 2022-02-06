using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceTest_389
{
    class FunnyFunny : IClown
    {
        private string funnyThingIhave;
        public string FunnyThingUHave { get { return funnyThingIhave; } }
    
        public  FunnyFunny(string funnyThingIhave)
        {
            this.funnyThingIhave = funnyThingIhave;
            Honk();
        }


        public void Honk()
        {
            Console.WriteLine("Hi Kids i have a {0}", funnyThingIhave);
        }
    }
}

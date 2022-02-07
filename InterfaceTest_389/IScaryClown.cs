using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceTest_389
{
    interface IScaryClown: IClown
    {
        string ScaryThingsHave { get; }
        void ScareLittleChildren();
        void ScareAdults()
        {
            Console.WriteLine($@"I am an ancient evil that will haunt your dreams.
Behold my terrifying necklace with {random.Next(4, 110)} of my last victim's fingers.
Oh, also, before I forget...");
            ScareLittleChildren();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceTest_389
{
    interface IScaryClown: IClown
    {
        string ScaryThingsHave { get; }
        void ScareLittleChildren();
    }
}

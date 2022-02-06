using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceTest_389
{
    class ScaryScary : FunnyFunny,IScaryClown
    {
        private int scaryThnigCount;
        public ScaryScary(string funnyThing, int scaryThnigCount): base(funnyThing)
        {
            this.scaryThnigCount = scaryThnigCount;
        }
        
        public string ScaryThingsHave
        {
            get
            { return $"{ scaryThnigCount} spiders"; }
        }
        
        public void ScareLittleChildren()
        {
            Console.WriteLine($"Boo! Gotcha Look at my {ScaryThingsHave}");
        }
    }
}


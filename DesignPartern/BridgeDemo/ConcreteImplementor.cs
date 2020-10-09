using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPartern.BridgeDemo
{
    class Kick : IAtack
    {
        public string Action()
        {
            return "Use Food to kick";
        }
    }

    class ThrowRock : IAtack
    {
        public string Action()
        {
            return "Throw a heavyrock";
        }
    }

    class Puch : IAtack
    {
        public string Action()
        {
            return "Punch player face";
        }
    }
}

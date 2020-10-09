using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPartern.BridgeDemo
{
    abstract class Enemy
    {
        protected IAtack atkaction;
        public Enemy(IAtack iatk)
        {
            this.atkaction = iatk;
        }
        public abstract string Attack();
    }
}

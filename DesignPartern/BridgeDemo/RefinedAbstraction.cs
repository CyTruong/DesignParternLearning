using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPartern.BridgeDemo
{
    class Orc : Enemy
    {
        public Orc(IAtack iatk) : base(iatk)
        {

        }
        public override string Attack()
        {
            return "Orc atk by " + atkaction.Action();
        }
    }

    class Skeleton : Enemy
    {
        public Skeleton(IAtack iatk) : base(iatk)
        {

        }

        public override string Attack()
        {
            return "Skeleton atk by " + atkaction.Action();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPartern.AbstractFactoryDemo
{
    class VictorianChair : Chair
    {
        public string HasLeg()
        {
            return "Victorian Chair has four long legs.";
        }

        public string Sit()
        {
            return "Sit on Victorian Chair.";
        }
    }

    class ArtChair : Chair
    {
        public string HasLeg()
        {
            return "Art Deco Chair has four short legs.";
        }

        public string Sit()
        {
            return "Return 'Sit on Art Deco Chair.;";
        }
    }

    class VictorianSofa : Sofa
    {
        public string HasLeg()
        {
            return "Victorian Sofa has four long legs.";
        }

        public string Sit()
        {
            return "Sit on Victorian Sofa.";
        }
    }

    class ArtSofa : Sofa
    {
        public string HasLeg()
        {
            return "Art Sofa has four long legs.";
        }

        public string Sit()
        {
            return "Sit on Art Deco Sofa.";
        }
    }

    class VictorianTable : Table
    {
        public string HasLeg()
        {
            return "Victorian Coffee Table has four long legs.";
        }

        public string Put()
        {
            return "Put something on Victorian Coffee Table.";
        }
    }

    class ArtTable : Table
    {
        public string HasLeg()
        {
            return "Art Deco Coffee Table has only one leg.";
        }

        public string Put()
        {
            return "Put something on Art Deco Table.";
        }
    }
}

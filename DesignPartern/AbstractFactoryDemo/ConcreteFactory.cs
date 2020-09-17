using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPartern.AbstractFactoryDemo
{
    class VictorianFurnitureFactory : FurnitureFactory
    {
        public Chair createChair()
        {
            return new VictorianChair();
        }

        public Sofa createSofa()
        {
            return new VictorianSofa();
        }

        public Table createTable()
        {
            return new VictorianTable();
        }
    }

    class ArtFurnitureFactory : FurnitureFactory
    {
        public Chair createChair()
        {
            return new ArtChair();
        }

        public Sofa createSofa()
        {
            return new ArtSofa();
        }

        public Table createTable()
        {
            return new ArtTable();
        }
    }
}

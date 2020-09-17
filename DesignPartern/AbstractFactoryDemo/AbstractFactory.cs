using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPartern.AbstractFactoryDemo
{
    interface FurnitureFactory
    {
        Chair createChair();
        Table createTable();
        Sofa createSofa();
    }
}

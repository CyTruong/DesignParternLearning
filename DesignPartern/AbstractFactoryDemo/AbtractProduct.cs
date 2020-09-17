using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPartern.AbstractFactoryDemo
{
    interface Chair
    {
        string HasLeg();
        string Sit();
    }

    interface Sofa
    {
        string HasLeg();
        string Sit();
    }
    interface Table
    {
        string HasLeg();
        string Put();
    }
}

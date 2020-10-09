using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPartern.AdapterDemo
{
    public interface Translatetarget
    {
        void Send(string words);
        string Get();
    }
}

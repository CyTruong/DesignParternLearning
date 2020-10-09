using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPartern.AdapterDemo
{
    class EnglishAdapter : Translatetarget
    {

        EnglishAdaptee adaptee;


        string _result;

        public string Get()
        {
            return _result;
        }

        public void Send(string words)
        {
             adaptee = new EnglishAdaptee();
            _result = adaptee.Receive(words);
        }

    }

    class JapAdapter : Translatetarget
    {
        JapanAdaptee adaptee;

        string _result;
        public string Get()
        {
            return _result;
        }

        public void Send(string words)
        {
            adaptee = new JapanAdaptee();
            _result = adaptee.Toru(words);
        }

    }
}

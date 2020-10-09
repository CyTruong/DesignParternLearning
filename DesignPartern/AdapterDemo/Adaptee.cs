using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPartern.AdapterDemo
{
    public class JapanAdaptee
    {   
        public string Toru(string words) //取る : Nhận
        {
            return "JAP :" +words ;
        }
    }

    public class EnglishAdaptee
    {
        public string Receive(string words) //Nhận
        {
            return "EN : "+words;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPartern.MethodFactoryDemo
{
    public abstract class Page
    {
        public int Pagenumber { get; set; }
        public string Header { get; set; }
        public string Content { get; set; }


        public abstract void FormatContent(); 
    }
}

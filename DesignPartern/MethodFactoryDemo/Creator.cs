using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPartern.MethodFactoryDemo
{
    abstract class Document
    {
        private List<Page> _pages = new List<Page>();
        public string DocName { get; set; }

        public List<Page> Pages
        {
            get { return _pages; }
        }

        public abstract void CreatePages();
    }
}

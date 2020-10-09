using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPartern.DecoratorDemo
{
    class FileDataSource : DataSource
    {
        private string _filename;

        public string currentdata;

        public FileDataSource(string name)
        {
            this._filename = name;
        }

        public string readData()
        {
            return currentdata;
        }

        public void writeData(string datastr)
        {
            currentdata =  _filename+" write : " + datastr;
        }
    }
}

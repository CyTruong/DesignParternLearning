using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPartern.DecoratorDemo
{
    public  class FileSourceDecorator : DataSource
    {
        private DataSource _datasource;

        public FileSourceDecorator(DataSource dataSource)
        {
            this._datasource = dataSource;
        }
        public virtual string readData()
        {
            return _datasource.readData();
        }

        public virtual void writeData(string datastr)
        {
            _datasource.writeData(datastr);
        }
    }
}

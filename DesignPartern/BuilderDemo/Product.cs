using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPartern.BuilderDemo
{
    public class BankAccount
    {
        private string _bankname;
        private Dictionary<string, string> _field =
          new Dictionary<string, string>();

        // Constructor
        public BankAccount(string bankname)
        {
            this._bankname = bankname;
        }

        // Indexer
        public string this[string key]
        {
            get { return _field[key]; }
            set { _field[key] = value; }
        }

        public string Show()
        {
            return "Name : " + _field["name"] + "@" + "Id : " + _field["id"] + " phonenumber" + _field["phone"];
        }

        public string getBankname()
        {
            return _bankname;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPartern.BuilderDemo
{
    abstract class ABankAccBuilder
    {
        protected BankAccount bankaccount;

        public BankAccount BankAccount
        {
            get { return bankaccount;  }
        }

        public abstract ABankAccBuilder setUsername(string username);
        public abstract ABankAccBuilder setId(string id);
        public abstract ABankAccBuilder setPhonenumber(string sdt);
    }
}

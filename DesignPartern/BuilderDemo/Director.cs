using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPartern.BuilderDemo
{
    class Bank
    {
        public BankAccount Contruct(ABankAccBuilder builder)
        {
            return builder.BankAccount;
        }
    }
}

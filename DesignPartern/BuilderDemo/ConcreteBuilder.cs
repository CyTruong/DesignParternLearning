using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPartern.BuilderDemo
{
    class SacombankBuilder : ABankAccBuilder
    {
        public SacombankBuilder()
        {
            bankaccount = new BankAccount("Sacombank");
        }

        public override ABankAccBuilder setId(string id)
        {
            BankAccount["id"] = "84-" + id;
            return this;
        }

        public override ABankAccBuilder setPhonenumber(string sdt)
        {
            BankAccount["phone"] = sdt;
            return this;

        }

        public override ABankAccBuilder setUsername(string username)
        {
            BankAccount["name"] ="SA "+ username;
            return this;

        }
    }

    class ViettinbankBuilder : ABankAccBuilder
    {
        public ViettinbankBuilder()
        {
            bankaccount = new BankAccount("Viettinbank");
        }

        public override ABankAccBuilder setId(string id)
        {
            BankAccount["id"] = "72-" + id;
            return this;

        }

        public override ABankAccBuilder setPhonenumber(string sdt )
        {
            BankAccount["phone"] = sdt;
            return this;

        }

        public override ABankAccBuilder setUsername(string username)
        {
            BankAccount["name"] = "VI " + username;
            return this;

        }
    }

}

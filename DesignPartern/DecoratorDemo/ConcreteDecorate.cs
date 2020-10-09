using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPartern.DecoratorDemo
{
    public class EncryptionDecorator : FileSourceDecorator
    {
        private string result; 

        public EncryptionDecorator(DataSource dataSource) :base (dataSource)
        {
        }
        public override string readData()
        {
            return result + " => " + result.Replace("abcxyz", "").Replace("123456","");
        }
        
        public override void writeData(string datastr)
        {
            result = Encrypt(datastr);
        }

        private string Encrypt(string input)
        {
            return "abcxyz"+input + "123456";
        }
    }



    public class CompressDecorator : FileSourceDecorator
    {
        private string result;

        public CompressDecorator(DataSource dataSource) : base (dataSource)
        {

        }
        public override string readData()
        {
            return result;
        }

        public override void writeData(string datastr)
        {
            result = datastr.Trim().ToLower();
        }
    }
}

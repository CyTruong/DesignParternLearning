using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace DesignPartern.FacadeDemo
{
    /// <summary>
    /// Interaction logic for FacadeDemo.xaml
    /// </summary>
    public partial class FacadeDemo : Window
    {
        mEncrypt encrypt;
        public FacadeDemo()
        {
            encrypt = new mEncrypt();

            InitializeComponent();
        }

        private void Btres_Click(object sender, RoutedEventArgs e)
        {
            if (cb1.IsChecked==true && cb2.IsChecked==true && cb3.IsChecked==true)
            {
               lbres.Content=   encrypt.SuperEncrype(input.Text);
            }
            else
            {
                if (cb1.IsChecked == true)
                {
                    lbres.Content = encrypt.RSA_Encrype.getResult(input.Text);
                }
                if (cb2.IsChecked == true)
                {
                    lbres.Content = encrypt.DES_Encrype.getResult(input.Text);
                }
                if (cb3.IsChecked == true)
                {
                    lbres.Content = encrypt.AES_Encrype.getResult(input.Text);
                }
            }
        }
    }

    class mEncrypt
    {
        public RSA_Encrype RSA_Encrype { get; set; }
        public DES_Encrype DES_Encrype { get; set; }
        public AES_Encrype AES_Encrype { get; set; }

        public mEncrypt()
        {
            RSA_Encrype = new RSA_Encrype();
            DES_Encrype = new DES_Encrype();
            AES_Encrype = new AES_Encrype();
        }

        public string SuperEncrype(string input) {
            string res = RSA_Encrype.getResult(input);
            res = DES_Encrype.getResult(res);
            return AES_Encrype.getResult(res);
        }

       
    }


    class RSA_Encrype
    {
        public string getResult(string input)
        {
            return input + " with RSA";
        }
    }
    class DES_Encrype
    {
        public string getResult(string input)
        {
            return input + " with DES";
        }
    }
    class AES_Encrype
    {
        public string getResult(string input)
        {
            return input + " with RSA";
        }
    }
}

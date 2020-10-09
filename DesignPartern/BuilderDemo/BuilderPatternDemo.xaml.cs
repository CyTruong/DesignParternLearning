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

namespace DesignPartern.BuilderDemo
{
    /// <summary>
    /// Interaction logic for BuilderPatternDemo.xaml
    /// </summary>
    public partial class BuilderPatternDemo : Window
    {
        public BuilderPatternDemo()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
        }

        private void Sacombt_Click(object sender, RoutedEventArgs e)
        {
            string id = IdTextBox.Text;
            string name = NameTextBox.Text;
            string sdt = PhonenumberTextbox.Text;
            ABankAccBuilder builder = new SacombankBuilder().setId(id).setPhonenumber(sdt).setUsername(name);
            Result resultwindown = new Result(builder.BankAccount);
            resultwindown.Show();

        }

        private void Viettinbt_Click(object sender, RoutedEventArgs e)
        {
            string id = IdTextBox.Text;
            string name = NameTextBox.Text;
            string sdt = PhonenumberTextbox.Text;
            ABankAccBuilder builder = new ViettinbankBuilder().setId(id).setPhonenumber(sdt).setUsername(name);
            Result resultwindown = new Result(builder.BankAccount);
            resultwindown.Show();
        }
    }





   
}

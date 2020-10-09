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

namespace DesignPartern.AdapterDemo
{
    /// <summary>
    /// Interaction logic for AdapterDemo.xaml
    /// </summary>
    public partial class AdapterDemo : Window
    {
        public AdapterDemo()
        {
            InitializeComponent();
        }

        private void BtVi_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtEng_Click(object sender, RoutedEventArgs e)
        {
            Translatetarget target = new EnglishAdapter();
            string text = tbinput.Text;
            target.Send(text);
            string result = target.Get();
            lbEng.Content = result;
        }

        private void BtJap_Click(object sender, RoutedEventArgs e)
        {
            Translatetarget target = new JapAdapter();
            string text = tbinput.Text;
            target.Send(text);
            string result = target.Get();
            lbjap.Content = result;
        }
    }
}

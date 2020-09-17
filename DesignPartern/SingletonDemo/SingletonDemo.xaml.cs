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

namespace DesignPartern.SingletonDemo
{
    /// <summary>
    /// Interaction logic for SingletonDemo.xaml
    /// </summary>
    public partial class SingletonDemo : Window
    {
        public SingletonDemo()
        {
            InitializeComponent();
        }

        private void BtCreate_Click(object sender, RoutedEventArgs e)
        {
            CountWindown windown = new CountWindown();
            windown.Show();
        }
    }
}

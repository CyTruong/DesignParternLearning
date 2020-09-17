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
    /// Interaction logic for CountWindown.xaml
    /// </summary>
    public partial class CountWindown : Window
    {
        private int count;
        public CountWindown()
        {
            InitializeComponent();
            count = LazyInstance.GetInstance().GetCount();
            lbCount.Content = "Current count : " + count;
        }

        private void BtUpdate_Click(object sender, RoutedEventArgs e)
        {
            count = LazyInstance.GetInstance().GetCount();
            lbCount.Content = "Current count : " + count;
        }

        private void BtIncrease_Click(object sender, RoutedEventArgs e)
        {
            LazyInstance.GetInstance().IncCount();
            count = LazyInstance.GetInstance().GetCount();
            lbCount.Content = "Current count : " + count;

        }
    }
}

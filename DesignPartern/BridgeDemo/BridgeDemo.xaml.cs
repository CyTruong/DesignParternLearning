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

namespace DesignPartern.BridgeDemo
{
    /// <summary>
    /// Interaction logic for BridgeDemo.xaml
    /// </summary>
    public partial class BridgeDemo : Window
    {
        private Enemy _enemy;
        private IAtack _atk;
        public BridgeDemo()
        {
            InitializeComponent();
            _atk = new ThrowRock();
            _enemy = new Orc(_atk);
        }

        private void BtOrc_Click(object sender, RoutedEventArgs e)
        {
            _enemy = new Orc(_atk);
        }

        private void BtSkeleton_Click(object sender, RoutedEventArgs e)
        {
            _enemy = new Skeleton(_atk);
        }

        private void ThrowRockbt_Click(object sender, RoutedEventArgs e)
        {
            _atk = new ThrowRock();
        }

        private void Kickbt_Click(object sender, RoutedEventArgs e)
        {
            _atk = new Kick();
        }

        private void Punchbt_Click(object sender, RoutedEventArgs e)
        {
            _atk = new Puch();
        }

        private void Actionbt_Click(object sender, RoutedEventArgs e)
        {
            lbResult.Content = _enemy.Attack();
        }
    }
}

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

namespace DesignPartern.PrototypeDemo
{
    /// <summary>
    /// Interaction logic for PrototypeDemo2.xaml
    /// </summary>
    public partial class PrototypeDemo2 : Window,PrototypeStudenWindown
    {
        public string Name { get; set; }
        public string Class { get; set; }
        public string Status { get; set; }

        public PrototypeDemo2()
        {
            InitializeComponent();
        }


        private void Btcopy_Click(object sender, RoutedEventArgs e)
        {
            PrototypeDemo2 demo = Clone() as PrototypeDemo2;
            demo.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            demo.Show();
        }

        #region Hàm ko liên quan
        private void Btclose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Tb1_TextChanged(object sender, TextChangedEventArgs e)
        {
            Name = tb1.Text;
        }

        private void Tb2_TextChanged(object sender, TextChangedEventArgs e)
        {
            Class = tb2.Text;
        }

        private void Tb3_TextChanged(object sender, TextChangedEventArgs e)
        {
            Status = tb3.Text;
        }
        #endregion

        
        public PrototypeStudenWindown Clone()
        {
            return this.MemberwiseClone() as PrototypeStudenWindown;
        }
    }

    public interface PrototypeStudenWindown
    {
        PrototypeStudenWindown Clone();
    }
}

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

namespace DesignPartern.DecoratorDemo
{
    /// <summary>
    /// Interaction logic for DecoratorDemo.xaml
    /// </summary>
    public partial class DecoratorDemo : Window
    {
        private DataSource datasource;
        private string content;

        public DecoratorDemo()
        {
            InitializeComponent();
        }

        private void Compressbt_Click(object sender, RoutedEventArgs e)
        {
            datasource = new CompressDecorator(datasource);
            datasource.writeData(contenttb.Text);
            resultlb.Content = "Wrote";


        }

        private void Encryptbt_Click(object sender, RoutedEventArgs e)
        {
            datasource = new EncryptionDecorator(datasource);
            datasource.writeData(contenttb.Text);
            resultlb.Content = "Wrote";

        }

        private void Normalbt_Click(object sender, RoutedEventArgs e)
        {
            datasource = new FileDataSource("A.txt");
            datasource.writeData(contenttb.Text);
            resultlb.Content = "Wrote";

        }

        private void Read_Click(object sender, RoutedEventArgs e)
        {
            resultlb.Content = datasource.readData() ;

        }

        private void Content_TextChanged(object sender, TextChangedEventArgs e)
        {
            this.content = contenttb.Text;
        }
    }



}

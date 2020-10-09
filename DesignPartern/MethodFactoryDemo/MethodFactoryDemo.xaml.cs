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

namespace DesignPartern.MethodFactoryDemo
{
    /// <summary>
    /// Interaction logic for MethodFactoryDemo.xaml
    /// </summary>
    public partial class MethodFactoryDemo : Window
    {
        public MethodFactoryDemo()
        {
            InitializeComponent();
        }

        private void Dictionary_Click(object sender, RoutedEventArgs e)
        {
            Document doc = new Dictionary();

            doc.CreatePages();
            foreach(var page in doc.Pages)
            {
                page.FormatContent();
                PageWindown windown = new PageWindown(page);
                windown.Title = doc.DocName;
                windown.Show();
                
            }
        }

        private void Report_Click(object sender, RoutedEventArgs e)
        {
            Document doc = new Report();

            doc.CreatePages();
            foreach (var page in doc.Pages)
            {
                page.FormatContent();
                PageWindown windown = new PageWindown(page);
                windown.Title = doc.DocName;
                windown.Show();

            }
        }
    }
}

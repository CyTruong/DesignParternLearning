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
    /// Interaction logic for PageWindown.xaml
    /// </summary>
    public partial class PageWindown : Window
    {
        public PageWindown(Page page)
        {
            InitializeComponent();
            lbcontent.Content = page.Content;
            lbheader.Content = page.Header;
            if (page.Pagenumber != 0)
            {
                lbpagenum.Content = page.Pagenumber.ToString();
            }
            else
            {
                lbpagenum.Content = "";
            }
        }
    }
}

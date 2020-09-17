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

namespace DesignPartern.AbstractFactoryDemo
{
    /// <summary>
    /// Interaction logic for AbstractFactoryPaternDemo.xaml
    /// </summary>
    public partial class AbstractFactoryPaternDemo : Window
    {
        public AbstractFactoryPaternDemo()
        {
            InitializeComponent();
        }
            
        private void CreateVictorian_Click(object sender, RoutedEventArgs e)
        {
            FurnitureFactory factory = new VictorianFurnitureFactory();
            PrintResult(factory);
        }

        private void CreateArt_Click(object sender, RoutedEventArgs e)
        {
            FurnitureFactory factory = new ArtFurnitureFactory();
            PrintResult(factory);
        }

        private void PrintResult(FurnitureFactory factory){
            lbChair.Content = "Chair : " + factory.createChair().HasLeg() + " " + factory.createChair().Sit();
            lbSofa.Content = "Sofa : " + factory.createSofa().HasLeg() + " " + factory.createSofa().Sit();
            lbTable.Content = "Table : " + factory.createTable().HasLeg() + " " + factory.createTable().Put();

        }

    }
}

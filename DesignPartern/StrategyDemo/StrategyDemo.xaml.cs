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

namespace DesignPartern.StrategyDemo
{
    /// <summary>
    /// Interaction logic for StrategyDemo.xaml
    /// </summary>
    public partial class StrategyDemo : Window
    {
        List<Line> lines;
        public StrategyDemo()
        {
            InitializeComponent();
            lines = new List<Line>();
            lines.Add(AB); //0
            lines.Add(AC); //1
            lines.Add(AD); //2
            lines.Add(BD); //3 
            lines.Add(CD); //4
            lines.Add(DE); //5
            lines.Add(CE); //6
            
        }


        private void Motobt_Click(object sender, RoutedEventArgs e)
        {
            TranportContext context = new TranportContext();
            context.SetTranportStagety(new MotorTanport());
            context.UpdateWay(lines);
        }

        private void Otobt_Click(object sender, RoutedEventArgs e)
        {
            TranportContext context = new TranportContext();
            context.SetTranportStagety(new OtoTranport());
            context.UpdateWay(lines);
        }

        private void Trainbt_Click(object sender, RoutedEventArgs e)
        {
            TranportContext context = new TranportContext();
            context.SetTranportStagety(new TrainTranport());
            context.UpdateWay(lines);
        }

        private void Cleanbt_Click(object sender, RoutedEventArgs e)
        {
            foreach(var line in lines)
            {
                line.Stroke = Brushes.Blue;
            }
        }
    }



    //Stagety
    public abstract class TranportStagety
    {
        public abstract void DrawWay(List<Line> inLine);
    }

    //'ConcreteStrategy' class
    class MotorTanport : TranportStagety
    {
        public override void DrawWay(List<Line> inLine)
        {
            inLine.ElementAt(1).Stroke = Brushes.Red;
            inLine.ElementAt(4).Stroke = Brushes.Red;
            inLine.ElementAt(5).Stroke = Brushes.Red;
        }
    }

    class OtoTranport : TranportStagety
    {
        public override void DrawWay(List<Line> inLine)
        {
            inLine.ElementAt(0).Stroke = Brushes.Red;
            inLine.ElementAt(3).Stroke = Brushes.Red;
            inLine.ElementAt(5).Stroke = Brushes.Red;
        }
    }

    class TrainTranport : TranportStagety
    {
        public override void DrawWay(List<Line> inLine)
        {
            inLine.ElementAt(2).Stroke = Brushes.Red;
            inLine.ElementAt(5).Stroke = Brushes.Red;
        }
    }

    //'Context' class
    class TranportContext
    {
        private TranportStagety _tranportStagety;
        public void SetTranportStagety(TranportStagety tranportStagety)
        {
            this._tranportStagety = tranportStagety;
        }

        public void UpdateWay(List<Line> lines)
        {
            _tranportStagety.DrawWay(lines);
        }
    }

}

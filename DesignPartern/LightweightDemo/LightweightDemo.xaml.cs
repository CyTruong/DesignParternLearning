using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace DesignPartern.LightweightDemo
{
    /// <summary>
    /// Interaction logic for LightweightDemo.xaml
    /// </summary>
    public partial class LightweightDemo : Window
    {
        Random ran = new Random();
        Brush[] COLORs = { Brushes.AliceBlue , Brushes.Red , Brushes.Yellow , Brushes.Black , Brushes.Cyan
                , Brushes.Gold , Brushes.Green , Brushes.Gray, Brushes.Firebrick};

        public LightweightDemo()
        {
            InitializeComponent();
            Stopwatch timer = new Stopwatch();
            timer.Start();

            Process currentProcess = Process.GetCurrentProcess();
            long usedMemory = currentProcess.PrivateMemorySize64;

            for (int i = 0; i<10000;i++)
            {
                //AShape shape = ShapeFactory.getShape(getRanColor());
                //shape.Draw(Canvas, getRanX(), getRanX(), getRanY(), getRanY());

                System.Windows.Shapes.Line
                  line = new System.Windows.Shapes.Line();
                line.X1 = getRanX();
                line.X2 = getRanX();
                line.Y1 = getRanY();
                line.Y2 = getRanY();
                line.Stroke = getRanColor();
                line.StrokeThickness = 5;
                Canvas.Children.Add(line);
            }
            timer.Stop();
            long usedMemory2 = currentProcess.PrivateMemorySize64;
            label.Content = "Draw in " + timer.Elapsed.TotalMilliseconds.ToString() + " milis With : " + (usedMemory2) + " byte";


        }


        private int getRanX()
        {          
            return ran.Next((int)this.Width);
        }

        private int getRanY()
        {
            return ran.Next((int)this.Height);
        }

        private Brush getRanColor()
        {
            return COLORs[ (ran.Next(COLORs.Length)) ];
        }
    }




}

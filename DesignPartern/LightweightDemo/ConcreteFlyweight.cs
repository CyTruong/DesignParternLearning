using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;

namespace DesignPartern.LightweightDemo
{
    class mLine : AShape
    {
        //private int x1, x2, y1, y2;
        public mLine(Brush color) : base(color)
        {
        }
      

     

        public override void Draw(Panel panel, int x1, int x2, int y1, int y2)
        {
            System.Windows.Shapes.Line
            line = new System.Windows.Shapes.Line();
            line.X1 = x1;
            line.X2 = x2;
            line.Y1 = y1;
            line.Y2 = y2;
            line.Stroke = color;
            line.StrokeThickness = 5;
            panel.Children.Add(line);
        }
    }
}

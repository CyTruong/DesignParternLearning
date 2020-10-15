using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace DesignPartern.LightweightDemo
{
    class ShapeFactory
    {
        public static Dictionary<Brush, AShape> ColortoShape = new Dictionary<Brush, AShape>();

        public static AShape getShape( Brush color)
        {
            if (ColortoShape.ContainsKey(color))
            {
                return ColortoShape[color];
            }
            else
            {
                AShape mshape = new mLine(color);
                ColortoShape.Add(color, mshape);
                return mshape;
            }
        }
    }
}

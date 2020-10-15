using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;

namespace DesignPartern.LightweightDemo
{
    public abstract class AShape {

       protected Brush color;
        
        public AShape(Brush color)
        {
            this.color = color;
        }
       public abstract void Draw(Panel panel,int x1,int x2,int y1, int y2);
    }
}

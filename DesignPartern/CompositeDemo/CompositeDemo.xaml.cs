using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace DesignPartern.CompositeDemo
{
    /// <summary>
    /// Interaction logic for CompositeDemo.xaml
    /// </summary>
    public partial class CompositeDemo : Window
    {
        public CompositeDemo()
        {
            InitializeComponent();

            List<Graphic> DrawingContents = new List<Graphic>();

            Graphic grap1 = new Line(0,0,100,100);
            Graphic grap2 = new Line(200, 150, 400, 500);
            Graphic grap3 = new Line(100, 0, 100, 600);
            Graphic grap4 = new Line(10, 500, 300, 100);
            Graphic grap5 = new Rectangle(50, 50, 160, 160);
            DrawingContents.Add(grap1);
            DrawingContents.Add(grap2);
            DrawingContents.Add(grap3);
            DrawingContents.Add(grap4);
            DrawingContents.Add(grap5);

            Graphic group1 = new GraphicGroup(DrawingContents);


            List<Graphic> DrawingContents2 = new List<Graphic>();
            Graphic grap6 = new Line(300, 0, 800, 100);
            Graphic grap7 = new Line(0, 0, 800, 800);
            DrawingContents2.Add(grap6);
            DrawingContents2.Add(grap7);
            DrawingContents2.Add(group1);

            Graphic group2 = new GraphicGroup(DrawingContents2);


            group2.Draw(canvasPanel);


        }
    }

 

    /// <summary>
    /// The 'Component' Treenode
    /// </summary>
    interface Graphic 
    {
        void Draw(Panel panel);
    }


    
    class Line : Graphic
    {
        private int x1;
        private int y1;
        private int x2;
        private int y2;

        public Line(int x1,int x2,int y1,int y2)
        {
            this.x1 = x1;
            this.x2 = x2;
            this.y1 = y1;
            this.y2 = y2;
        }

        public void Draw(Panel panel)
        {
            #region Vẽ đường thẳng
            System.Windows.Shapes.Line
            line = new System.Windows.Shapes.Line();
            line.X1 = x1;
            line.X2 = x2;
            line.Y1 = y1;
            line.Y2 = y2;
            line.Stroke = Brushes.Black;
            line.StrokeThickness = 5;
            panel.Children.Add(line);
            #endregion
        }
    }

    class Rectangle : Graphic
    {

        private int x1;
        private int y1;
        private int width;
        private int height;

        public Rectangle(int x1 , int y1 , int width ,int height)
        {
            this.x1 = x1;
            this.y1 = y1;
            this.width = width;
            this.height = height;
        }

        public  void Draw(Panel panel)
        {
            #region Vẽ hình chữ nhật
            Line line = new Line(x1,x1+width,y1,y1);
            line.Draw(panel);

            Line line2 = new Line(x1,x1,y1,y1+height);
            line2.Draw(panel);

            Line line3 = new Line(x1+width, x1 + width, y1, y1 + height);
            line3.Draw(panel);

            Line line4 = new Line(x1,x1+width,y1+height,y1+height);
            line4.Draw(panel);
            #endregion
        }

    }


    class GraphicGroup : Graphic
    {
        private List<Graphic> graps = new List<Graphic>();

        public GraphicGroup(List<Graphic> graphics)
        {
            this.graps = graphics;
        }

        public  void Draw(Panel panel)
        {
            foreach (Graphic grap in graps)
            {
                grap.Draw(panel);
            }
        }

        public void Add(Graphic grap)
        {
            graps.Add(grap);
        }

        public void Remove(Graphic grap)
        {
            graps.Remove(grap);
        }

        public Graphic Get(int index)
        {
           return graps.ElementAt(index);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Windows.Threading;


namespace DesignPartern.StateDemo
{
    /// <summary>
    /// Interaction logic for StateDemo.xaml
    /// </summary>
    public partial class StateDemo : Window
    {
        int imgindex = 0;
        Megaman megaman;
        public StateDemo()
        {
            megaman = new Megaman(new MegamanSlideState());

            InitializeComponent();
            Timer _timer = new Timer();
            _timer = new Timer(150);
            _timer.Elapsed += OnTimedEvent;
            _timer.Enabled = true;

        }

        private void OnTimedEvent(Object source, ElapsedEventArgs e)
        {
            Dispatcher.Invoke(() =>
            {
                megaman.Render(image);
            
            });
        }
    }


    /// <summary>
    /// The 'Context' class
    /// </summary>
    class Megaman
    {
        public State state { get; set; }
        public Megaman(State state)
        {
            this.state = state;
        }

        public void Render(System.Windows.Controls.Image img)
        {
            this.state.Draw(this, img);
        }
    }

    /// <summary>
    /// The 'State' abstract class
    /// </summary>
    abstract class State
    {
        protected int imgIndex;

        protected Dictionary<int, Bitmap> resImg = new Dictionary<int, Bitmap>();
        public abstract void Draw(Megaman context , System.Windows.Controls.Image Targetimg);

        protected BitmapImage Convert(Bitmap src)
        {
            MemoryStream ms = new MemoryStream();
            ((System.Drawing.Bitmap)src).Save(ms, System.Drawing.Imaging.ImageFormat.Bmp);
            BitmapImage image = new BitmapImage();
            image.BeginInit();
            ms.Seek(0, SeekOrigin.Begin);
            image.StreamSource = ms;
            image.EndInit();
            return image;
        }
    }


    /// <summary>
    /// A 'ConcreteState' class
    /// </summary>
    class MegamanRunningState : State
    {
        public MegamanRunningState()
        {
            resImg.Clear();
            resImg.Add(0, Properties.Resources.Megaman_Run00);
            resImg.Add(1, Properties.Resources.Megaman_Run01);
            resImg.Add(2, Properties.Resources.Megaman_Run02);
            resImg.Add(3, Properties.Resources.Megaman_Run03);
            resImg.Add(4, Properties.Resources.Megaman_Run04);
            resImg.Add(5, Properties.Resources.Megaman_Run05);
            resImg.Add(6, Properties.Resources.Megaman_Run06);
            resImg.Add(7, Properties.Resources.Megaman_Run07);
            resImg.Add(8, Properties.Resources.Megaman_Run08);
            resImg.Add(9, Properties.Resources.Megaman_Run09);
        }
        public override void Draw(Megaman context, System.Windows.Controls.Image Targetimg)
        {
            Targetimg.Source =  Convert( resImg[imgIndex]);

            imgIndex++;
            if (imgIndex> 9)
            {
               imgIndex = 0;
               context.state = new MegamanSlideState();
            }
        }
    }


    /// <summary>
    /// A 'ConcreteState' class
    /// </summary>
    class MegamanSlideState : State
    {
        public MegamanSlideState()
        {
            resImg.Clear();
            resImg.Add(0, Properties.Resources.Megaman_Slide00);
            resImg.Add(1, Properties.Resources.Megaman_Slide01);
            resImg.Add(2, Properties.Resources.Megaman_Slide02);
            resImg.Add(3, Properties.Resources.Megaman_Slide03);
            resImg.Add(4, Properties.Resources.Megaman_Slide04);
 
        }
        public override void Draw(Megaman context, System.Windows.Controls.Image Targetimg)
        {
            Targetimg.Source = Convert(resImg[imgIndex]);

            imgIndex++;
            if (imgIndex > 4)
            {
                imgIndex = 0;
                context.state = new MegamanRunningState();

            }
        }
    }
}

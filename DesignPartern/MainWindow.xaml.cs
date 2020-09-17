﻿using Microsoft.Win32;
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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Syncfusion.Presentation;
using System.IO;
using Syncfusion.OfficeChartToImageConverter;
using System.Drawing.Imaging;

namespace DesignPartern
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private System.Drawing.Image[] _images;
        private int _currentslide;
        private string _currentcontent;

        public MainWindow()
        {
            InitializeComponent();
            _currentslide = 0;
            _currentcontent = "";
        }

        private void ListViewItem_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            var item = sender as ListViewItem;
            Storyboard closeSb = this.FindResource("Closemenu") as Storyboard;
            closeSb.Begin();
            string filename = "";
            if (item != null )
            {
                _currentcontent = item.Name;

                if (item.Name.Equals("Singleton"))
                {
                    filename = "Asset/singleton.pptx";
                }
                if (item.Name.Equals("AbstractFactoryPatern"))
                {
                    filename = "Asset/AbstractFactoryPatern.pptx";
                }
            }
            if (!filename.Equals(""))
                loadImagefromfilename(filename);
        }

        private void loadImagefromfilename(string filename)
        {
            IPresentation pptxDoc = Presentation.Open(filename);
            pptxDoc.ChartToImageConverter = new ChartToImageConverter();
            pptxDoc.ChartToImageConverter.ScalingMode = Syncfusion.OfficeChart.ScalingMode.Best;
            _images = pptxDoc.RenderAsImages(Syncfusion.Drawing.ImageType.Metafile);          
            _currentslide = 0;
            loadImagetoUi(_currentslide);

        }

        private void loadImagetoUi(int pos)
        {
             Slideimage.Source = Convert(_images[pos]);
        }

        private BitmapImage Convert(System.Drawing.Image img)
        {
            using (var memory = new MemoryStream())
            {
                img.Save(memory, ImageFormat.Png);
                memory.Position = 0;

                var bitmapImage = new BitmapImage();
                bitmapImage.BeginInit();
                bitmapImage.StreamSource = memory;
                bitmapImage.CacheOption = BitmapCacheOption.OnLoad;
                bitmapImage.EndInit();

                return bitmapImage;
            }
        }
        private void BtnPrev_Click(object sender, RoutedEventArgs e)
        {
            if (_currentslide==0)
            {

            }else
                _currentslide--;

            loadImagetoUi(_currentslide);
        }

        private void BtnNext_Click(object sender, RoutedEventArgs e)
        {
            if (_currentslide == _images.Count()-1)
            {

            }
            else
                _currentslide++;
            loadImagetoUi(_currentslide);
        }

        private void BtDemo_Click(object sender, RoutedEventArgs e)
        {
            Window demowindown = null ;
            if (_currentcontent.Equals("Singleton"))
            {
                demowindown = new SingletonDemo.SingletonDemo();
            }
            if (_currentcontent.Equals("AbstractFactoryPatern"))
            {
                demowindown = new AbstractFactoryDemo.AbstractFactoryPaternDemo();
            }

            if (demowindown != null)
            {
                demowindown.Closed += Demowindown_Closed;
                demoBackGroud.Visibility = Visibility.Visible;
                demowindown.Show();
            }
        }

        private void Demowindown_Closed(object sender, EventArgs e)
        {
            demoBackGroud.Visibility = Visibility.Hidden;

        }
    }
}

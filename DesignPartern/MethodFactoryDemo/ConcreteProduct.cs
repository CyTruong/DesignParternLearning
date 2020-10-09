using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPartern.MethodFactoryDemo
{


    public class IntroductionPage : Page
    {
        public override void FormatContent()
        {
            Content = "Intro page " + Content;
        }
    }

    public class MenuPage : Page
    {
        public override void FormatContent()
        {
            Content = "Intro page " + Content;
        }
    }

    public class ConclutionPage : Page
    {
        public override void FormatContent()
        {
            Content = "Conclution: " + Content;

        }
    }

    public class NormalPage : Page
    {
        public override void FormatContent()
        {
            Content = "Normal Format " + Content;
        }
    }

}

                                                                                                                                                                                                                   
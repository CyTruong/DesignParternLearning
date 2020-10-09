using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPartern.MethodFactoryDemo
{
    class Dictionary : Document
    {
        public override void CreatePages()
        {
            DocName = "Dictionnary";
            Pages.Add(new IntroductionPage());
            Pages.Add(new NormalPage() { Content = "Hello = Chao", Pagenumber = 1 });
            Pages.Add(new NormalPage() { Content = "Hi = Chao", Pagenumber = 2 });
            Pages.Add(new NormalPage() { Content = "Bye = Tam biet", Pagenumber = 3 });
        }
    }

    class Report : Document
    {
        public override void CreatePages()
        {
            DocName = "Report";
            Pages.Add(new IntroductionPage() { Content = "Day la bao cao"});
            Pages.Add(new MenuPage() {Content = "Table of content "});
            Pages.Add(new NormalPage() { Content = "1 + 1 ?= 2" , Pagenumber= 1 , Header= "Bao cao khoa hoc" } );
            Pages.Add(new NormalPage() { Content = "2 + 2 ?= 4", Pagenumber = 2, Header = "Bao cao khoa hoc" } );
            Pages.Add(new ConclutionPage() { Content = "Tong ket ", Pagenumber = 3, Header = "Bao cao khoa hoc" });
        }
    }
}

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

namespace DesignPartern.PrototypeDemo
{
    /// <summary>
    /// Interaction logic for PrototypeDemo.xaml
    /// </summary>
    public partial class PrototypeDemo : Window
    {

        StudentPrototype prototype;
        public PrototypeDemo()
        {
            InitializeComponent();
            prototype = new AssignStudent();

        }

        public PrototypeDemo(StudentPrototype prototype)
        {
            InitializeComponent();
            this.prototype = prototype;
            tb1.Text = prototype["name"];
            tb2.Text = prototype["class"];
            tb3.Text = prototype["status"];
        }

        private void Btcopy_Click(object sender, RoutedEventArgs e)
        {
            PrototypeDemo demo = new PrototypeDemo(prototype.Clone());
            demo.Show();
        }

        private void Btclose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Tb1_TextChanged(object sender, TextChangedEventArgs e)
        {
            prototype["name"] = tb1.Text;
        }

        private void Tb2_TextChanged(object sender, TextChangedEventArgs e)
        {
            prototype["class"] = tb2.Text;
        }

        private void Tb3_TextChanged(object sender, TextChangedEventArgs e)
        {
            prototype["status"] = tb3.Text;
        }
    }

    /// <summary>
    /// The 'Prototype' abstract class
    /// </summary>
    public abstract class StudentPrototype
    {
        protected Dictionary<string, string> _field = new Dictionary<string, string>();
        public abstract StudentPrototype Clone();
       
        public string this[string key]
        {
            get { return _field[key]; }
            set { _field[key] = value; }
        }
    }

    class AssignStudent : StudentPrototype
    {   
        public AssignStudent()
        {
        }

        public AssignStudent(AssignStudent assignStudent)
        {
            this._field = assignStudent._field;
        }
        public override StudentPrototype Clone()
        {
            return new AssignStudent(this);
            //return this.MemberwiseClone() as StudentPrototype;
        }
    }    
}

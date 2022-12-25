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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;

namespace Wp2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string s;
        private string f;
        class Fly
        {
            string[] s = File.ReadAllText(@"D:\КУПК\3 курс\Практика 02\Практика 3\Wp2\s.txt").Split(' ');
            string[] f = File.ReadAllText(@"D:\КУПК\3 курс\Практика 02\Практика 3\Wp2\f.txt").Split(' ');
            public string Str(string f, string s)
            {
                if (f.Contains(s))
                {

                }
                return f;
            }
        }
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            StreamReader streamReader1 = new StreamReader(@"D:\КУПК\3 курс\Практика 02\Практика 3\Wp2\s.txt");
            s = streamReader1.ReadLine();
            StreamReader streamReader2 = new StreamReader(@"D:\КУПК\3 курс\Практика 02\Практика 3\Wp2\f.txt");
            f = streamReader2.ReadLine();
            Fly test = new Fly();
            dataGrid.Items.Add(new { Str = test.Str(f, s) });
        }
    }
}

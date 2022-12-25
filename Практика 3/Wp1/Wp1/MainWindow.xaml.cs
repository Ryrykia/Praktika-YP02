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

namespace Wp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string s;
        class Fly
        {
            string[] s = File.ReadAllLines(@"D:\КУПК\3 курс\Практика 02\Практика 3\Wp1\fly.txt").Where(s => s.Length > 60).ToArray();
            public string Str(string s)
            {
                foreach (var line in s)
                {

                }
                return s;
            }
        }
        public MainWindow()
        {
            InitializeComponent();
        }
     
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            StreamReader streamReader = new StreamReader(@"D:\КУПК\3 курс\Практика 02\Практика 3\Wp1\fly.txt");
            s = streamReader.ReadLine();
            Fly test = new Fly();
            dataGrid.Items.Add(new { Str = test.Str(s) });
        }
        
    }
}

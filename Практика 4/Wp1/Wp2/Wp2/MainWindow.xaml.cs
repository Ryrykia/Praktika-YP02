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

namespace Wp2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        class Lines
        {
            string[] lin =
            {
                "Солнце",
                "Небо",
                "Луна",
                "Звезды"
            };
            public string Lins()
            {
                var res = lin.Select(x => x[0]).Aggregate(new StringBuilder(), (sb, c) => sb.Append(c)).ToString();
                return res;
            }

        }
        private void Btn_Click(object sender, RoutedEventArgs e)
        {
            Lines l = new Lines();
            lab1.Content = l.Lins();
        }
    }
}

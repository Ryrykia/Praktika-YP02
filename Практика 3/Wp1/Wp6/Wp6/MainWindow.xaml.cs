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

namespace Wp6
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
        public class Router
        {
            public string Name { get; set; }
            public string Vendor { get; set; }
            public string Type { get; set; }
        }

        private void Btn_Click(object sender, RoutedEventArgs e)
        {
            List<Router> routers = new List<Router>
            {
            new Router{Name="CSR1000V", Vendor="Cisco", Type="Virtual"},
            new Router{Name="1921", Vendor="Cisco", Type="Hardware"},
            };
            dataGrid.ItemsSource = routers;
        }
    }
}

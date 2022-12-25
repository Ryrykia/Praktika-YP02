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

namespace Wp1
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
        class Min
        {
            int[] ar = { 1, 4, 5, 12, 18, 20};
            public int Rs()
            {
                var ans = from element in ar
                          where element > 0
                          select element;
                return (ans.Count() > 0 ? ans.Min() : 0);
            }
        }
        private void Btn_Click(object sender, RoutedEventArgs e)
        {
            Min min = new Min();
            lab1.Content = min.Rs();
        }
    }
}

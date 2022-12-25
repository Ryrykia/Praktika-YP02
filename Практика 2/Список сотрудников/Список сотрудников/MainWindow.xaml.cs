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
using System.Collections.ObjectModel;

namespace Список_сотрудников
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            data.Items.Add(new { Name = "Tom", Age = 18 });
            data.Items.Add(new { Name = "Bob", Age = 21 });
            data.Items.Add(new { Name = "Sam", Age = 23 });

        }
        private void Btn_Click(object sender, RoutedEventArgs e)
        {
            list.Items.Add(txt1.Text);
            data.Items.Add(new { Name = txt1.Text, Age = txt2.Text });
        }

        private void BtnExit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}

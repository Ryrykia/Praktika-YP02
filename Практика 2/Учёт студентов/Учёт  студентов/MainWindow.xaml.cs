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

namespace Учёт__студентов
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

        private void Btn_Click(object sender, RoutedEventArgs e)
        {
                list.SelectedItem = list.SelectedIndex;
                list.Items.Remove(list.SelectedItem);
                list.Items.Add(txt3.Text + " " + txt1.Text);
                data.SelectedItem = data.SelectedIndex;
                data.Items.Remove(data.SelectedItem);
                data.Items.Add(new { FirstName = txt1.Text, LastName = txt3.Text, Age = txt2.Text, Gruppa = txt4.Text });
            
        }

        private void Btn3_Click(object sender, RoutedEventArgs e)
        {
            list.Items.Add(txt3.Text + " " + txt1.Text);
            data.Items.Add(new { FirstName = txt1.Text, LastName = txt3.Text, Age = txt2.Text, Gruppa = txt4.Text });
        }

        private void Btn1_Click(object sender, RoutedEventArgs e)
        {
            list.SelectedItem = list.SelectedIndex;
            data.SelectedItem = data.SelectedIndex;
            data.Items.Remove(data.SelectedItem);
            list.Items.Remove(list.SelectedItem);
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            combo.SelectedItem = combo.SelectedIndex;
            txt4.Text = combo.Text;
        }

        private void Tab3_Drop(object sender, DragEventArgs e)
        {
            
        }

        private void Tab1_Drop(object sender, DragEventArgs e)
        {
            
        }

        private void Tab2_Drop(object sender, DragEventArgs e)
        {
           
        }

        private void Tab1_GotFocus(object sender, RoutedEventArgs e)
        {
            btn1.Visibility = Visibility.Visible;
            btn.Visibility = Visibility.Hidden;
            btn3.Visibility = Visibility.Hidden;
        }

        private void Tab2_GotFocus(object sender, RoutedEventArgs e)
        {
            btn3.Visibility = Visibility.Hidden;
            btn.Visibility = Visibility.Visible;
            btn1.Visibility = Visibility.Hidden;
        }

        private void Tab3_GotFocus(object sender, RoutedEventArgs e)
        {
            btn.Visibility = Visibility.Hidden;
            btn1.Visibility = Visibility.Hidden;
            btn3.Visibility = Visibility.Visible;
        }
    }
}

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

        List<Book> books = new List<Book>();

        //int id, string name, string author, string publisher, int year, int amount, double cost, string type
        private void Init()
        {
            Book b1 = new Book(0, "Skazka", "Me", "Moscow", 2022, 30, 550.5, "Tverdiy");
            Book b2 = new Book(0, "Name", "You", "Moscow", 2020, 30, 550.5, "Tverdiy");
            books.Add(b1);
            books.Add(b2);
        }
        public MainWindow()
        {
            Init();
            InitializeComponent();
        }

        
        private List<Book> SearchAuthor(string Name)
        {
            List<Book> answer = new List<Book>();

            for(int i=0; i<books.Count; ++i)
            {
                if (books[i].Author.ToLower().Contains(Name.ToLower()))
                {
                    answer.Add(books[i]);
                }
            }

            return answer;
        }



        private List<Book> SearchPublisher(string Name)
        {
            List<Book> answer = new List<Book>();

            for (int i = 0; i < books.Count; ++i)
            {
                if (books[i].Publisher.ToLower().Contains(Name.ToLower()))
                {
                    answer.Add(books[i]);
                }
            }

            return answer;
        }
        private List<Book> AfterCurrentYear(int year)
        {
            List<Book> answer = new List<Book>();

            for (int i = 0; i < books.Count; ++i)
            {
                if (books[i].yearOfPublish > year)
                {
                    answer.Add(books[i]);
                }
            }

            return answer;
        }



        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            listBox1.Items.Clear();

            if (textBox1.Text == "") return;

            var answer = SearchAuthor(textBox1.Text);
            for(int i=0; i < answer.Count; ++i)
            {
                listBox1.Items.Add(answer[i].ToString());
            }
            
        }

        private void searchPublsiher_Click(object sender, RoutedEventArgs e)
        {
            listBox1.Items.Clear();

            if (textBox1.Text == "") return;

            var answer = SearchPublisher(textBox1.Text);
            for (int i = 0; i < answer.Count; ++i)
            {
                listBox1.Items.Add(answer[i].ToString());
            }
        }

        private void searchForYear_Click(object sender, RoutedEventArgs e)
        {
            listBox1.Items.Clear();

            if (textBox1.Text == "") return;

            var answer = AfterCurrentYear(Convert.ToInt32(textBox1.Text));
            for (int i = 0; i < answer.Count; ++i)
            {
                listBox1.Items.Add(answer[i].ToString());
            }
        }
    }
}

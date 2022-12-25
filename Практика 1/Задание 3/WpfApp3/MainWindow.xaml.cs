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

namespace WpfApp3
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        Random rnd = new Random();
        public MainWindow()
        {
            InitializeComponent();
        }

        List<string> names = new List<string>() { "Василий", "Петя", "Евгений", "Александр", "Олег"};
        List<string> surnames = new List<string>() { "Шимон", "Смирнов", "Петров", "Ивванов", "Лебедев" };

        private void generate_butt_Click(object sender, RoutedEventArgs e)
        {
            int countOfCompetition = rnd.Next(7, 10);

            List<Competition> competitions = new List<Competition>();

            for(int i = 0; i < countOfCompetition; ++i)
            {
                List<Sportsman> thisComp = new List<Sportsman>();
                for(int j=0; j < 3; ++j)
                {
                    int sportsScore = rnd.Next(60);
                    Sportsman s1 = new Sportsman(names[rnd.Next(names.Count)] + " " + surnames[rnd.Next(surnames.Count)], sportsScore);
                    thisComp.Add(s1);
                }
                competitions.Add(new Competition(thisComp));
            }

 
            for (int i = 0; i < competitions.Count; ++i)
            {
                int number = i + 1;
                answerList.Items.Add("Соревнование " + number);
                List<Sportsman> winners = competitions[i].getWinner();
                for (int j = 0; j < winners.Count; ++j)
                {
                    answerList.Items.Add(winners[j].ToString());
                }
            }
        }
    }
}

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

namespace Wp4
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Random rnd = new Random();
        List<Client> clients = new List<Client>();
        List<string> clientNames = new List<string>()
        {
            "Дмитрий Макаров", "Елизавета Яковлева",
            "Мирослава Митрофанова", "Елизавета Ежова",
            "Денис Прокофьев", "Екатерина Лебедева",
            "Мира Никольская", "Надежда Федорова",
            "София Дроздовав", "Фёдор Виноградов"
        };

        List<string> statusList = new List<string>() { "None", "VIP", "Admin" };

        private void Init()
        {
            overall.Items.Clear();
            theOldestText.Items.Clear();
            clients.Clear();

            for (int i = 0; i<10; ++i)
            {
                clients.Add(new Client(clientNames[i], statusList[rnd.Next(3)], rnd.Next(18, 50)));
            }
        }

        private List<Client> getClients()
        {
            List<Client> answer = new List<Client>();
            var query = from client in clients
                        where client.status == "VIP" && client.age >= 20 && client.age <= 30
                        select client;
            query.ToList().ForEach(client => answer.Add(client));

            if(answer.Count == 0)
            {
                overall.Items.Add("Ни одного клиента удовл. условиям");
                return answer;
            }
            foreach(var client in answer)
            {
                overall.Items.Add(client.ToString());
            }

           

            return answer;

        }

        private Client getTheOldest(List<Client> answer)
        {
            return answer.Find(client => client.age == answer.Max(item => item.age));
            
        }
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Init();

            theOldestText.Items.Add(getTheOldest(getClients()));
        }
    }
}

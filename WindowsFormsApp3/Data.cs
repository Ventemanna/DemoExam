using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp3.Models;

namespace WindowsFormsApp3
{
    public class Data
    {
        public List<Client> clients = new List<Client>();
        public List<Order> orders = new List<Order>();
        public List<Post> posts = new List<Post>();
        public List<Status> statuses = new List<Status>();
        public List<Clients_orders> clients_orders = new List<Clients_orders>();

        private static Data _instance;
        public static Data Instance
        {
            get
            {
                if (_instance == null) { _instance = new Data(); }
                return _instance;
            }
        }

        public void Inizialize()
        {
            posts.Add(new Post("Пользователь"));
            posts.Add(new Post("Администратор"));

            statuses.Add(new Status("В процессе"));

            clients.Add(new Client(
                "Александр", 
                "Иванов", 
                "Николаевич", 
                "uchitel@gmail.com",
                "aspirantDrago", 
                "uchitel123", 
                "78003458923",
                posts[0]
                ));

            clients.Add(new Client(
                "Николай",
                "Иванов",
                "Александрович",
                "uchitel@gmail.com",
                "copp",
                "password",
                "78003458923",
                posts[1]
                ));




        }

    }
}

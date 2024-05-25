using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3.Models
{
    public class Client
    {
        static public int counterEntities = 0;

        public int Id { get; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Patronymic { get; set; }
        public string Email { get; set; }
        public string Login {  get; set; }
        public string Password { get; set; }
        public string Telephone_number { get; set; }
        public Post Post { get; set; }

        public Client(
            string name,
            string surname,
            string patronymic,
            string email,
            string login,
            string password,
            string telephone_number,
            Post post
            )
        {
            counterEntities++;
            Id = counterEntities;
            this.Name = name;
            this.Surname = surname;
            this.Patronymic = patronymic;
            this.Email = email;
            this.Login = login;
            this.Password = password;
            this.Telephone_number = telephone_number;
            this.Post = post;
        }



    }
}

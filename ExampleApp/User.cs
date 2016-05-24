using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleApp
{
    class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Role { get; set; }
        public DateTime DateOfAuthorisation { get; set; }

        public User()
        {
            Id = 1;
            Name = "Bill";
            Role = "Admin";
            DateOfAuthorisation = DateTime.Now;
        }

        //Інформація про користувача
        public void GetInformation()
        {
            Console.WriteLine("Користувач: {0}, Id: {1}, Роль: {2}", Name, Id, Role);
        }

        //Дата авторизації
        public void GetDate()
        {
            Console.WriteLine("Дата авторизації: {0}", DateOfAuthorisation);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class User
    {
        string login;
        string name;
        string lastName;
        int age;

        static public readonly DateTime curDate = DateTime.Now;

        public string Login
        {
            get { return login; }
            set { login = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public User(string login, string name, string lastName, int age)
        {
            Login = login;
            Name = name;
            LastName = lastName;
            Age = age;
        }

        public void ShowInfo()
        {
            Console.WriteLine("Login - " + login);
            Console.WriteLine("Name - " + name);
            Console.WriteLine("Lastname - " + lastName);
            Console.WriteLine("Age - " + age);
            Console.WriteLine("Data - " + curDate);
            Console.ReadKey();

        }
    }
}

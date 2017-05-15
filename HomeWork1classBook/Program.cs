using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            Author author = new Author();
            author.Content = "Vasia";

            Body body = new Body();
            body.Content = "BlaBla";

            Title title = new Title();
            title.Content = "Zdraste";

            Book book = new Book(author, body, title);
            book.Show();
            Console.ReadKey();
        }
    }
}

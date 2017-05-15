using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Book
    {
        Author author;
        Body body;
        Title title;

        public Book(Author author, Body body, Title title)
        {
            this.author = author;
            this.body = body;
            this.title = title;
        }

        public void Show()
        {
            this.author.Show();
            this.body.Show();
            this.title.Show();
        }
    }
}

using System;

namespace assingment
{
    class Book
    {
        public String name 
        {
            get;
        }

        public int pages 
        {
            get; 
        }

        public String author
        {
            get;
        }

        public Book(String n, String a, int p)
        {
            name = n;
            author = a;
            pages = p;
        }

        public void display()
        {
            Console.WriteLine($"Name : {this.name}\nAuthor: {this.author}\nPages {this.pages}");
        }

        public static void EntryPoint() 
        {
            Book b1 = new Book("It ends with us", "Colleen Hoover", 486);
            Book b2 = new Book("Master of the game", "Sidney Sheldon", 354);

            b1.display();
            b2.display();
        }
    }
}

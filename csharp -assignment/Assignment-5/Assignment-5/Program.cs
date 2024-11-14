using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_5
{
   
    class Book
    {
        string BookName;
        string AuthorName;
        
        public Book(string BookName, string AuthorName)
        {
            this.BookName = BookName;
            this.AuthorName = AuthorName;
        }

        
        public void Display()
        {
            Console.WriteLine($"Title of the book is {BookName} and Authored by {AuthorName}");
        }
    }
    
    class BookShelf
    {
        public Book[] Booklist = new Book[5];  
        public Book this[int i]
        {
            get { return Booklist[i]; }
            set { Booklist[i] = value; }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("*** Enter the Books details***");
            Console.WriteLine();
            string Bookname;
            string Authorname;

           
            BookShelf bs = new BookShelf();
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Enter book {i + 1} details");
                Console.Write("Enter the book name : ");
                Bookname = Console.ReadLine();
                Console.Write("Enter book Author name : ");
                Authorname = Console.ReadLine();
                bs[i] = new Book(Bookname, Authorname);
            }

            Console.WriteLine();
            Console.WriteLine("*** Books Details ***");
            Console.WriteLine();
            for (int j = 0; j < 5; j++)
            {
                bs[j].Display();
            }
            Console.ReadLine();

        }
    }
}

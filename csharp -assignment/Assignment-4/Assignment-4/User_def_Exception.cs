using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4
{
    class Doctor
    {
        int regNo;
        string name;
        double fees_charged;
        public int RegNo
        {
            get  { return regNo; }
            set { regNo = value; }
        } 
        public string Name
        {
            get { return name;}
            set { name = value; }
        }
        public double Fees_Charged
        {
            get { return fees_charged; }
            set { fees_charged = value; }
        }
    }
    class Book
    {
        string Book_Name;
        string Author_Name;
        public Book(string book_name, string author_name)
        {
            Book_Name = book_name;
            Author_Name = author_name;
        }
        public void Display()
        {
            Console.WriteLine("BookName:{0}", Book_Name);
            Console.WriteLine("AuthorName:{0}", Author_Name);
        }
    }
    class bookshelf
    {
        Book[] bobj = new Book[5];
        public Book this[int pos]
        {
            get { return bobj[pos]; }
            set { bobj[pos] = value; }

        }
    }
    class Driver
    {
        public static void Main()
        {
            Console.WriteLine("----Enter Doctor Class Details-----");
            Console.WriteLine("Enter the Registration Number");
            int reg_no = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the name");
            string names = Console.ReadLine();
            Console.WriteLine("Fees Charged");
            double fees = Convert.ToDouble(Console.ReadLine());
            Doctor d = new Doctor();
            Console.WriteLine("-----Displaying Doctor Class Details----");
            d.RegNo = reg_no;
            Console.WriteLine("Registration Number:{0}", d.RegNo);
            d.Name = names;
            Console.WriteLine("name:{0}", d.Name);
            d.Fees_Charged = fees;
            Console.WriteLine("Fees Charged:{0}", d.Fees_Charged);
            Console.WriteLine("-----enter Book class Details----");
            Console.WriteLine("Enter the book name");
            string bname = Console.ReadLine();
            Console.WriteLine("Enter the author name");
            string aname = Console.ReadLine();
            Book b = new Book(bname, aname);
            Console.WriteLine("---Displaying Book class Details----");
            b.Display();
            Console.WriteLine("----Indexers Example----");
            bookshelf bs = new bookshelf();
            Console.WriteLine("---Entering Book details---");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("enter the {0} book name", i++);
                String bookname = Console.ReadLine();
                Console.WriteLine("enter the {0} author name", i + 1);
                string authorname = Console.ReadLine();
                bs[i] = new Book(bookname, authorname);
            }
            Console.WriteLine("------Displaying Book Details----");
            for (int j = 0; j < 5; j++)
            {
                bs[j].Display();

            }
            Console.Read();
        }
    }

}

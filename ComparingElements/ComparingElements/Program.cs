using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComparingElements
{
    class Program
    {
        static void Main(string[] args)
        {
            //----- Overriding Equals -----//

            //Book book1 = new Book();
            //book1.isbn = "ABC";
            //book1.title = "AnimalFarm";
            
            //Book book2 = new Book();
            //book2.isbn = "ABC";
            //book2.title = "AnimalFarm";

            
            //bool areEqual = book1.Equals(book2);

            //Console.WriteLine(areEqual);

            //----- Comparators and Comparers -----/

            Book book1 = new Book();
            book1.title = "Northern Lights";
            book1.price = 25;
            book1.releaseDate = 1;

            Book book2 = new Book();
            book2.title = "The Hungry Caterpillar";
            book2.price = 5;
            book2.releaseDate = 3;

            Book book3 = new Book();    
            book3.title = "The Anarchists Cookbook";
            book3.price = 10;

            book3.releaseDate = 2;

            List<Book> books = new List<Book>();
            books.Add(book1);
            books.Add(book2);
            books.Add(book3);

            IComparer<Book> priceComparer = new BookPriceComparer();
            IComparer<Book> releaseDateComparer = new ReleaseDateComparer();

            books.Sort(releaseDateComparer);

            foreach (Book book in books)
            {
                Console.WriteLine(book.title);
            }

            Console.ReadLine();
        }
    }
}

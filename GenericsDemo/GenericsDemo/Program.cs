using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book();
            book1.id = 1;
            book1.numberOfPages = 50;

            Magazine mag1 = new Magazine();
            mag1.id = 2;
            mag1.numberOfPages = 20;

            Cd cd1 = new Cd();
            cd1.id = 3;
            cd1.numberOfTracks = 60;

            ItemsCatalogue itemsCatalogue = new ItemsCatalogue();
            itemsCatalogue.listOfItems.Add(book1);

            //We cant do this because the list holds ITEMS
            //itemsCatalogue.listOfItems[1].numberOfPages

            //We can cast the item but this is bad because it could casue runtime errors
            //Book book = (Book)itemsCatalogue.listOfItems[1];
            //int numOfPages = book.numberOfPages;

            //Console.WriteLine(itemsCatalogue.listOfItems.Count);
            GenericItemCatalogue<Magazine> mags = new GenericItemCatalogue<Magazine>();
            mags.listOfItems.Add(mag1);
            GenericItemCatalogue<Cd> cds = new GenericItemCatalogue<Cd>();
            GenericItemCatalogue<Book> books = new GenericItemCatalogue<Book>();
            books.listOfItems.Add(book1);

            int nOPB = books.listOfItems[0].numberOfPages;
            int nOPM = mags.listOfItems[0].numberOfPages;
            Console.WriteLine(nOPB);
            Console.WriteLine(nOPM);
            Console.Read();
        }
    }
}

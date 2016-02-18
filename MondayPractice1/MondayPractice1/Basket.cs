using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MondayPractice1
{
    public class Basket
    {
        //Save space in the basket for some books
        public List<Book> listOfBooks;

        //Constructor
        //When the basket is constructed give a list of books... 
        public Basket(List<Book> ListOfBooks)
        {
            //...and fill the space
            listOfBooks = ListOfBooks;
        }

        //Give back the list of books
        public List<Book> getBooksInBasket()
        {
            return listOfBooks;
        }

        public void AddBook()
        {
            Book book1 = new Book();
            book1.price = 10;

            listOfBooks.Add(book1);
 
        }
    }
}

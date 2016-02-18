using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MondayPractice1
{
    public class Checkout
    {
        public double calculatePrice(Basket basketContent)
        {
            double totalPrice = 0.0;

            foreach (Book book in basketContent.listOfBooks)
            {
                totalPrice += book.price;

            }
            if (basketContent.listOfBooks.Count == 3)
            {
                return totalPrice * 0.99;
            }
            else if (basketContent.listOfBooks.Count == 7)
            {
                return totalPrice * 0.98;
            }
            else if (basketContent.listOfBooks.Count >= 10)
            {
                return totalPrice * 0.90;
            }
            return totalPrice;
        }
    }
}

//if (count % 3
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComparingElements
{
    public class BookPriceComparer : IComparer<Book>
    {
        public int Compare(Book book1, Book book2)
        {
            if (book1.price < book2.price)
            {
                return -1;
            }
            else if (book1.price > book2.price)
            {
                return 1;
            }
            else 
            {
                return 0;
            }
        }
    }
}

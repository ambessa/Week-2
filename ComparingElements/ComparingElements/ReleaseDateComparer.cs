using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComparingElements
{
    public class ReleaseDateComparer : IComparer<Book>
    {
        public int Compare(Book book1, Book book2)
        {
            if (book1.releaseDate < book2.releaseDate)
            {
                return -1;
            }
            else if (book1.releaseDate > book2.releaseDate)
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

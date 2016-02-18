using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ComparingElements
{
    public class Book
    {
        //Is this single responsibility?

        public string isbn { get; set; }
        public string title { get; set; }

        public int price { get; set; }
        public int releaseDate { get; set; }
        //public override bool Equals(object obj)
        //{
        //    //Check that we are given a book to compare against
        //    if (obj == null)
        //    {
        //        return false;
        //    }

        //    //Cast the object that was given to us as a book
        //    Book otherBook = obj as Book;

        //    //Check the references of the books to see if they are the same
        //    //this - tells you to look at otherBook Class e.g. Book
        //    if (this == otherBook)
        //    {
        //        return true;
        //    }

        //    //Check wheteher both objects are books
        //    if (this.GetType() != otherBook.GetType())
        //    {
        //        return false;
        //    }

        //    //Check whether the isbn is the same
        //    if (otherBook.isbn != this.isbn)
        //    {
        //        return false;
        //    }

        //    //Check whether the title is the same
        //    if (otherBook.title != this.title)
        //    {
        //        return false;
        //    }
        //    return true;
        //}


        //public int CompareTo(object obj)
        //{
        //    if (obj == null)
        //    {
        //        return 1;
        //    }

        //    Book otherBook = obj as Book;

        //    if (this.price < otherBook.price) 
        //    {
        //        return -1;
        //    }
        //    else if (this.price > otherBook.price)
        //    {
        //        return 1;
        //    }
        //    else 
        //    {
        //        return 0;
        //    }
        //}
    }
}

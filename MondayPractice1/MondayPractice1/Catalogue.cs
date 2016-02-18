using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MondayPractice1
{
    public class Catalogue
    {
        ReadDatabase dataBReader;

        WriteDataBase dataBWriter;
       
        public Catalogue(ReadDatabase DataBReader, WriteDataBase DataBWriter)
        {
            dataBReader = DataBReader;
            dataBWriter = DataBWriter;
        }


        public List<Book> GetAllBooks()
        {
            dataBReader.ReadAll();
            return new List<Book>();
        }

        public void AddBook(Book book)
        {
            dataBWriter.InsertBook(book);
        }
    }
}

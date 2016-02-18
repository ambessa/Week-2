using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Dvd dvd1 = new Dvd();
            dvd1.id = 1000;
            dvd1.title = "Inglorious Basterds";
            dvd1.director = "Quentin Tarantino";
            dvd1.rating = "18";

            Dictionary<int, Dvd> dvdDictionary = new Dictionary<int, Dvd>();
            
            dvdDictionary.Add(dvd1.id, dvd1);

            Dvd dvdFromDictionary = new Dvd();

            //if(dvdDictionary.ContainsKey(1000))
            //{
            //    dvdFromDictionary = dvdDictionary[1000];
            //}
            //obtain dvd from dictionary using int id ref
            Dvd dvdFromDirectionary = dvdDictionary[1000];

            Console.WriteLine(dvdFromDictionary.title);

            Console.ReadLine();
        }
    }
}

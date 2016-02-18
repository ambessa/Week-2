using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsDemo
{
    public class GenericItemCatalogue<T>
    {
        public List<T> listOfItems = new List<T>();

        //public void Add(T itemToAdd)
        //{
        //    listOfItems.Add(itemToAdd);
        //}
    }
}

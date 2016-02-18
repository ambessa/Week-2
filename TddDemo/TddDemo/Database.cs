using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TddDemo
{
    public class Database
    {   
        //property retains memory
        public List<Dvd> listOfDvds;
        
        //method
        public List<Dvd> GetAllDvds()
        {
            return listOfDvds;
        }

        public List<Dvd> AddDvd()
        {
            listOfDvds.Add(new Dvd());
            return listOfDvds;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsExampleDay3
{
    public class PrizeGenerator
    {
        public Employee GetRandomEmployee(List<Employee> employees)
        {
            Random randomNumberGenerator = new Random();
            int randomNumber = randomNumberGenerator.Next(0, 3);

            return employees[randomNumber];
        }
    }
}

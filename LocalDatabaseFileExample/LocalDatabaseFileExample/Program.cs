using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataBaseFileProject;

namespace LocalDatabaseFileExample
{
    class Program
    {
        static void Main(string[] args)
        {
            using (CustomerDatabaseEntities customerContext = new CustomerDatabaseEntities())
            {
                var customers = customerContext.Customers.Select(x => x);
                foreach (Customer customer in customers)
                {
                    Console.WriteLine(customer.CustomerFirstName + " " + customer.CustomerLastName);
                }
            }
        }
    }
}

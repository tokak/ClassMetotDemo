using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    class CustomerManager
    {
        public void Add(Customer customer)
        {
            Console.WriteLine($"{customer.Name} {customer.Surname} müşteri eklendi.\n");
        }

        public void Listed(Customer[] customers)
        {
            foreach(Customer customer in customers)
            {
                Console.WriteLine(customer.Name+" "+customer.Surname+" "+customer.Adress+"\n");
                Console.WriteLine("------");
            }
        }

        public void Delete(int id)
        {
            Console.WriteLine($"{id} id'li müşteri silindi.");
        }
    }
}

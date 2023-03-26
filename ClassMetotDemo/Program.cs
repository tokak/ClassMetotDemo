using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Customer customer1 = new Customer();
            customer1.Id= 1;
            customer1.Name= "Murat";
            customer1.Surname= "Tokak";
            customer1.Adress= "Diyarbakır";
            Customer customer2 = new Customer();
            customer2.Id = 2;
            customer2.Name = "Engin";
            customer2.Surname = "Demirog";
            customer2.Adress = "Diyarbakır";

            //Ekleme,listeleme ve silme işlemleri
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Add(customer2);

            Customer[] customers = new Customer[] { customer1, customer2 };
            customerManager.Listed(customers);

            customerManager.Delete(1);



        }
    }
}
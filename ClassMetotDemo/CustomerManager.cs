using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class CustomerManager
    {
        public void AddCustomer()
        {
            Customer customer = new Customer();
            int idNo = customer.Id = 101;

            Console.Write("Müşteri TC No: ");
            customer.IdNumber = Console.ReadLine();

            Console.Write("Müşteri İsmi: ");
            customer.FirstName = Console.ReadLine();

            Console.Write("Müşteri Soyismi: ");
            customer.LastName = Console.ReadLine();

            Console.Write("Müşteri Yaşı: ");
            customer.Age = Console.ReadLine();

            Console.Write("Müşteri Şehri: ");
            customer.City = Console.ReadLine();
            Program program = new Program();

            Console.WriteLine("");

            Console.WriteLine("İşlem Başarılı!");
            
        }

        public void ListCustomer(Customer[] customers)
        {
            Customer customerId = new Customer();
            int idNo = customerId.Id = 101;

            Console.WriteLine("Id Nu");

            foreach (Customer customer in customers)
            {
                Console.WriteLine(" " + idNo +
                                  "   " + customer.IdNumber +
                                  "   " + customer.FirstName +
                                  "   " + customer.LastName +
                                  "   " + customer.Age +
                                  "   " + customer.City);
                idNo++;
            }
            Console.WriteLine("\n");
        }

        public void UpdateCustomer()
        {
            //CustomerManager customerManager = new CustomerManager();

            AddCustomer();
        }

        public void DeleteCustomer()
        {
            Console.WriteLine("");
            Console.WriteLine("Silme işlemi tamamlanmıştır.");
        }
    }
}

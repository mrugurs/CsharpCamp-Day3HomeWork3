using System;
using System.Security.Cryptography.X509Certificates;

namespace ClassMetotDemo
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.Write("Müşteri Ekle     : 1\n" + "Müşteri Güncelle : 2\n" + "Müşteri Sil      : 3\n" + "Operasyon Numarası Seçiniz: ");

            var operation = Console.ReadLine();

            Console.WriteLine("\n");
            
            Customer customer = new Customer();
            CustomerManager customerManager = new CustomerManager();


            //*******************************Customer0******************************
            Customer customer0 = new Customer();

            customer0.IdNumber = "25698725369";
            customer0.FirstName = "Murat";
            customer0.LastName = "UĞUR";
            customer0.Age = "27";
            customer0.City = "ISTANBUL";

            //*******************************Customer1******************************
            Customer customer1 = new Customer();

            customer1.IdNumber = "16524896371";
            customer1.FirstName = "Mehmet Can";
            customer1.LastName = "UĞUR";
            customer1.Age = "18";
            customer1.City = "ISTANBUL";

            if (operation == "1")
            {
                customerManager.AddCustomer();
            }
            else if (operation == "2")
            {
                Customer[] customers = new Customer[]
                {
                    customer0, customer1
                };
                customerManager.ListCustomer(customers);

                Console.Write("Bilgilerini Güncellemek İstediğiniz Müşterinin ID numarası: ");
                string id = Console.ReadLine();

                if (id == "101")
                {
                    Console.WriteLine("");

                    customerManager.UpdateCustomer();

                }
                else if (id == "102")
                {
                    Console.WriteLine("");

                    customerManager.UpdateCustomer();

                }
                else
                {
                    Console.WriteLine("Yanlış giriş yaptınız!! Tekrar Deneyiniz..");
                }

            }
            else if (operation == "3")
            {
                Customer[] customers = new Customer[]
                {
                    customer0, customer1
                };
                customerManager.ListCustomer(customers);

                Console.Write("Silmek İstediğiniz Müşterinin ID numarası: ");
                string id = Console.ReadLine();

                if (id == "101")
                {
                    customerManager.DeleteCustomer();
                }
                else if (id == "102")
                {
                    customerManager.DeleteCustomer();
                }
                else
                {
                    Console.WriteLine("Yanlış giriş yaptınız!! Tekrar Deneyiniz..");
                }
            }
            else
            {
                Console.WriteLine("Yanlış giriş yaptınız!! Tekrar Deneyiniz..");
            }
        }
        
    }
}

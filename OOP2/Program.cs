using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Birbirine benzeyen iki nesne aynı classta kullanılamaz.

            //Kamil Postaagasi
            Individual customer1 = new Individual();
            customer1.CustomerNo = "12345";
            customer1.Name = "Kamil";
            customer1.Surname = "Postaagasi";
            customer1.TcNo = "124235235";

            //Han Holding
            Corporate customer2 = new Corporate();
            customer2.CompanyName = "Han Holding";
            customer2.CustomerNo = "12435";
            customer2.Id = 2;
            customer2.TaxNo = "21231231";

            //SOLID

            Customer customer3 = new Individual();
            Customer customer4 = new Corporate();

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Add(customer2);

            


        }
    }
}

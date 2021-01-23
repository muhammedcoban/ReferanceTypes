using System;

namespace Constructors //yapıcı blog anlamına gelir.
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer { Id=2,FirstName="dfs",LastName="sawgw",City="aDad"};
            Customer customer1 = new Customer { Id = 1, FirstName = "dfs", LastName = "sawgw", City = "aDad" };
            Customer customer2 = new Customer (3,"dfs","sawgw","aDad" );

        }
    }

    class Customer
    {
        public Customer()
        {

        }
        public Customer(int id,string firstName,string lastName,string city)//Metod gibi çalışır
        {
            Console.WriteLine("yapıcı blog çalıştı");
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
    }
}

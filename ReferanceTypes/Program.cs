 using System;

namespace ReferanceTypes
{
    class Program
    {
        static void Main(string[] args)
        {   // Value type -Deger Tip
          //

            Person person1 = new Person();
            person1.FirstName = "engin";

            Person person2 = new Person();
            person2.FirstName = "muhammed";


            Customer customer = new Customer();
            Employee employee = new Employee();
            employee.FirstName = "asf";
            customer.FirstName = "asi";
            Person person3 = customer;
            Console.WriteLine(person3.FirstName);

            PersonManager personManager = new PersonManager();
            personManager.Add(employee);
        }

        class Person
        {
            public int Id   { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
        }

        class Customer : Person
        {
            public string CreditCardNumber { get; set; }
        }

        class Employee:Person
        {
            public int EmployeeNumber { get; set; }
        }

        class PersonManager
        {
            public void Add(Person person)
            {
                Console.WriteLine(person.FirstName);
            }
        }
    }
}

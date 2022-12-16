using System;

namespace MovieRental
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer("Иванов");
            Movie movie = new Movie("Lord of Rings", 1);
            Rental rental = new Rental(movie, 2);

            customer.Rentals = rental;
            Console.WriteLine(customer.Statement());
        }
    }
}

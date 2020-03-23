using System;
using System.Collections.Generic;
using System.Linq;
using EfCore2020.Entities;

namespace EfCore2020.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new DatabaseContext())
            {
                context.Customers.Add(new Customer
                {
                    CustomerId = 1,
                    Name = "Fii",
                    City = "Iasi"
                });
                context.Orders.Add(new Order
                {
                    OrderId = 1,
                    TotalValue = 10,
                    Date = DateTime.Now,
                    CustomerCustomerId = 1
                });

                var artist = new Artist
                {
                    ArtistId = 1,
                    FirstName = "Ionel",
                    LastName = "Popescu",
                    AlbumId = 1
                };
                context.Artists.Add(artist);

                var album = new Album
                {
                    AlbumId = 1,
                    AlbumName = "Muzica populara.",
                    ArtistId = 1
                };
                context.Albums.Add(album);

                context.SaveChanges();
            }
        }
    }
}

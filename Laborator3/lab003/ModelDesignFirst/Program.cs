using System;

namespace ModelDesignFirst_L1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Test Model Designer First");
            TestPerson();
            Console.ReadKey();
            Console.WriteLine("TestOneToMany");
            TestOneToMany();
            TestManyToMany();
        }

        public static void TestPerson()
        {
            using (Model1Container context = new Model1Container())
            {
                Person p = new Person()
                {
                    FirstName = "Julie",
                    LastName = "Andrew",
                    MiddleName = "T",
                    TelephonNumber = "1234567890"
                };
                context.People.Add(p);
                context.SaveChanges();
                var items = context.People;
                foreach (var x in items)
                    Console.WriteLine("{0} {1}", x.Id, x.FirstName);
            }
        }

        public static void TestOneToMany()
        {
            Console.WriteLine("One to many association");
            using (ModelOneToManyContainer1Container context = new ModelOneToManyContainer1Container())
            {
                Customer customer = new Customer()
                {
                    Name = "Name",
                    City = "Iasi"
                };

                Order o1 = new Order()
                {
                    TotalValue = 10,
                    Date = DateTime.Now,
                    Customer = customer
                };
                Order o2 = new Order()
                {
                    TotalValue = 12,
                    Date = DateTime.Now,
                    Customer = customer
                };
                context.Customers.Add(customer);
                context.Orders.Add(o1);
                context.Orders.Add(o2);
                context.SaveChanges();

                var items = context.Customers;
                foreach (var x in items)
                {
                    Console.WriteLine("Customer : {0}, {1}, {2}", x.CustomerId, x.Name, x.City);
                    foreach (var ox in x.Orders)
                    {
                        Console.WriteLine("\tOrders: {0}, {1}, {2}", ox.OrderId, ox.Date, ox.TotalValue);
                    }
                }
            }
        }

        public static void TestManyToMany()
        {
            using (ModelManyToManyContainer context = new ModelManyToManyContainer())
            {
                Album album = new Album
                {
                    AlbumName = "AlbumName"
                };
                Artist artist = new Artist
                {
                    FirstName = "FirstName",
                    LastName = "LastName"
                };

                context.Albums.Add(album);
                context.Artists.Add(artist);
                context.SaveChanges();

                var albums = context.Albums;
                foreach(var alb in albums)
                {
                    Console.WriteLine("Album: {0} {1}", alb.AlbumId, alb.AlbumName);
                }
                
                var artists = context.Artists;
                foreach(var art in artists)
                {
                    Console.WriteLine("Artist: {0} {1} {2}", art.ArtistId, art.FirstName, art.LastName);
                }

            }
        }

    }
}

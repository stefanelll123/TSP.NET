using System;
using System.Linq;
using Lab004.EF.Entities;

namespace Lab004.EF
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Scenario 1
            Console.WriteLine("Scenario 1");
            using (var context = new ModelSelfReference())
            {
                context.Database.ExecuteSqlCommand("DELETE FROM [SelfReferences]");
                context.SelfReferences.Add(new SelfReference
                {
                    Name = "Test"
                });
                context.SaveChanges();

                context.SelfReferences.Add(new SelfReference
                {
                    Name = "Test2",
                    ParentSelfReference = context.SelfReferences.FirstOrDefault()
                });
                context.SaveChanges();
            }

            using (var context = new ModelSelfReference())
            {
                foreach (var p in context.SelfReferences)
                {
                    Console.WriteLine("{0} {1} {2}", p.SelfReferenceId, p.Name, p.ParentSelfReferenceId);
                }
            }

            // Scenario 2
            Console.WriteLine("\nScenario 2");
            using (var context = new ModelSelfReference())
            {
                context.Database.ExecuteSqlCommand("DELETE FROM [BazaDeDate].[ProductWebInfo]");
                context.SaveChanges();
                context.Database.ExecuteSqlCommand("DELETE FROM [BazaDeDate].[Product]");

                var product = new Product
                {
                    SKU = 147,
                    Description = "Expandable Hydration Pack",
                    Price = 19.97M,
                    ImageURL = "/pack147.jpg"
                };
                context.Products.Add(product);
                product = new Product
                {
                    SKU = 178,
                    Description = "Rugged Ranger Duffel Bag",
                    Price = 39.97M,
                    ImageURL = "/pack178.jpg"
                };
                context.Products.Add(product);
                product = new Product
                {
                    SKU = 186,
                    Description = "Range Field Pack",
                    Price = 98.97M,
                    ImageURL = "/noimage.jp"
                };
                context.Products.Add(product);
                product = new Product
                {
                    SKU = 202,
                    Description = "Small Deployment Back Pack",
                    Price = 29.97M,
                    ImageURL = "/pack202.jpg"
                };
                context.Products.Add(product);
                context.SaveChanges();
            }

            using (var context = new ModelSelfReference())
            {
                foreach (var p in context.Products)
                {
                    Console.WriteLine("{0} {1} {2} {3}", p.SKU, p.Description,
                        p.Price.ToString("C"), p.ImageURL);
                }
            }

            // scenario 3 example
            Console.WriteLine("\nScenario 3");
            byte[] thumbBits = new byte[100];
            byte[] fullBits = new byte[2000];
            using (var context = new ModelSelfReference())
            {
                var photo = new Photograph
                {
                    Title = "My Dog",
                    ThumbnailBits = thumbBits
                };
                var fullImage = new PhotographFullImage
                {
                    HighResolutionBits =
                        fullBits
                };
                photo.PhotographFullImage = fullImage;
                context.Photographs.Add(photo);
                context.SaveChanges();
            }

            using (var context = new ModelSelfReference())
            {
                foreach (var photo in context.Photographs)
                {
                    Console.WriteLine("Photo: {0}, ThumbnailSize {1} bytes",
                        photo.Title, photo.ThumbnailBits.Length);
                    context.Entry(photo)
                        .Reference(p => p.PhotographFullImage).Load();
                    Console.WriteLine("Full Image Size: {0} bytes",
                        photo.PhotographFullImage.HighResolutionBits.Length);
                }
            }

            // Scenario 4
            Console.WriteLine("\n Scenario 4");
            using (var context = new ModelSelfReference())
            {
                var business = new Business
                {
                    Name = "Corner Dry Cleaning",
                    LicenseNumber = "100x1"
                };
                context.Businesses.Add(business);
                var retail = new Retail
                {
                    Name = "Shop and Save",
                    LicenseNumber =
                        "200C",
                    Address = "101 Main",
                    City = "Anytown",
                    State = "TX",
                    ZIPCode = "76106"
                };
                context.Businesses.Add(retail);
                var web = new ECommerce
                {
                    Name = "BuyNow.com",
                    LicenseNumber =
                        "300AB",
                    URL = "www.buynow.com"
                };
                context.Businesses.Add(web);
                context.SaveChanges();
            }

            using (var context = new ModelSelfReference())
            {
                Console.WriteLine("\n--- All Businesses ---");
                foreach (var b in context.Businesses)
                {
                    Console.WriteLine("{0} (#{1})", b.Name, b.LicenseNumber);
                }
                Console.WriteLine("\n--- Retail Businesses ---");
                foreach (var r in context.Businesses.OfType<Retail>())
                {
                    Console.WriteLine("{0} (#{1})", r.Name, r.LicenseNumber);
                    Console.WriteLine("{0}", r.Address);
                    Console.WriteLine("{0}, {1} {2}", r.City, r.State, r.ZIPCode);
                }
                Console.WriteLine("\n--- eCommerce Businesses ---");
                foreach (var e in context.Businesses.OfType<ECommerce>())
                {
                    Console.WriteLine("{0} (#{1})", e.Name, e.LicenseNumber);
                    Console.WriteLine("Online address is: {0}", e.URL);
                }
            }

            // Scenario 5
            Console.WriteLine("\nScenario 5");
            using (var context = new ModelSelfReference())
            {
                var fte = new FullTimeEmployee
                {
                    FirstName = "Jane",
                    LastName =
                        "Doe",
                    Salary = 71500M
                };
                context.Employees.Add(fte);
                fte = new FullTimeEmployee
                {
                    FirstName = "John",
                    LastName = "Smith",
                    Salary = 62500M
                };
                context.Employees.Add(fte);
                var hourly = new HourlyEmployee
                {
                    FirstName = "Tom",
                    LastName =
                        "Jones",
                    Wage = 8.75M
                };
                context.Employees.Add(hourly);
                context.SaveChanges();
            }
            using (var context = new ModelSelfReference())
            {
                Console.WriteLine("--- All Employees ---");
                foreach (var emp in context.Employees)
                {
                    bool fullTime = emp is HourlyEmployee ? false : true;
                    Console.WriteLine("{0} {1} ({2})", emp.FirstName, emp.LastName,
                        fullTime ? "Full Time" : "Hourly");
                }
                Console.WriteLine("--- Full Time ---");
                foreach (var fte in context.Employees.OfType<FullTimeEmployee>())
                {
                    Console.WriteLine("{0} {1}", fte.FirstName, fte.LastName);
                }
                Console.WriteLine("--- Hourly ---");
                foreach (var hourly in context.Employees.OfType<HourlyEmployee>())
                {
                    Console.WriteLine("{0} {1}", hourly.FirstName,
                        hourly.LastName);
                }
            }
        }
    }
}

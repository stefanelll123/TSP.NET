﻿using System;
using System.ServiceModel;
using System.ServiceModel.Description;
using MyPhotos.WcfServices.Services;

namespace MyPhotos.WcfServices.Host
{
    internal static class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Lansare server WCF...");
            ServiceHost host = new ServiceHost(typeof(ServiceImplementation), new Uri("http://localhost:8000/PC"));

            foreach (ServiceEndpoint se in host.Description.Endpoints)
                Console.WriteLine("A (address): {0} \nB (binding): {1}\nC (Contract): {2}\n", se.Address, se.Binding.Name, se.Contract.Name);
            
            host.Open();
            Console.WriteLine("Server in executie. Se asteapta conexiuni...");
            Console.WriteLine("Apasati Enter pentru a opri serverul!");
            Console.ReadKey();
            host.Close();
        }
    }
}
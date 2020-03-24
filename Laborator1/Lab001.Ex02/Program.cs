using System;
using System.Collections.Generic;
using System.Threading;

namespace Lab001.Ex02
{
    public class Program
    {
        public static void RunAlgorithmFirstDecorator(object i)
        {
            var primeAlgorithms = new PrimeAlgorithms();
            var result = primeAlgorithms.First((int) i);

            Console.WriteLine(Thread.GetDomainID() + ' ' + result);
        }
        public static void RunAlgorithmSecondDecorator(object i)
        {
            var primeAlgorithms = new PrimeAlgorithms();
            var result = primeAlgorithms.Second((int) i);
            Console.WriteLine(Thread.GetDomainID() + ' ' + result);
        }

        public static void Main(string[] args)
        {
            List<Thread> threads = new List<Thread>();

            for (var i = 0; i <= 99999; i++)
            {
                var thread = new Thread(RunAlgorithmFirstDecorator);
                var thread2 = new Thread(RunAlgorithmSecondDecorator);
                thread.Start(i);
                thread2.Start(i);
                //threads.Add(thread);
            }
        }
    }
}

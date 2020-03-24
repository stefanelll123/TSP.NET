using System;
using Lab001.Ex01.Library;

namespace Lab001.Ex01
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var emitter = new EventEmitter();
            emitter.ThresholdReached += (sender, eventArgs) =>
            {
                Console.WriteLine("Mama are mere.");
            };

            emitter.ThresholdReached += (sender, eventArgs) =>
            {
                Console.WriteLine("Mama are pere.");
            };

            emitter.CallAllToExecute();
        }
    }
}

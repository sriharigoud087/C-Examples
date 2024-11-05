using System.Diagnostics;

namespace LAsyncAwait
{
    internal class Program
    {
        /*  static void Main(string[] args)
          {
              Stopwatch stopWach = new Stopwatch();
              stopWach.Start();
              CookMealSynchronously();
              stopWach.Stop();

              TimeSpan elapsed = stopWach.Elapsed;
              Console.WriteLine($"Elapsed Time (Seconds):{elapsed.TotalSeconds}s");


              //Console.WriteLine("Hello, World!");
          }

          private static void CookMealSynchronously()
          {
              Console.WriteLine("Cooking Meal.....");
              CutVegetablesSynchronously();
              BoilWaterSynchronously();
              CompleteOtherCookingSynchromousliy();
          }
          private static void BoilWaterSynchronously()
          {
              Console.WriteLine("Boiling Water.....");
              Task.Delay(3000).Wait();
              Console.WriteLine("water is hot!");

          }
          private static void CutVegetablesSynchronously()
          {
              Console.WriteLine("Chopping  Vegatables.....");
              Task.Delay(3000).Wait();
              Console.WriteLine("Vegatables are ready!");
          }
          private static void CompleteOtherCookingSynchromousliy()
          {
              Console.WriteLine("Adding Seasoning...");
              Console.WriteLine("Tasting for salt...");
              Console.WriteLine("Cooking for 5 seconds");

              Task.Delay(5000).Wait();
              Console.WriteLine("Done Cooking!");
          }*/


        static async Task Main(string[] args)
        {
            Stopwatch stopWach = new Stopwatch();
            stopWach.Start();
            await CookMealAsynchronously();
            stopWach.Stop();

            TimeSpan elapsed = stopWach.Elapsed;
            Console.WriteLine($"Elapsed Time (Seconds):{elapsed.TotalSeconds}s");


            //Console.WriteLine("Hello, World!");
        }

        private static async Task CookMealAsynchronously()
        {
            Console.WriteLine("Cooking Meal asynchronously.....");
            Task boilWaterTask= CutVegetablesAsynchronously();
             Task cutVegatablesTask= BoilWaterAsynchronously();
            await Task.WhenAll(boilWaterTask, cutVegatablesTask);
            await CompleteOtherCookingSynchromousliy();
        }
        private static async Task BoilWaterAsynchronously()
        {
            Console.WriteLine("Boiling Water.....");
            await Task.Delay(3000);
            Console.WriteLine("water is hot!");

        }
        private static async Task CutVegetablesAsynchronously()
        {
            Console.WriteLine("Chopping  Vegatables.....");
            await Task.Delay(3000);
            Console.WriteLine("Vegatables are ready!");
        }
        private static async Task CompleteOtherCookingSynchromousliy()
        {
            Console.WriteLine("Adding Seasoning...");
            Console.WriteLine("Tasting for salt...");
            Console.WriteLine("Cooking for 5 seconds");

            await Task.Delay(5000);
            Console.WriteLine("Done Cooking!");
        }

    }
}
//Some real application uses of async
/*
 * E-commerce 
    1. To get products we will make DB it is an I/O bound opertatin It will spend some time on data retrival
    blocks main thread, instaed we use async and await to run in separate .

    2. For payments and third party API calls we need to use.

    3. File  uploads
    4. Email notifications.


    When not to use

    1. when we make simple api call to calculate price with out making DB call,
    it is an CPU bound calculation.

    2.Filteing, sorting or any other operations after loading data.

    3.Acessing configuration data , in code it self
    
    
 */
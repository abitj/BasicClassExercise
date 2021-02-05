using System;

namespace BasicClassExercise
{
    class Program
    {


        static void Main(string[] args)
        {
            Car myCar = new Car();
            myCar.Name = "Road Master";
            myCar.Model = "Jeep Wrangler Unlimited Sahara";
            myCar.Year = 2021;


            Console.WriteLine($"My car's name is { myCar.Name } and it's a {myCar.Year} {myCar.Model}");


        }


    }
}

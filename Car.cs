using System;
namespace BasicClassExercise
{
    public class Car
    {
       

        public Car() // default constructor
        {
        }

        public Car(string name, string model, int year) // custom constructor
        {
            Name = name;
            Model = model;
            Year = year;
        }

       
        public string Name { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
    }
}


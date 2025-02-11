// Author: Adam Verissimo
// Course: COMP003A
// Faculty: Jonathan Cruz
// Purpose: Demonstrate the creation and usage of classes in C#
namespace COMP003A.LectureActivity5_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car("Honda", "Civic", 2021); // Create a new Car object using the constructor
            myCar.DisplayInfo(); // Display the car information

            myCar.Make = "Toyota"; // Change the car's make
            myCar.Model = "Corolla"; // Change the car's model
            myCar.Year = 2020; // Change the car's year
            myCar.DisplayInfo(); // Display the car's information

            Car myCar2 = new Car("Ford", "Mustang", 2020); // Create a new Car object
            Car myCar3 = new Car("Chevrolet", "Camaro", 2021); // Create a new Car object
            Car.DisplayCarCount(); // Display the total number of cars created
        }
    }

    internal class Car
    {
        // Fields
        private static int carCount = 0;
        public string Make;
        public string Model;
        public int Year;

        // Properties
        public string make
        {
            get { return Make; }
            set { Make = value; }
        }
        public string model
        {
            get { return Model; }
            set { Model = value; }
        }
        public int year
        {
            get { return year; }
            set { if (value >= 1886) year = value; }
        }
        
        /// <summary>
        /// Default constructor
        /// </summary>
        /// <param name="make"></param>
        /// <param name="model"></param>
        /// <param name="year"></param>
        public Car(string make, string model, int year)
        {
            Make = make;
            Model = model;
            Year = year;
            carCount++;
        }

        /// <summary>
        /// Display the car information
        /// </summary>
        public void DisplayInfo()
        {
            Console.WriteLine($"Car: {Year} {Make} {Model}");
        }

        /// <summary>
        /// Static property to get the car count
        /// </summary>
        public static void DisplayCarCount()
        {
            Console.WriteLine($"Total cars created: {carCount}");
        }
    }
}

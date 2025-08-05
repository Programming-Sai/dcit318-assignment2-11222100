using System;

namespace InterfacesExample
{
    // Step 1: Define the interface
    interface IMovable
    {
        void Move();
    }

    // Step 2: Implement interface in Car
    class Car : IMovable
    {
        public void Move()
        {
            Console.WriteLine("Car is moving");
        }
    }

    // Step 3: Implement interface in Bicycle
    class Bicycle : IMovable
    {
        public void Move()
        {
            Console.WriteLine("Bicycle is moving");
        }
    }

    // Step 4: Main method to test
    class Program
    {
        static void Main(string[] args)
        {
            IMovable myCar = new Car();
            IMovable myBicycle = new Bicycle();

            myCar.Move();       // Output: Car is moving
            myBicycle.Move();   // Output: Bicycle is moving
        }
    }
}

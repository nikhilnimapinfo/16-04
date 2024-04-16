using System;

namespace Program_Problem
{
    public class Car : Vehical
    {
        public Car(string registrationNumber)
            : base(registrationNumber)
        {
            Console.WriteLine("Car is Bean Initialize ,{0}",registrationNumber);
        }

    }
}

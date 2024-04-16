using System;

namespace Program_Problem
{
    public class Vehical
    {
        private readonly string _registrationNumber;

        //public Vehical()
        //{
        //    Console.WriteLine("Vehical  is bean Initialize");
        //}

        public Vehical(string registrationNumber)
        {

            _registrationNumber = registrationNumber;
            Console.WriteLine("Vehical Is bean Initalize ,{0}", registrationNumber);
        }


    }
}

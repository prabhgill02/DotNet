using System;

namespace DotNetOOPS
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hi My Name is Prabhdeep Singh!");
            // 1.
            // Employee obj = new Employee();
            // obj.Experience = 3;
            // obj.CalculateSalary();

            //2.
            Car myCar = new Car();
            myCar.Tyre();
            Console.WriteLine(myCar.Brand);
        }
    }
}

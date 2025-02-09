using System;

namespace DotNetOOPS
{

// It is just a simple class which can be used as an example of encapsulation 
    public class Employee
    {
        // experience field can't be accessed from outside 
        // it can only be accessed using property which enhance the security of the applicaiton
        private int experience;

        public int Experience
        {
            get { return experience; }
            set { experience = value; }
        }

        public void CalculateSalary()
        {
            int salary = Experience * 300000;

            Console.WriteLine("salary: {0} ", salary);
        }

    }
}
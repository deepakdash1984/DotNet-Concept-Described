using System;

namespace Indexer
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee(1001,"Suresh","Nath"); //creating the Instance of Employee Class

            //Accessing the private variable of a class through Inexer of a class
            // Private variable of a class can be accessed in 3 ways making variable as public or 
            //making a get/set accessor for variables or indexer.
            Console.WriteLine("EmployeeNumber:" +employee[0]);
            Console.WriteLine("FirstName:" + employee[1]);
            Console.WriteLine("LastName:" + employee[2]);

            Console.ReadLine();
        }
    }
}

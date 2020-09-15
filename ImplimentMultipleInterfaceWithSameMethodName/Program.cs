using System;

namespace ImplimentMultipleInterfaceWithSameMethodName
{
    class Program 
    {
        static void Main(string[] args)
        {
            //Here we use Interface object to call the same named method with the child class
            IContractEmployee  contractEmployee = new Employee();
            Console.WriteLine(contractEmployee.Salary()); 

            IPermanentEmployee permanentEmployee = new Employee();
            Console.WriteLine(permanentEmployee.Salary());



            Console.ReadLine();

        }

        
    }
}

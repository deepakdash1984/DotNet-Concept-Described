using System;

namespace AbstractClassConstructor
{
    class Program
    {
        static void Main(string[] args)
        {
            PermanentEmployee permanentEmployee = new PermanentEmployee();
            Console.WriteLine(permanentEmployee.ID);

            ContractEmployee contractEmployee = new ContractEmployee();
            Console.WriteLine(contractEmployee.ID);

            Console.ReadLine();
        }
    }
}

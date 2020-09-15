using System;
using System.Collections.Generic;
using System.Text;

namespace ImplimentMultipleInterfaceWithSameMethodName
{
    public class Employee : IContractEmployee, IPermanentEmployee
    {
        // Here we cannot use access modifiers
        string IPermanentEmployee.Salary()
        {
            return "PermanentEmployee Salary";
           
        }



        string IContractEmployee.Salary()
        {
            return "ContractualEmployee Salary";
        }
       
    }
}

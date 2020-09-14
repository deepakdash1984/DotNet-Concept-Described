using System;
using System.Collections.Generic;
using System.Text;

namespace Indexer
{
    class Employee
    {
        
        //These are the private variables of a class
        int EmployeeNumber;
        string FirstName;
        string LastName;

        //This is a parameterised constructor
        public Employee(int empNo, string fName, string lName)
        {
            this.EmployeeNumber = empNo;
            this.FirstName = fName;
            this.LastName = lName;
        }
        // By using the this keyword on the method the class behaves as a virtual array
        public object this[int index]
        {
            get
            {
                if (index == 0 )
                {
                    return EmployeeNumber;
                }
                else if(index ==1)
                {
                    return FirstName;
                }
                else if (index ==2)
                {
                    return LastName;
                }
                else
                {
                    return null;
                }
            }
        }
    }
}

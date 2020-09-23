using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClassConstructor
{
    public class PermanentEmployee : Employee
    {
        //  1. By default constructor is private, even though we haven't marked the constructor as private
        //  2. static marked constructor are always called first.
        public PermanentEmployee()
        {

        }
    }
}

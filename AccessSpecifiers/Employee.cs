using System;
using System.Collections.Generic;
using System.Text;

namespace AccessSpecifiers
{
    class Employee
    {
        public void PublicMethod()
        {
            Console.WriteLine("PublicMethod");
        }
        private void PrivateMethod()
        {
            Console.WriteLine("PrivateMethod");
        }
        protected void ProtectedMethod()
        {
            Console.WriteLine("ProtectedMethod");
        }
        internal void InternalMethod()
        {
            Console.WriteLine("InternalMethod");
        }
        protected internal void protectedInternalMethod()
        {
            Console.WriteLine("protectedInternalMethod");
        }
    }
}

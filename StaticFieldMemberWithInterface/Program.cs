using System;

namespace StaticFieldMemberWithInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    public class BaseClass
    {
        public virtual string GetMethodOwnerName()
        {
            return "Base Class";
        }
    }
    public class ChildClass : BaseClass
    {
        public new string GetMethodOwnerName()
        {
            return "Child Class";
        }
    }
}

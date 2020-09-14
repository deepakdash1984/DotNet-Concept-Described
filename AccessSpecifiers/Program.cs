using System;

namespace AccessSpecifiers
{
    //These are special kind of modifiers which is used to define the scope of a type and it's member
    // Scope means who can access or who can't access
    // private/internal/protected/protected internal/public
    //Within the class there won't be any restriction only the restriction starts when we access the members of class 
    //from outside.
    class Program : Employee
    {
        static void Main(string[] args)
        {
            //Private method is not accessible through Inheritance
            // Protected is accessible through inheritance to the child class program.
            //public method is accessible from Inheritance
            //Internal is accessible through Inheritance from same project
            Program p = new Program();
            p.InternalMethod();
            p.protectedInternalMethod();
            p.ProtectedMethod();
            p.PublicMethod();

            // Private is not accessible in any way through Instance of class
            // Protected is not accessible through Instance of class
            //public method is accessible through instance of class
            //Internal is accessible through Instance of class from same project
            Employee employee = new Employee();
            employee.InternalMethod();
            employee.protectedInternalMethod();
            employee.PublicMethod();
        }
    }
}

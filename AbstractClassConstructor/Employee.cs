using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClassConstructor
{
	//	1. Abstract class are decorated with abstract keyword before the User-Defined class name.
	//	2. Abstract class can have constructors.
	//	3. Abstract class can have public/private/static and all types of constructor
	//	4. If a abstract class constructor is marked as private, then the base class can't be inherited.
	//	5. In abstract class static constructor are used to initialize static fields.
	//	6. Abstract class constructor is executed from the derived class.
	//	7. By default if we don't mark asccess specifiers to constructor they are considered as private for the class.
	//	8. Always base class constructor is called first and then derived class constructor is called.
	//	9. If derived class has a static constructor and base class has non-static constructor, then derived class constructor is called first.
	//	10. We can't create an object or instance of a Abstract class.


    public abstract class Employee
    {
		public Employee()
		{
			_id = Guid.NewGuid();
		}
		private Guid _id;

		public Guid ID
		{
			get { return _id; }
			set { _id = value; }
		}

	}
}

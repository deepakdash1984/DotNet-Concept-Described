using System;
using System.Text;

namespace StringVsStringBuilder
{
    class Program
    {
        static void Main(string[] args)
        {

            //-----------------------------------------STRING CLASS---------------------------------------------------------------
           
            string str = "Hello"; // In memory this makes a copy of string "Hello"
            str = str + " World"; // In memory this make a copy of string "HelloWorld"
            str = str + " String";// In memory this make a copy of string "HelloworldDeepak"

            //1.Hence when we print str then the last copy of string is printed.
            //2.So in memory there is 3 copies of string and that's why the string is immutable 
            //3.As internally the Hello is not changed rather three copies of stings are made internally.
            //4.Performance issue will be there if frequently you go on adding with string as
            //  copies are made and this copies goes on increasing.
            //5. string is in system namespace
            //6. string will store in heap as its a refrence type

            //----------------------------------------STRINGBUILDER CLASS----------------------------------------------------------------



            StringBuilder stringBuilder = new StringBuilder("Hello");//create a instance of StringBuilder Class
            stringBuilder.Append(" World"); //In memory it makes only one copy of string and add to it or Append to it.
            stringBuilder.Append(" StringBuilder"); //In memory it append to the same copy

            //1. StringBuilder is Refrence type
            //2. In memory it makes only one copy with 16 bit, when character increases StringBuilder doubles it capicity.
            //3. StringBuilder has automatic way of doubling the capicity from 16-32-64 and so on.
            //4. StringBuilder is present in System.Text namespace.
            //5. we too can assign the capicity to the overload constructor of the StringBuilder Class.
            //6. Performance is high when dealing with strings frequently and it is mutable.

            Console.WriteLine(stringBuilder);
            Console.WriteLine(str);
            Console.ReadLine();

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleHelloWorld
{
    
    class Program
    {
        int add_num(int a, int b)
        {
            return (a + b);
        }
        /// <summary>
        /// Just learning stuff
        /// </summary>
        
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int c = 1+2;
            Console.WriteLine(" 1 + 2 = {0}", c);

            int? x = null;
            Console.WriteLine(x ?? -1);

            string s = null;
            Console.WriteLine(s ?? "Undefined");

            // boxing and unboxing - 
            // object to var and vice-versa 
            int? i = 36;
            object boxed = i;
            int? j = boxed as int?;

            // automatic property
            Contact d = new Contact();
            d.Firstname = "Sharad";
            Console.WriteLine(d.Firstname);

            // Using a method
            Console.WriteLine("checking the length of phone number:");
            Console.WriteLine(d.checkPhoneNumber());
            // Add a wrong length phone number and check it
            d.PhoneNumber = "345";
            Console.WriteLine(d.checkPhoneNumber());
            
            // inheritance methods 
            TwoWheeler bike = new TwoWheeler();

            // enumeration - Days.cs
            Days days = Days.Saturday | Days.Sunday;
            Console.WriteLine("days = {0}  {1}", days, (int)days);
            Console.WriteLine(days.HasFlag(Days.Saturday));
            Console.WriteLine(days.HasFlag(Days.Monday));

            // Subscribing to an event
            var 

        }

        
    }
}

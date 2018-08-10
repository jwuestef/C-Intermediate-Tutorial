using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxingAndUnboxing
{
    class Program
    {

        // Boxing vs unboxing is about converting VALUE vs REFERENCE types to either one

        static void Main(string[] args)
        {

            ArrayList list = new ArrayList();  // This is a reference type
            list.Add(1);   // Boxing will occur here since it boxes a value type interger into a reference type as part of the referenced ArrayList
            list.Add("Mosh");
            list.Add(DateTime.Today);

            //var number = (int)list[1]; // ERROR due to invalid cast of string to integer

            var anotherList = new List<int>();
            anotherList.Add(1); // Provides typesafety, no boxing will occur





        }
    }
}

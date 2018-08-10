using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{



    public class Person
    {
        // Auto-implemented properties
        public string Name { get; set; }
        public string Username { get; set; }
        public DateTime Birthdate { get; private set; }  // use private so the birthdate cant be changed later

        // constructor
        public Person(DateTime birthdate)
        {
            Birthdate = birthdate;
        }

        // Calculated properties
        public int Age
        {
            get
            {
                TimeSpan timeSpan = DateTime.Today - Birthdate;
                var years = timeSpan.Days / 365;
                return years;
            }
            // Not setable - doesn't make sense to have a 'setter' for age... 
        }
    }



    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person(new DateTime(1982, 1, 1));

            Console.WriteLine(person.Birthdate);
        }
    }
}

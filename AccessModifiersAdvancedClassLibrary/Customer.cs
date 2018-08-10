using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiersAdvancedClassLibrary
{
    internal class RateCalculator   // Visible to other classes/etc in the same assembly only
    {
        public int Calculate(Customer customer)
        {
            return 0;
        }
    }



    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public void Promote()
        {
            //var rating = CalculateRating(excludeOrders: true);
            //if (rating == 0)
            //{
            //    Console.WriteLine("Promoted to level 1");
            //}
            //else
            //{
            //    Console.WriteLine("Promoted to level 2");
            //}

            var calculator = new RateCalculator();
            var rating = calculator.Calculate(this);

            Console.WriteLine("Promote logic.");
        }

        private int CalculateRating(bool excludeOrders)   // if you use 'protected' intead of 'private' then the GoldCustomer class will have access to it too!
        {
            return 0;
        }
    }
}

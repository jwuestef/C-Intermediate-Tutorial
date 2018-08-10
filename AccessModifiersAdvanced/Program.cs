using AccessModifiersAdvancedClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiersAdvanced
{


    public class GoldCustomer : Customer
    {
        public void OfferVoucher()
        {
            
        }
    }



    class Program
    {
        static void Main(string[] args)
        {
            var customer = new Customer();
            
        }
    }
}

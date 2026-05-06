using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    internal class CustomerAccount
    {
        
        public int CustomerId { get; set; }
        public int AccountNumber { get; set; } 
        public Customer customer { get; set; }
        public Account account { get; set; }
        public string OwnershipType { get; set; }
        public DateTime OwnershipStartDate { get; set; }
        public string AccountStatus { get; set; }

    }
}

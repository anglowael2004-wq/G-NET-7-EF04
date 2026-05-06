using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    internal class Account
    {
        [Key]
        public int AccountNumber { get; set; }
        public string AccountType { get; set; }
        public DateTime OpeningDate { get; set; }
        public decimal CurrentBalance { get; set; }
        public int branchCode { get; set; }
        public Branch branch { get; set; }
        public ICollection<CustomerAccount> customers { get; set; }
            public ICollection<Transaction>? transactions { get; set; }

       
    }
}

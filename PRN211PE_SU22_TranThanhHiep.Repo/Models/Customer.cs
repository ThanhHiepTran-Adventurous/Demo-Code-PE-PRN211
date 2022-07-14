using System;
using System.Collections.Generic;

#nullable disable

namespace PRN211PE_SU22_TranThanhHiep.Repo.Models
{
    public partial class Customer
    {
        public Customer()
        {
            CustomerAccounts = new HashSet<CustomerAccount>();
        }

        public string CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string CustomerDesc { get; set; }

        public virtual ICollection<CustomerAccount> CustomerAccounts { get; set; }
    }
}

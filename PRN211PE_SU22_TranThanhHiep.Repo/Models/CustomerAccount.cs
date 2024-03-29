﻿using System;
using System.Collections.Generic;

#nullable disable

namespace PRN211PE_SU22_TranThanhHiep.Repo.Models
{
    public partial class CustomerAccount
    {
        public string AccountId { get; set; }
        public string AccountName { get; set; }
        public DateTime OpenDate { get; set; }
        public string RegionName { get; set; }
        public string CustomerId { get; set; }

        public virtual Customer Customer { get; set; }


      
    }
}

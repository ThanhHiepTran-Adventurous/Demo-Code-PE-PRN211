using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
namespace PRN211PE_SU22_TranThanhHiep.Repo.Models
{
    public partial class CustomerAccountsContext : DbContext
    {
        public CustomerAccountsContext(string conn)
        {
            this.Database.SetConnectionString(conn);
        }

    }
}

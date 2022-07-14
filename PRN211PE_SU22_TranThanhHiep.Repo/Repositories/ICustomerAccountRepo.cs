using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PRN211PE_SU22_TranThanhHiep.Repo.Models;
namespace PRN211PE_SU22_TranThanhHiep.Repo.Repositories
{
    public interface ICustomerAccountRepo
    {
        IEnumerable<CustomerAccount> GetAll();


        void InsertAccount(CustomerAccount customerAccount);

        void UpdateAccount(CustomerAccount customerAccount);

        void DeleteAccount(string accountId);

    }
}

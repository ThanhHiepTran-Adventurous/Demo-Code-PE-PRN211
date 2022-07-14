using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PRN211PE_SU22_TranThanhHiep.Repo.Models;
namespace PRN211PE_SU22_TranThanhHiep.Repo.Repositories
{
    
    public class CustomerAccountRepo : ICustomerAccountRepo
    {
        private CustomerAccountsContext _db;

        public CustomerAccountRepo()
        {
            _db = new CustomerAccountsContext();
        }
        
        public IEnumerable<CustomerAccount> GetAll()
        {
            return this._db.CustomerAccounts.ToList();
            
        }


        public void InsertAccount(CustomerAccount customerAccount) => this._db.CustomerAccounts.Add(customerAccount);


        public void UpdateAccount(CustomerAccount customerAccount)
        {

            this._db.CustomerAccounts.Update(customerAccount);
            this._db.SaveChanges();
        }
        public void DeleteAccount(string accountId)
        {
            var cus = this._db.CustomerAccounts.FirstOrDefault(c => c.AccountId == accountId);
            this._db.Remove(cus);
            this._db.SaveChanges();
        }

    }
}

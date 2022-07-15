using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PRN211PE_SU22_TranThanhHiep.Repo.Models;
using Microsoft.Extensions.Configuration;
using System.IO;
namespace PRN211PE_SU22_TranThanhHiep.Repo.Repositories
{
    
    public class CustomerAccountRepo : ICustomerAccountRepo
    {
        private CustomerAccountsContext _db;


        public string GetConnectionString()
        {
            // string connectionString;
            IConfiguration config = new ConfigurationBuilder()
                                     .SetBasePath(Directory.GetCurrentDirectory())
                                     .AddJsonFile("appsettings.json", true, true)
                                     .Build();
            var strConn = config["ConnectionStrings:CustomerAccountsDB"];
            // connectionString = config["ConnectionStrings:CustomerAccountsDB"];
            return strConn;
        }

        public CustomerAccountRepo()
        {
            string Context = GetConnectionString();
            _db = new CustomerAccountsContext(Context);
        }
        
        public IEnumerable<CustomerAccount> GetAll()
        {
            return this._db.CustomerAccounts.ToList();
            
        }


        public void InsertAccount(CustomerAccount customerAccount)
        {
            this._db.CustomerAccounts.Add(customerAccount);
            this._db.SaveChanges(); 
        }

        public CustomerAccount getCustomerById(string customerId)
        {
            
            var customer = _db.CustomerAccounts.SingleOrDefault(c => c.AccountId == customerId);
            return customer;

        }
        public void UpdateAccount(CustomerAccount customerAccount)
        {
            CustomerAccount customer = null;
            customer = getCustomerById(customerAccount.AccountId);
            
            if (customer != null)
            {
                _db.CustomerAccounts.Update(customerAccount);
                _db.SaveChanges();
            }
            _db.Entry(customerAccount).State = EntityState.Detached;
            //     _db.CustomerAccounts.Update(customerAccount);
            //      _db.Entry(customerAccount).State = EntityState.Detached;
            //   this._db.Entry<CustomerAccount>(customerAccount).State = EntityState.Modified;
            //  _db.SaveChanges();
        }
        public void DeleteAccount(string accountId)
        {
            var cus = this._db.CustomerAccounts.FirstOrDefault(c => c.AccountId == accountId);
            this._db.Remove(cus);
            this._db.SaveChanges();
        }

        public IEnumerable<Customer> GetCustomers()
        {
            return _db.Customers.ToList();
        }


    }
}

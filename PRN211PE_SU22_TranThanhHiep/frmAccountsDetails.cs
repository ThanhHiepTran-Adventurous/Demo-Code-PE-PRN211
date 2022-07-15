using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PRN211PE_SU22_TranThanhHiep.Repo.Models;
using PRN211PE_SU22_TranThanhHiep.Repo.Repositories;
using System.Globalization;
namespace PRN211PE_SU22_TranThanhHiep
{
    public partial class frmAccountsDetails : Form
    {
        public ICustomerAccountRepo _customerAccountRepo { get; set; }
        
        public Customer CustomerInfo = new Customer();

        public bool InsertOrUpdate { get; set; }
       
        public CustomerAccount customerAccountInfo { get; set; }

        public frmAccountsDetails()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
       

        private void frmAccountsDetails_Load(object sender, EventArgs e)
        {
            var customers = _customerAccountRepo.GetCustomers();
            foreach (Customer customer in customers)
            {
                cbxCustomerId.Items.Add(customer);
            }
            txtAccountId.Enabled = !InsertOrUpdate;
            if(InsertOrUpdate == true)
            {
                txtAccountId.Text = customerAccountInfo.AccountId.ToString();
                txtAccountName.Text = customerAccountInfo.AccountName.ToString();
                txtOpenDate.Text = customerAccountInfo.OpenDate.ToString("dd//MM/yyyy");
                txtRegionName.Text = customerAccountInfo.RegionName.ToString();
                cbxCustomerId.Text = customerAccountInfo.CustomerId.ToString();
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {

            try
            {
                if(String.IsNullOrEmpty(txtAccountId.Text) || String.IsNullOrEmpty(txtAccountName.Text)
                    || String.IsNullOrEmpty(txtRegionName.Text) || String.IsNullOrEmpty(cbxCustomerId.Text))
                {
                    throw new Exception();
                }
                DateTime openDate = DateTime.ParseExact(
                        txtOpenDate.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                var customerAccounts = new CustomerAccount
                {

                    AccountId = txtAccountId.Text,
                    AccountName = txtAccountName.Text,
                    OpenDate = openDate,
                    RegionName = txtRegionName.Text,
                    CustomerId = cbxCustomerId.Text
                };
                if(InsertOrUpdate == false)
                {
                    _customerAccountRepo.InsertAccount(customerAccounts);
                    MessageBox.Show("Add Customer Account Successfully!!!");
                    this.Close();
                }else
                {
                    customerAccounts.AccountId = txtAccountId.Text;
                    _customerAccountRepo.UpdateAccount(customerAccounts);
                    MessageBox.Show("Update CustomerAccount Successfully");
                    this.Close();

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, InsertOrUpdate == false ? "Add a new CustomerAccounts " : "Update a CustomerAccounts");
            }
        }
    }
}


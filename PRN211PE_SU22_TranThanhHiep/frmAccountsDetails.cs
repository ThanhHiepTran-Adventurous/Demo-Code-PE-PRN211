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
        BindingSource source;

        public bool InsertOrUpdate { get; set; }
        private CustomerAccount customer;

        public frmAccountsDetails()
        {
            this._customerAccountRepo = new CustomerAccountRepo();
            InitializeComponent();
            LoadCustomer();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       


        public void Load(CustomerAccount customer)
        {
            txtAccountId.Text = customer.AccountId.ToString();
            txtAccountId.Enabled = false;
            txtAccountName.Text= customer.AccountName.ToString();
            txtOpenDate.Text = customer.OpenDate.ToString("dd/MM/yyyy");
            txtRegionName.Text = customer.RegionName.ToString();
            cbxCustomerId.SelectedValue = customer.CustomerId;
     //       txtCustomerId.Text = customer.CustomerId.ToString();
        }


        private void LoadCustomer()
        {
            var data = this._customerAccountRepo.GetAll();
            cbxCustomerId.DisplayMember = "CustomerID";
            cbxCustomerId.ValueMember = "CustomerID";
          
            var a = from customer in data
                  select new
                   {
                       customer.CustomerId
                   };         
            cbxCustomerId.DataSource = a.ToList();
        }
        
        private void btnSave_Click(object sender, EventArgs e)
        {
            customer = new CustomerAccount()
            {
                AccountId = txtAccountId.Text,
                AccountName = txtAccountName.Text,
                OpenDate = Convert.ToDateTime(txtOpenDate.Text),
                RegionName = txtRegionName.Text,
                CustomerId = txtOpenDate.Text
            };
            this._customerAccountRepo.UpdateAccount(customer);
        }

        private void frmAccountsDetails_Load(object sender, EventArgs e)
        {
            txtAccountId.Text = customer.AccountId.ToString();
            txtAccountName.Text = customer.AccountName.ToString();
            txtOpenDate.Text = customer.OpenDate.ToString("dd/MM/yyyy");
            txtRegionName.Text = customer.RegionName.ToString();
            cbxCustomerId.Text = customer.CustomerId.ToString();
        }
    }
}


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
namespace PRN211PE_SU22_TranThanhHiep
{
    public partial class frmAccounts : Form
    {
        ICustomerAccountRepo _customerAccountRepo = new CustomerAccountRepo();
        BindingSource source;


        public frmAccounts()
        {
           
            InitializeComponent();
        }
        private void frmAccounts_Load(object sender, EventArgs e)
        {
            btnDelete.Enabled = false;
           // LoadAccountList();
            dgvListAccount.CellDoubleClick += DgvMemberList_CellDoubleClick;

        }

        private void DgvMemberList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmAccountsDetails frm = new frmAccountsDetails
            {
                Text = "Update Customer Accounts",
                InsertOrUpdate = true,
                customerAccountInfo = GetCustomerAccountObject(),
                _customerAccountRepo = _customerAccountRepo
            };
            if(frm.ShowDialog() == DialogResult.OK)
            {
                LoadAccountList();
                source.Position = source.Position - 1;
            }
            LoadAccountList();
            
        }
        private void btnNew_Click(object sender, EventArgs e)
        {
            frmAccountsDetails frmAccountsDetails = new frmAccountsDetails
            {
                Text = "Add a new Customer Accounts",
                InsertOrUpdate = false,
                _customerAccountRepo = _customerAccountRepo
            };
            if( frmAccountsDetails.ShowDialog() == DialogResult.OK)
            {
                LoadAccountList();
                source.Position = source.Count - 1;
            }
            LoadAccountList();
        }

        private CustomerAccount GetCustomerAccountObject()
        {
            CustomerAccount customerAccount = null;
            try
            {
                customerAccount = new CustomerAccount
                {
                    AccountId = txtAccountId.Text,
                    AccountName = txtAccountName.Text,
                    OpenDate = DateTime.Parse(txtOpenDate.Text),
                    RegionName = txtRegionName.Text,
                    CustomerId = txtCustomerId.Text
                };


            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Get Customer Accounts");
            }
            return customerAccount;
        }

        private void LoadAccountList()
        {
            //goi len DB
            var customerAccounts = this._customerAccountRepo.GetAll();
            try
            {
                BindingSource source = new BindingSource();
                source.DataSource = customerAccounts;

                txtAccountId.DataBindings.Clear();
                txtAccountName.DataBindings.Clear();
                txtOpenDate.DataBindings.Clear();
                txtRegionName.DataBindings.Clear();
                txtCustomerId.DataBindings.Clear();



                txtAccountId.DataBindings.Add("Text", source, "AccountID");
                txtAccountName.DataBindings.Add("Text", source, "AccountName");
                txtOpenDate.DataBindings.Add("Text", source, "OpenDate");
                txtRegionName.DataBindings.Add("Text", source, "RegionName");
                txtCustomerId.DataBindings.Add("Text", source, "CustomerID");

                dgvListAccount.DataSource = null;
                dgvListAccount.DataSource = source;


                this.dgvListAccount.Columns["Customer"].Visible = false;
                this.dgvListAccount.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
                if (customerAccounts.Count() == 0)
                {
                    ClearTextOrder();
                    btnDelete.Enabled = false;
                }
                else
                {
                    btnDelete.Enabled = true;
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Load CustomerAccounts List");
            }

            
        }

        private void ClearTextOrder()
        {
            txtAccountId.Text = string.Empty;
            txtAccountName.Text = string.Empty;
            txtOpenDate.Text = string.Empty;
            txtRegionName.Text = string.Empty;
            txtCustomerId.Text = string.Empty;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
           if(dgvListAccount.SelectedRows.Count > 0)
            {
                string customerID = dgvListAccount.SelectedRows[0].Cells[0].Value.ToString();
                this._customerAccountRepo.DeleteAccount(customerID);
                MessageBox.Show("Delete successfuly");
                LoadAccountList();
            }
           
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadAccountList();
        }

       
    }
}

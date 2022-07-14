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
        private ICustomerAccountRepo _customerAccountRepo;
        CustomerAccount acccountCustomer = new CustomerAccount();
        BindingSource source;


        public frmAccounts()
        {
            this._customerAccountRepo = new CustomerAccountRepo();
            InitializeComponent();
        }


        private void LoadAccountList()
        {
            //goi len DB
            var data = this._customerAccountRepo.GetAll();
            source = new BindingSource();
            source.DataSource = data;
            //var a = from customer in data
            //        select new
            //        {
            //            customer.AccountName
            //        };

            //   source.DataSource = a.ToList();

            //Load lên thoong qua data source
            dgvListAccount.DataSource = null;
            dgvListAccount.DataSource = source;
           
            this.dgvListAccount.Columns["Customer"].Visible = false;
            this.dgvListAccount.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void frmAccounts_Load(object sender, EventArgs e)
        {               
                btnDelete.Enabled = false;        
                dgvListAccount.CellDoubleClick += DgvMemberList_CellDoubleClick;         
            
        }

        private void DgvMemberList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmAccountsDetails frm = new frmAccountsDetails();
            if(dgvListAccount.SelectedRows.Count > 0)
            {
                var Customer = new CustomerAccount()
                {
                    AccountId = (string)dgvListAccount.SelectedRows[0].Cells[0].Value,
                    AccountName = (string)dgvListAccount.SelectedRows[0].Cells[1].Value,
                    OpenDate = (DateTime)dgvListAccount.SelectedRows[0].Cells[2].Value,
                    RegionName = (string)dgvListAccount.SelectedRows[0].Cells[3].Value,
                    CustomerId = (string)dgvListAccount.SelectedRows[0].Cells[4].Value
                };
                frm.Load(Customer);
            }
            frm.ShowDialog();
            LoadAccountList();
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
            btnDelete.Enabled = true;
            var data = this._customerAccountRepo.GetAll();
            source = new BindingSource();
            source.DataSource = data;
            //var a = from customer in data
            //        select new
            //        {
            //            customer.AccountName
            //        };

            //   source.DataSource = a.ToList();

            //Load lên thoong qua data source
            dgvListAccount.DataSource = null;
            dgvListAccount.DataSource = source;
            dgvListAccount.CellDoubleClick += DgvMemberList_CellDoubleClick;
            this.dgvListAccount.Columns["Customer"].Visible = false;
            this.dgvListAccount.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}

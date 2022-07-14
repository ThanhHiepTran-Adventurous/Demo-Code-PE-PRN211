using Microsoft.Extensions.Configuration;
using PRN211PE_SU22_TranThanhHiep.Repo.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRN211PE_SU22_TranThanhHiep
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
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
        private void btnLogin_Click(object sender, EventArgs e)
        {
            //When click by pass conn to data access...
            //1. cehck not null User ID and password
            if(txtUserID.Text == String.Empty || txtPassword.Text == null)
            {
                MessageBox.Show("User ID or Password is not null.....");
            }else
            {
                //connect database to check user
                //check userID-password exist in DB
                //Check role is administrator
                //to be continue

                string cs = GetConnectionString();
                using(var db = new CustomerAccountsContext(cs))
                {
                    var user = db.Users.Where(a => a.UserId == txtUserID.Text
                    && a.Password == txtPassword.Text).FirstOrDefault();
                    if (user == null)        
                    {
                        MessageBox.Show("Invalid userID or password!!");
                    }
                    else
                    {
                        //Correct userId and password => check role
                        if(user.UserRole == 1)
                        {
                            // Login success => show main form
                            frmAccounts accounts = new frmAccounts();                                                 
                            this.Hide();
                            accounts.Show();
                        }
                        else
                        {   
                            //Correct user id and password but role not admin
                            MessageBox.Show("You are not allowed to access to access this function!!");
                        }
                    }
                }
               
            }
            
        }
       
    }
}

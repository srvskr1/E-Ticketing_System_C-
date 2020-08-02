using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using All.Data;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
namespace eticketing
{
    public partial class RegisterForm : MetroForm
    {
        internal DataAccess Da { get; set; }
        internal DataSet Ds { get; set; }
        public RegisterForm()
        {
            this.Da = new DataAccess();
            InitializeComponent();
        }

        private void btnCreatAccount_Click(object sender, EventArgs e)
        {
            string s1="";
            lblfname1.Text = "";
            lblLname.Text = "";
            lblEmail.Text = "";
            lblPassword.Text = "";
            lblConPassword.Text = "";
            lblPassword.Text = "";
            try
            {
                string sql1 = @"select username from clntinfo where username='" + txtusername.Text + "' ";
                this.Ds = this.Da.ExecuteQuery(sql1);
                s1 = this.Ds.Tables[0].Rows[0]["username"].ToString();
                lblUser.Text = "User Name Exists";

            }
            catch
            {
                lblUser1.Text = "";
            }
            if (txtFName.Text != "" && txtLName.Text != "" && txtusername.Text != "" && txtPassword.Text != "" && txtConPassword.Text != "" && txtEmail.Text != "" && txtPNumber.Text != "" && txtPassword.Text==txtConPassword.Text && s1!=txtusername.Text)
            {
                try
                {
                    s1 = @"insert into clntinfo(username, password, firstname, lastname, phonenumber, email)
                            values('"+txtusername.Text+"', '"+txtPassword.Text+"', '"+txtFName.Text+"', '"+txtLName.Text+"', '"+txtPNumber.Text+"', '"+txtEmail.Text+"'); ";
                    this.Ds = this.Da.ExecuteQuery(s1);
                    MessageBox.Show("User Account Successfuly Created. Please Loging ");
                }
                catch
                {
                    MessageBox.Show("Please Try again ");
                }

                WelcomeF wf = new WelcomeF();
                wf.Visible = true;
                this.Visible = false;

            }
            else if (txtFName.Text == "")
            {
                lblfname1.Text = "Fill the gap*";
            }
            else if (txtLName.Text == "")
            {
                lblLname.Text = "Fill the gap*";
            }
            else if (txtEmail.Text == "")
            {
                lblEmail.Text = "Fill the gap*";
            }
            else if (txtPassword.Text == "")
            {
                lblPassword.Text = "Fill the gap*";
            }
            else if (txtPassword.Text != txtConPassword.Text )
            {
                lblConPassword.Text = "Password Doesnot Match*";
            }
            else if (txtPNumber.Text == "")
            {
                lblPumber.Text = "Fill the gap*";
            }

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            WelcomeF wf = new WelcomeF();
            wf.Visible = true;
            this.Visible = false;
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {

        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            lblUser.Text = "";
            lblUser1.Text = "";
            try
            {
                string sql1 = @"select username from clntinfo where username='" + txtusername.Text + "' ";
                this.Ds = this.Da.ExecuteQuery(sql1);
                string s1 = this.Ds.Tables[0].Rows[0]["username"].ToString();
                
                
                lblUser.Text = "User Name Exists";
                
            }
            catch
            {
                lblUser1.Text = "User Name Available";
            }
            
        }
    }
}

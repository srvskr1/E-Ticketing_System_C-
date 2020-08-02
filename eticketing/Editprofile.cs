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
    public partial class Editprofile : MetroForm
    {
        string UserName { get; set; }
        internal DataAccess Da { get; set; }
        internal DataSet Ds { get; set; }
        public Editprofile(string username)
        {
            InitializeComponent();
            UserName = username;
            this.Da = new DataAccess();
            string sql2 = "select  firstname,lastname,email,phonenumber from clntinfo where username='" + UserName + "';";
            this.Ds = this.Da.ExecuteQuery(sql2);
            this.txtFName.Text = this.Ds.Tables[0].Rows[0]["firstname"].ToString();
            this.txtLName.Text = this.Ds.Tables[0].Rows[0]["lastname"].ToString();
            this.txtEmail.Text = this.Ds.Tables[0].Rows[0]["email"].ToString();
            this.txtPNumber.Text = this.Ds.Tables[0].Rows[0]["phonenumber"].ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.clear();
        }
        public void clear()
        {
            this.txtFName.Text = null;
            this.txtLName.Text = null;
            this.txtEmail.Text = null;
            this.txtPNumber.Text = null;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string sql2 = @"update clntinfo
                                set firstname= '" + this.txtFName.Text + "',lastname= '" + this.txtLName.Text + "',email='" + this.txtEmail.Text + "',[phonenumber]='" + this.txtPNumber.Text + "' where username = '" + this.UserName + "';";
                this.Da.ExecuteUpdateQuery(sql2);
                MessageBox.Show("Profile Successfuly edited...");
                UserMenu um = new UserMenu(UserName);
                um.Visible = true;
                this.Visible = false;
            }
            catch
            {
                MessageBox.Show("Profile edit Fail...");
            }
           
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            UserMenu um = new UserMenu(UserName);
            um.Visible = true;
            this.Visible = false;
        }
    }
}

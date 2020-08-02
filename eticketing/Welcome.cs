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
    public partial class WelcomeF : MetroForm
    {
        internal DataAccess Da { get; set; }
        internal DataSet Ds { get; set; }
        public WelcomeF()
        {
            this.Da = new DataAccess();
            InitializeComponent();
        }



        private void lblSignIn_Click(object sender, EventArgs e)
        {
            RegisterForm rf = new RegisterForm();
            rf.Visible = true;
            this.Visible = false;


        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            
            

            try
            {
                string sql2 = "select username,password from empinfo where username='" + txtUserid.Text + "';";
                this.Ds = this.Da.ExecuteQuery(sql2);
                string s1 = this.Ds.Tables[0].Rows[0]["username"].ToString();
                if (this.txtUserid.Text.Equals(s1))
                {
                    try
                    {
                        //string sql3 = "select password from empinfo where password='" + txtPassword.Text + "'";
                        //this.Ds = this.Da.ExecuteQuery(sql3);
                        string s4 = this.Ds.Tables[0].Rows[0]["password"].ToString();
                        if (this.txtPassword.Text == s4)
                        {
                            ManagerPanel mp = new ManagerPanel(txtUserid.Text);
                            mp.Visible = true;
                            this.Visible = false;
                        }
                        
                    }
                    catch
                    {
                        MessageBox.Show("invaild Password ");
                    }
                    
                }
               
            }
            catch
            {
                try
                {
                    string sql5= "select username,password from clntinfo where username='" + txtUserid.Text + "';";
                    this.Ds = this.Da.ExecuteQuery(sql5);
                    string s6 = this.Ds.Tables[0].Rows[0]["username"].ToString();
                    if (this.txtUserid.Text.Equals(s6))
                    {
                        try
                        {
                            //string sql6 = "select password from clntinfo where password='" + txtPassword.Text + "'";
                            //this.Ds = this.Da.ExecuteQuery(sql6);
                            string s7 = this.Ds.Tables[0].Rows[0]["password"].ToString();
                            if (this.txtPassword.Text == s7)
                            {
                                UserMenu um = new UserMenu(txtUserid.Text);
                                um.Visible = true;
                                this.Visible = false;
                            }
                            else
                            {
                                MessageBox.Show("invaild Password ");
                            }

                        }
                        catch 
                        {
                            MessageBox.Show("invaild Password ");
                        }

                    }
                }
                catch 
                {
                    MessageBox.Show("invaild userName ");
                }
                
            }

        }

        private void lblSignIn_MouseHover(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.Hand;

        }

        private void lblSignIn_MouseLeave(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.Hand;
        }
    }
}

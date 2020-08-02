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
using System.IO;
namespace eticketing
{
    public partial class UserMenu : MetroForm
    {
        internal DataAccess Da { get; set; }
        internal DataSet Ds { get; set; }
        string UserName { set; get; }
        public  UserMenu()
        {
            InitializeComponent();
        }
        public UserMenu(string userid)
        {
            InitializeComponent();
            UserName = userid;
            this.Da = new DataAccess();
            string sql2 = "select  firstname,lastname,email,phonenumber from clntinfo where username='"+UserName+ "';";
            this.Ds = this.Da.ExecuteQuery(sql2);
            string s1= (this.Ds.Tables[0].Rows[0]["firstname"].ToString())+" "+ (this.Ds.Tables[0].Rows[0]["lastname"].ToString());
            lblName.Text =s1 ;
            lblUserName.Text = UserName;
            lblMail.Text = this.Ds.Tables[0].Rows[0]["email"].ToString();
            lblPnumber.Text= this.Ds.Tables[0].Rows[0]["phonenumber"].ToString();
        }

        private void trainToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CalculateFareTrain cft = new CalculateFareTrain();
            cft.Visible = true;
            this.Visible = false;
        }

        private void profileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Profile pf = new Profile(this.UserName);
            pf.Visible = true;
            this.Visible = false;
        }

        private void editProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Editprofile ep = new Editprofile(this.lblUserName.Text);
            ep.Visible = true;
            this.Visible = false;
        }

        private void calculateFareToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void busToolStripMenuItem_Click(object sender, EventArgs e)
        {
           /// BusFareCalculation bfc = new BusFareCalculation();
            this.Visible = false;
           // bfc.Visible = true;
        }

        private void trainToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BuyTrainTicket btt = new BuyTrainTicket(UserName);
            btt.Visible = true;
            this.Visible = false;
        }

        private void bussToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BuyBusTicket bbt = new BuyBusTicket(UserName);
            this.Visible = false;
            bbt.Visible = true;
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WelcomeF wf = new WelcomeF();
            wf.Visible = true;
            this.Visible = false;
        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }
        private void populateGridView()
        {
            string sql = "select * from clienticketinfo where username='" + UserName + "';";
            this.metroGrid1.AutoGenerateColumns = false;
            this.Ds = this.Da.ExecuteQuery(sql);
            this.metroGrid1.DataSource = this.Ds.Tables[0];
        }

        private void metroPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void UserMenu_Load(object sender, EventArgs e)
        {
            this.populateGridView();
        }

        private void btnprint_Click(object sender, EventArgs e)
        {
            //textBox1.Text = this.metroGrid1.CurrentRow.Cells["status"].Value.ToString();
            if (this.metroGrid1.CurrentRow.Cells["status"].Value.ToString() == "Accepted")
            {
                StreamWriter sw = new StreamWriter(@"Ticket.txt");
                sw.WriteLine("Name :"+ lblName.Text);
                sw.WriteLine("Transportation :"+ this.metroGrid1.CurrentRow.Cells["transportation"].Value.ToString());
                sw.WriteLine("Journey Date :" + this.metroGrid1.CurrentRow.Cells["journeydate"].Value.ToString());
                sw.WriteLine("Departure :" + this.metroGrid1.CurrentRow.Cells["departure"].Value.ToString());
                sw.WriteLine("Destination :" + this.metroGrid1.CurrentRow.Cells["Destination"].Value.ToString());
                sw.Close();
                MessageBox.Show("Ticket Printed");

            }
            else
            {
                MessageBox.Show("Please wait for conformation...");
            }

        }

        private void metroGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //textBox1.Text = this.metroGrid1.CurrentRow.Cells["status"].Value.ToString();
            //textBox2.Text = this.metroGrid1.CurrentRow.Cells["paymentstatus"].Value.ToString();

        }
    }
}

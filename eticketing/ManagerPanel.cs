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
    public partial class ManagerPanel : MetroForm
    {
        string UserName { set; get; }
        string sr;
        internal DataAccess Da { get; set; }
        internal DataSet Ds { get; set; }
        public ManagerPanel(string userid)
        {
            InitializeComponent();
            this.Da = new DataAccess();
            this.UserName = userid;
            string sql2 = "select  firstname,lastname from empinfo where username='" + UserName + "';";
            this.Ds = this.Da.ExecuteQuery(sql2);
            string s1 = (this.Ds.Tables[0].Rows[0]["firstname"].ToString()) + " " + (this.Ds.Tables[0].Rows[0]["lastname"].ToString());
            lblName.Text = s1;
            lblUname.Text = UserName;
           

        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {
            
        }
        private void populateGridView(string sql2="select * from clienticketinfo")
        {
            // = ;
            this.metroGrid1.AutoGenerateColumns = false;
            this.Ds = this.Da.ExecuteQuery(sql2);
            this.metroGrid1.DataSource = this.Ds.Tables[0];
        }

        private void metroPanel1_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {
            populateGridView();
        }

        private void ManagerPanel_Load(object sender, EventArgs e)
        {
            populateGridView();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            string sql1 = @"update clienticketinfo
                            set status='Accepted' where Token='"+ this.metroGrid1.CurrentRow.Cells["Token"].Value.ToString() + "'";
            this.Ds = this.Da.ExecuteQuery(sql1);

            populateGridView();
        }

        private void metroGrid1_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void btnReject_Click(object sender, EventArgs e)
        {
            string sql1 = @"update clienticketinfo
                            set status='Rejected' where Token='" + this.metroGrid1.CurrentRow.Cells["Token"].Value.ToString() + "'";
            this.Ds = this.Da.ExecuteQuery(sql1);

            populateGridView();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string s = @"select * from clienticketinfo
                        where username like '" + this.txtSearch.Text + "%'  or status like '" + this.txtSearch.Text + "%' or paymentmethod like '" + this.txtSearch.Text + "%'or paymentstatus like '" + this.txtSearch.Text + "%' or transportation like '" + this.txtSearch.Text + "%'or departure like '" + this.txtSearch.Text + "%' or destination like '" + this.txtSearch.Text + "%' ; ";
            populateGridView(s);
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WelcomeF wf = new WelcomeF();
            this.Visible = false;
            wf.Visible = true;
        }

        private void trainToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BuyTrainTicket bt = new BuyTrainTicket(UserName);
            bt.Visible = true;
            this.Visible = false;

        }

        private void busToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BuyBusTicket bbt = new BuyBusTicket(UserName);
            bbt.Visible = true;
            this.Visible = false;
        }

        private void makeScheduleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MakeSchedule ms = new MakeSchedule(UserName);
            ms.Visible = true;
            this.Visible = false;
        }

        private void showScheduleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowShedule ss = new ShowShedule(UserName);
            ss.Visible = true;
            this.Visible = false;
        }

        private void txtSearch_TabIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

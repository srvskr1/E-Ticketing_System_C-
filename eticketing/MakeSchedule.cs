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
    public partial class MakeSchedule : MetroForm
    {
        string UserName { set; get; }
        
        internal DataAccess Da { get; set; }
        internal DataSet Ds { get; set; }
        public MakeSchedule(string userid)
        {
            InitializeComponent();
            this.Da = new DataAccess();
            UserName = userid;
        }
        private void populateGridView(string sql2 = "select * from scheduleinfo")
        {
            // = ;
            this.mgr.AutoGenerateColumns = false;
            this.Ds = this.Da.ExecuteQuery(sql2);
            this.mgr.DataSource = this.Ds.Tables[0];
        }

        private void MakeSchedule_Load(object sender, EventArgs e)
        {
            this.populateGridView();
            dtpDate.Format = DateTimePickerFormat.Custom;
            dtpDate.CustomFormat = "dd-MM-yyyy";
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            ManagerPanel mp = new ManagerPanel(UserName);
            mp.Visible = true;
            this.Visible = false;
        }

        private void Create_Click(object sender, EventArgs e)
        {
            try
            {
                //TimeSpan t1 = TimeSpan.TryParse(cmbDparttime.Text);
                //TimeSpan t2=TimeSpan.TryParse(cmbArrivalTime.Text);
                string s1 = @"insert into scheduleinfo(departure, destination, date, departuretime, arrivaltime, Transportation)
                            values('"+cmbdpart.Text+"','"+cmbdesti.Text+"','"+dtpDate.Text+"','"+ cmbdepartime.Text+"','"+cmbArrivalTime.Text+"','"+cmbtrans.Text+"'); ";
                this.Ds = this.Da.ExecuteQuery(s1);
                MessageBox.Show("Schedule Created.... ");
                this.populateGridView();
            }
            catch
            {
                MessageBox.Show("Please Try again ");
            }
        }

        private void cmbdpart_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnDelet_Click(object sender, EventArgs e)
        {
            string s1= @"delete from scheduleinfo where departure='"+ this.mgr.CurrentRow.Cells["departure"].Value.ToString() + "' and destination = '"+this.mgr.CurrentRow.Cells["destination"].Value.ToString()+"'and transportation = '"+this.mgr.CurrentRow.Cells["transportation"].Value.ToString()+"'and date='"+this.mgr.CurrentRow.Cells["journeydate"].Value.ToString()+ "'and departuretime='"+this.mgr.CurrentRow.Cells["departuretime"].Value.ToString() +"'";
            this.Ds = this.Da.ExecuteQuery(s1);
            this.populateGridView();
        }
    }
}

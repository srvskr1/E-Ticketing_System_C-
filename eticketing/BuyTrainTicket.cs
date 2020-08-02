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
    public partial class BuyTrainTicket : MetroForm
    {
        internal DataAccess Da { get; set; }
        internal DataSet Ds { get; set; }
        string UserName { set; get; }
        public BuyTrainTicket()
        {
            InitializeComponent();
            this.Da = new DataAccess();
            fillDeparture();
            dateTimePicker1.MinDate = DateTime.Today;
            dateTimePicker1.MaxDate = DateTime.Today.AddDays(10);

        }
        public BuyTrainTicket(string userid)
        {
            InitializeComponent();
            UserName = userid;
            this.Da = new DataAccess();
            fillDeparture();
            dateTimePicker1.MinDate = DateTime.Today;
            dateTimePicker1.MaxDate = DateTime.Today.AddDays(10);
        }
        private void fillDeparture()
        {
            comboBox1.Items.Clear();
            string s1 = @"select DISTINCT departure  from scheduleinfo;";
            this.Ds = Da.ExecuteQuery(s1);
            for (int i = 0; i < this.Ds.Tables[0].Rows.Count; i++)
            {
                comboBox1.Items.Add(this.Ds.Tables[0].Rows[i]["departure"].ToString());
            }

        }
        private void fillDestination()
        {
            comboBox2.Items.Clear();   
            string s1 = @"select DISTINCT destination from scheduleinfo where departure = '" + comboBox1.Text+"';";
            Ds = Da.ExecuteQuery(s1);
            for (int i = 0; i < this.Ds.Tables[0].Rows.Count; i++)
            {
                comboBox2.Items.Add(this.Ds.Tables[0].Rows[i]["destination"].ToString());
            }

        }
        private void fillTime()
        {
            metroComboBox1.Items.Clear();
            string s1 = @"select DISTINCT departuretime from scheduleinfo where destination='" + comboBox2.Text + "'and date = '"+dateTimePicker1.Text+"'and transportation='Train';";
            Ds = Da.ExecuteQuery(s1);
            for (int i = 0; i < this.Ds.Tables[0].Rows.Count; i++)
            {
                metroComboBox1.Items.Add(this.Ds.Tables[0].Rows[i]["departuretime"]);
            }

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            try
            { 
            string s1 = "select username,password from clntinfo where username='" + UserName + "'";
            this.Ds = this.Da.ExecuteQuery(s1);
            string s2 = this.Ds.Tables[0].Rows[0]["username"].ToString();
            if (UserName == s2)
            {
                UserMenu um = new UserMenu(UserName);
                um.Visible = true;
                this.Visible = false;
            }


             }
             catch
             {
                    ManagerPanel mp = new ManagerPanel(UserName);
                    mp.Visible = true;
                    this.Visible = false;
              }
}

        private void btnNext_Click(object sender, EventArgs e)
        {


            double a = Double.Parse(metroComboBox1.Text.Substring(0, 2));
            if (Int32.Parse(dateTimePicker1.Text.Substring(0, 2)) == DateTime.Now.Day)
            {

                if (DateTime.Now.Hour < a)
                {
                    TrainSeatPicker bsp = new TrainSeatPicker(UserName,dateTimePicker1.Text,metroComboBox1.Text,comboBox1.Text,comboBox2.Text);
                    bsp.Visible = true;
                    this.Visible = false;
                }
                else
                {
                    metroLabel7.Text = "";
                    label1.Text = "Please Select a time grater than " + DateTime.Now.Hour.ToString();
                }
            }
            else
            {
                TrainSeatPicker bsp = new TrainSeatPicker(UserName,dateTimePicker1.Text, metroComboBox1.Text, comboBox1.Text, comboBox2.Text);
                bsp.Visible = true;
                this.Visible = false;
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            //fillDestination();
        }

        private void comboBox2_MouseClick(object sender, MouseEventArgs e)
        {
            fillDestination();
        }

        private void BuyTrainTicket_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "dd-MM-yyyy";
        }

        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           // fillTime();
        }

        private void metroComboBox1_MouseClick(object sender, MouseEventArgs e)
        {
            fillTime();
        }
        public void seatplan()
        {
            
        }

    }
}

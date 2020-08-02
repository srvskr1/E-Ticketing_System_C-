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
    
    public partial class TrainSeatPicker : MetroForm
    {
        public int noofseat = 0;
        public bool seat1 = false;
        public bool seat2 = false;
        public bool seat3 = false;
        public bool seat4 = false;
        public bool seat5 = false;
        public bool seat6 = false;
        public bool seat7 = false;
        public bool seat8 = false;
        public bool seat9 = false;
        public bool seat10 = false;
        public bool seat11 = false;
        public bool seat12 = false;
        public bool seat13 = false;
        public bool seat14 = false;
        public bool seat15 = false;
        public bool seat16 = false;
        public bool seat17 = false;
        public bool seat18 = false;
        public bool seat19 = false;
        public bool seat20 = false;
        public bool seat21 = false;
        public bool seat22 = false;
        public bool seat23 = false;
        public bool seat24 = false;
        public bool seat25 = false;
        public bool seat26 = false;
        public bool seat27 = false;
        public bool seat28 = false;
        public bool seat29 = false;
        public bool seat30 = false;
        public bool seat31 = false;
        public bool seat32 = false;
        public bool seat33 = false;
        public bool seat34 = false;
        public bool seat35 = false;
        public bool seat36 = false;
        public bool seat37 = false;
        public bool seat38 = false;
        public bool seat39 = false;
        public bool seat40 = false;
        public bool seat41 = false;
        public bool seat42 = false;
        public bool seat43 = false;
        public bool seat44 = false;
        public bool seat45 = false;
        public bool seat46 = false;
        public bool seat47 = false;
        public bool seat48 = false;
        public bool seat49 = false;
        public bool seat50 = false;
        public bool seat51 = false;
        public bool seat52 = false;
        public bool seat53 = false;
        public bool seat54 = false;
        public bool seat55 = false;
        public bool seat56 = false;
        public bool seat57 = false;
        public bool seat58 = false;
        public bool seat59 = false;
        public bool seat60 = false;
        public bool seat61 = false;
        public bool seat62 = false;
        public bool seat63 = false;
        public bool seat64 = false;
        public bool seat65 = false;
        public bool seat66 = false;
        public bool seat67 = false;
        public bool seat68 = false;
        public bool seat69 = false;
        public bool seat70 = false;
        public bool seat71 = false;
        public bool seat72 = false;
        internal DataAccess Da { get; set; }
        internal DataSet Ds { get; set; }
        string UserName { set; get; }
        string Date { set; get; }
        string Time { set; get; }
        string Departure { set; get; }
        string Destination { set; get; }
        public TrainSeatPicker()
        {
            InitializeComponent();
            this.Da = new DataAccess();
        }
        public TrainSeatPicker(string userid,string date,string time,string departure,string destination)
        {
            InitializeComponent();
            this.Da = new DataAccess();
            UserName = userid;
            Date = date;
            Time = time;
            Departure = departure;
            Destination = destination;
            

        }
        public int RandomNumber(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }
        private void btnback_Click(object sender, EventArgs e)
        {
           BuyTrainTicket um = new BuyTrainTicket(UserName);
            um.Visible = true;
            this.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (cmbpayment.Text != "")
            {
                try
                {
                    string sql1 = @"insert into clienticketinfo(username,status,departure,destination,journeydate,totalseat,paymentmethod,paymentstatus,transportation,Token)
                                values('" + UserName + "','Pending','" + Departure + "','" + Destination + "','" + Date + "','" + txtnoOfSeat.Text + "','" + cmbpayment.Text + "','paid','train'," + RandomNumber(1000, 100000) + ");";
                    this.Ds = this.Da.ExecuteQuery(sql1);
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
            else
            {
                MessageBox.Show("Please Select Cash on Delivery");
            }
            
        }

        private void TrainSeatPicker_Load(object sender, EventArgs e)
        {
            TodayPanel.Visible = false;
            todaytrseatplan2.Visible = false;
            if(Departure=="Dhaka"&&Destination=="Chittagong"&&Int32.Parse(Date.Substring(0,2))== DateTime.Now.Day&&Time.Substring(0,2)=="17")
            {
                TodayPanel.Visible = true;
            }
            else if(Departure == "Dhaka" && Destination == "Chittagong" && Int32.Parse(Date.Substring(0, 2)) == DateTime.Now.Day && Time.Substring(0, 2) == "16")
            {
                todaytrseatplan2.Visible = true;
            }
            else if (Departure == "Chittagong" && Destination == "Dhaka" && Int32.Parse(Date.Substring(0, 2)) == DateTime.Now.Day && Time.Substring(0, 2) == "16")
            {
                TodayPanel.Visible =true;
            }
            else if (Departure == "Chittagong" && Destination == "Dhaka" && Int32.Parse(Date.Substring(0, 2)) == DateTime.Now.Day && Time.Substring(0, 2) == "08")
            {

                todaytrseatplan2.Visible = true;

            }

        }

        private void btnS1_Click(object sender, EventArgs e)
        {
            string s1 = "select * from seatalocation1 where seatno='21'";
            this.Ds = this.Da.ExecuteQuery(s1);
            string s2 = this.Ds.Tables[0].Rows[0]["bookingstatus"].ToString();
            string s4 = this.Ds.Tables[0].Rows[0]["username"].ToString();
            if (s2 == "booked")
            {
                if (s4 == UserName)
                {
                    btnS1.BackColor = Color.White;
                    noofseat--;
                    txtnoOfSeat.Text = noofseat.ToString();
                    txtTotalFare.Text = (noofseat * 450).ToString();
                    string s3 = @"update seatalocation1
                              set bookingstatus='not booked',username='' where seatno='21';";
                    this.Ds = this.Da.ExecuteQuery(s3);

                }
                else
                {
                    btnS1.BackColor = Color.Red;
                    MessageBox.Show("This seat is already booked..");
                }
            }
            else if (s2 != "booked")
            {
                btnS1.BackColor = Color.Green;
                seat1 = true;
                string s3 = @"update seatalocation1
                              set bookingstatus='booked',username='" + this.UserName + "' where seatno='21';";
                this.Ds = this.Da.ExecuteQuery(s3);
                noofseat++;
                txtnoOfSeat.Text = noofseat.ToString();
                txtTotalFare.Text = (noofseat * 450).ToString();
            }
        }
        private void btnS2_Click(object sender, EventArgs e)
        {
            string s1 = "select * from seatalocation1 where seatno='22'";
            this.Ds = this.Da.ExecuteQuery(s1);
            string s2 = this.Ds.Tables[0].Rows[0]["bookingstatus"].ToString();
            string s4 = this.Ds.Tables[0].Rows[0]["username"].ToString();
            if (s2 == "booked")
            {
                if (s4 == UserName)
                {
                    btnS2.BackColor = Color.White;
                    noofseat--;
                    txtnoOfSeat.Text = noofseat.ToString();
                    txtTotalFare.Text = (noofseat * 450).ToString();
                    string s3 = @"update seatalocation1
                              set bookingstatus='not booked',username='' where seatno='22';";
                    this.Ds = this.Da.ExecuteQuery(s3);

                }
                else
                {
                    btnS2.BackColor = Color.Red;
                    MessageBox.Show("This seat is already booked..");
                }
            }
            else if (s2 != "book")
            {
                btnS2.BackColor = Color.Green;
                seat1 = true;
                string s3 = @"update seatalocation1
                              set bookingstatus='booked',username='" + this.UserName + "' where seatno='22';";
                this.Ds = this.Da.ExecuteQuery(s3);
                noofseat++;
                txtnoOfSeat.Text = noofseat.ToString();
                txtTotalFare.Text = (noofseat * 450).ToString();
            }
        }

        private void btnS3_Click(object sender, EventArgs e)
        {
            string s1 = "select * from seatalocation1 where seatno='23'";
            this.Ds = this.Da.ExecuteQuery(s1);
            string s2 = this.Ds.Tables[0].Rows[0]["bookingstatus"].ToString();
            string s4 = this.Ds.Tables[0].Rows[0]["username"].ToString();
            if (s2 == "booked")
            {
                if (s4 == UserName)
                {
                    btnS3.BackColor = Color.White;
                    noofseat--;
                    txtnoOfSeat.Text = noofseat.ToString();
                    txtTotalFare.Text = (noofseat * 450).ToString();
                    string s3 = @"update seatalocation1
                              set bookingstatus='not booked',username='' where seatno='23';";
                    this.Ds = this.Da.ExecuteQuery(s3);

                }
                else
                {
                    btnS3.BackColor = Color.Red;
                    MessageBox.Show("This seat is already booked..");
                }
            }
            else if (s2 != "book")
            {
                btnS3.BackColor = Color.Green;
                seat1 = true;
                string s3 = @"update seatalocation1
                              set bookingstatus='booked',username='" + this.UserName + "' where seatno='23';";
                this.Ds = this.Da.ExecuteQuery(s3);
                noofseat++;
                txtnoOfSeat.Text = noofseat.ToString();
                txtTotalFare.Text = (noofseat * 450).ToString();
            }
        }

        private void btnS4_Click(object sender, EventArgs e)
        {
            string s1 = "select * from seatalocation1 where seatno='24'";
            this.Ds = this.Da.ExecuteQuery(s1);
            string s2 = this.Ds.Tables[0].Rows[0]["bookingstatus"].ToString();
            string s4 = this.Ds.Tables[0].Rows[0]["username"].ToString();
            if (s2 == "booked")
            {
                if (s4 == UserName)
                {
                    btnS4.BackColor = Color.White;
                    noofseat--;
                    txtnoOfSeat.Text = noofseat.ToString();
                    txtTotalFare.Text = (noofseat * 450).ToString();
                    string s3 = @"update seatalocation1
                              set bookingstatus='not booked',username='' where seatno='24';";
                    this.Ds = this.Da.ExecuteQuery(s3);

                }
                else
                {
                    btnS4.BackColor = Color.Red;
                    MessageBox.Show("This seat is already booked..");
                }
            }
            else if (s2 != "book")
            {
                btnS4.BackColor = Color.Green;
                seat1 = true;
                string s3 = @"update seatalocation1
                              set bookingstatus='booked',username='" + this.UserName + "' where seatno='24';";
                this.Ds = this.Da.ExecuteQuery(s3);
                noofseat++;
                txtnoOfSeat.Text = noofseat.ToString();
                txtTotalFare.Text = (noofseat * 450).ToString();
            }
        }

        private void btnS5_Click(object sender, EventArgs e)
        {
            string s1 = "select * from seatalocation1 where seatno='25'";
            this.Ds = this.Da.ExecuteQuery(s1);
            string s2 = this.Ds.Tables[0].Rows[0]["bookingstatus"].ToString();
            string s4 = this.Ds.Tables[0].Rows[0]["username"].ToString();
            if (s2 == "booked")
            {
                if (s4 == UserName)
                {
                    btnS5.BackColor = Color.White;
                    noofseat--;
                    txtnoOfSeat.Text = noofseat.ToString();
                    txtTotalFare.Text = (noofseat * 450).ToString();
                    string s3 = @"update seatalocation1
                              set bookingstatus='not booked',username='' where seatno='25';";
                    this.Ds = this.Da.ExecuteQuery(s3);

                }
                else
                {
                    btnS5.BackColor = Color.Red;
                    MessageBox.Show("This seat is already booked..");
                }
            }
            else if (s2 != "book")
            {
                btnS5.BackColor = Color.Green;
                seat1 = true;
                string s3 = @"update seatalocation1
                              set bookingstatus='booked',username='" + this.UserName + "' where seatno='25';";
                this.Ds = this.Da.ExecuteQuery(s3);
                noofseat++;
                txtnoOfSeat.Text = noofseat.ToString();
                txtTotalFare.Text = (noofseat * 450).ToString();
            }
        }

        private void btnS6_Click(object sender, EventArgs e)
        {
            string s1 = "select * from seatalocation1 where seatno='26'";
            this.Ds = this.Da.ExecuteQuery(s1);
            string s2 = this.Ds.Tables[0].Rows[0]["bookingstatus"].ToString();
            string s4 = this.Ds.Tables[0].Rows[0]["username"].ToString();
            if (s2 == "booked")
            {
                if (s4 == UserName)
                {
                    btnS6.BackColor = Color.White;
                    noofseat--;
                    txtnoOfSeat.Text = noofseat.ToString();
                    txtTotalFare.Text = (noofseat * 450).ToString();
                    string s3 = @"update seatalocation1
                              set bookingstatus='not booked',username='' where seatno='26';";
                    this.Ds = this.Da.ExecuteQuery(s3);

                }
                else
                {
                    btnS6.BackColor = Color.Red;
                    MessageBox.Show("This seat is already booked..");
                }
            }
            else if (s2 != "book")
            {
                btnS6.BackColor = Color.Green;
                seat1 = true;
                string s3 = @"update seatalocation1
                              set bookingstatus='booked',username='" + this.UserName + "' where seatno='26';";
                this.Ds = this.Da.ExecuteQuery(s3);
                noofseat++;
                txtnoOfSeat.Text = noofseat.ToString();
                txtTotalFare.Text = (noofseat * 450).ToString();
            }
        }

        private void btnS7_Click(object sender, EventArgs e)
        {
            string s1 = "select * from seatalocation1 where seatno='27'";
            this.Ds = this.Da.ExecuteQuery(s1);
            string s2 = this.Ds.Tables[0].Rows[0]["bookingstatus"].ToString();
            string s4 = this.Ds.Tables[0].Rows[0]["username"].ToString();
            if (s2 == "booked")
            {
                if (s4 == UserName)
                {
                    btnS7.BackColor = Color.White;
                    noofseat--;
                    txtnoOfSeat.Text = noofseat.ToString();
                    txtTotalFare.Text = (noofseat * 450).ToString();
                    string s3 = @"update seatalocation1
                              set bookingstatus='not booked',username='' where seatno='27';";
                    this.Ds = this.Da.ExecuteQuery(s3);

                }
                else
                {
                    btnS7.BackColor = Color.Red;
                    MessageBox.Show("This seat is already booked..");
                }
            }
            else if (s2 != "book")
            {
                btnS7.BackColor = Color.Green;
                seat1 = true;
                string s3 = @"update seatalocation1
                              set bookingstatus='booked',username='" + this.UserName + "' where seatno='27';";
                this.Ds = this.Da.ExecuteQuery(s3);
                noofseat++;
                txtnoOfSeat.Text = noofseat.ToString();
                txtTotalFare.Text = (noofseat * 450).ToString();
            }
        }

        private void btnS8_Click(object sender, EventArgs e)
        {
            string s1 = "select * from seatalocation1 where seatno='28'";
            this.Ds = this.Da.ExecuteQuery(s1);
            string s2 = this.Ds.Tables[0].Rows[0]["bookingstatus"].ToString();
            string s4 = this.Ds.Tables[0].Rows[0]["username"].ToString();
            if (s2 == "booked")
            {
                if (s4 == UserName)
                {
                    btnS8.BackColor = Color.White;
                    noofseat--;
                    txtnoOfSeat.Text = noofseat.ToString();
                    txtTotalFare.Text = (noofseat * 450).ToString();
                    string s3 = @"update seatalocation1
                              set bookingstatus='not booked',username='' where seatno='28';";
                    this.Ds = this.Da.ExecuteQuery(s3);

                }
                else
                {
                    btnS8.BackColor = Color.Red;
                    MessageBox.Show("This seat is already booked..");
                }
            }
            else if (s2 != "book")
            {
                btnS8.BackColor = Color.Green;
                seat1 = true;
                string s3 = @"update seatalocation1
                              set bookingstatus='booked',username='" + this.UserName + "' where seatno='28';";
                this.Ds = this.Da.ExecuteQuery(s3);
                noofseat++;
                txtnoOfSeat.Text = noofseat.ToString();
                txtTotalFare.Text = (noofseat * 450).ToString();
            }
        }

        private void button42_Click(object sender, EventArgs e)
        {
            string s1 = "select * from seatalocation1 where seatno='9'";
            this.Ds = this.Da.ExecuteQuery(s1);
            string s2 = this.Ds.Tables[0].Rows[0]["bookingstatus"].ToString();
            string s4 = this.Ds.Tables[0].Rows[0]["username"].ToString();
            if (s2 == "booked")
            {
                if (s4 == UserName)
                {
                    button42.BackColor = Color.White;
                    noofseat--;
                    txtnoOfSeat.Text = noofseat.ToString();
                    txtTotalFare.Text = (noofseat * 450).ToString();
                    string s3 = @"update seatalocation1
                              set bookingstatus='not booked',username='' where seatno='9';";
                    this.Ds = this.Da.ExecuteQuery(s3);

                }
                else
                {
                    button42.BackColor = Color.Red;
                    MessageBox.Show("This seat is already booked..");
                }
            }
            else if (s2 != "book")
            {
                button42.BackColor = Color.Green;
                seat1 = true;
                string s3 = @"update seatalocation1
                              set bookingstatus='booked',username='" + this.UserName + "' where seatno='9';";
                this.Ds = this.Da.ExecuteQuery(s3);
                noofseat++;
                txtnoOfSeat.Text = noofseat.ToString();
                txtTotalFare.Text = (noofseat * 450).ToString();
            }
        }

        private void btnS10_Click(object sender, EventArgs e)
        {
            string s1 = "select * from seatalocation1 where seatno='30'";
            this.Ds = this.Da.ExecuteQuery(s1);
            string s2 = this.Ds.Tables[0].Rows[0]["bookingstatus"].ToString();
            string s4 = this.Ds.Tables[0].Rows[0]["username"].ToString();
            if (s2 == "booked")
            {
                if (s4 == UserName)
                {
                    btnS10.BackColor = Color.White;
                    noofseat--;
                    txtnoOfSeat.Text = noofseat.ToString();
                    txtTotalFare.Text = (noofseat * 450).ToString();
                    string s3 = @"update seatalocation1
                              set bookingstatus='not booked',username='' where seatno='30';";
                    this.Ds = this.Da.ExecuteQuery(s3);

                }
                else
                {
                    btnS10.BackColor = Color.Red;
                    MessageBox.Show("This seat is already booked..");
                }
            }
            else if (s2 != "book")
            {
                btnS10.BackColor = Color.Green;
                seat1 = true;
                string s3 = @"update seatalocation1
                              set bookingstatus='booked',username='" + this.UserName + "' where seatno='30';";
                this.Ds = this.Da.ExecuteQuery(s3);
                noofseat++;
                txtnoOfSeat.Text = noofseat.ToString();
                txtTotalFare.Text = (noofseat * 450).ToString();
            }
        }

        private void btnS11_Click(object sender, EventArgs e)
        {
            string s1 = "select * from seatalocation1 where seatno='31'";
            this.Ds = this.Da.ExecuteQuery(s1);
            string s2 = this.Ds.Tables[0].Rows[0]["bookingstatus"].ToString();
            string s4 = this.Ds.Tables[0].Rows[0]["username"].ToString();
            if (s2 == "booked")
            {
                if (s4 == UserName)
                {
                    btnS11.BackColor = Color.White;
                    noofseat--;
                    txtnoOfSeat.Text = noofseat.ToString();
                    txtTotalFare.Text = (noofseat * 450).ToString();
                    string s3 = @"update seatalocation1
                              set bookingstatus='not booked',username='' where seatno='31';";
                    this.Ds = this.Da.ExecuteQuery(s3);

                }
                else
                {
                    btnS11.BackColor = Color.Red;
                    MessageBox.Show("This seat is already booked..");
                }
            }
            else if (s2 != "book")
            {
                btnS11.BackColor = Color.Green;
                seat1 = true;
                string s3 = @"update seatalocation1
                              set bookingstatus='booked',username='" + this.UserName + "' where seatno='31';";
                this.Ds = this.Da.ExecuteQuery(s3);
                noofseat++;
                txtnoOfSeat.Text = noofseat.ToString();
                txtTotalFare.Text = (noofseat * 450).ToString();
            }

        }

        private void btnS12_Click(object sender, EventArgs e)
        {
            string s1 = "select * from seatalocation1 where seatno='32'";
            this.Ds = this.Da.ExecuteQuery(s1);
            string s2 = this.Ds.Tables[0].Rows[0]["bookingstatus"].ToString();
            string s4 = this.Ds.Tables[0].Rows[0]["username"].ToString();
            if (s2 == "booked")
            {
                if (s4 == UserName)
                {
                    btnS12.BackColor = Color.White;
                    noofseat--;
                    txtnoOfSeat.Text = noofseat.ToString();
                    txtTotalFare.Text = (noofseat * 450).ToString();
                    string s3 = @"update seatalocation1
                              set bookingstatus='not booked',username='' where seatno='32';";
                    this.Ds = this.Da.ExecuteQuery(s3);

                }
                else
                {
                    btnS12.BackColor = Color.Red;
                    MessageBox.Show("This seat is already booked..");
                }
            }
            else if (s2 != "book")
            {
                btnS12.BackColor = Color.Green;
                seat1 = true;
                string s3 = @"update seatalocation1
                              set bookingstatus='booked',username='" + this.UserName + "' where seatno='32';";
                this.Ds = this.Da.ExecuteQuery(s3);
                noofseat++;
                txtnoOfSeat.Text = noofseat.ToString();
                txtTotalFare.Text = (noofseat * 450).ToString();
            }
        }

        private void btnS13_Click(object sender, EventArgs e)
        {
            string s1 = "select * from seatalocation1 where seatno='33'";
            this.Ds = this.Da.ExecuteQuery(s1);
            string s2 = this.Ds.Tables[0].Rows[0]["bookingstatus"].ToString();
            string s4 = this.Ds.Tables[0].Rows[0]["username"].ToString();
            if (s2 == "booked")
            {
                if (s4 == UserName)
                {
                    btnS13.BackColor = Color.White;
                    noofseat--;
                    txtnoOfSeat.Text = noofseat.ToString();
                    txtTotalFare.Text = (noofseat * 450).ToString();
                    string s3 = @"update seatalocation1
                              set bookingstatus='not booked',username='' where seatno='33';";
                    this.Ds = this.Da.ExecuteQuery(s3);

                }
                else
                {
                    btnS13.BackColor = Color.Red;
                    MessageBox.Show("This seat is already booked..");
                }
            }
            else if (s2 != "book")
            {
                btnS13.BackColor = Color.Green;
                seat1 = true;
                string s3 = @"update seatalocation1
                              set bookingstatus='booked',username='" + this.UserName + "' where seatno='33';";
                this.Ds = this.Da.ExecuteQuery(s3);
                noofseat++;
                txtnoOfSeat.Text = noofseat.ToString();
                txtTotalFare.Text = (noofseat * 450).ToString();
            }
        }

        private void btnS14_Click(object sender, EventArgs e)
        {
            string s1 = "select * from seatalocation1 where seatno='34'";
            this.Ds = this.Da.ExecuteQuery(s1);
            string s2 = this.Ds.Tables[0].Rows[0]["bookingstatus"].ToString();
            string s4 = this.Ds.Tables[0].Rows[0]["username"].ToString();
            if (s2 == "booked")
            {
                if (s4 == UserName)
                {
                    btnS14.BackColor = Color.White;
                    noofseat--;
                    txtnoOfSeat.Text = noofseat.ToString();
                    txtTotalFare.Text = (noofseat * 450).ToString();
                    string s3 = @"update seatalocation1
                              set bookingstatus='not booked',username='' where seatno='34';";
                    this.Ds = this.Da.ExecuteQuery(s3);

                }
                else
                {
                    btnS14.BackColor = Color.Red;
                    MessageBox.Show("This seat is already booked..");
                }
            }
            else if (s2 != "book")
            {
                btnS14.BackColor = Color.Green;
                seat1 = true;
                string s3 = @"update seatalocation1
                              set bookingstatus='booked',username='" + this.UserName + "' where seatno='34';";
                this.Ds = this.Da.ExecuteQuery(s3);
                noofseat++;
                txtnoOfSeat.Text = noofseat.ToString();
                txtTotalFare.Text = (noofseat * 450).ToString();
            }
        }

        private void btnS15_Click(object sender, EventArgs e)
        {
            string s1 = "select * from seatalocation1 where seatno='35'";
            this.Ds = this.Da.ExecuteQuery(s1);
            string s2 = this.Ds.Tables[0].Rows[0]["bookingstatus"].ToString();
            string s4 = this.Ds.Tables[0].Rows[0]["username"].ToString();
            if (s2 == "booked")
            {
                if (s4 == UserName)
                {
                    btnS15.BackColor = Color.White;
                    noofseat--;
                    txtnoOfSeat.Text = noofseat.ToString();
                    txtTotalFare.Text = (noofseat * 450).ToString();
                    string s3 = @"update seatalocation1
                              set bookingstatus='not booked',username='' where seatno='35';";
                    this.Ds = this.Da.ExecuteQuery(s3);

                }
                else
                {
                    btnS15.BackColor = Color.Red;
                    MessageBox.Show("This seat is already booked..");
                }
            }
            else if (s2 != "book")
            {
                btnS15.BackColor = Color.Green;
                seat1 = true;
                string s3 = @"update seatalocation1
                              set bookingstatus='booked',username='" + this.UserName + "' where seatno='35';";
                this.Ds = this.Da.ExecuteQuery(s3);
                noofseat++;
                txtnoOfSeat.Text = noofseat.ToString();
                txtTotalFare.Text = (noofseat * 450).ToString();
            }
        }

        private void btnS16_Click(object sender, EventArgs e)
        {
            string s1 = "select * from seatalocation1 where seatno='36'";
            this.Ds = this.Da.ExecuteQuery(s1);
            string s2 = this.Ds.Tables[0].Rows[0]["bookingstatus"].ToString();
            string s4 = this.Ds.Tables[0].Rows[0]["username"].ToString();
            if (s2 == "booked")
            {
                if (s4 == UserName)
                {
                    btnS16.BackColor = Color.White;
                    noofseat--;
                    txtnoOfSeat.Text = noofseat.ToString();
                    txtTotalFare.Text = (noofseat * 450).ToString();
                    string s3 = @"update seatalocation1
                              set bookingstatus='not booked',username='' where seatno='36';";
                    this.Ds = this.Da.ExecuteQuery(s3);

                }
                else
                {
                    btnS16.BackColor = Color.Red;
                    MessageBox.Show("This seat is already booked..");
                }
            }
            else if (s2 != "book")
            {
                btnS16.BackColor = Color.Green;
                seat1 = true;
                string s3 = @"update seatalocation1
                              set bookingstatus='booked',username='" + this.UserName + "' where seatno='36';";
                this.Ds = this.Da.ExecuteQuery(s3);
                noofseat++;
                txtnoOfSeat.Text = noofseat.ToString();
                txtTotalFare.Text = (noofseat * 450).ToString();
            }
        }

        private void btnS17_Click(object sender, EventArgs e)
        {
            string s1 = "select * from seatalocation1 where seatno='37'";
            this.Ds = this.Da.ExecuteQuery(s1);
            string s2 = this.Ds.Tables[0].Rows[0]["bookingstatus"].ToString();
            string s4 = this.Ds.Tables[0].Rows[0]["username"].ToString();
            if (s2 == "booked")
            {
                if (s4 == UserName)
                {
                    btnS17.BackColor = Color.White;
                    noofseat--;
                    txtnoOfSeat.Text = noofseat.ToString();
                    txtTotalFare.Text = (noofseat * 450).ToString();
                    string s3 = @"update seatalocation1
                              set bookingstatus='not booked',username='' where seatno='37';";
                    this.Ds = this.Da.ExecuteQuery(s3);

                }
                else
                {
                    btnS17.BackColor = Color.Red;
                    MessageBox.Show("This seat is already booked..");
                }
            }
            else if (s2 != "book")
            {
                btnS17.BackColor = Color.Green;
                seat1 = true;
                string s3 = @"update seatalocation1
                              set bookingstatus='booked',username='" + this.UserName + "' where seatno='37';";
                this.Ds = this.Da.ExecuteQuery(s3);
                noofseat++;
                txtnoOfSeat.Text = noofseat.ToString();
                txtTotalFare.Text = (noofseat * 450).ToString();
            }
        }

        private void btnS18_Click(object sender, EventArgs e)
        {
            string s1 = "select * from seatalocation1 where seatno='38'";
            this.Ds = this.Da.ExecuteQuery(s1);
            string s2 = this.Ds.Tables[0].Rows[0]["bookingstatus"].ToString();
            string s4 = this.Ds.Tables[0].Rows[0]["username"].ToString();
            if (s2 == "booked")
            {
                if (s4 == UserName)
                {
                    btnS18.BackColor = Color.White;
                    noofseat--;
                    txtnoOfSeat.Text = noofseat.ToString();
                    txtTotalFare.Text = (noofseat * 450).ToString();
                    string s3 = @"update seatalocation1
                              set bookingstatus='not booked',username='' where seatno='38';";
                    this.Ds = this.Da.ExecuteQuery(s3);

                }
                else
                {
                    btnS18.BackColor = Color.Red;
                    MessageBox.Show("This seat is already booked..");
                }
            }
            else if (s2 != "book")
            {
                btnS18.BackColor = Color.Green;
                seat1 = true;
                string s3 = @"update seatalocation1
                              set bookingstatus='booked',username='" + this.UserName + "' where seatno='38';";
                this.Ds = this.Da.ExecuteQuery(s3);
                noofseat++;
                txtnoOfSeat.Text = noofseat.ToString();
                txtTotalFare.Text = (noofseat * 450).ToString();
            }
        }

        private void btnS19_Click(object sender, EventArgs e)
        {
            string s1 = "select * from seatalocation1 where seatno='39'";
            this.Ds = this.Da.ExecuteQuery(s1);
            string s2 = this.Ds.Tables[0].Rows[0]["bookingstatus"].ToString();
            string s4 = this.Ds.Tables[0].Rows[0]["username"].ToString();
            if (s2 == "booked")
            {
                if (s4 == UserName)
                {
                    btnS19.BackColor = Color.White;
                    noofseat--;
                    txtnoOfSeat.Text = noofseat.ToString();
                    txtTotalFare.Text = (noofseat * 450).ToString();
                    string s3 = @"update seatalocation1
                              set bookingstatus='not booked',username='' where seatno='39';";
                    this.Ds = this.Da.ExecuteQuery(s3);

                }
                else
                {
                    btnS19.BackColor = Color.Red;
                    MessageBox.Show("This seat is already booked..");
                }
            }
            else if (s2 != "book")
            {
                btnS19.BackColor = Color.Green;
                seat1 = true;
                string s3 = @"update seatalocation1
                              set bookingstatus='booked',username='" + this.UserName + "' where seatno='39';";
                this.Ds = this.Da.ExecuteQuery(s3);
                noofseat++;
                txtnoOfSeat.Text = noofseat.ToString();
                txtTotalFare.Text = (noofseat * 450).ToString();
            }
        }

        private void btnS20_Click(object sender, EventArgs e)
        {
            string s1 = "select * from seatalocation1 where seatno='40'";
            this.Ds = this.Da.ExecuteQuery(s1);
            string s2 = this.Ds.Tables[0].Rows[0]["bookingstatus"].ToString();
            string s4 = this.Ds.Tables[0].Rows[0]["username"].ToString();
            if (s2 == "booked")
            {
                if (s4 == UserName)
                {
                    btnS20.BackColor = Color.White;
                    noofseat--;
                    txtnoOfSeat.Text = noofseat.ToString();
                    txtTotalFare.Text = (noofseat * 450).ToString();
                    string s3 = @"update seatalocation1
                              set bookingstatus='not booked',username='' where seatno='40';";
                    this.Ds = this.Da.ExecuteQuery(s3);

                }
                else
                {
                    btnS20.BackColor = Color.Red;
                    MessageBox.Show("This seat is already booked..");
                }
            }
            else if (s2 != "book")
            {
                btnS20.BackColor = Color.Green;
                seat1 = true;
                string s3 = @"update seatalocation1
                              set bookingstatus='booked',username='" + this.UserName + "' where seatno='40';";
                this.Ds = this.Da.ExecuteQuery(s3);
                noofseat++;
                txtnoOfSeat.Text = noofseat.ToString();
                txtTotalFare.Text = (noofseat * 450).ToString();
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            if (seat21 == false)
            {
                button21.BackColor = Color.Red;
                seat21 = true;
                noofseat++;
                txtnoOfSeat.Text = noofseat.ToString();
                txtTotalFare.Text = (noofseat * 450).ToString();
            }
            else
            {
                MessageBox.Show("this seat is already taken");

            }
        }

        
        private void button41_Click(object sender, EventArgs e)
        {
            if (seat37 == false)
            {
                button41.BackColor = Color.Red;
                seat37 = true;
                noofseat++;
                txtnoOfSeat.Text = noofseat.ToString();
                txtTotalFare.Text = (noofseat * 450).ToString();
            }
            else
            {
                MessageBox.Show("this seat is already taken");

            }
        }

        private void button33_Click(object sender, EventArgs e)
        {
            if (seat38 == false)
            {
                button33.BackColor = Color.Red;
                seat38 = true;
                noofseat++;
                txtnoOfSeat.Text = noofseat.ToString();
                txtTotalFare.Text = (noofseat * 450).ToString();
            }
            else
            {
                MessageBox.Show("this seat is already taken");

            }
        }

        

        private void button20_Click(object sender, EventArgs e)
        {
            if (seat40 == false)
            {
                button20.BackColor = Color.Red;
                seat40 = true;
                noofseat++;
                txtnoOfSeat.Text = noofseat.ToString();
                txtTotalFare.Text = (noofseat * 450).ToString();
            }
            else
            {
                MessageBox.Show("this seat is already taken");

            }
        }

        private void button40_Click(object sender, EventArgs e)
        {
            if (seat41 == false)
            {
                button40.BackColor = Color.Red;
                seat41 = true;
                noofseat++;
                txtnoOfSeat.Text = noofseat.ToString();
                txtTotalFare.Text = (noofseat * 450).ToString();
            }
            else
            {
                MessageBox.Show("this seat is already taken");

            }
        }

        private void button30_Click(object sender, EventArgs e)
        {
            if (seat42 == false)
            {
                button30.BackColor = Color.Red;
                seat42 = true;
                noofseat++;
                txtnoOfSeat.Text = noofseat.ToString();
                txtTotalFare.Text = (noofseat * 450).ToString();
            }
            else
            {
                MessageBox.Show("this seat is already taken");

            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (seat43 == false)
            {
                button19.BackColor = Color.Red;
                seat43 = true;
                noofseat++;
                txtnoOfSeat.Text = noofseat.ToString();
                txtTotalFare.Text = (noofseat * 450).ToString();
            }
            else
            {
                MessageBox.Show("this seat is already taken");

            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (seat44 == false)
            {
                button18.BackColor = Color.Red;
                seat44 = true;
                noofseat++;
                txtnoOfSeat.Text = noofseat.ToString();
                txtTotalFare.Text = (noofseat * 450).ToString();
            }
            else
            {
                MessageBox.Show("this seat is already taken");

            }
        }

        private void button39_Click(object sender, EventArgs e)
        {
            if (seat45 == false)
            {
                button39.BackColor = Color.Red;
                seat45 = true;
                noofseat++;
                txtnoOfSeat.Text = noofseat.ToString();
                txtTotalFare.Text = (noofseat * 450).ToString();
            }
            else
            {
                MessageBox.Show("this seat is already taken");

            }
        }

        private void button29_Click(object sender, EventArgs e)
        {
            if (seat46 == false)
            {
                button29.BackColor = Color.Red;
                seat46 = true;
                noofseat++;
                txtnoOfSeat.Text = noofseat.ToString();
                txtTotalFare.Text = (noofseat * 450).ToString();
            }
            else
            {
                MessageBox.Show("this seat is already taken");

            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (seat47 == false)
            {
                button16.BackColor = Color.Red;
                seat47 = true;
                noofseat++;
                txtnoOfSeat.Text = noofseat.ToString();
                txtTotalFare.Text = (noofseat * 450).ToString();
            }
            else
            {
                MessageBox.Show("this seat is already taken");

            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (seat48 == false)
            {
                button15.BackColor = Color.Red;
                seat48 = true;
                noofseat++;
                txtnoOfSeat.Text = noofseat.ToString();
                txtTotalFare.Text = (noofseat * 450).ToString();
            }
            else
            {
                MessageBox.Show("this seat is already taken");

            }
        }

        private void button38_Click(object sender, EventArgs e)
        {
            if (seat49 == false)
            {
                button38.BackColor = Color.Red;
                seat49 = true;
                noofseat++;
                txtnoOfSeat.Text = noofseat.ToString();
                txtTotalFare.Text = (noofseat * 450).ToString();
            }
            else
            {
                MessageBox.Show("this seat is already taken");

            }
        }

        private void button28_Click(object sender, EventArgs e)
        {
            if (seat50 == false)
            {
                button28.BackColor = Color.Red;
                seat50 = true;
                noofseat++;
                txtnoOfSeat.Text = noofseat.ToString();
                txtTotalFare.Text = (noofseat * 450).ToString();
            }
            else
            {
                MessageBox.Show("this seat is already taken");

            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (seat51 == false)
            {
                button17.BackColor = Color.Red;
                seat51 = true;
                noofseat++;
                txtnoOfSeat.Text = noofseat.ToString();
                txtTotalFare.Text = (noofseat * 450).ToString();
            }
            else
            {
                MessageBox.Show("this seat is already taken");

            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (seat52 == false)
            {
                button13.BackColor = Color.Red;
                seat52 = true;
                noofseat++;
                txtnoOfSeat.Text = noofseat.ToString();
                txtTotalFare.Text = (noofseat * 450).ToString();
            }
            else
            {
                MessageBox.Show("this seat is already taken");

            }
        }

        private void button37_Click(object sender, EventArgs e)
        {
            if (seat53 == false)
            {
                button37.BackColor = Color.Red;
                seat53 = true;
                noofseat++;
                txtnoOfSeat.Text = noofseat.ToString();
                txtTotalFare.Text = (noofseat * 450).ToString();
            }
            else
            {
                MessageBox.Show("this seat is already taken");

            }
        }

        private void button27_Click(object sender, EventArgs e)
        {
            if (seat54 == false)
            {
                button27.BackColor = Color.Red;
                seat54 = true;
                noofseat++;
                txtnoOfSeat.Text = noofseat.ToString();
                txtTotalFare.Text = (noofseat * 450).ToString();
            }
            else
            {
                MessageBox.Show("this seat is already taken");

            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (seat55 == false)
            {
                button14.BackColor = Color.Red;
                seat55 = true;
                noofseat++;
                txtnoOfSeat.Text = noofseat.ToString();
                txtTotalFare.Text = (noofseat * 450).ToString();
            }
            else
            {
                MessageBox.Show("this seat is already taken");

            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (seat56 == false)
            {
                button12.BackColor = Color.Red;
                seat56 = true;
                noofseat++;
                txtnoOfSeat.Text = noofseat.ToString();
                txtTotalFare.Text = (noofseat * 450).ToString();
            }
            else
            {
                MessageBox.Show("this seat is already taken");

            }
        }

        private void button36_Click(object sender, EventArgs e)
        {
            if (seat57 == false)
            {
                button36.BackColor = Color.Red;
                seat57 = true;
                noofseat++;
                txtnoOfSeat.Text = noofseat.ToString();
                txtTotalFare.Text = (noofseat * 450).ToString();
            }
            else
            {
                MessageBox.Show("this seat is already taken");

            }
        }

        private void button26_Click(object sender, EventArgs e)
        {
            if (seat58 == false)
            {
                button26.BackColor = Color.Red;
                seat58 = true;
                noofseat++;
                txtnoOfSeat.Text = noofseat.ToString();
                txtTotalFare.Text = (noofseat * 450).ToString();
            }
            else
            {
                MessageBox.Show("this seat is already taken");

            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (seat59 == false)
            {
                button10.BackColor = Color.Red;
                seat59 = true;
                noofseat++;
                txtnoOfSeat.Text = noofseat.ToString();
                txtTotalFare.Text = (noofseat * 450).ToString();
            }
            else
            {
                MessageBox.Show("this seat is already taken");

            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (seat60 == false)
            {
                button9.BackColor = Color.Red;
                seat60 = true;
                noofseat++;
                txtnoOfSeat.Text = noofseat.ToString();
                txtTotalFare.Text = (noofseat * 450).ToString();
            }
            else
            {
                MessageBox.Show("this seat is already taken");

            }
        }

        private void todaytrseatplan2_Paint(object sender, PaintEventArgs e)
        {
            button2.Visible = true;
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            if (cmbpayment.Text == "")
            {

                try
                {
                    string sql1 = @"insert into clienticketinfo(username,status,departure,destination,journeydate,totalseat,paymentmethod,paymentstatus,transportation,Token)
                                values('" + UserName + "','Pending','" + Departure + "','" + Destination + "','" + Date + "','" + txtnoOfSeat.Text + "','Cash in Delivery','not paid','train'," + RandomNumber(1000, 100000) + ");";
                    this.Ds = this.Da.ExecuteQuery(sql1);
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
            else {
                MessageBox.Show("Please Select Paynow");
            }
        }
    }
}

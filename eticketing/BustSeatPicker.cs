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
    public partial class BustSeatPicker : MetroForm
    {
        public int noofseat = 0;
        public int total = 0;
        

        internal DataAccess Da { get; set; }
        internal DataSet Ds { get; set; }
        string UserName { set; get; }
        string Date { set; get; }
        string Time { set; get; }
        string Departure { set; get; }
        string Destination { set; get; }
        public BustSeatPicker()
        {
            InitializeComponent();
        }
        public BustSeatPicker(string userid, string date, string time, string departure, string destination)
        {
            InitializeComponent();
            this.Da = new DataAccess();
            UserName = userid;
            Date = date;
            Time = time;
            Departure = departure;
            Destination = destination;

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            BuyBusTicket um = new BuyBusTicket(UserName);
            um.Visible = true;
            this.Visible = false;
        }

        public int RandomNumber(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (cmbpayment.Text != "")
            {



                try
                {
                    string sql1 = @"insert into clienticketinfo(username,status,departure,destination,journeydate,totalseat,paymentmethod,paymentstatus,transportation,Token)
                                values('" + UserName + "','Pending','" + Departure + "','" + Destination + "','" + Date + "','" + txtnoOfSeat.Text + "','" + cmbpayment.Text + "','paid','Bus',"+RandomNumber(1000,100000)+");";
                    this.Ds = this.Da.ExecuteQuery(sql1);
                    MessageBox.Show("Ticket succesfuly booked..");
                    string s1 = "select username,password from clntinfo where username='"+UserName+"'";
                    this.Ds = this.Da.ExecuteQuery(s1);
                    string s2 = this.Ds.Tables[0].Rows[0]["username"].ToString();
                    if(UserName==s2)
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
                MessageBox.Show("Please Select Cash in delevery..");
            }
        }

        private void BustSeatPicker_Load(object sender, EventArgs e)
        {
            Tpanel1.Visible = false;
            CtgDhk16.Visible = false;
            if (Departure == "Dhaka" && Destination == "Chittagong" && Int32.Parse(Date.Substring(0, 2)) == DateTime.Now.Day && Time.Substring(0, 2) == "17")
            {
                Tpanel1.Visible = true;
            }
            else if (Departure == "Dhaka" && Destination == "Chittagong" && Int32.Parse(Date.Substring(0, 2)) == DateTime.Now.Day && Time.Substring(0, 2) == "16")
            {
                Tpanel1.Visible = true;
            }
            else if (Departure == "Chittagong" && Destination == "Dhaka" && Int32.Parse(Date.Substring(0, 2)) == DateTime.Now.Day && Time.Substring(0, 2) == "16")
            {
                Tpanel1.Visible = false;
                  
                CtgDhk16.Visible = true;
            }
            else if (Departure == "Chittagong" && Destination == "Dhaka" && Int32.Parse(Date.Substring(0, 2)) == DateTime.Now.Day && Time.Substring(0, 2) == "08")
            {
                
                    Tpanel1.Visible = true;
                
            }
        }

        private void btnS1_Click(object sender, EventArgs e)
        {
            string s1 = "select * from seatalocation1 where seatno='1'";
            this.Ds = this.Da.ExecuteQuery(s1);
            string s2= this.Ds.Tables[0].Rows[0]["bookingstatus"].ToString();
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
                              set bookingstatus='not booked',username='' where seatno='1';";
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
                
                string s3 = @"update seatalocation1
                              set bookingstatus='booked',username='" + this.UserName + "' where seatno='1';";
                this.Ds = this.Da.ExecuteQuery(s3);
                noofseat++;
                txtnoOfSeat.Text = noofseat.ToString();
                txtTotalFare.Text = (noofseat * 450).ToString();
            }
            
        }

        private void btnS2_Click(object sender, EventArgs e)
        {
            string s1 = "select * from seatalocation1 where seatno='2'";
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
                              set bookingstatus='not booked',username='' where seatno='2';";
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
                
                string s3 = @"update seatalocation1
                              set bookingstatus='booked',username='" + this.UserName + "' where seatno='2';";
                this.Ds = this.Da.ExecuteQuery(s3);
                noofseat++;
                txtnoOfSeat.Text = noofseat.ToString();
                txtTotalFare.Text = (noofseat * 450).ToString();
            }
        }

        private void btnS3_Click(object sender, EventArgs e)
        {
            string s1 = "select * from seatalocation1 where seatno='3'";
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
                              set bookingstatus='not booked',username='' where seatno='3';";
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
                
                string s3 = @"update seatalocation1
                              set bookingstatus='booked',username='" + this.UserName + "' where seatno='3';";
                this.Ds = this.Da.ExecuteQuery(s3);
                noofseat++;
                txtnoOfSeat.Text = noofseat.ToString();
                txtTotalFare.Text = (noofseat * 450).ToString();
            }
        }

        private void btnS4_Click(object sender, EventArgs e)
        {
            string s1 = "select * from seatalocation1 where seatno='4'";
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
                              set bookingstatus='not booked',username='' where seatno='4';";
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
                
                string s3 = @"update seatalocation1
                              set bookingstatus='booked',username='" + this.UserName + "' where seatno='4';";
                this.Ds = this.Da.ExecuteQuery(s3);
                noofseat++;
                txtnoOfSeat.Text = noofseat.ToString();
                txtTotalFare.Text = (noofseat * 450).ToString();
            }
        }

        private void btnS5_Click(object sender, EventArgs e)
        {
            string s1 = "select * from seatalocation1 where seatno='5'";
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
                              set bookingstatus='not booked',username='' where seatno='5';";
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
                
                string s3 = @"update seatalocation1
                              set bookingstatus='booked',username='" + this.UserName + "' where seatno='5';";
                this.Ds = this.Da.ExecuteQuery(s3);
                noofseat++;
                txtnoOfSeat.Text = noofseat.ToString();
                txtTotalFare.Text = (noofseat * 450).ToString();
            }
        }

        private void btnS6_Click(object sender, EventArgs e)
        {
            string s1 = "select * from seatalocation1 where seatno='6'";
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
                              set bookingstatus='not booked',username='' where seatno='6';";
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
               
                string s3 = @"update seatalocation1
                              set bookingstatus='booked',username='" + this.UserName + "' where seatno='6';";
                this.Ds = this.Da.ExecuteQuery(s3);
                noofseat++;
                txtnoOfSeat.Text = noofseat.ToString();
                txtTotalFare.Text = (noofseat * 450).ToString();
            }
        }

        private void btnS7_Click(object sender, EventArgs e)
        {
            string s1 = "select * from seatalocation1 where seatno='7'";
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
                              set bookingstatus='not booked',username='' where seatno='7';";
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
                
                string s3 = @"update seatalocation1
                              set bookingstatus='booked',username='" + this.UserName + "' where seatno='7';";
                this.Ds = this.Da.ExecuteQuery(s3);
                noofseat++;
                txtnoOfSeat.Text = noofseat.ToString();
                txtTotalFare.Text = (noofseat * 450).ToString();
            }
        }

        private void btnS8_Click(object sender, EventArgs e)
        {
            string s1 = "select * from seatalocation1 where seatno='8'";
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
                              set bookingstatus='not booked',username='' where seatno='8';";
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
                
                string s3 = @"update seatalocation1
                              set bookingstatus='booked',username='" + this.UserName + "' where seatno='8';";
                this.Ds = this.Da.ExecuteQuery(s3);
                noofseat++;
                txtnoOfSeat.Text = noofseat.ToString();
                txtTotalFare.Text = (noofseat * 450).ToString();
            }
        }

        private void btnS9_Click(object sender, EventArgs e)
        {
            string s1 = "select * from seatalocation1 where seatno='9'";
            this.Ds = this.Da.ExecuteQuery(s1);
            string s2 = this.Ds.Tables[0].Rows[0]["bookingstatus"].ToString();
            string s4 = this.Ds.Tables[0].Rows[0]["username"].ToString();
            if (s2 == "booked")
            {
                if (s4 == UserName)
                {
                    btnS9.BackColor = Color.White;
                    noofseat--;
                    txtnoOfSeat.Text = noofseat.ToString();
                    txtTotalFare.Text = (noofseat * 450).ToString();
                    string s3 = @"update seatalocation1
                              set bookingstatus='not booked',username='' where seatno='9';";
                    this.Ds = this.Da.ExecuteQuery(s3);

                }
                else
                {
                    btnS9.BackColor = Color.Red;
                    MessageBox.Show("This seat is already booked..");
                }
            }
            else if (s2 != "book")
            {
                btnS9.BackColor = Color.Green;
                
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
            string s1 = "select * from seatalocation1 where seatno='10'";
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
                              set bookingstatus='not booked',username='' where seatno='10';";
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
                
                string s3 = @"update seatalocation1
                              set bookingstatus='booked',username='" + this.UserName + "' where seatno='10';";
                this.Ds = this.Da.ExecuteQuery(s3);
                noofseat++;
                txtnoOfSeat.Text = noofseat.ToString();
                txtTotalFare.Text = (noofseat * 450).ToString();
            }
        }

        private void btnS11_Click(object sender, EventArgs e)
        {
            string s1 = "select * from seatalocation1 where seatno='11'";
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
                              set bookingstatus='not booked',username='' where seatno='11';";
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
                
                string s3 = @"update seatalocation1
                              set bookingstatus='booked',username='" + this.UserName + "' where seatno='11';";
                this.Ds = this.Da.ExecuteQuery(s3);
                noofseat++;
                txtnoOfSeat.Text = noofseat.ToString();
                txtTotalFare.Text = (noofseat * 450).ToString();
            }
        }

        private void btnS12_Click(object sender, EventArgs e)
        {
            string s1 = "select * from seatalocation1 where seatno='12'";
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
                              set bookingstatus='not booked',username='' where seatno='12';";
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
                
                string s3 = @"update seatalocation1
                              set bookingstatus='booked',username='" + this.UserName + "' where seatno='12';";
                this.Ds = this.Da.ExecuteQuery(s3);
                noofseat++;
                txtnoOfSeat.Text = noofseat.ToString();
                txtTotalFare.Text = (noofseat * 450).ToString();
            }
        }

        private void btnS13_Click(object sender, EventArgs e)
        {
            string s1 = "select * from seatalocation1 where seatno='13'";
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
                              set bookingstatus='not booked',username='' where seatno='13';";
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
               
                string s3 = @"update seatalocation1
                              set bookingstatus='booked',username='" + this.UserName + "' where seatno='13';";
                this.Ds = this.Da.ExecuteQuery(s3);
                noofseat++;
                txtnoOfSeat.Text = noofseat.ToString();
                txtTotalFare.Text = (noofseat * 450).ToString();
            }
        }

        private void btnS14_Click(object sender, EventArgs e)
        {
            string s1 = "select * from seatalocation1 where seatno='14'";
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
                              set bookingstatus='not booked',username='' where seatno='14';";
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
                
                string s3 = @"update seatalocation1
                              set bookingstatus='booked',username='" + this.UserName + "' where seatno='14';";
                this.Ds = this.Da.ExecuteQuery(s3);
                noofseat++;
                txtnoOfSeat.Text = noofseat.ToString();
                txtTotalFare.Text = (noofseat * 450).ToString();
            }
        }

        private void btnS15_Click(object sender, EventArgs e)
        {
            string s1 = "select * from seatalocation1 where seatno='15'";
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
                              set bookingstatus='not booked',username='' where seatno='15';";
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
               
                string s3 = @"update seatalocation1
                              set bookingstatus='booked',username='" + this.UserName + "' where seatno='15';";
                this.Ds = this.Da.ExecuteQuery(s3);
                noofseat++;
                txtnoOfSeat.Text = noofseat.ToString();
                txtTotalFare.Text = (noofseat * 450).ToString();
            }
        }

        private void btnS16_Click(object sender, EventArgs e)
        {
            string s1 = "select * from seatalocation1 where seatno='16'";
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
                              set bookingstatus='not booked',username='' where seatno='16';";
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
               
                string s3 = @"update seatalocation1
                              set bookingstatus='booked',username='" + this.UserName + "' where seatno='16';";
                this.Ds = this.Da.ExecuteQuery(s3);
                noofseat++;
                txtnoOfSeat.Text = noofseat.ToString();
                txtTotalFare.Text = (noofseat * 450).ToString();
            }
        }

        private void btnS17_Click(object sender, EventArgs e)
        {
            string s1 = "select * from seatalocation1 where seatno='17'";
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
                              set bookingstatus='not booked',username='' where seatno='17';";
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
                
                string s3 = @"update seatalocation1
                              set bookingstatus='booked',username='" + this.UserName + "' where seatno='17';";
                this.Ds = this.Da.ExecuteQuery(s3);
                noofseat++;
                txtnoOfSeat.Text = noofseat.ToString();
                txtTotalFare.Text = (noofseat * 450).ToString();
            }
        }

        private void btnS18_Click(object sender, EventArgs e)
        {
            string s1 = "select * from seatalocation1 where seatno='18'";
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
                              set bookingstatus='not booked',username='' where seatno='18';";
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
                
                string s3 = @"update seatalocation1
                              set bookingstatus='booked',username='" + this.UserName + "' where seatno='18';";
                this.Ds = this.Da.ExecuteQuery(s3);
                noofseat++;
                txtnoOfSeat.Text = noofseat.ToString();
                txtTotalFare.Text = (noofseat * 450).ToString();
            }
        }

        private void btnS19_Click(object sender, EventArgs e)
        {
            string s1 = "select * from seatalocation1 where seatno='19'";
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
                              set bookingstatus='not booked',username='' where seatno='19';";
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
                
                string s3 = @"update seatalocation1
                              set bookingstatus='booked',username='" + this.UserName + "' where seatno='19';";
                this.Ds = this.Da.ExecuteQuery(s3);
                noofseat++;
                txtnoOfSeat.Text = noofseat.ToString();
                txtTotalFare.Text = (noofseat * 450).ToString();
            }
        }

        private void btnS20_Click(object sender, EventArgs e)
        {
            string s1 = "select * from seatalocation1 where seatno='20'";
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
                              set bookingstatus='not booked',username='' where seatno='20';";
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
                
                string s3 = @"update seatalocation1
                              set bookingstatus='booked',username='" + this.UserName + "' where seatno='20';";
                this.Ds = this.Da.ExecuteQuery(s3);
                noofseat++;
                txtnoOfSeat.Text = noofseat.ToString();
                txtTotalFare.Text = (noofseat * 450).ToString();
            }
        }

       

        private void btnCashindelivery_Click(object sender, EventArgs e)
        {
            if (cmbpayment.Text == "")
            {
                try
                {
                    string sql1 = @"insert into clienticketinfo(username,status,departure,destination,journeydate,totalseat,paymentmethod,paymentstatus,transportation,Token)
                                values('" + UserName + "','Pending','" + Departure + "','" + Destination + "','" + Date + "','" + txtnoOfSeat.Text + "','Cash in Delivery','not paid','Bus'," + RandomNumber(1000, 100000) + ");";
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
                MessageBox.Show("Please Select Pay now");
            }
        }
    }
    
}

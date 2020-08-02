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
    public partial class ShowShedule : MetroForm
    {
        string UserName { set; get; }

        internal DataAccess Da { get; set; }
        internal DataSet Ds { get; set; }
        public ShowShedule(string userid)
        {
            InitializeComponent();
            this.Da = new DataAccess();
            UserName = userid;
        }
        private void populateGridView(string sql2 = "select * from scheduleinfo")
        {
            // = ;
            this.metroGrid1.AutoGenerateColumns = false;
            this.Ds = this.Da.ExecuteQuery(sql2);
            this.metroGrid1.DataSource = this.Ds.Tables[0];
        }

        private void metroGrid1_CellContentClick(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
        {

        }

        private void ShowShedule_Load(object sender, EventArgs e)
        {
            this.populateGridView();
        }
    }
}

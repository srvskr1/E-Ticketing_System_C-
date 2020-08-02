using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MetroFramework.Forms;

namespace eticketing
{
    public partial class Profile : MetroForm
    {
        string UserName { set; get; }
        public Profile(string userid)
        {
            this.UserName = userid;
            InitializeComponent();
        }

        private void metroLabel2_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            UserMenu um = new UserMenu();
            um.Visible = true;
            this.Visible = false;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp_Test1
{
    public partial class FormA : Form
    {
        public FormA()
        {
            InitializeComponent();
        }

        private void btnA_send_Click(object sender, EventArgs e)
        {
            FormB frmb = new FormB(this);

            frmb.name = txtA_Name.Text;
            frmb.corp = txtA_Corp.Text;

            frmb.Show();
        }

        public void send(string name, string corp)
        {
            txtA_returnName.Text = name;
            txtA_returnCorp.Text = corp;
        }
    }
}

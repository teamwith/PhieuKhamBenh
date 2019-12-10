using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PhieuKhamBenh
{
    public partial class Thaotac : Form
    {
        public Thaotac()
        {
            InitializeComponent();
        }

        private void BtnTaophieumoi_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm mf = new MainForm();
            mf.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            InPhieu ip = new InPhieu();
            ip.Show();
        }

        private void Quaylai_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }
    }
}

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

    public partial class Add : Form
    {

        public Add()
        {
            InitializeComponent();

        }

        private void Add_Load(object sender, EventArgs e)
        {

        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login lg = new Login();
            lg.Show();

        }



        private void BtnReset_Click(object sender, EventArgs e)
        {
            this.tbxFullName.Clear();
            this.tbxUserName.Clear();
            this.tbxPassword.Clear();
            this.ckAdmin.Checked = false;
            this.radioButton_Nam.Checked = false;
            this.radioButton_Nu.Checked = false;

        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            ConnectDB_SQL connectDB = new ConnectDB_SQL();
            string sUser, sPass, sFullName;
            bool bAdmin = this.ckAdmin.Checked;
            bool bnam = this.radioButton_Nam.Checked;
            bool bnu = this.radioButton_Nu.Checked;
            sFullName = tbxFullName.Text;
            sUser = tbxUserName.Text;
            sPass = tbxPassword.Text;

            Boolean KQ = true;
            KQ = connectDB.Fun_Register(sFullName, sUser, sPass, bAdmin, bnam, bnu);
            if (KQ)
            {
                MessageBox.Show("Đăng ký thành công!!!");
            }
            else
            {
                MessageBox.Show("Dang ky khong thanh cong!!");
            }

            this.Hide();
            Login lg = new Login();
            lg.Show();

        }
    }
}

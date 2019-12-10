using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace PhieuKhamBenh
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            ConnectDB_SQL connectDB = new ConnectDB_SQL();
            string sUserName = txtUser.Text;
            string sPass = txtPassword.Text;
            Boolean result = true;
            result = connectDB.Fun_ConnectDB(sUserName, sPass);
            if (result)
            {
                MessageBox.Show("Đăng nhập thành công!✔ ");
                this.Hide();
                Thaotac tt = new Thaotac();
                tt.Show();

            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại! Mời nhập đăng nhập lại!⛔");
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TxtPassword_TextChanged(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnDangnhap.PerformClick();
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void BtnDangky_Click(object sender, EventArgs e)
        {
           this.Hide();
            Add add = new Add();
            add.Show();
        }

        private void CbxHienmatkhau_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxHienmatkhau.Checked == false)
            {
                //gán kí tự pass thành '❤'
                txtPassword.PasswordChar = '❤';
            }
            else
            {
                // reset hiển thị pas về mặc định
                txtPassword.PasswordChar = (char)0;
            }
        }

        private void TxtUser_TextChanged(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtPassword.Focus();
            }
        }
    }
}

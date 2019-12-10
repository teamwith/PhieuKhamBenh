using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using System.Data.Sql;

namespace PhieuKhamBenh
{
    public partial class MainForm
    {
        class clsBacsy
        {

        }

        public void Insert_Bacsy()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"server=DESKTOP-19EPU5O\SQLEXPRESS; database = Kham_benh; user id = sa; password = 123";
            con.Open();
            String sql = "INSERT INTO Bac_sy(Bacsy,Donvi) VALUES ("; sql += "N'" + txtBacsy.Text + "',N'" + txtDonvi.Text + "')";
            //Thực thi câu lệnh SQL sử dụng đối tượng Command
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();

        }
        public bool kiemtra()
        {

            if (string.IsNullOrWhiteSpace(txtBacsy.Text))
            {
                MessageBox.Show("Bạn chưa nhập tên bác sỹ", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtBacsy.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtDonvi.Text))
            {
                MessageBox.Show("Bạn chưa nhập tên đơn vị", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDonvi.Focus();
                return false;
            }
            if (txtBacsy.Text.Equals(txtBacsy))
            {
                MessageBox.Show("Tên bác sỹ đã tồn tại", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
    }
}

/*
 * Created by SharpDevelop.
 * User: Acer
 * Date: 11/28/2019
 * Time: 2:43 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using System.Data.Sql;

namespace PhieuKhamBenh
{
    /// <summary>
    /// Description of MainForm.
    /// </summary>
    public partial class MainForm : Form
    {
        public MainForm()
        {
            //
            // The InitializeComponent() call is required for Windows Forms designer support.
            //
            InitializeComponent();
            //
            // TODO: Add constructor code after the InitializeComponent() call.
            //
        }
        void TableLayoutPanel1Paint(object sender, PaintEventArgs e)
        {

        }
        void MainFormLoad(object sender, EventArgs e)
        {

        }
        void TableLayoutPanel2Paint(object sender, PaintEventArgs e)
        {

        }
        void Label11Click(object sender, EventArgs e)
        {

        }
        void Panel2Paint(object sender, PaintEventArgs e)
        {

        }
        void RichTextBox14TextChanged(object sender, EventArgs e)
        {

        }
        void Panel1Paint(object sender, PaintEventArgs e)
        {

        }
        void CheckedListBox1SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        void TableLayoutPanel4Paint(object sender, PaintEventArgs e)
        {

        }
        void TableLayoutPanel9Paint(object sender, PaintEventArgs e)
        {

        }
        void RichTextBox12TextChanged(object sender, EventArgs e)
        {

        }

        void Label19Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (kiemtra())
            {
                Insert_Bacsy();
                MessageBox.Show("Insert Thành Công", "Chúc mừng", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                InPhieu inPhieu = new InPhieu();
                inPhieu.Show();
            }
            
            else
                MessageBox.Show("Chưa có in được nha!");
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Hide();
            Thaotac tt = new Thaotac();
            tt.Show();
        }

        private void RadiobtnNam_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void RadiobtnNu_CheckedChangee(object sender, EventArgs e)
        {

        }
        private void Phieukhambenh_Click(object sender, EventArgs e)
        {

        }

        private void RadioButton6_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void BtnNhaplai_Click(object sender, EventArgs e)
        {


        }

        private void RichTextBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void Ketluan_Click(object sender, EventArgs e)
        {

        }

        private void Label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}

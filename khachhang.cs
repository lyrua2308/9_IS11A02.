using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hoa_don_nhap
{
    public partial class khachhang : Form
    {
        public khachhang()
        {
            InitializeComponent();
        }

       
            private void frmKhachHang_Load(object sender, EventArgs e)
            {
                string sql = "select * from Khach_hang";
                DAO.loatdata(sql, dataGridViewkhachhang);
            }
            private void loaddata()
            {
                string sql = "select * from Khach_hang";
                DAO.loatdata(sql, dataGridViewkhachhang);
            }

            private void buttonthem_Click(object sender, EventArgs e)
            {
                textBoxmakh.Enabled = true;
                textBoxtenkh.Text = "";
                textBoxmakh.Text = "";
                textBoxdiachi.Text = "";
                textBoxsodienthoai.Text = "";


            }

            private void dataGridViewkhachhang_CellClick(object sender, DataGridViewCellEventArgs e)
            {
                textBoxmakh.Text = dataGridViewkhachhang.CurrentRow.Cells["makh"].Value.ToString();
                textBoxtenkh.Text = dataGridViewkhachhang.CurrentRow.Cells["tenkh"].Value.ToString();
                textBoxdiachi.Text = dataGridViewkhachhang.CurrentRow.Cells["diachi"].Value.ToString();
                textBoxsodienthoai.Text = dataGridViewkhachhang.CurrentRow.Cells["sodt"].Value.ToString();
                textBoxmakh.Enabled = false;
            }

            private void buttonxoa_Click(object sender, EventArgs e)
            {
                string sql = "delete from khach_hang where makhach=N'" + textBoxmakh.Text + "'";
                DAO.RunSqlDel(sql);
                loaddata();

            }

            private void buttonthoat_Click(object sender, EventArgs e)
            {
                this.Close();
            }

            private void buttonsua_Click(object sender, EventArgs e)
            {
                string sql = "update khach_hang set tenkhach=N'" + textBoxtenkh.Text + "',diachi=N'" + textBoxdiachi.Text + "',dienthoai='"
                    + textBoxsodienthoai.Text + "' where makhach=N'" + textBoxmakh.Text + "'";
                DAO.RunSql(sql);
                loaddata();

            }

            private void buttonluu_Click(object sender, EventArgs e)
            {
                if (textBoxmakh.Text == "")
                {
                    MessageBox.Show("bạn chư nhập mã khách hàng");
                    textBoxmakh.Focus();
                }
                if (textBoxsodienthoai.Text == "")
                {
                    MessageBox.Show("bạn chưa nhập số điện thoại");
                    textBoxsodienthoai.Focus();
                }
                if (textBoxtenkh.Text == "")
                {
                    MessageBox.Show("Bạn chưa nhập tên khách hàng");
                    textBoxtenkh.Focus();
                }
                if (textBoxdiachi.Text == "")
                {
                    MessageBox.Show("Bạn chưa nhập địa chỉ");
                    textBoxdiachi.Focus();
                }
                string sql = "insert into khach_hang values(N'" + textBoxmakh.Text + "',N'" + textBoxtenkh.Text + "',N'" + textBoxdiachi.Text + "','"
                    + textBoxsodienthoai.Text + "')";
                DAO.OpenConnection();
                string sqlCheck = "select * from khach_hang where makhach='" + textBoxmakh.Text.Trim() + "'";
                if (DAO.CheckKey(sqlCheck))
                {
                    MessageBox.Show("khách hàng đã ton tai");
                    DAO.CloseConnection();
                    textBoxmakh.Enabled = true;
                    textBoxmakh.Focus();
                    return;
                }
                else
                {
                    SqlCommand cmd = new SqlCommand();

                    cmd.CommandText = sql;
                    cmd.Connection = DAO.Conn;
                    cmd.ExecuteNonQuery();

                    loaddata();

                    DAO.CloseConnection();
                }
            }

        private void buttonthoat_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBoxsodienthoai_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar >= '0') && (e.KeyChar <= '9')) || (Convert.ToInt32(e.KeyChar) == 8))
                e.Handled = false;
            else e.Handled = true;
        }
    }
}

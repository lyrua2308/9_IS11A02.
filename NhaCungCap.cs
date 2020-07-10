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
    public partial class NhaCungCap : Form
    {
        public NhaCungCap()
        {
            InitializeComponent();
        }

        private void NhaCungCap_Load(object sender, EventArgs e)
        {
            loaddata();
        }
        private void loaddata()
        {
            string sql = "select * from nha_cc";
            DAO.loatdata(sql, dataGridViewncc);
        }

        
      
        

        

      

        private void buttonthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

     

        private void buttonthoat_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridViewncc_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            textBoxmanhacungcap.Text = dataGridViewncc.CurrentRow.Cells["mancc"].Value.ToString();
            textboxnhacungcap.Text = dataGridViewncc.CurrentRow.Cells["tenncc"].Value.ToString();
            textBoxdiachi.Text = dataGridViewncc.CurrentRow.Cells["diachi"].Value.ToString();
            textBoxsodienthoai.Text = dataGridViewncc.CurrentRow.Cells["sodienthoai"].Value.ToString();
            textBoxmanhacungcap.Enabled = false;
        }

        private void buttonthem_Click_1(object sender, EventArgs e)
        {
            textBoxmanhacungcap.Enabled = true;
            textBoxmanhacungcap.Text = "";
            textboxnhacungcap.Text = "";
            textBoxsodienthoai.Text = "";
            textBoxdiachi.Text = "";
        }

        private void buttonsua_Click_1(object sender, EventArgs e)
        {
            string sql = "update nha_cc set tenncc=N'" + textboxnhacungcap.Text + "',diachi=N'" + textBoxdiachi.Text + "',dienthoai='"
                + textBoxsodienthoai.Text + "' where mancc=N'" + textBoxmanhacungcap.Text + "'";
            DAO.RunSql(sql);
            loaddata();
        }

        private void buttonxoa_Click_1(object sender, EventArgs e)
        {

            string sql = "delete from nha_cc where mancc=N'" + textBoxmanhacungcap.Text + "'";
            DAO.RunSqlDel(sql);
            loaddata();
        }

        private void buttonluu_Click_1(object sender, EventArgs e)
        {

            if (textBoxmanhacungcap.Text == "")
            {
                MessageBox.Show("bạn chưa nhập mã nhà cung cấp");
                textBoxmanhacungcap.Focus();
            }
            if (textboxnhacungcap.Text == "")
            {
                MessageBox.Show("bạn chưa nhập tên nhà cung cấp");
                textboxnhacungcap.Focus();
            }
            if (textBoxsodienthoai.Text == "")
            {
                MessageBox.Show("bạn chưa nhập số điện thoại");
                textBoxsodienthoai.Focus();
            }
            if (textBoxdiachi.Text == "")
            {
                MessageBox.Show("bạn chưa nhập địa chỉ");
                textBoxdiachi.Focus();

            }
            string sql = "insert into nha_cc values(N'" + textBoxmanhacungcap.Text + "',N'" + textboxnhacungcap.Text + "',N'" + textBoxdiachi.Text + "','"
                + textBoxsodienthoai.Text + "')";
            DAO.OpenConnection();
            string sqlCheck = "select * from nha_cc where mancc='" + textBoxmanhacungcap.Text + "'";
            if (DAO.CheckKey(sqlCheck))
            {
                MessageBox.Show("nhà cung cấp đã tồn tại");
                DAO.CloseConnection();
                textBoxmanhacungcap.Enabled = true;
                textBoxmanhacungcap.Focus();
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

        private void textBoxsodienthoai_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar >= '0') && (e.KeyChar <= '9')) || (Convert.ToInt32(e.KeyChar) == 8))
                e.Handled = false;
            else e.Handled = true;
        }
    }
}

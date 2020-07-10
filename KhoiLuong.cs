using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
namespace hoa_don_nhap
{
    public partial class KhoiLuong : Form
    {
        public KhoiLuong()
        {
            InitializeComponent();
        }

        private void KhoiLuong_Load(object sender, EventArgs e)
        {
            LoadDataToGridview();
        }
        private void LoadDataToGridview()
        {
            try
            {
                // mở kết nối
                DAO.OpenConnection();
                string sql = " select * from  Khoi_luong";
                SqlDataAdapter myAdapter = new SqlDataAdapter(sql, DAO.Conn);
                DataTable Khoi_luong = new DataTable();
                myAdapter.Fill(Khoi_luong);
                gridviewKhoiluong.DataSource = Khoi_luong;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                DAO.CloseConnection();

            }

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            txtMakl.Enabled = true;
            txtMakl.Text = "";
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtMakl.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập mã khối lượng gas");
                txtMakl.Focus();
                return;
            }
            string sqlCheckKey = "select * from Khoi_luong where Makhoiluong = '"
                + txtMakl.Text.Trim() + "'";
            if (DAO.CheckKey(sqlCheckKey))
            {
                MessageBox.Show("Mã khối lượng gas đã tồn tại");
                DAO.CloseConnection();
                txtMakl.Focus();
                return;
            }
            else
            {
                string sql = " insert into Khoi_luong values('" +
                txtMakl.Text.Trim()
                 + "')";
                DAO.OpenConnection();
                SqlCommand cmd = new SqlCommand(sql, DAO.Conn);
                cmd.ExecuteNonQuery();
                DAO.CloseConnection();
                LoadDataToGridview();

            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql = " delete from Khoi_luong where Makhoiluong = N'" + txtMakl.Text + "'";
            SqlCommand cmd = new SqlCommand();
            DAO.OpenConnection();
            cmd.CommandText = sql;
            cmd.Connection = DAO.Conn;
            cmd.ExecuteNonQuery();
            DAO.CloseConnection();
            LoadDataToGridview();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void gridviewKhoiluong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMakl.Text = gridviewKhoiluong.CurrentRow.Cells["makhoiluong"].Value.ToString();
        }
    }
}

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
    public partial class Loaics : Form
    {
        public Loaics()
        {
            InitializeComponent();
        }

        private void Loaics_Load(object sender, EventArgs e)
        {
            LoadDataToGridview();
        }
        private void LoadDataToGridview()
        {
            try
            {
                // mở kết nối
                DAO.OpenConnection();
                string sql = " select * from Loai_ga";
                SqlDataAdapter myAdapter = new SqlDataAdapter(sql, DAO.Conn);
                DataTable Loai_ga = new DataTable();
                myAdapter.Fill(Loai_ga);
                gridviewLoai.DataSource = Loai_ga;

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

        private void gridviewLoai_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaloai.Text = gridviewLoai.CurrentRow.Cells["Maloai"].Value.ToString();
            txtTenloai.Text = gridviewLoai.CurrentRow.Cells["Tenloai"].Value.ToString();
            txtMaloai.Enabled = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string Sql = "Update Loai_ga set Tenloai = N'" + txtTenloai.Text.Trim() +
                   "' where Maloai = '" + txtMaloai.Text + "'";
            DAO.OpenConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = Sql;
            cmd.Connection = DAO.Conn;
            cmd.ExecuteNonQuery();

            DAO.CloseConnection();


            LoadDataToGridview();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql = " delete from Loai_ga where Maloai = N'" + txtMaloai.Text + "'";
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

        private void btnLuu_Click(object sender, EventArgs e)
        {
            //kiểm tra điều kiện
            if (txtMaloai.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập mã loại gas");
                txtMaloai.Focus();
                return;
            }
            if (txtTenloai.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập tên loại gas");
                txtTenloai.Focus();
                return;
            }
            string sqlCheckKey = "select * from Loai_ga where Maloai = '"
                + txtMaloai.Text.Trim() + "'";
            if (DAO.CheckKey(sqlCheckKey))
            {
                MessageBox.Show("Mã loại gas đã tồn tại");
                DAO.CloseConnection();
                txtMaloai.Focus();
                return;
            }
            else
            {
                string sql = " insert into Loai_ga values('" +
                txtMaloai.Text.Trim() + "' , N'" +
                txtTenloai.Text.Trim() + "')";
                DAO.OpenConnection();
                SqlCommand cmd = new SqlCommand(sql, DAO.Conn);
                cmd.ExecuteNonQuery();
                DAO.CloseConnection();
                LoadDataToGridview();

            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            txtMaloai.Enabled = true;
            txtTenloai.Enabled = true;
            //xóa dữ liệu trong textbox
            txtMaloai.Text = "";
            txtTenloai.Text = "";
        }      
    }
}

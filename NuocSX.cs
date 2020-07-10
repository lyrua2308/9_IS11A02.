using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace hoa_don_nhap
{
    public partial class NuocSX : Form
    {
        public NuocSX()
        {
            InitializeComponent();
        }

        private void NuocSX_Load(object sender, EventArgs e)
        {
            LoadDataToGridview();
        }
        private void LoadDataToGridview()
        {
            try
            {
                // mở kết nối
                DAO.OpenConnection();
                string sql = " select * from Nuoc_san_xuat";
                SqlDataAdapter myAdapter = new SqlDataAdapter(sql, DAO.Conn);
                DataTable Nuoc_san_xuat = new DataTable();
                myAdapter.Fill(Nuoc_san_xuat);
                gridviewSX.DataSource = Nuoc_san_xuat;

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

        private void gridviewSX_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaSX.Text = gridviewSX.CurrentRow.Cells["ManuocSX"].Value.ToString();
            txtTenSX.Text = gridviewSX.CurrentRow.Cells["TennuocSX"].Value.ToString();
            txtMaSX.Enabled = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string Sql = "Update Nuoc_san_xuat set TennuocSX = N'" + txtTenSX.Text.Trim() +
                   "' where ManuocSX = '" + txtMaSX.Text + "'";
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
            string sql = " delete from Nuoc_san_xuat where ManuocSX = N'" + txtMaSX.Text + "'";
            SqlCommand cmd = new SqlCommand();
            DAO.OpenConnection();
            cmd.CommandText = sql;
            cmd.Connection = DAO.Conn;
            cmd.ExecuteNonQuery();
            DAO.CloseConnection();
            LoadDataToGridview();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            //kiểm tra điều kiện
            if (txtMaSX.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập mã nuoc SX gas");
                txtMaSX.Focus();
                return;
            }
            if (txtTenSX.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập tên nuoc SX gas");
                txtTenSX.Focus();
                return;
            }
            string sqlCheckKey = "select * from Nuoc_san_xuat where ManuocSX = '"
                + txtMaSX.Text.Trim() + "'";
            if (DAO.CheckKey(sqlCheckKey))
            {
                MessageBox.Show("Mã nước SX gas đã tồn tại");
                DAO.CloseConnection();
                txtMaSX.Focus();
                return;
            }
            else
            {
                string sql = " insert into Nuoc_san_xuat values('" +
                txtMaSX.Text.Trim() + "' , N'" +
                txtTenSX.Text.Trim() + "')";
                DAO.OpenConnection();
                SqlCommand cmd = new SqlCommand(sql, DAO.Conn);
                cmd.ExecuteNonQuery();
                DAO.CloseConnection();
                LoadDataToGridview();

            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            txtMaSX.Enabled = true;
            txtTenSX.Enabled = true;
            //xóa dữ liệu trong textbox
            txtMaSX.Text = "";
            txtTenSX.Text = "";
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtTenSX_TextChanged(object sender, EventArgs e)
        {

        }

        private void gridviewSX_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}

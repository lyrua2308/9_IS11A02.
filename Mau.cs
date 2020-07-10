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
    public partial class Mau : Form
    {
        public Mau()
        {
            InitializeComponent();
        }

        private void Mau_Load(object sender, EventArgs e)
        {
            LoadDataToGridview();
        }
        private void LoadDataToGridview()
        {
            try
            {
                // mở kết nối
                DAO.OpenConnection();
                string sql = " select * from Mau";
                SqlDataAdapter myAdapter = new SqlDataAdapter(sql, DAO.Conn);
                DataTable Mau = new DataTable();
                myAdapter.Fill(Mau);
                gridviewMau.DataSource = Mau;

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

        private void gridviewMau_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMamau.Text = gridviewMau.CurrentRow.Cells["Mamau"].Value.ToString();
            txtTenmau.Text = gridviewMau.CurrentRow.Cells["Tenmau"].Value.ToString();
            txtMamau.Enabled = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string Sql = "Update Mau set Tenmau = N'" + txtTenmau.Text.Trim() +
                   "' where Mamau = '" + txtMamau.Text + "'";
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

            string sql = " delete from Mau where Mamau = N'" + txtMamau.Text + "'";
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
            if (txtMamau.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập mã màu gas");
                txtMamau.Focus();
                return;
            }
            if (txtTenmau.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập tên màu gas");
                txtTenmau.Focus();
                return;
            }
            string sqlCheckKey = "select * from Mau where Mamau = '"
                + txtMamau.Text.Trim() + "'";
            if (DAO.CheckKey(sqlCheckKey))
            {
                MessageBox.Show("Mã màu gas đã tồn tại");
                DAO.CloseConnection();
                txtMamau.Focus();
                return;
            }
            else
            {
                string sql = " insert into Mau values('" +
                txtMamau.Text.Trim() + "' , N'" +
                txtTenmau.Text.Trim() + "')";
                DAO.OpenConnection();
                SqlCommand cmd = new SqlCommand(sql, DAO.Conn);
                cmd.ExecuteNonQuery();
                DAO.CloseConnection();
                LoadDataToGridview();

            }

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            txtMamau.Enabled = true;
            txtTenmau.Enabled = true;
            //xóa dữ liệu trong textbox
            txtMamau.Text = "";
            txtTenmau.Text = "";
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}

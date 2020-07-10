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
    public partial class NhanVien : Form
    {
        public NhanVien()
        {
            InitializeComponent();
        }

        private void loatdata()
        {

            DAO.OpenConnection();
            string sql = "select * from nhan_vien";
            SqlDataAdapter myAdater = new SqlDataAdapter(sql, DAO.Conn);
            DataTable table = new DataTable();
            myAdater.Fill(table);
            dataGridViewNhanVien.DataSource = table;
        }

      

       


        private void buttonthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

        private void buttonthoat_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NhanVien_Load(object sender, EventArgs e)
        {
            loatdata();
            string sql = "select * from Cong_viec";
            DAO.fillDataToCombo(sql, comboBoxmacongviec, "macv", "tencv");//displaymember:chọn tên ,valuemember:lấy mã tương ứng

            string sql1 = "select * from ca_lam";
            DAO.fillDataToCombo(sql1, comboBoxmaca, "maca", "tenca");
            string sql2 = "select distinct gioitinh from Nhan_vien";
            DAO.fillDataToCombo(sql2, comboBoxgioitinh, "gioitinh", "gioitinh");

        }

        private void dataGridViewNhanVien_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            textBoxMaNV.Text = dataGridViewNhanVien.CurrentRow.Cells["MaNV"].Value.ToString();
            textBoxTenNV.Text = dataGridViewNhanVien.CurrentRow.Cells["TenNV"].Value.ToString();
            textBoxdiachi.Text = dataGridViewNhanVien.CurrentRow.Cells["DiaChi"].Value.ToString();
            textBoxdienthoai.Text = dataGridViewNhanVien.CurrentRow.Cells["dienthoai"].Value.ToString();
            comboBoxgioitinh.Text = dataGridViewNhanVien.CurrentRow.Cells["gioitinh"].Value.ToString();
            comboBoxmaca.Text = dataGridViewNhanVien.CurrentRow.Cells["maca"].Value.ToString();
            comboBoxmacongviec.Text = dataGridViewNhanVien.CurrentRow.Cells["macv"].Value.ToString();
            maskedTextBoxngaysinh.Text = dataGridViewNhanVien.CurrentRow.Cells["ngaysinh"].Value.ToString();
            textBoxMaNV.Enabled = false;

        }

        private void buttonthem_Click_1(object sender, EventArgs e)
        {
            textBoxMaNV.Enabled = true;
            textBoxdienthoai.Text = "";
            textBoxMaNV.Text = "";
            textBoxTenNV.Text = "";
            textBoxdiachi.Text = "";
            maskedTextBoxngaysinh.Text = "";
            comboBoxmacongviec.SelectedValue = "";
            comboBoxmaca.SelectedValue = "";
            comboBoxgioitinh.SelectedValue = "";
        }

        private void buttonsua_Click_1(object sender, EventArgs e)
        {
            string sql = "update Nhan_Vien set tennv=N'" + textBoxTenNV.Text + "',diachi=N'" + textBoxdiachi.Text + "',gioitinh=N'" + comboBoxgioitinh.SelectedValue
               + "',ngaysinh='" + maskedTextBoxngaysinh.Text + "',dienthoai='" + textBoxdienthoai.Text + "',maca='" + comboBoxmaca.SelectedValue + "',macv='"
               + comboBoxmacongviec.SelectedValue +
               "' where manv=N'" + textBoxMaNV.Text + "'";
            
            DAO.RunSql(sql);
            loatdata();
        }

        private void buttonxoa_Click_1(object sender, EventArgs e)
        {

            string sql = "delete from nhan_vien where manv='" + textBoxMaNV.Text + "'";
            DAO.RunSqlDel(sql);
            loatdata();
               
            
        }

        private void buttonluu_Click_1(object sender, EventArgs e)
        {
            if (textBoxdiachi.Text == "")
            {
                MessageBox.Show("bạn chưa nhập Địa chỉ");
                textBoxdiachi.Focus();

            }
            if (textBoxdienthoai.Text == "")
            {
                MessageBox.Show("bạn chưa nhập số điện thoại");
                textBoxdienthoai.Focus();
            }
            if (textBoxMaNV.Text == "")
            {
                MessageBox.Show("bạn chưa nhập mã");
                textBoxMaNV.Focus();
            }
            if (textBoxTenNV.Text == "")
            {
                MessageBox.Show("bạn chưa nhập tên");
                textBoxTenNV.Focus();

            }
            if (maskedTextBoxngaysinh.Text == "")
            {
                MessageBox.Show("bạn chưa nhập ngay sinh");
                maskedTextBoxngaysinh.Focus();
            }
            if (comboBoxgioitinh.SelectedIndex == -1)
            {
                MessageBox.Show("bạn chưa nhập giới tính");
                comboBoxgioitinh.Focus();




            }
            if (comboBoxmaca.SelectedIndex == -1)
            {
                MessageBox.Show("bạn chưa nhập maca");
                comboBoxmaca.Focus();

            }
            if (comboBoxmacongviec.SelectedIndex == -1)
            {
                MessageBox.Show("bạn chưa nhập mã công việc");
                comboBoxmacongviec.Focus();

            }
            string sql = "insert into nhan_vien values('" + textBoxMaNV.Text + "','" + textBoxTenNV.Text
                + "','" + comboBoxgioitinh.SelectedValue + "','" + maskedTextBoxngaysinh.Text
                + "','" + textBoxdiachi.Text + "','" + textBoxdienthoai.Text + "','" + comboBoxmaca.SelectedValue
                + "','" + comboBoxmacongviec.SelectedValue + "')";
            //MessageBox.Show(sql);
            DAO.OpenConnection();
            string sqlCheck = "select * from nhan_vien where manv='" + textBoxMaNV.Text.Trim() + "'";
            if (DAO.CheckKey(sqlCheck))
            {
                MessageBox.Show("nhanvien da ton tai");
                DAO.CloseConnection();
                textBoxMaNV.Enabled = true;
                textBoxMaNV.Focus();
                return;
            }
            else
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandText = sql;
                cmd.Connection = DAO.Conn;
                cmd.ExecuteNonQuery();

                loatdata();

                DAO.CloseConnection();
            }


        }

        private void textBoxdienthoai_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar >= '0') && (e.KeyChar <= '9')) || (Convert.ToInt32(e.KeyChar) == 8))
                e.Handled = false;
            else e.Handled = true;
        }
    }
}

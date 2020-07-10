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
using System.Security.Cryptography.X509Certificates;

namespace hoa_don_nhap
{
    public partial class FrmDMBinhGa : Form
    {
      
        public FrmDMBinhGa()
        {
            InitializeComponent();
        }
        private void goiy()
        {
            string sql = "select distinct thoigianbaohanh from DM_Binh_ga ";



            SqlDataReader reader = DAO.getDataReader(sql);

            AutoCompleteStringCollection auto = new AutoCompleteStringCollection();

            if (reader != null)

            {

                while (reader.Read())

                {

                    auto.Add(reader["thoigianbaohanh"].ToString());

                }

            }
            txtTGBH.AutoCompleteMode = AutoCompleteMode.SuggestAppend;

            txtTGBH.AutoCompleteSource = AutoCompleteSource.CustomSource;

            txtTGBH.AutoCompleteCustomSource = auto;

            reader.Close();
        }
            private void DMBinhGas_Load(object sender, EventArgs e)
        {
            RefreshData();
            goiy();
        }

        public void RefreshData()
        {
            DAO.OpenConnection();
            LoadDataToGridView();
            FillDataToCombo();
            string sql = "select Maloai,Tenloai from Loai_ga";
            DAO.fillDataToCombo(sql, cmbLoaiGas, "Maloai", "Tenloai");
            sql = "select Mamau,Tenmau from Mau";
            DAO.fillDataToCombo(sql, cmbMau, "Mamau", "Tenmau");
            sql = "select Makhoiluong from Khoi_luong";
            DAO.fillDataToCombo(sql, cmbKhoiLuong, "Makhoiluong", "Makhoiluong");
            sql = "select ManuocSX,TennuocSX from Nuoc_san_xuat";
            DAO.fillDataToCombo(sql, cmbNuocSX, "ManuocSX", "TennuocSX");
            DAO.CloseConnection();
        }

        private void LoadDataToGridView()
        {
            DAO.OpenConnection();
            string sql = " SELECT * FROM DM_Binh_ga";
            SqlDataAdapter adapter = new SqlDataAdapter(sql, DAO.Conn);
            DataTable table = new DataTable();
            adapter.Fill(table);
            GridViewBinhGas.DataSource = table;
            DAO.CloseConnection();
        }
        public void FillDataToCombo()
        {
            DAO.OpenConnection();
            string sql = "select * from DM_Binh_ga";
            SqlDataAdapter adapter = new SqlDataAdapter(sql, DAO.Conn);
            DataTable table = new DataTable();
            adapter.Fill(table);
            cmbLoaiGas.DataSource = table;
            cmbLoaiGas.ValueMember = "Maloai";
            cmbLoaiGas.DisplayMember = "Tenloai";
            cmbMau.DataSource = table;
            cmbMau.ValueMember = "Mamau";
            cmbMau.DisplayMember = "Tenmau";
            cmbKhoiLuong.DataSource = table;
            cmbKhoiLuong.ValueMember = "Makhoiluong";
            cmbNuocSX.DataSource = table;
            cmbNuocSX.ValueMember = "ManuocSX";
            cmbNuocSX.DisplayMember = "TennuocSX";
            DAO.CloseConnection();
        }

        private void btnThoat_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            DAO.OpenConnection();
            txtTenBinh.Text = "";
            txtMaBinh.Text = "";
            cmbKhoiLuong.Text = "";
            cmbLoaiGas.Text = "";
            cmbMau.Text = "";
            cmbNuocSX.Text = "";
            txtSoLuong.Text = "0";
            txtDonGiaNhap.Text = "0";
            txtDonGiaBan.Text = "0";
            txtTGBH.Text = "";
            txtAnh.Text = "";
            txtGhichu.Text = "";
            picAnh.Image = null;
            cmbLoaiGas.SelectedIndex = -1;
            cmbMau.SelectedIndex = -1;
            cmbKhoiLuong.SelectedIndex = -1;
            cmbNuocSX.SelectedIndex = -1;
            DAO.CloseConnection();
        }

        private void GridViewBinhGas_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            DAO.OpenConnection();
            if (btnThem.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaBinh.Focus();
                return;
            }

            txtMaBinh.Text = GridViewBinhGas.CurrentRow.Cells["Mabinh"].Value.ToString();
            txtTenBinh.Text = GridViewBinhGas.CurrentRow.Cells["Tenbinh"].Value.ToString();
            txtSoLuong.Text = GridViewBinhGas.CurrentRow.Cells["Soluong"].Value.ToString();
            txtDonGiaNhap.Text = GridViewBinhGas.CurrentRow.Cells["Dongianhap"].Value.ToString();
            txtDonGiaBan.Text = GridViewBinhGas.CurrentRow.Cells["Dongiaban"].Value.ToString();
            txtTGBH.Text = GridViewBinhGas.CurrentRow.Cells["Thoigianbaohanh"].Value.ToString();
            txtAnh.Text = GridViewBinhGas.CurrentRow.Cells["Anh"].Value.ToString();
            txtGhichu.Text = GridViewBinhGas.CurrentRow.Cells["Ghichu"].Value.ToString();
            cmbKhoiLuong.Text = GridViewBinhGas.CurrentRow.Cells["Makhoiluong"].Value.ToString();
            cmbMau.Text = GridViewBinhGas.CurrentRow.Cells["Mamau"].Value.ToString();
            cmbLoaiGas.Text = GridViewBinhGas.CurrentRow.Cells["Maloai"].Value.ToString();
            cmbNuocSX.Text = GridViewBinhGas.CurrentRow.Cells["manuocSX"].Value.ToString();

            if (!String.IsNullOrEmpty(txtAnh.Text))
            {
                picAnh.Image = Image.FromFile(txtAnh.Text);
            }

            string sql;
            double gianhap, giaban;
            gianhap = Convert.ToDouble(DAO.GetFieldValues("Select Dongianhap from DM_Binh_ga where Mabinh = N'" + txtMaBinh.Text.Trim() + "'"));
            giaban = (gianhap * 110) / 100;
            sql = "UPDATE DM_Binh_ga SET Dongiaban =" + giaban + "where Mabinh =N'" + txtMaBinh.Text.Trim() + "'";
            DAO.RunSql(sql);
            txtDonGiaBan.Text = giaban.ToString();

            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            txtMaBinh.Enabled = true;
            DAO.CloseConnection();
        }

        private void btnXoa_Click_1(object sender, EventArgs e)
        {
            DAO.OpenConnection();
            string sql;
            sql = "select Mabinh from Chi_tiet_hoa_don_ban where Mabinh ='" + txtMaBinh.Text.Trim() + "'";
 
            if (DAO.CheckKey(sql))
            {
                MessageBox.Show("Bạn không thể xóa vì Bình gas này đã được bán! ");
                txtMaBinh.Focus();
                DAO.CloseConnection();
                return;
            }

            else
            {
                sql = "delete from DM_Binh_ga where Mabinh =N'" + txtMaBinh.Text + "'";
                
                SqlCommand cmd = new SqlCommand(sql, DAO.Conn);
                cmd.CommandText = sql;
                cmd.Connection = DAO.Conn;
                cmd.ExecuteNonQuery();
                DAO.CloseConnection();
                LoadDataToGridView();
            }
            DAO.CloseConnection();
        }

        public string Equal(string field, object value)
        {
            if (value != null)
            {
                return "'," + field + "=N'" + value.ToString();
            }

            return "";
        }
        //edit
        private void btnSua_Click(object sender, EventArgs e)
        {
            DAO.OpenConnection();
            string sql;
            sql = "Update DM_Binh_ga set Tenbinh=N'" + txtTenBinh.Text.Trim() 
                    + Equal("Maloai", cmbLoaiGas.SelectedValue) 
                    + Equal("Mamau", cmbMau.SelectedValue)
                    + Equal("Makhoiluong", cmbKhoiLuong.SelectedValue)
                    + Equal("ManuocSX", cmbNuocSX.SelectedValue) 
                    + "',Soluong=" + txtSoLuong.Text.Trim() 
                    + ",Dongianhap=" + txtDonGiaNhap.Text.Trim()
                    + ",Dongiaban=" + txtDonGiaBan.Text.Trim() + ",Thoigianbaohanh=N'" + txtTGBH.Text.Trim() + "',Anh='" + txtAnh.Text + "',Ghichu=N'" + txtGhichu.Text.Trim() + "' where Mabinh=N'" + txtMaBinh.Text.Trim() + "'";
            
            txtMaBinh.Enabled = false;
            SqlCommand cmd = new SqlCommand(sql, DAO.Conn);
            //MessageBox.Show(sql);
            cmd.CommandText = sql;
            cmd.Connection = DAO.Conn;
            cmd.ExecuteNonQuery();
            
            DAO.CloseConnection();
            LoadDataToGridView();
        }
        


        private void btnLuu_Click_1(object sender, EventArgs e)
        {
            DAO.OpenConnection();
            if (txtMaBinh.Text == "")
            {
                MessageBox.Show("Bạn không được để trống mã bình");
                txtMaBinh.Focus();
                return;

            }
            if (txtTenBinh.Text == "")
            {
                MessageBox.Show("bạn không được để trống tên bình");
                txtTenBinh.Focus();
                return;
            }
            if (cmbLoaiGas.SelectedIndex == -1)
            {
                MessageBox.Show("bạn chưa chọn loại gas");
                return;
            }
            if (cmbMau.SelectedIndex == -1)
            {
                MessageBox.Show("bạn chưa chọn màu");
                return;
            }
            if (cmbKhoiLuong.SelectedIndex == -1)
            {
                MessageBox.Show("bạn chưa chọn khối lượng");
                return;
            }
            if (cmbNuocSX.SelectedIndex == -1)
            {
                MessageBox.Show("bạn chưa chọn nước sản xuất");
                return;
            }
            if (txtSoLuong.Text == "")
            {
                MessageBox.Show("bạn không được để trống số lượng");
                txtSoLuong.Focus();
                return;
            }
            if (txtDonGiaNhap.Text == "")
            {
                MessageBox.Show("bạn không được để trống đơn giá nhập ");
                txtDonGiaNhap.Focus();
                return;
            }
            if (txtDonGiaBan.Text == "")
            {
                MessageBox.Show("bạn không được để trống đơn giá bán");
                txtDonGiaBan.Focus();
                return;
            }
            if (txtAnh.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải chọn ảnh minh họa cho hàng");
                txtAnh.Focus();
                return;
            }
            if (txtTGBH.Text == "")
            {
                MessageBox.Show("bạn không được để trống thời gian bảo hành");
                txtTGBH.Focus();
                return;
            }

            string sql = "select * from DM_Binh_ga where Mabinh ='" + txtMaBinh.Text.Trim() + "'";
 
            if (DAO.CheckKey(sql))
            {
                MessageBox.Show("Mã bình đã tồn tại");
                txtMaBinh.Focus();
                
                return;
            }
            else
            {

                sql = "insert into DM_Binh_ga(Mabinh, Tenbinh, Maloai, Mamau, Makhoiluong, ManuocSX, Soluong, Dongianhap, Dongiaban, Thoigianbaohanh, Anh, Ghichu) values(N'" + txtMaBinh.Text.Trim() + "', N'"
                                + txtTenBinh.Text.Trim() + "',N'" + cmbLoaiGas.SelectedValue.ToString() + "'," + cmbMau.SelectedValue.ToString() + ",N'" + cmbKhoiLuong.SelectedValue.ToString()
                                + "',N'" + cmbNuocSX.SelectedValue.ToString() + "',"
                                + txtSoLuong.Text.Trim() + "," + txtDonGiaNhap.Text.Trim() + ","
                                + txtDonGiaBan.Text.Trim() + ",N'" + txtTGBH.Text.Trim() + "','" + txtAnh.Text + "',N'" + txtGhichu.Text.Trim() + "')";


               

                //MessageBox.Show(sql);
                SqlCommand cmd = new SqlCommand(sql, DAO.Conn);

                cmd.ExecuteNonQuery();
                LoadDataToGridView();
                RefreshData();
               
                txtMaBinh.Enabled = true;
            }
            DAO.CloseConnection();
        }

        private void Ảnh_Click(object sender, EventArgs e)
        {
            DAO.OpenConnection();
            OpenFileDialog dlgOpen = new OpenFileDialog();
            dlgOpen.Filter = "Bitmap(*.bmp)|*.bmp|Gif(*.gif)|*.gif|All files(*.*)|*.*";
            dlgOpen.InitialDirectory = "D:\\";
            dlgOpen.FilterIndex = 2;
            dlgOpen.Title = "Chọn hình ảnh để hiển thị";
            if (dlgOpen.ShowDialog() == DialogResult.OK)
            {
                picAnh.Image = Image.FromFile(dlgOpen.FileName);
                txtAnh.Text = dlgOpen.FileName;
            }
            DAO.CloseConnection();
        }


        //tim kiem
        private void btnTimKiem_Click_1(object sender, EventArgs e)
        {
            
            string sql;
            if ((txtMaBinh.Text == "") && (txtTenBinh.Text == "") && (cmbLoaiGas.Text == "") && (cmbMau.Text == "") && (cmbKhoiLuong.Text == "")
                && (cmbNuocSX.Text == "") && (txtSoLuong.Text == "") && (txtDonGiaNhap.Text == "") && (txtDonGiaBan.Text == "") && (txtTGBH.Text == "")
                && (txtAnh.Text == "") && (txtGhichu.Text == ""))
            {
                MessageBox.Show("Hãy nhập một điều kiện tìm kiếm!!!");
                return;
            }

            sql = "SELECT * FROM DM_Binh_ga WHERE 1=1";

            if (txtMaBinh.Text != "")
                sql = sql + " AND MaBinh Like N'%" + txtMaBinh.Text + "%'";
            if (txtTenBinh.Text != "")
                sql = sql + " AND TenBinh Like N'%" + txtTenBinh.Text + "%'";
            if (cmbLoaiGas.Text != "")
                sql = sql + " AND Maloai Like N'%" + cmbLoaiGas.SelectedValue + "%'";
            if (cmbMau.Text != "")
                sql = sql + " AND Mamau Like N'%" + cmbMau.SelectedValue + "%'";
            if (cmbKhoiLuong.Text != "")
                sql = sql + " AND Makhoiluong Like N'%" + cmbKhoiLuong.SelectedValue + "%'";
            if (cmbNuocSX.Text != "")
                sql = sql + " AND ManuocSX Like N'%" + cmbNuocSX.SelectedValue + "%'";
            if (txtSoLuong.Text != "" && txtSoLuong.Text != "0")
                sql = sql + " AND Soluong Like N'%" + txtSoLuong.Text + "%'";
            if (txtDonGiaNhap.Text != "" && txtDonGiaNhap.Text != "0")
                sql = sql + " AND Dongianhap Like N'%" + txtDonGiaNhap.Text + "%'";
            if (txtDonGiaBan.Text != "" && txtDonGiaBan.Text != "0")
                sql = sql + " AND Dongiaban Like N'%" + txtDonGiaBan.Text + "%'";
            if (txtTGBH.Text != "")
                sql = sql + " AND Thoigianbaohanh Like N'%" + txtTGBH.Text + "%'";
            if (txtAnh.Text != "")
                sql = sql + " AND Anh Like N'%" + txtAnh.Text + "%'";
            if (txtGhichu.Text != "")
                sql = sql + " AND Ghichu Like N'%" + txtGhichu.Text + "%'";
             DataTable DM_Binh_ga = DAO.GetDataToTable(sql);
            if (DM_Binh_ga.Rows.Count == 0)
               MessageBox.Show("Không có bản ghi thỏa mãn điều kiện!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
             else

               MessageBox.Show("Có " + DM_Binh_ga.Rows.Count + " bản ghi thỏa mãn điều kiện!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
             GridViewBinhGas.DataSource = DM_Binh_ga;
           
            txtMaBinh.Enabled = true;
            txtGhichu.Enabled = true;
            txtTenBinh.Enabled = true;
            txtDonGiaNhap.Enabled = true;
            txtDonGiaBan.Enabled = true;
            txtAnh.Enabled = true;              
            cmbKhoiLuong.Enabled = true;
            cmbMau.Enabled = true;
            
           
        }

        private void btnHienThi_Click(object sender, EventArgs e)
        {
            DAO.OpenConnection();
            btnLuu.Enabled = true;
            btnThem.Enabled = true;
            btnThoat.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;

            string sql;
            //sql = "SELECT Mabinh, Tenbinh, Maloai,Mamau,Makhoiluong,ManuocSX,Soluong, Dongianhap, Dongiaban,Thoigianbaohanh, Anh, Ghichu FROM DM_Binh_ga";
            sql = "SELECT * FROM DM_Binh_ga";
            DataTable DM_Binh_ga = DAO.GetDataToTable(sql);
            GridViewBinhGas.DataSource = DM_Binh_ga;
            DAO.CloseConnection();
        }

        private void txtDonGiaNhap_TextChanged_1(object sender, EventArgs e)
        {
            DAO.OpenConnection();
            double gb, gn;

            if (txtDonGiaNhap.Text == "")
                gn = 0;
            else
                gn = Convert.ToDouble(txtDonGiaNhap.Text);
            gb = gn * 110 / 100;
            txtDonGiaBan.Text = gb.ToString();
            DAO.CloseConnection();
        }

        private void cmbMau_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FrmDMBinhGa_Load(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }


 }


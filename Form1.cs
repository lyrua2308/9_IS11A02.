using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;
using COMExcel = Microsoft.Office.Interop.Excel;

namespace hoa_don_nhap
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           refreshdata();
        }
        private void refreshdata()

        {
            DAO.OpenConnection();
            
            txtSoHDN.ReadOnly = true;
            txtTennhanvien.ReadOnly = true;
            txtTenNCC.ReadOnly = true;
            txtDiachi.ReadOnly = true;
            mskDienthoai.ReadOnly = true;
            txtTenbinh.ReadOnly = true;
            txtDongia.ReadOnly = false;
            txtThanhtien.ReadOnly = true;
            txtTongtien.ReadOnly = true;
            txtGiamgia.Text = "0";
            txtTongtien.Text = "0";
            DAO.FillCombo("SELECT MaNCC, TenNCC FROM nha_cc", cboMaNCC, "MaNCC", "MaNCC");
            cboMaNCC.SelectedIndex = -1;
            DAO.FillCombo("SELECT MaNV, TenNV FROM nhan_vien", cboManhanvien, "MaNV", "MaNV");
            cboManhanvien.SelectedIndex = -1;
            DAO.FillCombo("SELECT Mabinh, tenbinh FROM DM_Binh_ga ", cboMabinh, "Mabinh", "Mabinh");
            cboMabinh.SelectedIndex = -1;
            //Hiển thị thông tin của một hóa đơn được gọi từ form tìm kiếm
            if (txtSoHDN.Text != "")
            {
                LoadInfoHoadon();
                
            }
            LoadDataGridView();
        }
        private void LoadDataGridView()
        {
            DAO.OpenConnection();
            string sql;
            sql = "select tenbinh /*Chi_tiet_hoa_don_nhap.SoHDN*/,Hoa_don_nhap.NgayNhap,Chi_tiet_hoa_don_nhap.Mabinh," +
                "Hoa_don_nhap.MaNCC,Chi_tiet_hoa_don_nhap.Dongia,Chi_tiet_hoa_don_nhap.Soluong,Chi_tiet_hoa_don_nhap.Giamgia," +
                "Chi_tiet_hoa_don_nhap.Thanhtien,manv,hoa_don_nhap.sohdn" +
                " from Chi_tiet_hoa_don_nhap join Hoa_don_nhap on Chi_tiet_hoa_don_nhap.SoHDN = Hoa_don_nhap.SoHDN join DM_Binh_ga ON DM_Binh_ga.Mabinh = Chi_tiet_hoa_don_nhap.Mabinh ";
            SqlDataAdapter adapter = new SqlDataAdapter(sql, DAO.Conn);
            DataTable table = new DataTable();
            adapter.Fill(table);
            DataGridView_hdn.DataSource = table;
            DataGridView_hdn.AllowUserToAddRows = false;
            DataGridView_hdn.EditMode = DataGridViewEditMode.EditProgrammatically;
            DAO.CloseConnection();
        }
        private void LoadInfoHoadon()
        {
            string str;
            str = "SELECT MaNV FROM hoa_don_nhap WHERE SoHDN = N'" + txtSoHDN.Text + "'";
            cboManhanvien.Text = DAO.GetFieldValues(str);
            str = "SELECT NgayNhap FROM hoa_don_nhap WHERE SoHDN = N'" + txtSoHDN.Text + "'";
            txtNgaynhap.Text = DAO.ConvertDateTime(DAO.GetFieldValues(str));
            str = "SELECT MaNCC FROM hoa_don_nhap WHERE SoHDN = N'" + txtSoHDN.Text + "'";
            cboMaNCC.Text = DAO.GetFieldValues(str);
            str = "SELECT TongTien FROM hoa_don_nhap WHERE SoHDN = N'" + txtSoHDN.Text + "'";
            txtTongtien.Text = DAO.GetFieldValues(str);
            lblBangchu.Text = "Bằng chữ: " + DAO.ChuyenSoSangChu(txtTongtien.Text);
        }
        private void ResetValues()
        {
            txtSoHDN.Text = "";
            txtNgaynhap.Text = DateTime.Now.ToShortDateString();
            cboManhanvien.Text = "";
            txtTennhanvien.Text = "";
            cboMaNCC.Text = "";
            txtTenNCC.Text = "";
            txtDiachi.Text = "";
            mskDienthoai.Text = "";
            txtTongtien.Text = "0";
            lblBangchu.Text = "Bằng chữ: ";
            cboMabinh.Text = "";
            txtSoluong.Text = "";
            txtGiamgia.Text = "0";
            txtDongia.Text = "0";
            txtThanhtien.Text = "0";
        }

        private void cboManhanvien_SelectedIndexChanged(object sender, EventArgs e)
        {
            DAO.OpenConnection();
            string str;
            if (cboManhanvien.Text == "")
                txtTennhanvien.Text = "";
            // Khi chọn Mã nhân viên thì tên nhân viên tự động hiện ra
            str = "Select TenNV from nhan_vien where MaNV =N'" + cboManhanvien.SelectedValue + "'";
            txtTennhanvien.Text = DAO.GetFieldValues(str);
            DAO.CloseConnection();
        }

        private void cboMaNCC_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            string str;
            if (cboMaNCC.Text == "")
            {
                txtTenNCC.Text = "";
                txtDiachi.Text = "";
                mskDienthoai.Text = "";
            }
            //Khi chọn Mã nhà cung cấp này thì các thông tin của nhà cung cấp sẽ hiện ra
            str = "Select TenNCC from nha_cc where MaNCC = N'" + cboMaNCC.SelectedValue + "'";
            txtTenNCC.Text =DAO.GetFieldValues(str);
            str = "Select DiaChi from nha_cc where MaNCC = N'" + cboMaNCC.SelectedValue + "'";
            txtDiachi.Text = DAO.GetFieldValues(str);
            str = "Select DienThoai from nha_cc where MaNCC= N'" + cboMaNCC.SelectedValue + "'";
            mskDienthoai.Text = DAO.GetFieldValues(str);

        }

        private void cboMabinh_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            string str;
            if (cboMabinh.Text == "")
            {
                txtTenbinh.Text = "";
                txtDongia.Text = "";
            }
            // Khi chọn mã binh  thì các thông tin về hàng hiện ra
            str = "SELECT Tenbinh FROM DM_binh_ga WHERE Mabinh =N'" + cboMabinh.SelectedValue + "'";
            txtTenbinh.Text = DAO.GetFieldValues(str);
            str = "SELECT DonGianhap FROM DM_binh_ga WHERE Mabinh =N'" + cboMabinh.SelectedValue + "'";
            txtDongia.Text = DAO.GetFieldValues(str);
        }

        private void txtSoluong_TextChanged(object sender, EventArgs e)
        {
            //Khi thay đổi số lượng thì thực hiện tính lại thành tiền
            double tt, sl, dg, gg;
            if (txtSoluong.Text == "")
                sl = 0;
            else
                sl = Convert.ToDouble(txtSoluong.Text);
            if (txtGiamgia.Text == "")
                gg = 0;
            else
                gg = Convert.ToDouble(txtGiamgia.Text);
            if (txtDongia.Text == "")
                dg = 0;
            else
                dg = Convert.ToDouble(txtDongia.Text);
            tt = sl * dg - sl * dg * gg / 100;
            txtThanhtien.Text = tt.ToString();
        }

        private void txtGiamgia_TextChanged(object sender, EventArgs e)
        {
            //Khi thay đổi giảm giá thì tính lại thành tiền
            double tt, sl, dg, gg;
            if (txtSoluong.Text == "")
                sl = 0;
            else
                sl = Convert.ToDouble(txtSoluong.Text);
            if (txtGiamgia.Text == "")
                gg = 0;
            else
                gg = Convert.ToDouble(txtGiamgia.Text);
            if (txtDongia.Text == "")
                dg = 0;
            else
                dg = Convert.ToDouble(txtDongia.Text);
            tt = sl * dg - sl * dg * gg / 100;
            txtThanhtien.Text = tt.ToString();
        }

        private void txtSoluong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar >= '0') && (e.KeyChar <= '9')) || (Convert.ToInt32(e.KeyChar) == 8))
                e.Handled = false;
            else e.Handled = true;
        }

        private void txtGiamgia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar >= '0') && (e.KeyChar <= '9')) || (Convert.ToInt32(e.KeyChar) == 8))
                e.Handled = false;
            else e.Handled = true;
        }

        private void txtDongia_TextChanged(object sender, EventArgs e)
        {

            //Khi thay đổi đơn giá nhập thì thực hiện tính lại thành tiền
            double tt, sl, dg, gg;
            if (txtSoluong.Text == "")
                sl = 0;
            else
                sl = Convert.ToDouble(txtSoluong.Text);
            if (txtGiamgia.Text == "")
                gg = 0;
            else
                gg = Convert.ToDouble(txtGiamgia.Text);
            if (txtDongia.Text == "")
                dg = 0;
            else
                dg = Convert.ToDouble(txtDongia.Text);
            tt = sl * dg - sl * dg * gg / 100;
            txtThanhtien.Text = tt.ToString();
        }

        private void txtDongia_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (((e.KeyChar >= '0') && (e.KeyChar <= '9')) || (Convert.ToInt32(e.KeyChar) == 8))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void ResetValuesHang()
        {
            cboMabinh.Text = "";
            txtSoluong.Text = "";
            txtTenbinh.Text = "";
            txtGiamgia.Text = "0";
            txtDongia.Text = "0";
            txtThanhtien.Text = "0";
            
        }
        private void btnThemmoi_Click(object sender, EventArgs e)
        {
            
            ResetValues();
            ResetValuesHang();
            txtSoHDN.Text = DAO.CreateKey("HDN");
            LoadDataGridView();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            DAO.OpenConnection();
            string sql;
            double sl, SLcon, tong, Tongmoi;
            sql = "SELECT SoHDN FROM hoa_don_nhap WHERE SoHDN=N'" + txtSoHDN.Text + "'";
            if (!DAO.CheckKey(sql))
            {
                // Số hóa đơn nhập chưa có, tiến hành lưu các thông tin chung
                // SoHDNhap được sinh tự động do đó không có trường hợp trùng khóa
                if (cboManhanvien.Text.Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập mã nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cboManhanvien.Focus();
                    return;
                }
                if (txtNgaynhap.Text.Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập ngày nhập hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtNgaynhap.Focus();
                    return;
                }
                if (cboMaNCC.Text.Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập mã nhà cung cấp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cboMaNCC.Focus();
                    return;
                }
                sql = "INSERT INTO hoa_don_nhap(SoHDN, MaNV, NgayNhap, MaNCC, TongTien) VALUES (N'" + txtSoHDN.Text.Trim() + "',N'" + cboManhanvien.SelectedValue + "',N'" +
                        DAO.ConvertDateTime(txtNgaynhap.Text.Trim()) + "',N'" +
                        cboMaNCC.SelectedValue + "'," + txtTongtien.Text + ")";
                
               DAO.RunSql(sql);
            
            }
            // Lưu thông tin của các mặt hàng
            if (cboMabinh.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã bình", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboMabinh.Focus();
                return;
            }
            if ((txtSoluong.Text.Trim().Length == 0) || (txtSoluong.Text == "0"))
            {
                MessageBox.Show("Bạn phải nhập số lượng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSoluong.Text = "";
                txtSoluong.Focus();
                return;
            }
            if (txtGiamgia.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập giảm giá", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtGiamgia.Focus();
                return;
            }
            if (txtDongia.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập đơn giá nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDongia.Focus();
                return;
            }
            sql = "SELECT Mabinh FROM chi_tiet_hoa_don_nhap WHERE Mabinh=N'" + cboMabinh.SelectedValue + "' AND SoHDN = N'" + txtSoHDN.Text.Trim() + "'";
            if (DAO.CheckKey(sql))
            {
                MessageBox.Show("Mã bình này đã có, bạn phải nhập mã bình khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ResetValuesHang();
                cboMabinh.Focus();
                return;
            }
            DAO.OpenConnection();
            sql = "INSERT INTO chi_tiet_hoa_don_nhap VALUES(N'" + txtSoHDN.Text.Trim() + "',N'" + cboMabinh.SelectedValue + "'," + txtSoluong.Text + "," + txtDongia.Text + "," + txtGiamgia.Text + "," + txtThanhtien.Text + ")";
            
            DAO.RunSql(sql);
            LoadDataGridView();

            
            //cap nhat

            double dgnhap = Convert.ToDouble(txtDongia.Text); // đơn giá nhập
           
            sl = Convert.ToDouble(DAO.GetFieldValues("SELECT SoLuong FROM DM_binh_ga WHERE mabinh = N'" + cboMabinh.SelectedValue + "'"));
            double slmoi = Convert.ToDouble(txtSoluong.Text);
           

            sql = "UPDATE DM_binh_ga SET DonGiaNhap=" + dgnhap + "WHERE Mabinh= N'" + cboMabinh.SelectedValue + "'";
            DAO.RunSql(sql);
            sql = "UPDATE DM_binh_ga SET DonGiaBan=" + dgnhap * 1.1 + "WHERE Mabinh= N'" + cboMabinh.SelectedValue + "'";
            DAO.RunSql(sql);

            // Cập nhật lại số lượng ga vào bảng DM Binh ga
            SLcon = sl + slmoi;
            sql = "UPDATE DM_binh_ga  SET SoLuong =" + SLcon + " WHERE Mabinh= N'" + cboMabinh.SelectedValue + "'";
            DAO.RunSql(sql);

            //Cập nhật lại tổng tiền cho hóa đơn nhập
            
                tong = Int32.Parse(DAO.GetFieldValues("SELECT TongTien FROM hoa_don_nhap WHERE SoHDN = N'" + txtSoHDN.Text + "'"));
            
             Tongmoi = tong + Convert.ToDouble(txtThanhtien.Text);
            sql = "UPDATE hoa_don_nhap SET TongTien =" + Tongmoi + " WHERE SoHDN = N'" + txtSoHDN.Text + "'";
            DAO.RunSql(sql);


             txtTongtien.Text = Tongmoi.ToString();
            lblBangchu.Text = "Bằng chữ: " + DAO.ChuyenSoSangChu(Tongmoi.ToString());
           
            LoadDataGridView();
            DAO.CloseConnection();
            
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            double sl, slcon, slxoa;
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string sql = "SELECT Mabinh,SoLuong FROM chi_tiet_hoa_don_nhap WHERE SoHDN = N'" + txtSoHDN.Text + "'";
                DataTable DM_Binh_ga = DAO.GetDataToTable(sql);
                for (int ga = 0; ga <= DM_Binh_ga.Rows.Count - 1; ga++)
                {
                    // Cập nhật lại số lượng cho các loại ga
                    sl = Convert.ToDouble(DAO.GetFieldValues("SELECT SoLuong FROM DM_Binh_ga WHERE Mabinh = N'" + DM_Binh_ga.Rows[ga][0].ToString() + "'"));
                    slxoa = Convert.ToDouble(DM_Binh_ga.Rows[ga][1].ToString());
                    slcon = sl - slxoa;
                    sql = "UPDATE DM_Binh_ga SET SoLuong =" + slcon + " WHERE Mabinh= N'" + DM_Binh_ga.Rows[ga][0].ToString() + "'";
                    DAO.RunSql(sql);
                }

                //Xóa chi tiết hóa đơn
                sql = "DELETE Chi_tiet_hoa_don_nhap WHERE SoHDN=N'" + txtSoHDN.Text + "'";
                DAO.RunSqlDel(sql);

                //Xóa hóa đơn
                sql = "DELETE hoa_don_nhap WHERE SoHDN=N'" + txtSoHDN.Text + "'";
                DAO.RunSqlDel(sql);
                ResetValues();
                LoadDataGridView();
               
            }

        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            ResetValues();
        }

      

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DataGridView_hdn_DoubleClick(object sender, EventArgs e)
        {
            DAO.OpenConnection();
            string mabinhxoa, sql;
            Double thanhtienxoa, soluongxoa, sl, slcon, tong, tongmoi;
            if ((MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
            {
                //Xóa sách và cập nhật lại số lượng ga
                mabinhxoa = DataGridView_hdn.CurrentRow.Cells["Mabinh"].Value.ToString();
                soluongxoa = Convert.ToDouble(DataGridView_hdn.CurrentRow.Cells["SoLuong"].Value.ToString());
                thanhtienxoa = Convert.ToDouble(DataGridView_hdn.CurrentRow.Cells["Thanhtien"].Value.ToString());
                sql = "DELETE chi_tiet_hoa_don_nhap WHERE SoHDN =N'" + txtSoHDN.Text + "' AND Mabinh = N'" + mabinhxoa + "'";
                DAO.RunSql(sql);

                // Cập nhật lại số lượng cho các loại bình
                sl = Convert.ToDouble(DAO.GetFieldValues("SELECT SoLuong FROM DM_binh_ga WHERE Mabinh = N'" + mabinhxoa + "'"));
                slcon = sl - soluongxoa;
                sql = "UPDATE DM_binh_ga SET SoLuong =" + slcon + " WHERE Mabinh= N'" + mabinhxoa + "'";
                DAO.RunSql(sql);

                // Cập nhật lại tổng tiền cho hóa đơn nhập
                tong = Convert.ToDouble(DAO.GetFieldValues("SELECT TongTien FROM hoa_don_nhap WHERE SoHDN = N'"+txtSoHDN.Text+"'"));
                tongmoi = tong - thanhtienxoa;
                sql = "UPDATE hoa_don_nhap SET TongTien =" + tongmoi + " WHERE SoHDN = N'" + txtSoHDN.Text + "'";
                DAO.RunSql(sql);
                txtTongtien.Text = tongmoi.ToString();
                lblBangchu.Text = "Bằng chữ: " + DAO.ChuyenSoSangChu(tongmoi.ToString());
                LoadDataGridView();
            }
        }

        private void btnInhoadon_Click(object sender, EventArgs e)
        {
            COMExcel.Application exApp = new COMExcel.Application();
            COMExcel.Workbook exBook; //Trong 1 chương trình Excel có nhiều Workbook
            COMExcel.Worksheet exSheet; //Trong 1 Workbook có nhiều Worksheet
            COMExcel.Range exRange;
            string sql;
            int hang = 0, cot = 0;
            DataTable tblThongtinHD, tblThongtinHang;
            exBook = exApp.Workbooks.Add(COMExcel.XlWBATemplate.xlWBATWorksheet);
            exSheet = exBook.Worksheets[1];
            // Định dạng chung
            exRange = exSheet.Cells[1, 1];
            exRange.Range["A1:Z300"].Font.Name = "Times new roman"; //Font chữ
            exRange.Range["A1:B3"].Font.Size = 10;
            exRange.Range["A1:B3"].Font.Bold = true;
            exRange.Range["A1:B3"].Font.ColorIndex = 5; 
            exRange.Range["A1:A1"].ColumnWidth = 10;
            exRange.Range["B1:B1"].ColumnWidth = 17;
            exRange.Range["A1:B1"].MergeCells = true;
            exRange.Range["A1:B1"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A1:B1"].Value = "Đại Lý Bán Ga nhóm 9";
            exRange.Range["A2:B2"].MergeCells = true;
            exRange.Range["A2:B2"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A2:B2"].Value = "Số 75 Thái Hà-Đống Đa-Hà Nội";
            exRange.Range["A3:B3"].MergeCells = true;
            exRange.Range["A3:B3"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A3:B3"].Value = "Điện thoại: 0866162243";
            exRange.Range["C2:E2"].Font.Size = 16;
            exRange.Range["C2:E2"].Font.Bold = true;
            exRange.Range["C2:E2"].Font.ColorIndex = 3;
            exRange.Range["C2:E2"].MergeCells = true;
            exRange.Range["C2:E2"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["C2:E2"].Value = "HÓA ĐƠN NHẬP";
            // Biểu diễn thông tin chung của hóa đơn nhập
            sql = "SELECT a.SoHDN, a.NgayNhap, a.TongTien, b.TenNCC, b.DiaChi, b.DienThoai, c.TenNV FROM hoa_don_nhap AS a, nha_cc AS b, nhan_vien AS c WHERE a.SoHDN = N'" + txtSoHDN.Text + "' AND a.MaNCC = b.MaNCC AND a.MaNV = c.MaNV";
            tblThongtinHD = DAO.GetDataToTable(sql);
            exRange.Range["B6:C9"].Font.Size = 12;
            exRange.Range["B6:B6"].Value = "Mã hóa đơn:";
            exRange.Range["C6:E6"].MergeCells = true;
            exRange.Range["C6:E6"].Value = tblThongtinHD.Rows[0][0].ToString();
            exRange.Range["B7:B7"].Value = "Nhà cung cấp:";
            exRange.Range["C7:E7"].MergeCells = true;
            exRange.Range["C7:E7"].Value = tblThongtinHD.Rows[0][3].ToString();
            exRange.Range["B8:B8"].Value = "Địa chỉ:";
            exRange.Range["C8:E8"].MergeCells = true;
            exRange.Range["C8:E8"].Value = tblThongtinHD.Rows[0][4].ToString();
            exRange.Range["B9:B9"].Value = "Điện thoại:";
            exRange.Range["C9:E9"].MergeCells = true;
            exRange.Range["C9:D9"].Value = tblThongtinHD.Rows[0][5].ToString();
            //Lấy thông tin các mặt hàng
            sql = "SELECT b.Tenbinh, a.Soluong, b.DonGiaNhap, a.Giamgia, a.ThanhTien " +
                  "FROM chi_tiet_hoa_don_nhap AS a , DM_binh_ga AS b WHERE a.SoHDN = N'" +
                  txtSoHDN.Text + "' AND a.Mabinh = b.Mabinh";
            tblThongtinHang = DAO.GetDataToTable(sql);
            //Tạo dòng tiêu đề bảng
            exRange.Range["A11:F11"].Font.Bold = true;
            exRange.Range["A11:F11"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["C11:F11"].ColumnWidth = 12;
            exRange.Range["A11:A11"].Value = "STT";
            exRange.Range["B11:B11"].Value = "Tên bình";
            exRange.Range["C11:C11"].Value = "Số lượng nhập";
            exRange.Range["D11:D11"].Value = "Đơn giá";
            exRange.Range["E11:E11"].Value = "Giảm giá";
            exRange.Range["F11:F11"].Value = "Thành tiền";
            for (hang = 0; hang < tblThongtinHang.Rows.Count; hang++)
            {
                //Điền số thứ tự vào cột 1 từ dòng 12
                exSheet.Cells[1][hang + 12] = hang + 1;
                for (cot = 0; cot < tblThongtinHang.Columns.Count; cot++)
                //Điền thông tin hàng từ cột thứ 2, dòng 12
                {
                    exSheet.Cells[cot + 2][hang + 12] = tblThongtinHang.Rows[hang][cot].ToString();
                    if (cot == 3) exSheet.Cells[cot + 2][hang + 12] = tblThongtinHang.Rows[hang][cot].ToString() + "%";
                }
            }
            exRange = exSheet.Cells[cot][hang + 14];
            exRange.Font.Bold = true;
            exRange.Value2 = "Tổng tiền:";
            exRange = exSheet.Cells[cot + 1][hang + 14];
            exRange.Font.Bold = true;
            exRange.Value2 = tblThongtinHD.Rows[0][2].ToString();
            exRange = exSheet.Cells[1][hang + 15]; //Ô A1 
            exRange.Range["A1:F1"].MergeCells = true;
            exRange.Range["A1:F1"].Font.Bold = true;
            exRange.Range["A1:F1"].Font.Italic = true;
            exRange.Range["A1:F1"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignRight;
            exRange.Range["A1:F1"].Value = "Bằng chữ: " + DAO.ChuyenSoSangChu(tblThongtinHD.Rows[0][2].ToString());
            exRange = exSheet.Cells[4][hang + 17]; //Ô A1 
            exRange.Range["A1:C1"].MergeCells = true;
            exRange.Range["A1:C1"].Font.Italic = true;
            exRange.Range["A1:C1"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            DateTime d = Convert.ToDateTime(tblThongtinHD.Rows[0][1]);
            exRange.Range["A1:C1"].Value = "Hà Nội, ngày " + d.Day + " tháng " + d.Month + " năm " + d.Year;
            exRange.Range["A2:C2"].MergeCells = true;
            exRange.Range["A2:C2"].Font.Italic = true;
            exRange.Range["A2:C2"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A2:C2"].Value = "Nhân viên nhập hàng";
            exRange.Range["A6:C6"].MergeCells = true;
            exRange.Range["A6:C6"].Font.Italic = true;
            exRange.Range["A6:C6"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A6:C6"].Value = tblThongtinHD.Rows[0][6];
            exSheet.Name = "Hóa đơn nhập";
            exApp.Visible = true;

        }

        private void DataGridView_hdn_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtTenbinh.Text = DataGridView_hdn.CurrentRow.Cells["tenbinh"].Value.ToString();
            txtSoluong.Text = DataGridView_hdn.CurrentRow.Cells["soluong"].Value.ToString();
            txtDongia.Text = DataGridView_hdn.CurrentRow.Cells["dongia"].Value.ToString();
            txtGiamgia.Text = DataGridView_hdn.CurrentRow.Cells["giamgia"].Value.ToString();
            txtThanhtien.Text = DataGridView_hdn.CurrentRow.Cells["thanhtien"].Value.ToString();
            txtNgaynhap.Text = DAO.ConvertDateTime(DataGridView_hdn.CurrentRow.Cells["ngaynhap"].Value.ToString());
            cboMabinh.Text= DataGridView_hdn.CurrentRow.Cells["mabinh"].Value.ToString();
           cboMaNCC.Text= DataGridView_hdn.CurrentRow.Cells["mancc"].Value.ToString();
            cboManhanvien.Text = DataGridView_hdn.CurrentRow.Cells["manv"].Value.ToString();
            txtSoHDN.Text= DataGridView_hdn.CurrentRow.Cells["sohdn"].Value.ToString();
        }

        private void bt_timkiem_Click(object sender, EventArgs e)
        {


            string sql;
            if ((txtNgaynhap.Text == "") && (cboMaNCC.Text == "") && (cboMabinh.Text == ""))

                
            {
                MessageBox.Show("Hãy nhập một điều kiện tìm kiếm!!!", "Yêu cầu ...",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            sql = "select tenbinh /*Chi_tiet_hoa_don_nhap.SoHDN*/, Hoa_don_nhap.NgayNhap,Chi_tiet_hoa_don_nhap.Mabinh," +
                "Hoa_don_nhap.MaNCC,Chi_tiet_hoa_don_nhap.Dongia,Chi_tiet_hoa_don_nhap.Soluong,Chi_tiet_hoa_don_nhap.Giamgia," +
                "Chi_tiet_hoa_don_nhap.Thanhtien,manv,hoa_don_nhap.sohdn" +
            " from Chi_tiet_hoa_don_nhap join Hoa_don_nhap on Chi_tiet_hoa_don_nhap.SoHDN = Hoa_don_nhap.SoHDN join DM_Binh_ga ON DM_Binh_ga.Mabinh = Chi_tiet_hoa_don_nhap.Mabinh where 1=1 ";
         
            if (cboMabinh.Text != "")
                sql = sql + " AND dm_binh_ga.Mabinh Like N'%" + cboMabinh.Text + "%'";
            
            if (cboMaNCC.Text != "")
                sql = sql + " AND Mancc Like N'%" + cboMaNCC.SelectedValue + "%'";
           
            if (txtNgaynhap.Text != "")
                sql = sql + "AND CONVERT(VARCHAR(25), Ngaynhap, 126) Like N'%" + DAO.ConvertDateTime( txtNgaynhap.Text) + "%'";
          
            DataTable DM_Binh_ga = DAO.GetDataToTable(sql);

            if (DM_Binh_ga.Rows.Count == 0)
            {
                MessageBox.Show("không có bản ghi nào thỏa mãn điều kiện", "thông báo",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Có " + DM_Binh_ga.Rows.Count + " bản ghi thỏa mãn điều kiện!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            DAO.loatdata(sql, DataGridView_hdn);
           
        }
        



    private void btnHienthi_Click(object sender, EventArgs e)
        {

            string sql;
            sql = "select tenbinh /*Chi_tiet_hoa_don_nhap.SoHDN*/, Hoa_don_nhap.NgayNhap,Chi_tiet_hoa_don_nhap.Mabinh," +
                "Hoa_don_nhap.MaNCC,Chi_tiet_hoa_don_nhap.Dongia,Chi_tiet_hoa_don_nhap.Soluong,Chi_tiet_hoa_don_nhap.Giamgia," +
                "Chi_tiet_hoa_don_nhap.Thanhtien,manv,hoa_don_nhap.sohdn" +
                " from Chi_tiet_hoa_don_nhap join Hoa_don_nhap on Chi_tiet_hoa_don_nhap.SoHDN = Hoa_don_nhap.SoHDN join DM_Binh_ga ON DM_Binh_ga.Mabinh = Chi_tiet_hoa_don_nhap.Mabinh ";
            DataTable DM_Binh_ga = DAO.GetDataToTable(sql);
            DataTable Hoa_don_nhap = DAO.GetDataToTable(sql);
            DataTable Chi_tiet_hoa_don_nhap = DAO.GetDataToTable(sql);
            DataGridView_hdn.DataSource = DM_Binh_ga;
            DataGridView_hdn.DataSource = Hoa_don_nhap;
            DataGridView_hdn.DataSource = Chi_tiet_hoa_don_nhap;
            LoadDataGridView();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cboMabinh.Enabled = true;
            cboMaNCC.Enabled = true;
            txtNgaynhap.Enabled = true;
            txtDiachi.Enabled = false;
            txtDongia.Enabled = false;
            txtGiamgia.Enabled = false;
            txtSoHDN.Enabled = false;
            txtSoluong.Enabled = false;
            txtTenbinh.Enabled = false;
            txtThanhtien.Enabled = false;
            cboManhanvien.Enabled = false;
            txtNgaynhap.Text = "";
            
        }

        private void grbThongtinchung_Enter(object sender, EventArgs e)
        {

        }

        private void grbThongtinmathang_Enter(object sender, EventArgs e)
        {

        }

        private void txtTongtien_TextChanged(object sender, EventArgs e)
        {

        }
    }

       
 }


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using COMExcel = Microsoft.Office.Interop.Excel;
using System.Data.Sql;
using System.Data.SqlClient;

namespace hoa_don_nhap
{
    public partial class HoaDonBan : Form
    {
        public HoaDonBan()
        {
            InitializeComponent();
        }

        private void HoaDonBan_Load(object sender, EventArgs e)
        {

            //string abc= "select * from Chi_tiet_hoa_don_ban ";
            // fill dữ liệu vào các comboboxmax nv,kh,tenhang,mahang,soluong
            string sql = "select MaNV,TenNV from Nhan_Vien";
            DAO.OpenConnection();
            DAO.fillDataToCombo(sql, cmbMaNV, "MaNV", "MaNV");

            sql = "select Makhach,Tenkhach from Khach_hang";
            DAO.fillDataToCombo(sql, cmbMaKH, "Makhach", "Makhach");

            sql = "select Mabinh,Tenbinh from DM_Binh_ga";
            DAO.fillDataToCombo(sql, cmbMabinh, "Mabinh", "Mabinh");

            sql = " select SoHDB from hoa_don_ban ";
            DAO.fillDataToCombo(sql, cmbMaHDB, "SoHDB", "SoHDB");

            Load_DataGridViewChitiet();
        }
        private void Load_DataGridViewChitiet()
        {
            DataTable Chi_tiet_hoa_don_ban = new DataTable();
            txtDiachi.Enabled = false;
            txtDienthoai.Enabled = false;
            txtDongia.Enabled = false;
            txtTenbinh.Enabled = false;
            txtTenKH.Enabled = false;
            txtTenNV.Enabled = false;
            DAO.OpenConnection();
            string sql;
            sql = "SELECT b.tenbinh,c.ngayban,a.SoHDB,b.Mabinh,makhach,manv, a.Soluong, b.Dongiaban, a.Giamgia,a.Thanhtien " +
                " FROM Chi_tiet_hoa_don_ban AS a join DM_Binh_ga as b on a.mabinh=b.mabinh join" +
                " hoa_don_ban as c on a.SoHDB=c.SoHDB ";
            Chi_tiet_hoa_don_ban = DAO.GetDataToTable(sql);
            DataGridViewChiTiet.DataSource = Chi_tiet_hoa_don_ban;
            DAO.CloseConnection();


        }
        private void LoadInfoHoaDon()
        {
            string str;
            str = "SELECT NgayBan FROM Hoa_don_ban WHERE SoHDB = N'" + txtSoHDB.Text + "'";
            txtNgayBan.Text = DAO.ConvertDateTime(DAO.GetFieldValues(str));
            str = "SELECT MaNV FROM Hoa_don_ban  WHERE SoHDB = N'" + txtSoHDB.Text + "'";
            cmbMaNV.Text = DAO.GetFieldValues(str);
            str = "SELECT Makhach FROM Hoa_don_ban WHERE SoHDB = N'" + txtSoHDB.Text + "'";
            cmbMaKH.Text = DAO.GetFieldValues(str);
            str = "SELECT Tongtien FROM Hoa_don_ban WHERE SoHDB = N'" + txtSoHDB.Text + "'";
            txtTongtien.Text = DAO.GetFieldValues(str);
            labelChuyen.Text = "Bằng chữ: " + DAO.ChuyenSoSangChu(txtTongtien.Text);


        }
        private void ResetValues()
        {
            txtSoHDB.Text = "";
            txtNgayBan.Text = DateTime.Now.ToShortDateString();
            cmbMaNV.Text = "";
            cmbMaKH.Text = "";
            txtTongtien.Text = "0";
            cmbMabinh.Text = "";
            txtSoluong.Text = "";
            txtGiamgia.Text = "0";
            txtThanhtien.Text = "0";
            labelChuyen.Text = "Bằng chữ: ";
        }

        private void ResetValuesHang()
        {
            txtSoHDB.Text = "";
            cmbMabinh.Text = "";
            txtSoluong.Text = "";
            txtGiamgia.Text = "0";
            txtThanhtien.Text = "0";
        }


            private void cmbMaNV_SelectedIndexChanged(object sender, EventArgs e)
            {
                string str;
                if (cmbMaNV.Text == "")
                {
                    txtTenNV.Text = "";
                }
                //
                str = "select TenNV from nhan_vien where MaNV = N'" + cmbMaNV.SelectedValue + "'";
                txtTenNV.Text = DAO.GetFieldValues(str);
            }

            private void cmbMaKH_SelectedIndexChanged(object sender, EventArgs e)
            {
                string str;
                if (cmbMaKH.Text == "")
                {
                    txtTenKH.Text = "";
                    txtDiachi.Text = "";
                    txtDienthoai.Text = "";

                }
                str = "select tenkhach from khach_hang where makhach =N'" + cmbMaKH.SelectedValue + "'";
                txtTenKH.Text = DAO.GetFieldValues(str);
                str = "select diachi from khach_hang where makhach =N'" + cmbMaKH.SelectedValue + "'";
                txtDiachi.Text = DAO.GetFieldValues(str);
                str = "select dienthoai from khach_hang where makhach =N'" + cmbMaKH.SelectedValue + "'";
                txtDienthoai.Text = DAO.GetFieldValues(str);
            }

            private void cmbMabinh_SelectedIndexChanged(object sender, EventArgs e)
            {
                DAO.OpenConnection();
                string str;
                if (cmbMabinh.Text == "")
                {
                    txtTenbinh.Text = "";
                    txtDongia.Text = "";

                }
                str = "select tenbinh from DM_Binh_ga where mabinh = N'" + cmbMabinh.SelectedValue + "'";
                txtTenbinh.Text = DAO.GetFieldValues(str);
                str = "select dongiaban from dm_binh_ga where mabinh = N'" + cmbMabinh.SelectedValue + "'";
                txtDongia.Text = DAO.GetFieldValues(str);
            DAO.CloseConnection();
            }

            private void DataGridViewChiTiet_CellContentClick(object sender, DataGridViewCellEventArgs e)
            {

            }

            private void txtTenKH_TextChanged(object sender, EventArgs e)
            {

            }

            private void label1_Click(object sender, EventArgs e)
            {

            }

        private void btnThem_Click_1(object sender, EventArgs e)
        {

           
            cmbMabinh.SelectedIndex = -1;
            cmbMaKH.SelectedIndex = -1;
            cmbMaNV.SelectedIndex = -1;
            ResetValues();
            ResetValuesHang();
            txtSoHDB.Text = DAO.CreateKey("HDB");
            Load_DataGridViewChitiet();

        }


        private void btnLuu_Click_1(object sender, EventArgs e)
        {
            
            string sql;
            double sl, SLcon, tong, Tongmoi;
            //double giaban, giabanmoi;
            DAO.OpenConnection();
            sql = "SELECT SoHDB FROM Hoa_don_ban WHERE SoHDB=N'" + txtSoHDB.Text + "'";
            if (!DAO.CheckKey(sql))
            {

                if (txtNgayBan.Text.Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập ngày bán", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtNgayBan.Focus();
                    return;
                }
                if (cmbMaNV.Text.Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cmbMaNV.Focus();
                    return;
                }
                if (cmbMaKH.Text.Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cmbMaKH.Focus();
                    return;
                }
                sql = "INSERT INTO hoa_don_ban(SoHDB, MaNV, Ngayban, makhach, TongTien) VALUES(N'" +txtSoHDB.Text.Trim() + "', N'" + cmbMaNV.SelectedValue + "', N'" +
 
                         txtNgayBan.Text.Trim() + "',N'" +
                         cmbMaKH.SelectedValue + "'," + txtTongtien.Text + ")";
                //MessageBox.Show(sql);
                DAO.RunSql(sql);
            }
            // Lưu thông tin của các mặt hàng
            if (cmbMabinh.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cmbMabinh.Focus();
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
            sql = "SELECT Mabinh FROM Chi_tiet_hoa_don_ban WHERE Mabinh=N'" + cmbMabinh.SelectedValue + "' AND SoHDB = N'" + txtSoHDB.Text.Trim() + "'";
            if (DAO.CheckKey(sql))
            {
                MessageBox.Show("Mã hàng này đã có, bạn phải nhập mã khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ResetValuesHang();
                cmbMabinh.Focus();
                return;
            }
            // Kiểm tra xem số lượng hàng trong kho còn đủ để cung cấp không?
            sl = Convert.ToDouble(DAO.GetFieldValues("SELECT SoLuong FROM DM_Binh_ga WHERE Mabinh = N'" + cmbMabinh.SelectedValue + "'"));
            if (Convert.ToDouble(txtSoluong.Text) > sl)
            {
                MessageBox.Show("Số lượng mặt hàng này chỉ còn " + sl, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSoluong.Text = "";
                txtSoluong.Focus();
                return;
            }
            sql = "INSERT INTO Chi_tiet_hoa_don_ban(SoHDB,Mabinh,Soluong, Giamgia,Thanhtien) VALUES(N'" + txtSoHDB.Text + "',N'"
                + cmbMabinh.SelectedValue + "'," + txtSoluong.Text + "," + txtGiamgia.Text + "," + txtThanhtien.Text + ")";
            //MessageBox.Show(sql);
            DAO.RunSql(sql);
            Load_DataGridViewChitiet();
            // Cập nhật lại số lượng của mặt hàng vào bảng DM_Binh_ga
            SLcon = sl - Convert.ToDouble(txtSoluong.Text);
            sql = "UPDATE DM_Binh_ga SET Soluong =" + SLcon + " WHERE Mabinh= N'" + cmbMabinh.SelectedValue + "'";
            DAO.RunSql(sql);
            
            //Cập nhật lại tổng tiền cho hóa đơn bán


            tong = Int32.Parse(DAO.GetFieldValues("SELECT tongtien FROM hoa_don_ban WHERE SoHDB = N'" + txtSoHDB.Text + "'"));
            Tongmoi = tong + Convert.ToDouble(txtThanhtien.Text);
            sql = "UPDATE Hoa_don_ban SET Tongtien =" + Tongmoi + " WHERE SoHDB = N'" + txtSoHDB.Text + "'";
            DAO.RunSql(sql);
            txtTongtien.Text = Tongmoi.ToString();
            labelChuyen.Text = "Bằng chữ: " + DAO.ChuyenSoSangChu(Tongmoi.ToString());
            ResetValuesHang();
            
            //btnInhoadon = true;
        }

        private void DataGridViewChiTiet_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            string Mabinhxoa, sql;
            Double ThanhTienxoa, SoLuongxoa, sl, slcon, tong, tongmoi;

            //if ( DM_Binh_ga.Rows.Count == 0)
            //{
            // MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //return;
            //}
            if ((MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
            {
                //Xóa hàng và cập nhật lại số lượng hàng 
                Mabinhxoa = DataGridViewChiTiet.CurrentRow.Cells["Mabinh"].Value.ToString();
                SoLuongxoa = Convert.ToDouble(DataGridViewChiTiet.CurrentRow.Cells["SoLuong"].Value.ToString());
                ThanhTienxoa = Convert.ToDouble(DataGridViewChiTiet.CurrentRow.Cells["ThanhTien"].Value.ToString());
                sql = "DELETE Chi_tiet_hoa_don_ban WHERE SoHDB=N'" + txtSoHDB.Text + "' AND Mabinh = N'" + Mabinhxoa + "'";
                DAO.RunSql(sql);
                // Cập nhật lại số lượng cho các mặt hàng
                sl = Convert.ToDouble(DAO.GetFieldValues("SELECT Soluong FROM DM_Binh_ga WHERE Mabinh = N'" + Mabinhxoa + "'"));
                slcon = sl + SoLuongxoa;
                sql = "UPDATE DM_Binh_ga SET Soluong =" + slcon + " WHERE Mabinh= N'" + Mabinhxoa + "'";
                DAO.RunSql(sql);
                // Cập nhật lại tổng tiền cho hóa đơn bán
                tong = Convert.ToDouble(DAO.GetFieldValues("SELECT TongTien FROM Hoa_don_ban WHERE SoHDB = N'" + txtSoHDB.Text + "'"));
                tongmoi = tong - ThanhTienxoa;
                sql = "UPDATE Hoa_don_ban SET Tongtien =" + tongmoi + " WHERE SoHDB = N'" + txtSoHDB.Text + "'";
                DAO.RunSql(sql);
                txtTongtien.Text = tongmoi.ToString();
                labelChuyen.Text = "Bằng chữ: " + DAO.ChuyenSoSangChu(tongmoi.ToString());
                txtTongtien.Text = tongmoi.ToString();
                Load_DataGridViewChitiet();
            }
    }

        private void btnXoa_Click_1(object sender, EventArgs e)
        {
            double sl, slcon, slxoa;
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string sql = "SELECT Mabinh,Soluong FROM Chi_tiet_hoa_don_ban WHERE SoHDB = N'" + txtSoHDB.Text + "'";
                DataTable DM_Binh_ga = DAO.GetDataToTable(sql);
                for (int hang = 0; hang <= DM_Binh_ga.Rows.Count - 1; hang++)
                {
                    // Cập nhật lại số lượng cho các mặt hàng
                    sl = Convert.ToDouble(DAO.GetFieldValues("SELECT SoLuong FROM DM_Binh_ga WHERE Mabinh = N'" + DM_Binh_ga.Rows[hang][0].ToString() + "'"));
                    slxoa = Convert.ToDouble(DM_Binh_ga.Rows[hang][1].ToString());
                    slcon = sl + slxoa;
                    sql = "UPDATE DM_Binh_ga SET Soluong =" + slcon + " WHERE Mabinh= N'" + DM_Binh_ga.Rows[hang][0].ToString() + "'";
                    DAO.RunSql(sql);
                }

                //Xóa chi tiết hóa đơn
                sql = "DELETE Chi_tiet_hoa_don_ban WHERE SoHDB=N'" + txtSoHDB.Text + "'";
                DAO.RunSql(sql);

                //Xóa hóa đơn
                sql = "DELETE Hoa_don_ban WHERE SoHDB=N'" + txtSoHDB.Text + "'";
                DAO.RunSql(sql);
                ResetValues();
                Load_DataGridViewChitiet();
                
            }
    }

        private void txtSoluong_TextChanged_1(object sender, EventArgs e)
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

        private void txtGiamgia_TextChanged_1(object sender, EventArgs e)
        {
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

        private void btnTimkiem_Click_1(object sender, EventArgs e)
        {
            DataTable Chi_tiet_hoa_don_ban = new DataTable();
            if (cmbMaHDB.Text == "")
            {
                MessageBox.Show("Bạn phải chọn một mã hóa đơn để tìm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cmbMaHDB.Focus();
                return;
            }
            txtSoHDB.Text = cmbMaHDB.Text;
            LoadInfoHoaDon();
            string sql;
            sql = "SELECT b.tenbinh,c.ngayban,a.SoHDB,a.Mabinh,makhach,manv, a.Soluong, b.Dongiaban, a.Giamgia,a.Thanhtien " +
                "FROM Chi_tiet_hoa_don_ban AS a join DM_Binh_ga as b on a.mabinh=b.mabinh join hoa_don_ban as c on a.SoHDB=c.SoHDB " +
                "where a.sohdb='" + txtSoHDB.Text + "'";
            Chi_tiet_hoa_don_ban = DAO.GetDataToTable(sql);
            DataGridViewChiTiet.DataSource = Chi_tiet_hoa_don_ban;

           
            cmbMaHDB.SelectedIndex = -1;
        }

        private void btnTimkiem_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar >= '0') && (e.KeyChar <= '9')) || (Convert.ToInt32(e.KeyChar) == 8))
                e.Handled = false;
            else e.Handled = true;
        }

        private void cmbMaHDB_DropDown_1(object sender, EventArgs e)
        {
            DAO.FillCombo("SELECT SoHDB FROM Hoa_don_ban", cmbMaHDB, "SoHDB", "SoHDB");
            cmbMaHDB.SelectedIndex = -1;
        }

        private void HoaDonBan_FormClosing(object sender, FormClosingEventArgs e)
        {
            ResetValues();
        }

        private void cmbMabinh_DropDown_1(object sender, EventArgs e)
        {
            cmbMabinh.DataSource = DAO.GetDataToTable("SELECT Mabinh From DM_Binh_ga");
            cmbMabinh.ValueMember = "Mabinh";
            cmbMabinh.SelectedIndex = -1;
        }

        private void cmbMaKH_DropDown_1(object sender, EventArgs e)
        {

            cmbMaKH.DataSource = DAO.GetDataToTable("select Makhach from Khach_hang");
            cmbMaKH.ValueMember = "Makhach";
            cmbMaKH.SelectedIndex = -1;
        }

        private void cmbMaNV_DropDown_1(object sender, EventArgs e)
        {
            cmbMaNV.DataSource = DAO.GetDataToTable("Select MaNV From Nhan_Vien");
            cmbMaNV.ValueMember = "MaNV";
            cmbMaNV.SelectedIndex = -1;
        }

        private void btnInhoadon_Click_1(object sender, EventArgs e)
        {
            // Khởi động chương trình Excel
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
            exRange.Range["A1:B3"].Font.Size = 10;
            exRange.Range["A1:B3"].Font.Name = "Times new roman";
            exRange.Range["A1:B3"].Font.Bold = true;
            exRange.Range["A1:B3"].Font.ColorIndex = 5; //Màu xanh da trời
            exRange.Range["A1:A1"].ColumnWidth = 7;
            exRange.Range["B1:B1"].ColumnWidth = 15;
            exRange.Range["A1:B1"].MergeCells = true;
            exRange.Range["A1:B1"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A1:B1"].Value = "Đại Lý Bán Ga Nhóm 9";

            exRange.Range["A2:B2"].MergeCells = true;
            exRange.Range["A2:B2"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A2:B2"].Value = "Số 75 Thái Hà-Đống Đa-Hà Nội";

            exRange.Range["A3:B3"].MergeCells = true;
            exRange.Range["A3:B3"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A3:B3"].Value = "Điện thoại: 0866162243";


            exRange.Range["C2:E2"].Font.Size = 16;
            exRange.Range["C2:E2"].Font.Name = "Times new roman";
            exRange.Range["C2:E2"].Font.Bold = true;
            exRange.Range["C2:E2"].Font.ColorIndex = 3; //Màu đỏ
            exRange.Range["C2:E2"].MergeCells = true;
            exRange.Range["C2:E2"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["C2:E2"].Value = "HÓA ĐƠN BÁN";
            // Biểu diễn thông tin chung của hóa đơn bán
            sql = "SELECT a.SoHDB, a.Ngayban, a.Tongtien, b.tenkhach, b.Diachi, b.Dienthoai, c.TenNV FROM hoa_don_ban AS a, khach_hang AS b, nhan_vien AS c WHERE a.SoHDB = N'" + txtSoHDB.Text + "' AND a.Makhach = b.Makhach AND a.MaNV = c.MaNV";
            tblThongtinHD = DAO.GetDataToTable(sql);
            exRange.Range["B6:C9"].Font.Size = 12;
            exRange.Range["B6:C9"].Font.Name = "Times new roman";
            exRange.Range["B6:B6"].Value = "Mã hóa đơn:";
            exRange.Range["C6:E6"].MergeCells = true;
            exRange.Range["C6:E6"].Value = tblThongtinHD.Rows[0][0].ToString();
            exRange.Range["B7:B7"].Value = "Khách hàng:";
            exRange.Range["C7:E7"].MergeCells = true;
            exRange.Range["C7:E7"].Value = tblThongtinHD.Rows[0][3].ToString();
            exRange.Range["B8:B8"].Value = "Địa chỉ:";
            exRange.Range["C8:E8"].MergeCells = true;
            exRange.Range["C8:E8"].Value = tblThongtinHD.Rows[0][4].ToString();
            exRange.Range["B9:B9"].Value = "Điện thoại:";
            exRange.Range["C9:E9"].MergeCells = true;
            exRange.Range["C9:E9"].Value = tblThongtinHD.Rows[0][5].ToString();
            //Lấy thông tin các mặt hàng
            sql = "SELECT b.Tenbinh, a.Soluong, b.Dongiaban, a.Giamgia, a.Thanhtien " +
                  "FROM chi_tiet_hoa_don_ban AS a , DM_Binh_ga AS b WHERE a.SoHDB = N'" +
                  txtSoHDB.Text + "' AND a.mabinh = b.mabinh";
            tblThongtinHang = DAO.GetDataToTable(sql);
            //Tạo dòng tiêu đề bảng
            exRange.Range["A11:F11"].Font.Bold = true;
            exRange.Range["A11:F11"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["C11:F11"].ColumnWidth = 12;
            exRange.Range["A11:A11"].Value = "STT";
            exRange.Range["B11:B11"].Value = "Tên hàng";
            exRange.Range["C11:C11"].Value = "Số lượng";
            exRange.Range["D11:D11"].Value = "Đơn giá";
            exRange.Range["E11:E11"].Value = "Giảm giá";
            exRange.Range["F11:F11"].Value = "Thành tiền";
            for (hang = 0; hang <= tblThongtinHang.Rows.Count - 1; hang++)
            {
                //Điền số thứ tự vào cột 1 từ dòng 12
                exSheet.Cells[1][hang + 12] = hang + 1;
                for (cot = 0; cot <= tblThongtinHang.Columns.Count - 1; cot++)
                    //Điền thông tin hàng từ cột thứ 2, dòng 12
                    exSheet.Cells[cot + 2][hang + 12] = tblThongtinHang.Rows[hang][cot].ToString();
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
            exRange.Range["A1:F1"].Value = "Bằng chữ: " + DAO.ChuyenSoSangChu
 (tblThongtinHD.Rows[0][2].ToString());
            exRange = exSheet.Cells[4][hang + 17]; //Ô A1 
            exRange.Range["A1:C1"].MergeCells = true;
            exRange.Range["A1:C1"].Font.Italic = true;
            exRange.Range["A1:C1"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            DateTime d = Convert.ToDateTime(tblThongtinHD.Rows[0][1]);
            exRange.Range["A1:C1"].Value = "Hà Nội, ngày " + d.Day + " tháng " + d.Month + " năm " + d.Year;
            exRange.Range["A2:C2"].MergeCells = true;
            exRange.Range["A2:C2"].Font.Italic = true;
            exRange.Range["A2:C2"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A2:C2"].Value = "Nhân viên bán hàng";
            exRange.Range["A6:C6"].MergeCells = true;
            exRange.Range["A6:C6"].Font.Italic = true;
            exRange.Range["A6:C6"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A6:C6"].Value = tblThongtinHD.Rows[0][6];
            exSheet.Name = "Hóa đơn bán";
            exApp.Visible = true;



        }

        private void cmbMaNV_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string str;
            if (cmbMaNV.Text == "")
            {
                txtTenNV.Text = "";
            }
            //
            str = "select TenNV from nhan_vien where MaNV = N'" + cmbMaNV.SelectedValue + "'";
            txtTenNV.Text = DAO.GetFieldValues(str);
   
    }

        private void cmbMabinh_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            DAO.OpenConnection();
            string str;
            if (cmbMabinh.Text == "")
            {
                txtTenbinh.Text = "";
                txtDongia.Text = "";

            }
            str = "select tenbinh from DM_Binh_ga where mabinh = N'" + cmbMabinh.SelectedValue + "'";
            txtTenbinh.Text = DAO.GetFieldValues(str);
            str = "select dongiaban from DM_Binh_ga where mabinh = N'" + cmbMabinh.SelectedValue + "'";
            txtDongia.Text = DAO.GetFieldValues(str);

        }

        private void cmbMaKH_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string str;
            if (cmbMaKH.Text == "")
            {
                txtTenKH.Text = "";
                txtDiachi.Text = "";
                txtDienthoai.Text = "";

            }
            str = "select tenkhach from khach_hang where makhach =N'" + cmbMaKH.SelectedValue + "'";
            txtTenKH.Text = DAO.GetFieldValues(str);
            str = "select diachi from khach_hang where makhach =N'" + cmbMaKH.SelectedValue + "'";
            txtDiachi.Text = DAO.GetFieldValues(str);
            str = "select dienthoai from khach_hang where makhach =N'" + cmbMaKH.SelectedValue + "'";
            txtDienthoai.Text = DAO.GetFieldValues(str);
        }

        private void DataGridViewChiTiet_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            DAO.OpenConnection();
            txtTenbinh.Text = DataGridViewChiTiet.CurrentRow.Cells["tenbinh"].Value.ToString();
            txtSoluong.Text = DataGridViewChiTiet.CurrentRow.Cells["soluong"].Value.ToString();
            txtSoHDB.Text = DataGridViewChiTiet.CurrentRow.Cells["sohdb"].Value.ToString();
            txtNgayBan.Text = DAO.ConvertDateTime(DataGridViewChiTiet.CurrentRow.Cells["ngayban"].Value.ToString());
            txtDongia.Text = DataGridViewChiTiet.CurrentRow.Cells["dongiaban"].Value.ToString();
            txtGiamgia.Text = DataGridViewChiTiet.CurrentRow.Cells["giamgia"].Value.ToString();
            txtThanhtien.Text = DataGridViewChiTiet.CurrentRow.Cells["thanhtien"].Value.ToString();
            cmbMabinh.Text = DataGridViewChiTiet.CurrentRow.Cells["mabinh"].Value.ToString();
            cmbMaKH.Text = DataGridViewChiTiet.CurrentRow.Cells["makh"].Value.ToString();
            cmbMaNV.Text = DataGridViewChiTiet.CurrentRow.Cells["manv"].Value.ToString();
        }

        

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

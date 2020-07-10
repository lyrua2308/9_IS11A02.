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



namespace hoa_don_nhap
{
    public partial class BaoCaoKhachHang : Form
    {
        DataTable BCKH;
        public BaoCaoKhachHang()
        {
            InitializeComponent();
        }

        private void bt_batdau_Click(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;
            BaoCaoKhachHang_Load(sender, e);
        }

        private void bt_thongke_Click(object sender, EventArgs e)
        {

            if (comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Bạn chưa nhập tháng");
                comboBox1.Focus();
                return;
            }
            if (comboBox2.SelectedIndex == -1)
            {
                MessageBox.Show("Bạn chưa nhập năm");
                comboBox2.Focus();
                return;
            }
            string sql = " select Hoa_don_ban.Makhach,Tenkhach,Diachi,Dienthoai,ngayban,chi_tiet_hoa_don_ban.mabinh ,"
                       + "  chi_tiet_hoa_don_ban.soluong as so_luong,giamgia,dbo.DM_Binh_ga.dongiaban,thanhtien,tenbinh "
                      + "from Hoa_don_ban join Khach_hang on Hoa_don_ban.MaKhach = Khach_hang.Makhach JOIN dbo.Chi_tiet_hoa_don_ban "
                      + " ON hoa_don_ban.sohdb = chi_tiet_hoa_don_ban.sohdb JOIN "
                       + "dbo.DM_Binh_ga ON chi_tiet_hoa_don_ban.mabinh = dm_binh_ga.mabinh"
                       + " where MONTH(ngayban) =" + comboBox1.SelectedValue + " and YEAR(ngayban)=" + comboBox2.SelectedValue;


            BCKH = DAO.GetDataToTable(sql);
            if (BCKH.Rows.Count == 0)
            {
                MessageBox.Show("không có bản ghi nào thỏa mãn điều kiện", "thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("có" + BCKH.Rows.Count + "bản ghi thỏa mãn điều kiện", "thông báo",
                      MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            DAO.loatdata(sql, dataGridView1);
        }

        private void BaoCaoKhachHang_Load(object sender, EventArgs e)
        {
            DAO.OpenConnection();
            string sql1 = "select DISTINCT month(ngayban) as thang from hoa_don_ban order by month(ngayban) asc";
            DAO.FillCombo(sql1, comboBox1, "thang", "thang");
            string sql2 = "select DISTINCT year(ngayban) as  nam from hoa_don_ban order by year(ngayban)";
            DAO.FillCombo(sql2, comboBox2, "nam", "nam");
            string sql = " select Hoa_don_ban.Makhach,Tenkhach,Diachi,Dienthoai,ngayban,chi_tiet_hoa_don_ban.mabinh ,"
                       + " chi_tiet_hoa_don_ban.soluong as so_luong,giamgia,dbo.DM_Binh_ga.dongiaban,thanhtien,tenbinh "
                      + "from Hoa_don_ban join Khach_hang on Hoa_don_ban.MaKhach = Khach_hang.Makhach JOIN dbo.Chi_tiet_hoa_don_ban "
                      + " ON hoa_don_ban.sohdb = chi_tiet_hoa_don_ban.sohdb JOIN "
                       + "dbo.DM_Binh_ga ON chi_tiet_hoa_don_ban.mabinh = dm_binh_ga.mabinh";
            DAO.loatdata(sql, dataGridView1);
            DAO.CloseConnection();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string sql = "select sum(thanhtien) from  hoa_don_ban JOIN dbo.Chi_tiet_hoa_don_ban "
                      + " ON hoa_don_ban.sohdb = chi_tiet_hoa_don_ban.sohdb" +
                "  where makhach='" + dataGridView1.CurrentRow.Cells["mak"] + "'";
            labeltongtien.Text = DAO.GetFieldValues(sql);
        }

        private void bt_inbaocao_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Bạn chưa nhập tháng");
                comboBox1.Focus();
                return;
            }
            if (comboBox2.SelectedIndex == -1)
            {
                MessageBox.Show("Bạn chưa nhập năm");
                comboBox2.Focus();
                return;
            }
            COMExcel.Application exApp = new COMExcel.Application();
            COMExcel.Workbook exBook;
            COMExcel.Worksheet exSheet;
            COMExcel.Range exRange;
            string sql, sql1;
            int hang = 0, cot = 0;
            DataTable danhsach;
            DataTable danhsach1;

            exBook = exApp.Workbooks.Add(COMExcel.XlWBATemplate.xlWBATWorksheet);
            exSheet = exBook.Worksheets[1];
            exRange = exSheet.Cells[1, 1];
            exRange.Range["A1:Z300"].Font.Name = "Times new roman";
            exRange.Range["A1:B3"].Font.Size = 14;
            exRange.Range["A1:B3"].Font.Bold = true;
            exRange.Range["A1:B3"].Font.ColorIndex = 5;
            exRange.Range["A1:A1"].ColumnWidth = 16;
            exRange.Range["B1:C1"].ColumnWidth = 16;
            exRange.Range["A1:C1"].MergeCells = true;
            exRange.Range["A1:C1"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A1:C1"].Value = "Đại lý bán ga nhóm 9";
            exRange.Range["A2:C2"].MergeCells = true;
            exRange.Range["A2:C2"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A2:C2"].Value = "75 Thái Hà-Đống Đa-Hà Nội";
            exRange.Range["A3:C3"].MergeCells = true;
            exRange.Range["A3:C3"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A3:C3"].Value = "Điện thoại: 0866162243";
            exRange.Range["E2:J2"].Font.Size = 14;
            exRange.Range["E2:J2"].Font.Bold = true;
            exRange.Range["E2:J2"].Font.ColorIndex = 3;
            exRange.Range["E2:J2"].MergeCells = true;
            exRange.Range["E2:J2"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["E2:J2"].Value = "Báo Cáo Khách Hàng Trong Tháng " + comboBox1.SelectedValue + " Năm " + comboBox2.SelectedValue;
            sql = " select hoa_don_ban.sohdb,Hoa_don_ban.Makhach,Tenkhach,Dienthoai,diachi,ngayban,chi_tiet_hoa_don_ban.mabinh ,"
                      + " tenbinh, chi_tiet_hoa_don_ban.soluong as so_luong,dbo.DM_Binh_ga.dongiaban,giamgia,thanhtien "
                     + "from Hoa_don_ban join Khach_hang on Hoa_don_ban.MaKhach = Khach_hang.Makhach JOIN dbo.Chi_tiet_hoa_don_ban "
                     + " ON hoa_don_ban.sohdb = chi_tiet_hoa_don_ban.sohdb JOIN "
                      + "dbo.DM_Binh_ga ON chi_tiet_hoa_don_ban.mabinh = dm_binh_ga.mabinh"
                      + " where MONTH(ngayban) =" + comboBox1.SelectedValue + " and YEAR(ngayban)=" + comboBox2.SelectedValue;
            sql1 = "select SUM(TongTien) from hoa_Don_ban where MONTH(ngayban) =" + comboBox1.SelectedValue + " and YEAR(ngayban)=" + comboBox2.SelectedValue;
            danhsach = DAO.GetDataToTable(sql);
            danhsach1 = DAO.GetDataToTable(sql1);

            exRange.Range["B5:G5"].Font.Bold = true;
            exRange.Range["B5:G5"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["B5:B5"].ColumnWidth = 8;
            exRange.Range["C5:C5"].ColumnWidth = 8;
            exRange.Range["D5:D5"].ColumnWidth = 11;
            exRange.Range["E5:E5"].ColumnWidth = 22;
            exRange.Range["F5:F5"].ColumnWidth = 11;
            exRange.Range["G5:G5"].ColumnWidth = 11;
            exRange.Range["H5:H5"].ColumnWidth = 15;
            exRange.Range["I5:I5"].ColumnWidth = 10;
            exRange.Range["J5:J5"].ColumnWidth = 11;
            exRange.Range["K5:K5"].ColumnWidth = 11;
            exRange.Range["L5:L5"].ColumnWidth = 11;
            exRange.Range["M5:M5"].ColumnWidth = 11;
            exRange.Range["C4:D4"].Font.Bold = true;
            exRange.Range["C4:D4"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["C4:D4"].Font.Size = 16;


            exRange.Range["E5:E5"].Font.Bold = true;
            exRange.Range["E5:E5"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["B5:B5"].Value = "STT";
            exRange.Range["C5:C5"].Value = "Số HĐB";
            exRange.Range["D5:D5"].Value = "Mã Khách";
            //exRange.Range["G5:G5"].Value = "Địa Chỉ";
            exRange.Range["E5:E5"].Value = "Tên Khách";
            exRange.Range["F5:F5"].Value = "Số điện thoại";
            exRange.Range["G5:G5"].Value = "Địa chỉ";
            exRange.Range["H5:H5"].Value = "Ngày mua";

            exRange.Range["I5:I5"].Value = "Mã bình";
            exRange.Range["J5:J5"].Value = "Tên bình";
            exRange.Range["K5:K5"].Value = "Số lượng";
            exRange.Range["L5:L5"].Value = "Đơn Giá";
            exRange.Range["M5:M5"].Value = "Giảm giá";
            exRange.Range["N5:N5"].Value = "Thành Tiền";

            for (hang = 0; hang < danhsach.Rows.Count; hang++)
            {
                exSheet.Cells[2][hang + 6] = hang + 1;
                for (cot = 0; cot < danhsach.Columns.Count; cot++)
                {
                    exSheet.Cells[cot + 3][hang + 6] = danhsach.Rows[hang][cot].ToString();
                }
            }

            /*exRange = exSheet.Cells[2][hang + 8];
            exRange.Range["D1:E1"].MergeCells = true;
            exRange.Range["D1:E1"].Font.Italic = true;
            exRange.Range["D1:E1"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["D1:E1"].Value = "Tổng tiền các hóa đơn: " + danhsach1.Rows[0][0].ToString();
            exRange.Range["D2:F2"].MergeCells = true;
            exRange.Range["D2:F2"].Font.Italic = true;
            exRange.Range["D2:F2"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["D2:F2"].Value = "Bằng chữ: " + DAO.ChuyenSoSangChu(danhsach1.Rows[0][0].ToString());*/


            exRange = exSheet.Cells[2][hang + 8];
            exRange.Range["D4:F4"].MergeCells = true;
            exRange.Range["D4:F4"].Font.Italic = true;
            exRange.Range["D4:F4"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["D4:F4"].Value = "Hà Nội, Ngày " + DateTime.Now.ToShortDateString();

            exRange.Range[" D5: F5 "].Value = " Nhân viên lập báo cáo ";
            exRange.Range[" D5: F5 "].MergeCells = true;
            exRange.Range["D5: F5 "].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range[" D6: F6 "].Value = " (Kí, Ghi rõ họ tên)";
            exRange.Range[" D6: F6 "].MergeCells = true;
            exRange.Range["D6: F6 "].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exSheet.Name = " BÁO CÁO KHÁCH HÀNG";
            exApp.Visible = true;





        }

        private void bt_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

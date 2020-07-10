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
    public partial class BaoCaoDoanhThu : Form
    {
        DataTable BCDT;
        public BaoCaoDoanhThu()
        {
            InitializeComponent();
        }

        private void bt_thongke_Click(object sender, EventArgs e)
        {
            DAO.OpenConnection();
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
            string sql = "select sum(thanhtien) as tong_tien,DM_binh_ga.dongiaban," +
                "dm_binh_ga.mabinh,tenbinh,sum(chi_tiet_hoa_don_ban.soluong) as so_luong, ngayban " +

                "from chi_tiet_Hoa_don_ban join dm_binh_ga on " +
                "chi_tiet_hoa_don_ban.mabinh = dm_binh_ga.mabinh join hoa_don_ban on hoa_don_ban.sohdb = chi_tiet_hoa_don_ban.sohdb " +
                     " where MONTH(ngayban)=" + comboBox1.SelectedValue + " and YEAR(ngayban)=" + comboBox2.SelectedValue +

                         " group BY dm_binh_ga.mabinh,tenbinh,DM_binh_ga.dongiaban,ngayban ";
            BCDT = DAO.GetDataToTable(sql);
            if (BCDT.Rows.Count == 0)
            {
                MessageBox.Show("không có bản ghi nào thỏa mãn điều kiện", "thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("có" + BCDT.Rows.Count + "bản ghi thỏa mãn điều kiện", "thông báo",
                      MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            DAO.loatdata(sql, dataGridViewdoanhthu);



            labeldoanhthu.Text = DAO.GetFieldValues("SELECT SUM(thanhtien) FROM dbo.Chi_tiet_hoa_don_ban JOIN dbo.Hoa_don_ban ON hoa_don_ban.sohdb = chi_tiet_hoa_don_ban.sohdb  " +
                " where MONTH(ngayban)=" + comboBox1.SelectedValue + " and YEAR(ngayban)=" + comboBox2.SelectedValue);
            DAO.CloseConnection();
        }

      

        private void BaoCaoDoanhThu_Load(object sender, EventArgs e)
        {
            DAO.OpenConnection();
            string sql1 = "select distinct month(ngayban) as thang from hoa_don_ban order by month(ngayban) asc";
            DAO.FillCombo(sql1, comboBox1, "thang", "thang");
            string sql2 = "select distinct year(ngayban) as  nam from hoa_don_ban order by year(ngayban)";
            DAO.FillCombo(sql2, comboBox2, "nam", "nam");
            string sql = "select sum(thanhtien) as tong_tien,DM_binh_ga.dongiaban," +
                "dm_binh_ga.mabinh,tenbinh,sum(chi_tiet_hoa_don_ban.soluong) as so_luong," +
                " ngayban" +
                " from chi_tiet_Hoa_don_ban join dm_binh_ga on " +
                "chi_tiet_hoa_don_ban.mabinh = dm_binh_ga.mabinh join hoa_don_ban on hoa_don_ban.sohdb = chi_tiet_hoa_don_ban.sohdb " +


                         " group BY dm_binh_ga.mabinh,tenbinh,DM_binh_ga.dongiaban,ngayban";

            DAO.loatdata(sql, dataGridViewdoanhthu);
            DAO.CloseConnection();
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
            exRange.Range["E2:J2"].Value = "Báo Cáo Doanh Thu Cửa Hàng Theo Tháng " + comboBox1.SelectedValue + " Năm " + comboBox2.SelectedValue;
            sql = " select hoa_don_ban.sohdb,chi_tiet_hoa_don_ban.mabinh ,"
                      + " tenbinh, chi_tiet_hoa_don_ban.soluong as so_luong,dbo.DM_Binh_ga.dongiaban,giamgia,thanhtien "
                     + "from Hoa_don_ban join dbo.Chi_tiet_hoa_don_ban "
                     + " ON hoa_don_ban.sohdb = chi_tiet_hoa_don_ban.sohdb join dm_binh_ga on dm_binh_ga.mabinh=chi_tiet_hoa_don_ban.mabinh "
                      + " where MONTH(ngayban) =" + comboBox1.SelectedValue + " and YEAR(ngayban)=" + comboBox2.SelectedValue;
            sql1 = "SELECT SUM(thanhtien) FROM dbo.Chi_tiet_hoa_don_ban JOIN dbo.Hoa_don_ban ON hoa_don_ban.sohdb = chi_tiet_hoa_don_ban.sohdb  " +
                " where MONTH(ngayban)=" + comboBox1.SelectedValue + " and YEAR(ngayban)=" + comboBox2.SelectedValue;
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

            exRange.Range["C4:D4"].Font.Bold = true;
            exRange.Range["C4:D4"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["C4:D4"].Font.Size = 16;


            exRange.Range["E5:E5"].Font.Bold = true;
            exRange.Range["E5:E5"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["B5:B5"].Value = "STT";
            exRange.Range["C5:C5"].Value = "Số HĐB";


            exRange.Range["D5:D5"].Value = "Mã bình";
            exRange.Range["E5:E5"].Value = "Tên bình";
            exRange.Range["F5:F5"].Value = "Số lượng";
            exRange.Range["G5:G5"].Value = "Đơn Giá";
            exRange.Range["H5:H5"].Value = "Giảm giá";
            exRange.Range["I5:I5"].Value = "Thành Tiền";





            for (hang = 0; hang < danhsach.Rows.Count; hang++)
            {
                exSheet.Cells[2][hang + 6] = hang + 1;
                for (cot = 0; cot < danhsach.Columns.Count; cot++)
                {
                    exSheet.Cells[cot + 3][hang + 6] = danhsach.Rows[hang][cot].ToString();
                }
            }

            exRange = exSheet.Cells[2][hang + 8];
            exRange.Range["D1:E1"].MergeCells = true;
            exRange.Range["D1:E1"].Font.Italic = true;
            exRange.Range["D1:E1"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["D1:E1"].Value = "Tổng tiền các hóa đơn: " + danhsach1.Rows[0][0].ToString();
            exRange.Range["D2:F2"].MergeCells = true;
            exRange.Range["D2:F2"].Font.Italic = true;
            exRange.Range["D2:F2"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["D2:F2"].Value = "Bằng chữ: " + DAO.ChuyenSoSangChu(danhsach1.Rows[0][0].ToString());


            exRange = exSheet.Cells[2][hang + 8];
            exRange.Range["D4:F4"].MergeCells = true;
            exRange.Range["D4:F4"].Font.Italic = true;
            exRange.Range["D4:F4"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["D4:F4"].Value = "Hà Nội, Ngày " + DateTime.Now.ToShortDateString();

            exRange.Range[" D5: F5 "].Value = " Nhân viên lập báo cáo ";
            exRange.Range[" D5: F5 "].MergeCells = true;
            exRange.Range["D5: F5 "].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range[" D5: F5 "].Value = " (Kí, Ghi rõ họ tên)";
            exSheet.Name = " Doanh thu";
            exApp.Visible = true;
        }

        private void bt_batdau_Click_1(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;
            BaoCaoDoanhThu_Load(sender, e);
        }

        private void bt_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}


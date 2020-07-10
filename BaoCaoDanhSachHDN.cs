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
    public partial class BaoCaoDanhSachHDN : Form
    {
        public BaoCaoDanhSachHDN()
        {
            InitializeComponent();
        }

        private void BaoCaoDanhSachHDN_Load(object sender, EventArgs e)
        {
            DAO.OpenConnection();
            string sql = "select Chi_tiet_hoa_don_nhap.SoHDN,NgayNhap, nha_cc.MaNCC,TenNCC," +
                "Dienthoai,Mabinh,Soluong,GIAMGIA,Dongia,Thanhtien from Nha_cc join Hoa_don_nhap on " +
                "Nha_cc.MaNCC = Hoa_don_nhap.MaNCC join Chi_tiet_hoa_don_nhap " +
                "on Hoa_don_nhap.SoHDN = Chi_tiet_hoa_don_nhap.SoHDN";
            DAO.loatdata(sql, datagridview_DSHDN);
            DAO.FillCombo("select * from nha_cc", comboBox1, "mancc", "mancc");
            goiy();
            // textBoxtenncc.AutoCompleteMode = AutoCompleteMode.Suggest;
            //  textBoxtenncc.AutoCompleteSource = AutoCompleteSource.CustomSource;
            // AutoCompleteStringCollection DataCollection = new AutoCompleteStringCollection();
            // getda (DataCollection);
            //  textBox1.AutoCompleteCustomSource = DataCollection;
            DAO.CloseConnection();
        }
        private void goiy()
        {
            string sql = "select distinct tenncc from Nha_cc ";



            SqlDataReader reader = DAO.getDataReader(sql);

            AutoCompleteStringCollection auto = new AutoCompleteStringCollection();

            if (reader != null)

            {

                while (reader.Read())

                {

                    auto.Add(reader["tenncc"].ToString());

                }

            }
            textBoxtenncc.AutoCompleteMode = AutoCompleteMode.SuggestAppend;

            textBoxtenncc.AutoCompleteSource = AutoCompleteSource.CustomSource;

            textBoxtenncc.AutoCompleteCustomSource = auto;

            reader.Close();

        }

        private void bt_batdau_Click(object sender, EventArgs e)
        {

            text_nam.Text = "";
            comboBox1.SelectedIndex = -1;
            BaoCaoDanhSachHDN_Load(sender, e);
        }

       
        private void bt_inbaocao_Click(object sender, EventArgs e)
        {
            if (text_nam.Text == "")
            {
                MessageBox.Show("bạn phải nhập năm báo cáo");
                text_nam.Focus();
                return;
            }
            if (comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("bạn phải chọn mã nhà cung cấp");
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
            exRange.Range["E2:J2"].Value = "Báo Cáo Nhập Hàng Từ " + textBoxtenncc.Text + " Trong Tháng " +numeric_thang.Value + " Năm " + text_nam.Text;
            sql = "select Chi_tiet_hoa_don_nhap.SoHDN, nha_cc.MaNCC,TenNCC," +
                "Dienthoai,NgayNhap,dm_binh_ga.Mabinh,tenbinh,chi_tiet_hoa_don_nhap.Soluong,GIAMGIA,chi_tiet_hoa_don_nhap.Dongia,Thanhtien from Nha_cc join Hoa_don_nhap on " +
                "Nha_cc.MaNCC = Hoa_don_nhap.MaNCC join Chi_tiet_hoa_don_nhap " +
                "on Hoa_don_nhap.SoHDN = Chi_tiet_hoa_don_nhap.SoHDN join dm_binh_ga on Dm_binh_ga.mabinh=chi_tiet_hoa_don_nhap.mabinh  where month(ngaynhap)='"
                + numeric_thang.Value + "' and year(ngaynhap)='" + text_nam.Text + "'" +
                "AND nha_cc.mancc='" + comboBox1.SelectedValue + "'";
            sql1 = "select SUM(TongTien) from hoa_don_nhap  where (MONTH(NgayNhap) = '" + numeric_thang.Value + "') AND (YEAR(NgayNhap) = '" + text_nam.Text + "'" +
                " and mancc='"+comboBox1.SelectedValue+"')";
            danhsach = DAO.GetDataToTable(sql);
            danhsach1 = DAO.GetDataToTable(sql1);

            exRange.Range["B5:G5"].Font.Bold = true;
            exRange.Range["B5:G5"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["B5:B5"].ColumnWidth = 8;
            exRange.Range["C5:C5"].ColumnWidth = 8;
            exRange.Range["D5:D5"].ColumnWidth = 11;
            exRange.Range["E5:E5"].ColumnWidth = 15;
            exRange.Range["F5:F5"].ColumnWidth = 11;
            exRange.Range["G5:G5"].ColumnWidth = 15;
            exRange.Range["H5:H5"].ColumnWidth = 10;
            exRange.Range["I5:I5"].ColumnWidth = 15;
            exRange.Range["J5:J5"].ColumnWidth = 11;
            exRange.Range["K5:K5"].ColumnWidth = 11;
            exRange.Range["L5:L5"].ColumnWidth = 11;
            exRange.Range["M5:M5"].ColumnWidth = 11;
            exRange.Range["C4:C4"].Font.Bold = true;
            exRange.Range["C4:C4"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;



            exRange.Range["E5:E5"].Font.Bold = true;
            exRange.Range["E5:E5"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["B5:B5"].Value = "STT";
            exRange.Range["C5:C5"].Value = "Số HĐN";
            exRange.Range["D5:D5"].Value = "Mã NCC";
            exRange.Range["E5:E5"].Value = "Tên NCC";
            exRange.Range["F5:F5"].Value = "Điện thoại";
            exRange.Range["G5:G5"].Value = "Ngày nhập";

            exRange.Range["H5:H5"].Value = "Mã bình";
            exRange.Range["I5:I5"].Value = "Tên bình";
            exRange.Range["J5:J5"].Value = "Số lượng";
            exRange.Range["K5:K5"].Value = "Đơn Giá";
            exRange.Range["L5:L5"].Value = "Giảm giá";
            exRange.Range["M5:M5"].Value = "Thành Tiền";
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
            exRange.Range["D1:E1"].Value = "Tổng tiền các hóa đơn: " + danhsach1.Rows[0][0];
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
            exSheet.Name = " NHẬP HÀNG";
            exApp.Visible = true;

        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DAO.OpenConnection();
            string str;
            if (comboBox1.Text == "")
                textBoxtenncc.Text = "";

            str = "Select Tenncc from nha_cc where Mancc =N'" + comboBox1.SelectedValue + "'";
            textBoxtenncc.Text = DAO.GetFieldValues(str);
            DAO.CloseConnection();
        }

        private void bt_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_thongke_Click_1(object sender, EventArgs e)
        {
            if (text_nam.Text == "")
            {
                MessageBox.Show("bạn phải nhập năm báo cáo");
                text_nam.Focus();
                return;
            }
            if (comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("bạn phải chọn mã nhà cung cấp");
            }
            DAO.OpenConnection();
            string sql = "select Chi_tiet_hoa_don_nhap.SoHDN,NgayNhap, nha_cc.MaNCC,TenNCC," +
                "Dienthoai,Mabinh,Soluong,GIAMGIA,Dongia,Thanhtien from Nha_cc join Hoa_don_nhap on " +
                "Nha_cc.MaNCC = Hoa_don_nhap.MaNCC join Chi_tiet_hoa_don_nhap " +
                "on Hoa_don_nhap.SoHDN = Chi_tiet_hoa_don_nhap.SoHDN where month(ngaynhap)='"
                + numeric_thang.Value + "' and year(ngaynhap)='" + text_nam.Text + "'" +
                "AND nha_cc.mancc='" + comboBox1.SelectedValue + "'";
            DAO.loatdata(sql, datagridview_DSHDN);
            // LBTONG=
            string sql1 = "select sum(thanhtien)  from Nha_cc join Hoa_don_nhap on " +
               "Nha_cc.MaNCC = Hoa_don_nhap.MaNCC join Chi_tiet_hoa_don_nhap " +
               "on Hoa_don_nhap.SoHDN = Chi_tiet_hoa_don_nhap.SoHDN  where month(ngaynhap)='"
               + numeric_thang.Value + "' and year(ngaynhap)='" + text_nam.Text + "' and " +
               " hoa_don_nhap.mancc='" + comboBox1.SelectedValue + "'";
            LBTONG.Text = DAO.GetFieldValues(sql1);
            DAO.CloseConnection();
        }
    }
   

}

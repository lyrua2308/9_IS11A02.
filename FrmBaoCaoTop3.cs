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
using COMExcel = Microsoft.Office.Interop.Excel;


namespace hoa_don_nhap
{
    public partial class FrmBaoCaoTop3 : Form
    {
        public FrmBaoCaoTop3()
        {
            InitializeComponent();
        }
        private void goiy()
        {
            string sql = "select distinct tennv from nhan_vien where tennv like '%"+combo_manv.Text+"%'";



            SqlDataReader reader = DAO.getDataReader(sql);

            AutoCompleteStringCollection auto = new AutoCompleteStringCollection();

            if (reader != null)

            {

                while (reader.Read())

                {

                    auto.Add(reader["tennv"].ToString());

                }

            }
            combo_manv.AutoCompleteMode = AutoCompleteMode.SuggestAppend;

            combo_manv.AutoCompleteSource = AutoCompleteSource.CustomSource;

            combo_manv.AutoCompleteCustomSource = auto;

            reader.Close();

        }
        private void FrmBaoCaoTop3_Load(object sender, EventArgs e)
        {
            DAO.OpenConnection();
            goiy();
            string sql = "SELECT c.MaNV,TenNV,a.Mabinh,d.Tenbinh, sum(a.Soluong) as soluong from " +
                "Chi_tiet_hoa_don_ban as a join Hoa_don_ban as b on a.SoHDB = b.SoHDB join " +
                "Nhan_vien  as c on c.MaNV = b.MaNV join DM_Binh_ga as d on " +
                "d.Mabinh = a.Mabinh group by tenbinh ,c.MaNV, TenNV, a.mabinh, tenbinh order by soluong ASC";
            DAO.loatdata(sql, dataGridView1);
            DAO.FillCombo("SELECT MaNV, TenNV FROM nhan_vien", combo_manv, "TenNV", "MaNV");
            DAO.CloseConnection();
        }
        private void bt_batdau_Click_1(object sender, EventArgs e)
        {
            
            combo_manv.Text = "";
            combo_manv.Focus();

        }

        private void bt_thongke_Click(object sender, EventArgs e)
        {
         

            if (combo_manv.Text=="")
            {
                MessageBox.Show("Bạn chưa chọn nhân viên ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                combo_manv.Focus();
                return;
            }
            string sql;
            sql= "SELECT TOP 3 c.MaNV,TenNV,a.Mabinh,d.Tenbinh, sum(a.Soluong) as soluong from " +
                "Chi_tiet_hoa_don_ban as a join Hoa_don_ban as b on a.SoHDB = b.SoHDB join " +
                "Nhan_vien  as c on c.MaNV = b.MaNV join DM_Binh_ga as d on " +
                "d.Mabinh = a.Mabinh where c.manv = '"+combo_manv.SelectedValue.ToString()+
                "' group by tenbinh ,c.MaNV, TenNV, a.mabinh, tenbinh order by soluong ASC";
            SqlDataAdapter myAdapter = new SqlDataAdapter(sql, DAO.Conn);
            DataTable sanpham = new DataTable();
            myAdapter.Fill(sanpham);
            dataGridView1.DataSource =sanpham;
        }

        private void bt_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_inbaocao_Click(object sender, EventArgs e)
        {

            if (combo_manv.SelectedIndex==-1)
            {
                MessageBox.Show("Bạn chưa chọn mã nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                combo_manv.Focus();
                return;
            }
            COMExcel.Application exApp = new COMExcel.Application();
            COMExcel.Workbook exBook;
            COMExcel.Worksheet exSheet;
            COMExcel.Range exRange;
            string sql;
            int hang = 0, cot = 0;
            DataTable danhsach;

            exBook = exApp.Workbooks.Add(COMExcel.XlWBATemplate.xlWBATWorksheet);
            exSheet = exBook.Worksheets[1];
            exRange = exSheet.Cells[1, 1];
            exRange.Range["A1:Z300"].Font.Name = "Times new roman";
            exRange.Range["A1:B3"].Font.Size = 10;
            exRange.Range["A1:B3"].Font.Bold = true;
            exRange.Range["A1:B3"].Font.ColorIndex = 5;
            exRange.Range["A1:A1"].ColumnWidth = 7;
            exRange.Range["B1:B1"].ColumnWidth = 15;
            exRange.Range["A1:B1"].MergeCells = true;
            exRange.Range["A1:B1"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A1:B1"].Value = "Cửa hàng bán Ga";
            exRange.Range["A2:B2"].MergeCells = true;
            exRange.Range["A2:B2"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A2:B2"].Value = "Đội Cấn - Hà Nội";
            exRange.Range["A3:B3"].MergeCells = true;
            exRange.Range["A3:B3"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A3:B3"].Value = "Điện thoại: 01635612685";
            exRange.Range["C2:G2"].Font.Size = 16;
            exRange.Range["C2:G2"].Font.Bold = true;
            exRange.Range["C2:G2"].Font.ColorIndex = 3;
            exRange.Range["C2:G2"].MergeCells = true;
            exRange.Range["C2:G2"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["C2:G2"].Value = "Báo cáo top 3 sản phẩm được bán ít nhất theo nhân viên ";

            sql = "SELECT TOP 3 c.MaNV,TenNV,a.Mabinh,d.Tenbinh, sum(a.Soluong) as soluong from Chi_tiet_hoa_don_ban as a join Hoa_don_ban as b on a.SoHDB = b.SoHDB join Nhan_vien  as c on c.MaNV = b.MaNV join DM_Binh_ga as d on d.Mabinh = a.Mabinh where c.manv = '" + combo_manv.SelectedValue.ToString() + "' group by tenbinh ,c.MaNV, TenNV, a.mabinh, tenbinh order by soluong ASC";



            danhsach = DAO.GetDataToTable(sql);

            exRange.Range["B5:G5"].Font.Bold = true;
            exRange.Range["B5:G5"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["B5:B5"].ColumnWidth = 12;
            exRange.Range["C5:C5"].ColumnWidth = 11;
            exRange.Range["D5:D5"].ColumnWidth = 23;
            exRange.Range["E5:E5"].ColumnWidth = 23;
            exRange.Range["F5:F5"].ColumnWidth = 23;
            exRange.Range["G5:G5"].ColumnWidth = 23;
            exRange.Range["B5:B5"].Value = "STT";
            exRange.Range["C5:C5"].Value = "Mã NV";
            exRange.Range["D5:D5"].Value = "Tên NV";
            exRange.Range["E5:E5"].Value = "Mã bình";
            exRange.Range["F5:F5"].Value = "Tên bình";
            exRange.Range["G5:G5"].Value = "soluong";


            for (hang = 0; hang < danhsach.Rows.Count; hang++)
            {
                exSheet.Cells[2][hang + 6] = hang + 1;
                for (cot = 0; cot < danhsach.Columns.Count; cot++)
                {
                    exSheet.Cells[cot + 3][hang + 6] = danhsach.Rows[hang][cot].ToString();
                }
            }

            exRange = exSheet.Cells[2][hang + 8];
            exRange.Range["D4:F4"].MergeCells = true;
            exRange.Range["D4:F4"].Font.Italic = true;
            exRange.Range["D4:F4"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["D4:F4"].Value = "Hà Nội, Ngày " + DateTime.Now.ToShortDateString();

            exRange.Range[" D5: F5 "].Value = " Nhân viên lập báo cáo ";
            exRange.Range[" D5: F5 "].MergeCells = true;
            exRange.Range["D5: F5 "].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range[" D5: F5 "].Value = " (Kí, Ghi rõ họ tên)";
            exApp.Visible = true;
            exSheet.Name = "Báo cáo";
            exApp.Visible = true;
        }
    }
}

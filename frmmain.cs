
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hoa_don_nhap
{
    public partial class frmmain : Form
    {
        public frmmain()
        {
            InitializeComponent();
        }

       
        private void báoCáoHóaĐơnNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BaoCaoDanhSachHDN f1 = new BaoCaoDanhSachHDN();
            f1.Show();
        }

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void loạiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Loaics f1 = new Loaics();
            f1.Show();
        }

        private void khốiLượngToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            KhoiLuong f1 = new KhoiLuong();
            f1.Show();
        }

        private void màuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mau f1 = new Mau();
            f1.Show();

        }

        private void nướcSXXToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NuocSX f1 = new NuocSX();
            f1.Show();
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NhanVien f1 = new NhanVien();
            f1.Show();
        }

        private void caLàmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CaLam f1 = new CaLam();
            f1.Show();
        }

        private void côngViêcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CongViec f1 = new CongViec();
            f1.Show();
        }

        private void quảnLýNhàCungCấpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NhaCungCap f1 = new NhaCungCap();
            f1.Show();

        }

        private void quảnLýKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            khachhang f1 = new khachhang();
            f1.Show();
        }

        private void nhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
        }

        private void bánToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HoaDonBan f1 = new HoaDonBan();
            f1.Show();
        }

        private void báoCáoTop3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBaoCaoTop3 f1 = new FrmBaoCaoTop3();
            f1.Show();
        }

        private void báoCáoDoanhThuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BaoCaoDoanhThu f1 = new BaoCaoDoanhThu();
            f1.Show();
        }

        private void báoCáoKháchHàngMuaHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BaoCaoKhachHang f1 = new BaoCaoKhachHang();
            f1.Show();
        }

        private void dMBìnhGaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDMBinhGa f1 = new FrmDMBinhGa();
            f1.Show();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }

}

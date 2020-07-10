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
    public partial class frmDangKy : Form
    {
        public frmDangKy()
        {
            InitializeComponent();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void frmDangkyTK_Load(object sender, EventArgs e)
        {
            txtMatKhau.Enabled = false;
            txtTaiKhoan.Enabled = false;
            btnLuu.Enabled = false;
        }
        private void reset()
        {
            txtMatKhau.Text = "";
            txtTaiKhoan.Text = "";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnLuu.Enabled = true;
            txtMatKhau.Enabled = true;
            txtTaiKhoan.Enabled = true;
            txtTaiKhoan.Focus();
            reset();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            DAO.OpenConnection();
            String sql="insert into taikhoan Values('"+txtTaiKhoan.Text+"','"+txtMatKhau.Text+"')";
            DAO.RunSql(sql);
            MessageBox.Show("ban da dang ki tai khoan thanh cong");

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}

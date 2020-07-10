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

namespace hoa_don_nhap
{
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }
        private void DangNhap_Load(object sender, EventArgs e)
        {

        }

        private void btDangnhap_Click(object sender, EventArgs e)
        {
            if(txtTaikhoan.Text=="")
            {
                MessageBox.Show("Bạn chưa nhập tài khoản");
                txtTaikhoan.Focus();
                return ;

            }   
            if(txtMatkhau.Text=="")
            {
                MessageBox.Show("Bạn chưa nhập mật khẩu");
                txtMatkhau.Focus();
                return;
            }    
            DAO.OpenConnection();

            {
                DataTable tk;
                //string sql = "select count(*) from taikhoan where taikhoan='" + txtTaikhoan.Text + "' and matkhau='" + txtMatkhau.Text + "'";

                string sql1 = "select * from taikhoan where taikhoan='" + txtTaikhoan.Text + "' and matkhau='" + txtMatkhau.Text + "'";
                DAO.OpenConnection();
                tk = DAO.GetDataToTable(sql1);
                //tk1 = DAO.GetDataToTable(sql);
               // SqlCommand cmd = new SqlCommand(sql, DAO.Conn);
               // SqlDataReader reader = cmd.ExecuteReader();
                if (tk.Rows.Count>0)
                {
                    this.Hide();
                    Form main = new frmmain();
                    main.Show();
                }
                else
                {
                    string sql = "select matkhau from taikhoan where taikhoan='" + txtTaikhoan.Text + "'";
                    if (txtMatkhau.Text != DAO.GetFieldValues(sql).ToString())
                    {
                        MessageBox.Show("bạn nhập sai mật khẩu hoặc tài khoản không tồn tại,hãy nhập lại");
                        txtMatkhau.Text = "";
                        txtTaikhoan.Text = "";
                    }

                }

            }
        }
        
            

        private void checkBoxHienthi_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxHienthi.Checked)
            {
                txtMatkhau.UseSystemPasswordChar = false;
            }
            else
            {
                txtMatkhau.UseSystemPasswordChar = true;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Form  frmDangKy = new frmDangKy();
            frmDangKy.Show();
        }
    }
}


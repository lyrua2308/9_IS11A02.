using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hoa_don_nhap
{
    public partial class CongViec : Form
    {
        public CongViec()
        {
            InitializeComponent();
        }

        //private void CongViec_Load(object sender, EventArgs e)
        private void loaddata()
        {
            string sql = "select * from cong_viec";
            DAO.loatdata(sql, dataGridViewcv);
        }
        private void CongViec_Load(object sender, EventArgs e)
        {
            loaddata();
        }

        private void dataGridViewcv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxmacv.Text = dataGridViewcv.CurrentRow.Cells["macv"].Value.ToString();
            textBoxtencv.Text = dataGridViewcv.CurrentRow.Cells["tencv"].Value.ToString();
            textBoxmacv.Enabled = false;
        }

        private void buttonthem_Click(object sender, EventArgs e)
        {
            textBoxmacv.Enabled = true;
            textBoxmacv.Text = "";
            textBoxtencv.Text = "";

        }

        private void buttonthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonsua_Click(object sender, EventArgs e)
        {
            string sql = "update cong_viec set tencv=N'" + textBoxtencv.Text + "'where macv=N'" + textBoxmacv.Text + "'";
            DAO.RunSqlDel(sql);
            loaddata();
        }

        private void buttonxoa_Click(object sender, EventArgs e)
        {
            string sql = "delete from cong_viec where macv=N'" + textBoxmacv.Text + "'";
            DAO.RunSql(sql);
            loaddata();
        }

        private void buttonluu_Click(object sender, EventArgs e)
        {
            string sql = "insert into cong_viec values (N'" + textBoxmacv.Text + "',N'" + textBoxtencv.Text + "')";
            DAO.OpenConnection();
            string sqlCheck = "select * from cong_viec where macv=N'" + textBoxmacv.Text + "'";
            if (DAO.CheckKey(sqlCheck))
            {
                MessageBox.Show("Công việc đã tồn tại");
                DAO.CloseConnection();
                textBoxmacv.Enabled = true;
                textBoxmacv.Focus();
                return;
            }
            else
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandText = sql;
                cmd.Connection = DAO.Conn;
                cmd.ExecuteNonQuery();

                loaddata();

                DAO.CloseConnection();
            }
        }

        private void buttonthoat_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

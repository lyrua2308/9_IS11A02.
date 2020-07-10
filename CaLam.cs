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
    public partial class CaLam : Form
    {
        public CaLam()
        {
            InitializeComponent();
        }

        //private void CaLam_Load(object sender, EventArgs e)
        private void buttonsua_Click(object sender, EventArgs e)
        {
            string sql = "update ca_lam set tenca=N'" + textBoxtenca.Text + "' where maca=N'" + textBoxmaca.Text + "'";
            DAO.RunSql(sql);
            loaddata();
        }
        private void loaddata()
        {
            string sql = "select * from Ca_lam";
            DAO.loatdata(sql, dataGridView1);
        }
       
    

        private void buttonthem_Click(object sender, EventArgs e)
        {
            textBoxmaca.Enabled = true;
            textBoxmaca.Text = "";
            textBoxtenca.Text = "";
        }

        private void buttonxoa_Click(object sender, EventArgs e)
        {
            string sql = "delete from ca_lam where maca=N'" + textBoxmaca.Text + "'";
            DAO.RunSqlDel(sql);
            loaddata();
        }

        private void buttonthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonluu_Click(object sender, EventArgs e)
        {
            if (textBoxmaca.Text == "")
            {
                MessageBox.Show("bạn chưa nhập mã ca");
                textBoxmaca.Focus();
            }
            if (textBoxtenca.Text == "")
            {
                MessageBox.Show("bạn chưa nhập ten ca");
                textBoxtenca.Focus();



            }
            string sql = "insert into ca_lam values (N'" + textBoxmaca.Text + "',N'" + textBoxtenca.Text + "')";
            DAO
                .OpenConnection();
            string sqlCheck = "select * from ca_lam where maca=N'" + textBoxmaca.Text.Trim() + "'";
            if (DAO.CheckKey(sqlCheck))
            {
                MessageBox.Show("Ca làm đã tồn tại");
                DAO.CloseConnection();
                textBoxmaca.Enabled = true;
                textBoxmaca.Focus();
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

        private void CaLam_Load(object sender, EventArgs e)
        {
            loaddata();
        }

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            textBoxmaca.Text = dataGridView1.CurrentRow.Cells["maca"].Value.ToString();
            textBoxtenca.Text = dataGridView1.CurrentRow.Cells["tenca"].Value.ToString();
            textBoxmaca.Enabled = false;
        }
    }
}

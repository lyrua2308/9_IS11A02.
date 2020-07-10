using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;
using System.Globalization;

namespace hoa_don_nhap
{
    class DAO
    {

        public static SqlConnection Conn;
        static string ConnectionString = "Data Source=.;Initial Catalog=baitaplon;Integrated Security=True";
        public static void OpenConnection()
        {
            Conn = new SqlConnection();
            Conn.ConnectionString = ConnectionString;
            if (Conn.State == System.Data.ConnectionState.Closed) 
            try
            {
                Conn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }


        }
        public static void CloseConnection()
        {
            if (Conn.State == System.Data.ConnectionState.Open)
                try
                {
                    Conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
        }
        public static DataTable GetDataToTable(string sql)
        {
            SqlDataAdapter Mydata = new SqlDataAdapter();	// Khai báo
            // Tạo đối tượng Command thực hiện câu lệnh SELECT        
            Mydata.SelectCommand = new SqlCommand();
            Mydata.SelectCommand.Connection = DAO.Conn; 	// Kết nối CSDL
            Mydata.SelectCommand.CommandText = sql;	// Gán câu lệnh SELECT
            DataTable table = new DataTable();    // Khai báo DataTable nhận dữ liệu trả về
            Mydata.Fill(table); 	//Thực hiện câu lệnh SELECT và đổ dữ liệu vào bảng table
            return table;
        }
        public static bool CheckKey(string sql)
        {
            SqlDataAdapter Mydata = new SqlDataAdapter(sql, DAO.Conn);
            DataTable table = new DataTable();
            Mydata.Fill(table);
            if (table.Rows.Count > 0)
                return true;
            else
                return false;
        }
        public static void RunSql(string sql)
        {
            DAO.OpenConnection();
            SqlCommand cmd;		                // Khai báo đối tượng SqlCommand
            cmd = new SqlCommand();	         // Khởi tạo đối tượng
            cmd.Connection = DAO.Conn;	  // Gán kết nối
            cmd.CommandText = sql;			  // Gán câu lệnh SQL
            try
            {
                cmd.ExecuteNonQuery();		  // Thực hiện câu lệnh SQL
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            cmd.Dispose();
            cmd = null;
            DAO.CloseConnection();
        }
        public static void RunSqlDel(string sql)
        {
            DAO.OpenConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = DAO.Conn;
            cmd.CommandText = sql;
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (System.Exception)
            {
                MessageBox.Show("Dữ liệu đang được dùng, không thể xóa...", "Thông báo",
MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            cmd.Dispose();
            cmd = null;
            DAO.CloseConnection();
        }
        public static void FillCombo(string sql, ComboBox cbo, string DisplayField, string valuesField)
        {
                SqlDataAdapter adapter = new SqlDataAdapter(sql,Conn);
                DataTable Table = new DataTable();
                adapter.Fill(Table);
                cbo.DataSource = Table;
                cbo.ValueMember = valuesField;
                cbo.DisplayMember = DisplayField;
            
        }
        public static void fillDataToCombo(string sql, ComboBox combo, string valuesfield, string displayfield)
        {
            SqlDataAdapter adapter = new SqlDataAdapter(sql, Conn);
            DataTable mytable = new DataTable();
            adapter.Fill(mytable);
            combo.DataSource = mytable;
            combo.ValueMember = valuesfield;
            combo.DisplayMember = displayfield;
        }
        public static string GetFieldValues(string sql)
        {
            DAO.OpenConnection();
            string ma = "";
            SqlCommand cmd = new SqlCommand(sql, DAO.Conn);
            SqlDataReader reader;
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                ma = reader.GetValue(0).ToString();
            }
            reader.Close();
            return ma;
            
        }
        public static void loatdata(string sql, DataGridView dataGridView)
        {


            DAO.OpenConnection();

            SqlDataAdapter myAdater = new SqlDataAdapter(sql, DAO.Conn);
            DataTable table = new DataTable();
            myAdater.Fill(table);
            dataGridView.DataSource = table;
            DAO.CloseConnection();
        }
        public static SqlDataReader getDataReader(string sql)

        {

            OpenConnection();

            SqlCommand com = new SqlCommand(sql,Conn);

            SqlDataReader dr = com.ExecuteReader();

            return dr;

        }
        public static bool IsDate(string d)
        {
            string[] parts = d.Split('/');
            if ((Convert.ToInt32(parts[0]) >= 1) && (Convert.ToInt32(parts[0]) <= 31) &&
(Convert.ToInt32(parts[1]) >= 1) && (Convert.ToInt32(parts[1]) <= 12) && (Convert.ToInt32(parts[2]) >= 1900))
                return true;
            else
                return false;
        }
        public static string ConvertDateTime(string d)
        {
            var date = DateTime.Parse(d);
             string[] parts = d.Split('/');
             string dt = string.Format("{0}/{1}/{2}  yyyy-MM-dd", parts[1], parts[0], parts[2]);

            return date.ToString("yyyy-MM-dd");
        }
        public static string ConvertDateTime1(string d)
        {
            var date = DateTime.ParseExact(d, "yyyy-MM-dd", CultureInfo.InvariantCulture);
           // string[] parts = d.Split('/');
           // string dt = string.Format("{0}/{1}/{2}  yyyy-MM-dd", parts[1], parts[0], parts[2]);

            return date.ToString("yyyy-MM-dd");
        }


        public static string ChuyenSoSangChu(string sNumber)
        {
            int mLen, mDigit;
            string mTemp = "";
            string[] mNumText;
            sNumber = sNumber.Replace(",", "");
            mNumText = "không;một;hai;ba;bốn;năm;sáu;bảy;tám;chín".Split(';');
            mLen = sNumber.Length - 1;
            for (int i = 0; i <= mLen; i++)
            {
                mDigit = Convert.ToInt32(sNumber.Substring(i, 1));
                mTemp = mTemp + " " + mNumText[mDigit];
                if (mLen == i)
                    break;
                switch ((mLen - i) % 9)
                {
                    case 0:
                        mTemp = mTemp + " tỷ";
                        if (sNumber.Substring(i + 1, 3) == "000")
                            i = i + 3;
                        if (sNumber.Substring(i + 1, 3) == "000")
                            i = i + 3;
                        if (sNumber.Substring(i + 1, 3) == "000")
                            i = i + 3;
                        break;
                    case 6:
                        mTemp = mTemp + " triệu";
                        if (sNumber.Substring(i + 1, 3) == "000")
                            i = i + 3;
                        if (sNumber.Substring(i + 1, 3) == "000")
                            i = i + 3;
                        break;
                    case 3:
                        mTemp = mTemp + " nghìn";
                        if (sNumber.Substring(i + 1, 3) == "000")
                            i = i + 3;
                        break;
                    default:
                        switch ((mLen - i) % 3)
                        {
                            case 2:
                                mTemp = mTemp + " trăm";
                                break;
                            case 1:
                                mTemp = mTemp + " mươi";
                                break;
                        }
                        break;
                }
            }
            mTemp = mTemp.Replace("không mươi không ", "");
            mTemp = mTemp.Replace("không mươi không", "");
            mTemp = mTemp.Replace("không mươi ", "linh ");
            mTemp = mTemp.Replace("mươi không", "mươi");
            mTemp = mTemp.Replace("một mươi", "mười");
            mTemp = mTemp.Replace("mươi bốn", "mươi tư");
            mTemp = mTemp.Replace("linh bốn", "linh tư");
            mTemp = mTemp.Replace("mươi năm", "mươi lăm");
            mTemp = mTemp.Replace("mươi một", "mươi mốt");
            mTemp = mTemp.Replace("mười năm", "mười lăm");
            mTemp = mTemp.Trim();
            mTemp = mTemp.Substring(0, 1).ToUpper() + mTemp.Substring(1) + " đồng";
            return mTemp;
        }
        public static string ConvertTimeTo24(string hour)
        {
            string h = "";
            switch (hour)
            {
                case "1":
                    h = "13";
                    break;
                case "2":
                    h = "14";
                    break;
                case "3":
                    h = "15";
                    break;
                case "4":
                    h = "16";
                    break;
                case "5":
                    h = "17";
                    break;
                case "6":
                    h = "18";
                    break;
                case "7":
                    h = "19";
                    break;
                case "8":
                    h = "20";
                    break;
                case "9":
                    h = "21";
                    break;
                case "10":
                    h = "22";
                    break;
                case "11":
                    h = "23";
                    break;
                case "12":
                    h = "0";
                    break;
            }
            return h;
        }

        public static string CreateKey(string tiento)
        {
            string key = tiento;
            string[] partsDay;
            partsDay = DateTime.Now.ToShortDateString().Split('/');
            string d = String.Format("{0}{1}{2}", partsDay[0], partsDay[1], partsDay[2]);
            key = key + d;
            string[] partsTime;
            partsTime = DateTime.Now.ToLongTimeString().Split(':');
            if (partsTime[2].Substring(3, 2) == "PM")
                partsTime[0] = ConvertTimeTo24(partsTime[0]);
            if (partsTime[2].Substring(3, 2) == "AM")
                if (partsTime[0].Length == 1)
                    partsTime[0] = "0" + partsTime[0];
            partsTime[2] = partsTime[2].Remove(2, 3);
            string t;
            t = String.Format("_{0}{1}{2}", partsTime[0], partsTime[1], partsTime[2]);
           key = key + t;
            return key;
        }
       
        public static string matudong(string tiento, DataTable x)
        {
            string g;
            if (x.Rows.Count == 0)
            {
                g = tiento + "001";
            }
            else
            {
                int k;
                g = tiento;
                k = Convert.ToInt32(x.Rows[x.Rows.Count - 1][0].ToString().Substring(3, 3));
                k = k + 1;
                if (k < 10)
                {
                    g = g + "00";
                }
                if (k >= 10 && k <= 99)
                {
                    g = g + "0";
                }
                g = g + k.ToString();
            }
            return g;
        }

    }

}

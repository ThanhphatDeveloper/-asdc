using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAO
{


    public class DataProvider
    {
        public SqlConnection cn = new SqlConnection();
        public void Ketnoi()
        {
            try
            {
                if (cn.State == 0)
                {
                    cn.ConnectionString = @"Data Source=DESKTOP-8R0VE7P\SQLEXPRESS;Initial Catalog=NCP;Integrated Security=True";
                    cn.Open();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Ngatketnoi()
        {
            if (cn.State != 0)
            {
                cn.Close();
            }
        }

        // Hiển thị Dữ Liệu DataGridview

        public DataTable XemDLDGV(string sql, DataGridView dgv)
        {
            Ketnoi();

            SqlDataAdapter adap = new SqlDataAdapter(sql, cn);
            DataTable dt = new DataTable();
            adap.Fill(dt);
            dgv.DataSource = dt;
            Ngatketnoi();
            return dt;
        }

        public DataTable XemDL(string sql)
        {
            Ketnoi();
            SqlDataAdapter adap = new SqlDataAdapter(sql, cn);
            DataTable dt = new DataTable();
            adap.Fill(dt);
            Ngatketnoi();
            return dt;
        }
        //Phương thức truy vấn dữ liệu: Insert, Update, Delete
        public SqlCommand ThucThiDl(string sql)
        {
            Ketnoi();

            SqlCommand cm = new SqlCommand(sql, cn);
            int i = cm.ExecuteNonQuery();
            if (i > 0)
            {
                MessageBox.Show("Thành công");
            }
            else
            {
                MessageBox.Show("Không thành công");
            }
            Ngatketnoi();
            return cm;
        }
        public SqlDataReader getdata(string sql)
        {
            Ketnoi();
            SqlCommand cmd = new SqlCommand(sql, cn);
            SqlDataReader reader = cmd.ExecuteReader();
            return reader;
        }


//              ███████]▄▄▄▄▄▄▄▄▃
//         ▂▄▅█████████▅▄▃▂
//        [███████████████████]
//        ◥⊙▲⊙▲⊙▲⊙▲⊙▲⊙▲⊙▲⊙▲⊙▲⊙◤…

        public int Insert(string sql)
        {
            Ketnoi();
            SqlCommand cmd = new SqlCommand(sql, cn);
            int count = cmd.ExecuteNonQuery();
            Ngatketnoi();
            return count;
        }
        public int Update(string sql)
        {
            Ketnoi();
            SqlCommand cmd = new SqlCommand(sql, cn);
            int count = cmd.ExecuteNonQuery();
            Ngatketnoi();
            return count;
        }
        public int Delete(string sql)
        {
            Ketnoi();
            SqlCommand cmd = new SqlCommand(sql, cn);
            int count = cmd.ExecuteNonQuery();
            Ngatketnoi();
            return count;
        }
        //...
        public Int64 GetDataScalar(string sql)
        {
            Ketnoi();
            SqlCommand cmd = new SqlCommand(sql, cn);
            object data = cmd.ExecuteScalar();
            Int64 count = Convert.ToInt64(data);
            Ngatketnoi();
            return count;
        }
        public object GetDataScalarObj(string sql)
        {
            Ketnoi();
            SqlCommand cmd = new SqlCommand(sql, cn);
            object data = cmd.ExecuteScalar();
            Ngatketnoi();
            return data;
        }

        public Int64 GetTong(string sql)
        {
            try
            {
                return this.GetDataScalar(sql);
            }
            catch
            {
                return 0;
            }

        }
        //..
        public string GetMaxPNId(string sql)
        {

            try
            {
                Object maxPNId = this.GetDataScalarObj(sql);
                return Convert.ToString(maxPNId);
            }
            catch
            {
                return "";
            }
        }
    }


}

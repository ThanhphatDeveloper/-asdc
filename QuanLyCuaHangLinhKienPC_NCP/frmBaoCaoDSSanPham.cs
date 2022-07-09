using CrystalDecisions.CrystalReports.Engine;
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

namespace QuanLyCuaHangLinhKienPC_NCP
{
    public partial class frmBaoCaoDSSanPham : Form
    {
        public frmBaoCaoDSSanPham()
        {
            InitializeComponent();
        }

        private void frmBaoCaoDSSanPham_Load(object sender, EventArgs e)
        {
          /*  ReportDocument rptDoc = new ReportDocument();
            // tập tin .xsd
            QuanLyCuaHangLinhKienPC_NCP.DSSanPham ds = new QuanLyCuaHangLinhKienPC_NCP.DSSanPham();
            DataTable dt = new DataTable();
            // Đặt tên cho DataTable
            dt.TableName = "Crystal Report Example";
            dt = getAllGeres();//Gọi phương thức getAllGenres
            ds.Tables[0].Merge(dt);
            // Lấy đường dẫn tập tin crystal report (CrystalReport.rpt)
            string reportPath = "D:\\GitHub\\QuanLyCuaHangLinhKienPC_NCP [Ver0.3 - Add CrystalReport]\\QuanLyCuaHangLinhKienPC_NCP\\" + "crysRptDSSanPham.rpt";
            rptDoc.Load(reportPath);
            //gán dataset đến report viewer
            rptDoc.SetDataSource(ds);
            crysRpvBaoCaoDSSanPham.ReportSource = rptDoc;
            crysRpvBaoCaoDSSanPham.DisplayToolbar = true;*/
        }
        public DataTable getAllGeres()
        {
            string connectionString = null;
            connectionString = @"Data Source=.;Initial Catalog=NCP;Integrated Security=True";
            SqlConnection Con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand();
            DataSet ds = null;
            SqlDataAdapter adapter = default(SqlDataAdapter);
            try
            {
                Con.Open();
                cmd.CommandText = "SELECT * FROM SanPham";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = Con;
                ds = new DataSet();
                adapter = new SqlDataAdapter(cmd);
                adapter.Fill(ds, "SanPham");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                cmd.Dispose();
                if (Con.State != ConnectionState.Closed)
                {
                    Con.Close();
                }
            }
            return ds.Tables[0];
        }
    }
}


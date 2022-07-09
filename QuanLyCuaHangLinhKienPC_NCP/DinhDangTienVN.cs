using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCuaHangLinhKienPC_NCP
{
    public static class DinhDangTienVN
    {
        public static string DinhDangTienVND(decimal tien)
        {
            return string.Format(new CultureInfo("vi-VN"), "{0:#,##0}", tien);
        }
    }
}

using DBLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace BALayer
{
    internal class DBDoanhThu
    {
        DAL db = null;

        public DBDoanhThu()
        {
            db = new DAL();
        }

        public DataSet LayThongTinDoanhThu()
        {
            return db.ExecuteQueryDataSet("select * from DoanhThu", CommandType.Text, null);
        }

        public bool ThemDoanhThu(ref string err, int SoThuTu, string MaHoaDon, int TongTien, DateTime NgayNhapDoanhThu, string MaNhanVien)
        {
            return db.MyExecuteNonQuery("spThemDoanhThu", CommandType.StoredProcedure, ref err,
                new SqlParameter("@SoThuTu", SoThuTu),
                new SqlParameter("@MaHoaDon", MaHoaDon),
                new SqlParameter("@TongTien", TongTien),
                new SqlParameter("@NgayNhapDoanhThu", NgayNhapDoanhThu),
                new SqlParameter("@MaNhanVien", MaNhanVien));
        }
    }
}

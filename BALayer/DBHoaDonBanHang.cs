using DBLayer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BALayer
{
    public class DBHoaDonBanHang
    {
        DAL db = null;

        public DBHoaDonBanHang()
        {
            db = new DAL();
        }

        public DataSet LayThongTinHoaDonBanHang()
        {
            return db.ExecuteQueryDataSet("select * from HoaDonBanHang", CommandType.Text, null);
        }

        public bool ThemHoaDonBanHang(ref string err, string MaHoaDonBanHang, string MaBan, int TongTien, DateTime NgayXuatHoaDon,
                                        string MaNhanVien)
        {
            return db.MyExecuteNonQuery("spThemHoaDonBanHang", CommandType.StoredProcedure, ref err,
                new SqlParameter("@MaHoaDonBanHang", MaHoaDonBanHang),
                new SqlParameter("@MaBan", MaBan),
                new SqlParameter("@TongTien", TongTien),
                new SqlParameter("@NgayXuatHoaDon", NgayXuatHoaDon),
                new SqlParameter("@MaNhanVien", MaNhanVien));
        }
    }
}

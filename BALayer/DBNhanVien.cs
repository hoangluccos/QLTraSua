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
    internal class DBNhanVien
    {
        DAL db = null;

        public DBNhanVien()
        {
            db = new DAL();
        }

        public DataSet LayThongTinNhanVien()
        {
            return db.ExecuteQueryDataSet("select * from NhanVien", CommandType.Text, null);
        }

        public bool ThemNhanVien(ref string err, string MaNhanVien, string HoTen, int GioiTinh, DateTime NgaySinh)
        {
            return db.MyExecuteNonQuery("spThemNhanVien", CommandType.StoredProcedure, ref err,
                new SqlParameter("@MaNhanVien", MaNhanVien),
                new SqlParameter("@HoTen", HoTen),
                new SqlParameter("@GioiTinh", GioiTinh),
                new SqlParameter("@NgaySinh", NgaySinh));
        }
        public bool CapNhatNhanVien(ref string err, string MaNhanVien, string HoTen, int GioiTinh, DateTime NgaySinh)
        {
            return db.MyExecuteNonQuery("spCapNhatNhanVien", CommandType.StoredProcedure, ref err,
                new SqlParameter("@MaNhanVien", MaNhanVien),
                new SqlParameter("@HoTen", HoTen),
                new SqlParameter("@GioiTinh", GioiTinh),
                new SqlParameter("@NgaySinh", NgaySinh));
        }

        public bool XoaNhanVien(ref string err, string MaNhanVien)
        {
            return db.MyExecuteNonQuery("spXoaNhanVien", CommandType.StoredProcedure,
                ref err, new SqlParameter("@MaNhanVien", MaNhanVien));
        }
    }
}

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
    public class DBNguyenLieu
    {
        DAL db = null;

        public DBNguyenLieu()
        {
            db = new DAL();
        }

        public DataSet LayThongTinNguyenLieu()
        {
            return db.ExecuteQueryDataSet("select * from NguyenLieu", CommandType.Text, null);
        }

        public bool ThemNguyenLieu(ref string err, string MaNguyenLieu, string TenNguyenLieu, int DonGia)
        {
            return db.MyExecuteNonQuery("spThemNguyenLieu", CommandType.StoredProcedure, ref err,
                new SqlParameter("@MaNguyenLieu", MaNguyenLieu),
                new SqlParameter("@TenNguyenLieu", TenNguyenLieu),
                new SqlParameter("@DonGia", DonGia));
        }

        public bool CapNhatGiaNguyenLieu(ref string err, string MaNguyenLieu, int DonGia)
        {
            return db.MyExecuteNonQuery("spCapNhatGiaNguyenLieu", CommandType.StoredProcedure, ref err,
                new SqlParameter("@MaNguyenLieu", MaNguyenLieu),
                new SqlParameter("@DonGia", DonGia));
        }
    }
}

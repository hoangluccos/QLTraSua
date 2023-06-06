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
    internal class DBDangNhap
    {
        DAL db = null;

        public DBDangNhap()
        {
            db = new DAL();
        }

        public bool CheckDangNhap(ref string err, string TaiKhoan, string MatKhau)
        {
            return db.MyExecuteNonQuery("spDangNhap", CommandType.StoredProcedure, ref err,
                new SqlParameter("@TaiKhoan", TaiKhoan),
                new SqlParameter("@MatKhau", MatKhau));
        }
    }
}

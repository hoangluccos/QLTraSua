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
    public class DBBan
    {
        DAL db = null;

        public DBBan()
        {
            db = new DAL();
        }

        public DataSet LayThongTinBan()
        {
            return db.ExecuteQueryDataSet("select * from Ban", CommandType.Text, null);
        }

        public bool ThemBan(ref string err, string MaBan, int SoChoNgoi)
        {
            return db.MyExecuteNonQuery("spThemBan", CommandType.StoredProcedure, ref err,
                new SqlParameter("@MaBan", MaBan),
                new SqlParameter("@SoChoNgoi", SoChoNgoi));
        }

        public bool XoaBan(ref string err, string MaBan)
        {
            return db.MyExecuteNonQuery("spXoaBan", CommandType.StoredProcedure, ref err,
                new SqlParameter("@MaBan", MaBan));
        }

        public bool CapNhatTinhTrangBan(ref string err, string MaBan)
        {
            return db.MyExecuteNonQuery("spCapNhatTinhTrang", CommandType.StoredProcedure, ref err,
                new SqlParameter("@MaBan", MaBan));
        }
    }
}
}

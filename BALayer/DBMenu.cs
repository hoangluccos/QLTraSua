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
    public class DBMenu
    {
        DAL db = null;

        public DBMenu()
        {
            db = new DAL();
        }

        public DataSet LayThongTinMenuTS()
        {
            return db.ExecuteQueryDataSet("select * from Menu where MaMon LIKE 'TS%'", CommandType.Text, null);
        }
        public DataSet LayThongTinMenuYK()
        {
            return db.ExecuteQueryDataSet("select * from Menu where MaMon LIKE 'YA%'", CommandType.Text, null);
        }
        public DataSet LayThongTinMenuToping()
        {
            return db.ExecuteQueryDataSet("select * from Menu where MaMon LIKE 'TP%'", CommandType.Text, null);
        }
        public DataSet LayThongTinMenuTT()
        {
            return db.ExecuteQueryDataSet("select * from Menu where MaMon LIKE 'TT%'", CommandType.Text, null);
        }

        public bool ThemMon(ref string err, string MaMon, string TenMon, int DonGia)
        {
            return db.MyExecuteNonQuery("spThemMon", CommandType.StoredProcedure, ref err,
                new SqlParameter("@MaMon", MaMon),
                new SqlParameter("@TenMon", TenMon),
                new SqlParameter("@DonGia", DonGia));
        }

        public bool XoaMon(ref string err, string MaMon)
        {
            return db.MyExecuteNonQuery("spXoaMon", CommandType.StoredProcedure, ref err,
                new SqlParameter("@MaMon", MaMon));
        }

        public bool CapNhatGiaMon(ref string err, string MaMon, int DonGia)
        {
            return db.MyExecuteNonQuery("spCapNhatGiaMon", CommandType.StoredProcedure, ref err,
                new SqlParameter("@MaMon", MaMon),
                new SqlParameter("@DonGia", DonGia));
        }
    }
}

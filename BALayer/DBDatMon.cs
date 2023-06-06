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
    public class DBDatMon
    {
        DAL db = null;

        public DBDatMon()
        {
            db = new DAL();
        }

        public DataSet LayThongTinDatMon(string MaBan)
        {
            return db.ExecuteQueryDataSet("select * from DatMon", CommandType.Text, null);
        }

        public bool ThemDatMon(ref string err, string MaBan, string MaMon, int SoLuong, int DonGia, int ThanhTien)
        {
            return db.MyExecuteNonQuery("spThemDatMon", CommandType.StoredProcedure, ref err,
                new SqlParameter("@MaBan", MaBan),
                new SqlParameter("@MaMon", MaMon),
                new SqlParameter("SoLuong", SoLuong),
                new SqlParameter("@DonGia", DonGia),
                new SqlParameter("@ThanhTien", ThanhTien));
        }

        public bool CapNhatDatMon(ref string err, string MaBan, string MaMon, int SoLuong, int DonGia, int ThanhTien)
        {
            return db.MyExecuteNonQuery("spCapNhatDatMon", CommandType.StoredProcedure, ref err,
                new SqlParameter("@MaBan", MaBan),
                new SqlParameter("@MaMon", MaMon),
                new SqlParameter("SoLuong", SoLuong),
                new SqlParameter("@DonGia", DonGia),
                new SqlParameter("@ThanhTien", ThanhTien));
        }

        public bool Xoa1DatMon(ref string err, string MaBan, string MaMon)
        {
            return db.MyExecuteNonQuery("spXoa1DatMon", CommandType.StoredProcedure, ref err,
                new SqlParameter("@MaBan", MaBan),
                new SqlParameter("@MaMon", MaMon));
        }

        public bool XoaAllDatMon(ref string err, string MaBan)
        {
            return db.MyExecuteNonQuery("spXoaAllDatMon", CommandType.StoredProcedure, ref err,
                new SqlParameter("@MaBan", MaBan));
        }
    }
}

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
    public class DBHoaDonNhapHang
    {
        DAL db = null;

        public DBHoaDonNhapHang()
        {
            db = new DAL();
        }

        public DataSet LayThongTinHoaDonNhapHang()
        {
            return db.ExecuteQueryDataSet("select * from HoaDonNhapHang", CommandType.Text, null);
        }

        public bool ThemHoaDonNhapHang(ref string err, string MaHoaDonNhapHang, string MaNguyenLieu, int SoLuong, int DonGia,
                                        int ThanhTien, DateTime NgayNhapNguyenLieu, string MaNhanVien)
        {
            return db.MyExecuteNonQuery("spThemHoaDonNhapHang", CommandType.StoredProcedure, ref err,
                new SqlParameter("@MaHoaDonNhapHang", MaHoaDonNhapHang),
                new SqlParameter("@MaNguyenLieu", MaNguyenLieu),
                new SqlParameter("@SoLuong", SoLuong),
                new SqlParameter("@DonGia", DonGia),
                new SqlParameter("@ThanhTien", ThanhTien),
                new SqlParameter("@NgayNhapNguyenLieu", NgayNhapNguyenLieu),
                new SqlParameter("@MaNhanVien", MaNhanVien));
        }

        public bool XoaHoaDonNhapHang(ref string err, string MaHoaDonNhapHang)
        {
            return db.MyExecuteNonQuery("spXoaHoaDonNhapHang", CommandType.StoredProcedure, ref err,
                new SqlParameter("@MaHoaDonNhapHang", MaHoaDonNhapHang));
        }
    }
}

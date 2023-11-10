using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp3.DAL;

namespace WindowsFormsApp3.BLL
{
    public class NhanVien
    {
        Database db;
        public NhanVien()
        {
            db = new Database();
        }
        public DataTable LayDSNhanvien()
        {
            string strSQL = "Select MaNhanVien, HoTenNhanVien, NgaySinh, DiaChi, DienThoai, TenBangCap From NHANVIEN nv, BANGCAP bc WHERE nv.MaBangCap = bc.MaBangCap";
            DataTable dt = db.Execute(strSQL);
            //Goi phuong thuc truy xuat du lieu
            return dt;
        }

        public void XoaNhanVien(string index_nv)
        {
            string sql = "Delete from NhanVien where MaNhanVien = " + index_nv;
            db.ExecuteNonQuery(sql);
        }

        public void ThemNhanVien(string ten, string ngaysinh, string diachi, string dienthoai, string index_bc)
        {
            string sql = string.Format("INSERT INTO NhanVien Values (N'{0}', '{1}', N'{2}', '{3}', {4})", ten, ngaysinh, diachi, dienthoai, index_bc);
            db.ExecuteNonQuery(sql);
        }

        public void CapNhatNhanVien(string index_nv, string hoten, string ngaysinh, string diachi, string dienthoai, string index_bc)
        {
            string str = string.Format("UPDATE NHANVIEN SET HoTenNhanVien = N'{0}', NgaySinh = '{1}', DiaChi = N'{2}', DienThoai = '{3}', MaBangCap = {4} WHERE MaNhanVien = {5}", hoten, ngaysinh, diachi, dienthoai, index_bc, index_nv);
            db.ExecuteNonQuery(str);
        }
    }
}

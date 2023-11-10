using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp3.DAL;

namespace WindowsFormsApp3.BLL
{
    public class PhieuThuTien
    {
        Database db;
        public PhieuThuTien()
        {
            db = new Database();
        }
        public DataTable LayDSPhieuThu()
        {
            string strSQL = "Select * from PHIEUTHUTIEN";
            DataTable dt = db.Execute(strSQL); //Goi phuong thuc truy xuat du lieu
            return dt;
        }

        public void XoaPhieuThu(string index_pt)
        {
            string sql = "Delete from PHIEUTHUTIEN where MaPhieuThuTien = " + index_pt;
            db.ExecuteNonQuery(sql);
        }

        public void ThemPhieuThu(string tienno, string tienthu, string madocgia, string manv)
        {

            string sql = string.Format("Insert Into PHIEUTHUTIEN " +
                "Values({0}, {1}, {2}, {3})", tienno, tienthu, madocgia, manv);

            db.ExecuteNonQuery(sql);
        }


        public void CapNhatPhieuThu(string index_pt, string tienno, string tienthu, string madocgia, string manv)
        {
            //Chuẩn bị câu lẹnh truy vấn
            string str = string.Format("Update PHIEUTHUTIEN set SoTienNo = '{0}', SoTienThu = '{1}', MaDocGia = {2}, MaNhanVien = {3} where MaPhieuThuTien = {4}", tienno, tienthu, madocgia, manv, index_pt);
            db.ExecuteNonQuery(str);
        }
    }
}

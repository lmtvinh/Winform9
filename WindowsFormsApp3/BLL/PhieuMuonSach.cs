using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Microsoft.SqlServer.Server;
using WindowsFormsApp3.DAL;

namespace WindowsFormsApp3.BLL
{
    class PhieuMuonSach
    {
        Database db;
        public PhieuMuonSach()
        {
            db = new Database();
        }
        public DataTable LayDSPM()
        {
            string strSQL = "Select * from PHIEUMUONSACH";
            DataTable dt = db.Execute(strSQL);
            return dt;
        }

        public void XoaPhieuMuon(string index_pm)
        {
            string sql = "Delete from PHIEUMUONSACH where MaPhieuMuon = " + index_pm;
            db.ExecuteNonQuery(sql);

        }
        //Thêm  1  nhân  viên  mới
        public void ThemPhieuMuon(String dt, String madocgia)
        {
            string sql = string.Format("Insert Into PHIEUMUONSACH Values('{0}',N'{1}')", dt, madocgia);
            db.ExecuteNonQuery(sql);
        }
        //Cập  nhật  nhân  viên
        public void CapNhatPhieuMuon(String mpm, String dt, String madocgia)
        {
            //Chuẩn  bị  câu  lẹnh  truy  vấn
            string str = string.Format("Update PHIEUMUONSACH set NgayMuon= N'{0}', MaDocGia=N'{1}',MaPhieuMuon='{3}'", dt, madocgia, mpm);
            db.ExecuteNonQuery(str);

        }
    }


}

//Con  tiếp  cho  các  phuong  thuc  khác  như  thêm,  xóa,  sửa


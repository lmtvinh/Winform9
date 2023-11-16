using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Microsoft.SqlServer.Server;
using System.Windows.Forms;
using WindowsFormsApp3.DAL;

namespace WindowsFormsApp3.BLL
{
    class ChiTietPhieuMuon
    {
        Database db;
        public ChiTietPhieuMuon()
        {
            db = new Database();
        }
        public DataTable LayDSCTPM()
        {
            string strSQL = "Select * from CHITIETPHIEUMUON";
            DataTable dt = db.Execute(strSQL);
            //Goi phuong thuc truy xuat du lieu
            return dt;
        }

        public void XoaChiTietPhieuMuon(string index_pm)
        {
            string sql = "Delete from ChiTietPhieuMuon where MaPhieuMuon = " + index_pm;
            db.ExecuteNonQuery(sql);

        }
        //Thêm  1  nhân  viên  mới
        public void ThemChiTietPhieuMuon(String masach)
        {
            string check = string.Format("Select MaSach from SACH where MaSach='{0}'", masach);
            if (check != null)
            {
                string sql = string.Format("Insert Into CHITIETPHIEUMUON Values(N'{1}')", masach);
                db.ExecuteNonQuery(sql);
            }
            else
            {
                MessageBox.Show("Mã sách không tồn tại!");
            }
        }
        //Cập  nhật  nhân  viên
        public void CapNhatChiTietPhieuMuon(String mpm, String masach)
        {
            //Chuẩn  bị  câu  lẹnh  truy  vấn
            string str = string.Format("Update CHITIETPHIEUMUON set MaSach=N'{0}' where MaPhieuMuon='{1}'", masach, mpm);
            db.ExecuteNonQuery(str);

        }
    }


}

//Con  tiếp  cho  các  phuong  thuc  khác  như  thêm,  xóa,  sửa


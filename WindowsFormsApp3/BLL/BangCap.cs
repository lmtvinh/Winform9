using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp3.DAL;

namespace WindowsFormsApp3.BLL
{
    public class BangCap
    {
        Database db;
        public BangCap()
        {
            db = new Database();
        }
        public DataTable LayDSBC()
        {
            string strSQL = "Select * from BANGCAP"; DataTable dt = db.Execute(strSQL);
            //Goi phuong thuc truy xuat du lieu
            return dt;
        }
        public void XoaBangCap(string index_bc)
        {
            string sql = "Delete from BANGCAP where MaBangCap = " + index_bc;
            db.ExecuteNonQuery(sql);
        }
        //Thêm  1  nhân  viên  mới
        public void ThemBangCap(String name)
        {
            string sql = string.Format("Insert Into BangCap Values(N'{0}')", name);
            db.ExecuteNonQuery(sql);
        }
        //Cập  nhật  nhân  viên
        public void CapNhatBangCap(string ID, string name)
        {
            //Chuẩn  bị  câu  lẹnh  truy  vấn
            string str = string.Format("Update BANGCAP set TenBangCap= N'{0}', MaBangCap={1}", name, ID);
            db.ExecuteNonQuery(str);
        }
    }
}

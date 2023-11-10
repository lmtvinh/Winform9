using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp3.DAL;

namespace WindowsFormsApp3.BLL
{
    public class Sach
    {
        Database db;
        public Sach()
        {
            db = new Database();
        }
        public DataTable LayDSSach()
        {
            string strSQL = "Select * from SACH";
            DataTable dt = db.Execute(strSQL); //Goi phuong thuc truy xuat du lieu
            return dt;
        }
        public void XoaSach(string index_sa)
        {
            string sql = "Delete from SACH where MaSach = " + index_sa;
            db.ExecuteNonQuery(sql);
        }

        public void ThemSach(string ten, string tacgia, string namxb, string nhaxb, string trigia, string ngaynhap)
        {

            string sql = string.Format("Insert Into SACH " +
                "Values(N'{0}', N'{1}', {2}, N'{3}',{4}, '{5}')", ten, tacgia, namxb, nhaxb, trigia, ngaynhap); db.ExecuteNonQuery(sql);
        }


        public void CapNhatSach(string index_sa, string ten, string tacgia, string namxb, string nhaxb, string trigia, string ngaynhap)
        {
            //Chuẩn bị câu lẹnh truy vấn
            string str = string.Format("Update SACH set TenSach = N'{0}', TacGia = N'{1}', NamXuatBan = {2}, NhaXuatBan = N'{3}', TriGia = {4}, NgayNhap = '{5}' where MaSach = {6}", ten, tacgia, namxb, nhaxb, trigia, ngaynhap, index_sa); db.ExecuteNonQuery(str);
        }
    }
}

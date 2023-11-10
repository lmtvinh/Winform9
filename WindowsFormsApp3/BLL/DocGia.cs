using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp3.DAL;

namespace WindowsFormsApp3.BLL
{
    public class DocGia
    {
        Database db;
        public DocGia()
        {
            db = new Database();
        }
        public DataTable layDSDG()
        {
            string strSQL = "Select * from DOCGIA";
            DataTable dt = db.Execute(strSQL);
            return dt;
        }

        public void XoaDocGia(string index_dg)
        {
            string sql = "Delete from DOCGIA where MaDocGia = " +
            index_dg;
            db.ExecuteNonQuery(sql);
        }
        public void ThemDG(string hovaten, string ngaysinh, string diachi, string email, string ngaylapthe, string ngayhethan, string tienno)
        {
            string sql = string.Format("Insert Into DOCGIA " +
                "Values(N'{0}','{1}',N'{2}',N'{3}','{4}','{5}',{6})",
                hovaten, ngaysinh, diachi, email, ngaylapthe, ngayhethan, tienno);
            db.ExecuteNonQuery(sql);
        }
        public void CapNhatDG(string HoTenDocGia, string ngaysinh, string diachi, string email, string ngaylapthe, string ngayhethan, string tienno, string MaDocGia)
        {

            string str = string.Format("Update DOCGIA set HoTenDocGia = N'{0}', NgaySinh = '{1}', DiaChi = N'{2}', Email = N'{3}', NgayLapThe = '{4}',NgayHetHan = '{5}',TienNo='{6}' where MaDocGia = '{7}'",
            HoTenDocGia, ngaysinh, diachi, email, ngaylapthe, ngayhethan, tienno, MaDocGia);
            db.ExecuteNonQuery(str);
        }
    }
}

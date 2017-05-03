using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormQLTV.Data_Access_Layer
{
    class DAL_Sql_User
    {
        DAL_KetNoiDB kn = new DAL_KetNoiDB();

        public int checkLogin(string username, string password)
        {
            return (int)kn.GetValue(@"select count(*) from DangKyDocGia where username = '" + username + "' and password = '" + password + "'");
        }

        public int getMaxMaDocGia()
        {
            return (int)kn.GetValue(@"select MAX(docGiaMa) from DangKyDocGia");
        }

        public string getTenDocGia(string username, string password)
        {
            return (string)kn.GetValue(@"select dg.hoTen from DocGia dg inner join DangKyDocGia dkdg on dg.maDocGia = dkdg.docGiaMa where dkdg.username = '" + username + "' and dkdg.password = '" + password + "'");
        }

        public int checkRegister(string username)
        {
            return (int)kn.GetValue(@"select count(*) from DangKyDocGia where username = '" + username + "'");
        }

        public int getMaDocGia(string username, string password)
        {
            return (int)kn.GetValue(@"select docGiaMa from DangKyDocGia where username = '" + username + "' and password = '" + password + "'");
        }

        public string getTenDocGia(string maDocGia)
        {
            return (string)kn.GetValue(@"select dg.hoTen from DocGia dg inner join DangKyDocGia dkdg on dg.maDocGia = dkdg.docGiaMa where dkdg.docGiaMa = "+maDocGia);
        }

        public string getTen(string maDocGia)
        {
            return (string)kn.GetValue(@"select dg.hoTen from DocGia dg inner join DangKyDocGia dkdg on dg.maDocGia = dkdg.docGiaMa where dkdg.docGiaMa = " + maDocGia);
        }

        public DateTime getNgaySinh(string maDocGia)
        {
            return (DateTime)kn.GetValue(@"select dg.ngaySinh from DocGia dg inner join DangKyDocGia dkdg on dg.maDocGia = dkdg.docGiaMa where dkdg.docGiaMa = " + maDocGia);
        }

        public string getGioiTinh(string maDocGia)
        {
            return (string)kn.GetValue(@"select dg.gioiTinh from DocGia dg inner join DangKyDocGia dkdg on dg.maDocGia = dkdg.docGiaMa where dkdg.docGiaMa = " + maDocGia);
        }

        public string getLophoc(string maDocGia)
        {
            return (string)kn.GetValue(@"select DocGia.lopHoc from DocGia inner join DangKyDocGia on DocGia.maDocGia = DangKyDocGia.docGiaMa where DangKyDocGia.docGiaMa = " + maDocGia);
        }

        public int getSoCMND(string maDocGia)
        {
            return (int)kn.GetValue(@"select dg.soCMND from DocGia dg inner join DangKyDocGia dkdg on dg.maDocGia = dkdg.docGiaMa where dkdg.docGiaMa = " + maDocGia);
        }

        public int getMaDocGia(string username)
        {
            return (int)kn.GetValue(@"select docGiaMa from DangKyDocGia where username = '" + username+"'");
        }
    }
}

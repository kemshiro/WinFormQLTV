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
            return (int)kn.GetValue("select MAX(docGiaMa) from DangKyDocGia");
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
    }
}

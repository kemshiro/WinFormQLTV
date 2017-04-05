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

        public int getMaDocGia(string username, string password)
        {
            return (int)kn.GetValue(@"select docGiaMa from DangKyDocGia where username = '" + username + "' and password = '" + password + "'");
        }
    }
}

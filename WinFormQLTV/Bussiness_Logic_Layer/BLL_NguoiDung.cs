using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormQLTV.Data_Access_Layer;

namespace WinFormQLTV.Bussiness_Logic_Layer
{
    class BLL_NguoiDung
    {
        DAL_Sql_User user = new DAL_Sql_User();

        public int checkLogin(string username, string password)
        {
            return user.checkLogin(username, password);
        }

        public int getMaxMaDocGia()
        {
            return user.getMaxMaDocGia();
        }

        public string getTenDocGia(string username, string password)
        {
            return user.getTenDocGia(username, password);
        }

        public int checkRegister(string username)
        {
            return user.checkRegister(username);
        }
    }
}

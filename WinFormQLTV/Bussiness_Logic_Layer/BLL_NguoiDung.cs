using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormQLTV.Data_Access_Layer;

namespace WinFormQLTV.Bussiness_Logic_Layer
{
    public class BLL_NguoiDung
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

        public int getMaDocGia(string username)
        {
            return user.getMaDocGia(username);
        }

        public string getTenDocGia(string username, string password)
        {
            return user.getTenDocGia(username, password);
        }

        public int checkRegister(string username)
        {
            return user.checkRegister(username);
        }

        public int getMaDocGia(string username, string pass)
        {
            return user.getMaDocGia(username, pass);
        }

        public string getTen(string maDocGia)
        {
            return user.getTen(maDocGia);
        }

        public string getLopHoc(string maDocGia)
        {
            return user.getLophoc(maDocGia);
        }

        public string getGioiTinh(string maDocGia)
        {
            return user.getGioiTinh(maDocGia);
        }

        public int getSoCMND(string maDocGia)
        {
            return user.getSoCMND(maDocGia);
        }

        public DateTime getNgaySinh(string maDocGia)
        {
            return user.getNgaySinh(maDocGia);
        }
    }
}

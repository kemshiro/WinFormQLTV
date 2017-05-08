using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormQLTV.Data_Access_Layer;

namespace WinFormQLTV.Bussiness_Logic_Layer
{
    public class BLL_Book
    {
        DAL_Sql_Book book = new DAL_Sql_Book();

        public int getMaxMaDauSach()
        {
            return book.getMaxMaDauSach();
        }

        public int getMaxMaCuonSach()
        {
            return book.getMaxMaCuonSach();
        }

        public int getMaxMaCuonSach(string dauSachMa)
        {
            return book.getMaxMaCuonSach(dauSachMa);
        }

        public int getMaDauSach(int maCuonSach)
        {
            return book.getMaDauSach(maCuonSach);
        }

        public string getNoiDung(string maDauSach)
        {
            return book.getNoiDung(maDauSach);
        }

        public int getSoLuong(string maDauSach)
        {
            return book.getSoLuong(maDauSach);
        }

        public string getISBN(string dauSachMa, string cuonSachMa)
        {
            return book.getISBN(dauSachMa, cuonSachMa);
        }

        public int getDSMa(string maISBN)
        {
            return getDSMa(maISBN);
        }

        public int getMaxMaCS(string dauSachMa)
        {
            return book.getMaxMaCS(dauSachMa);
        }
    }
}

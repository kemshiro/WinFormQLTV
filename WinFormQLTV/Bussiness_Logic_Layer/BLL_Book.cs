using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormQLTV.Data_Access_Layer;

namespace WinFormQLTV.Bussiness_Logic_Layer
{
    class BLL_Book
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

        public int getMaDauSach(int maCuonSach)
        {
            return book.getMaDauSach(maCuonSach);
        }
    }
}

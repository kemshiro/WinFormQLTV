using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormQLTV.Data_Access_Layer;

namespace WinFormQLTV.Bussiness_Logic_Layer
{
    public class BLL_PhieuMuon
    {
        private DAL_Sql_PhieuMuon bill;

        public BLL_PhieuMuon()
        {
            bill = new DAL_Sql_PhieuMuon();
        }

        public DateTime getNgayMuon(string maThongTin)
        {
            return bill.getNgayMuon(maThongTin);
        }

        public DateTime getNgayHetHan(string maThongTin)
        {
            return bill.getNgayHetHan(maThongTin);
        }
    }
}

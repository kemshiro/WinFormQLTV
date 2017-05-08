using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormQLTV.Data_Access_Layer
{
    public class DAL_Sql_PhieuMuon
    {
        DAL_KetNoiDB kn = new DAL_KetNoiDB();

        public DateTime getNgayMuon(string maThongTin)
        {
            return  (DateTime)kn.GetValue(@"select ngayMuon from ThongTinMuon where maThongTin = '"+maThongTin+"'");
        }

        public DateTime getNgayHetHan(string maThongTin)
        {
            return (DateTime)kn.GetValue(@"select ngayHetHan from ThongTinMuon where maThongTin = '" + maThongTin + "'");
        }
    }
}

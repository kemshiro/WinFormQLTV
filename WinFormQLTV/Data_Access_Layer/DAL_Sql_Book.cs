﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormQLTV.Data_Access_Layer
{
    class DAL_Sql_Book
    {

        DAL_KetNoiDB kn = new DAL_KetNoiDB();

        public int getMaxMaDauSach()
        {
            return (int)kn.GetValue(@"select MAX(maDauSach) from DauSach");
        }

        public int getMaxMaCuonSach()
        {
            return (int)kn.GetValue(@"select MAX(maCuonSach) from CuonSach");
        }

        public int getMaDauSach(int maCuonSach)
        {
            return (int)kn.GetValue(@"select dauSachMa from CuonSach where CuonSach.maCuonSach = " + maCuonSach);
        }
    }
}
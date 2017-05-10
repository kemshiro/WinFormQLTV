using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormQLTV.Bussiness_Logic_Layer;
using WinFormQLTV.Data_Access_Layer;

namespace WinFormQLTV.Presentation_Layer
{
    public partial class frmLichSuMuonTra : Form
    {
        private DAL_KetNoiDB kn;
        private BLL_NguoiDung user;
        private string username;
        private int docGiaMa;

        public frmLichSuMuonTra()
        {
        
            InitializeComponent();
        }

        public frmLichSuMuonTra(string username)
        {
            kn = new DAL_KetNoiDB();
            user = new BLL_NguoiDung();
            this.username = username;
            InitializeComponent();
        }


        private void frmLichSuMuonTra_Load(object sender, EventArgs e)
        {
            showDataSachMuon();
        }

        private void showDataSachMuon()
        {
            docGiaMa = user.getMaDocGia(username);
            string sqlCommand = @"select ngayMuon, ngayTra, isbnMa, tieuDe from ThongTinMuon where ngayTra != ngayMuon and docGiaMa =  " + docGiaMa +" order by ngayMuon";
            kn.Open();

            dgvLichSu.DataSource = kn.GetDataSet(sqlCommand, "DSSM");
            dgvLichSu.DataMember = "DSSM";


            dgvLichSu.Columns[0].HeaderText = "Ngày Mượn";
            dgvLichSu.Columns[0].Width = 150;
            dgvLichSu.Columns[1].HeaderText = "Ngày Trả";
            dgvLichSu.Columns[1].Width = 150;
            dgvLichSu.Columns[2].HeaderText = "Mã";
            dgvLichSu.Columns[2].Width = 70;
            dgvLichSu.Columns[3].HeaderText = "Tiêu Đề";
            dgvLichSu.Columns[3].Width = 200;

            kn.Close();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}

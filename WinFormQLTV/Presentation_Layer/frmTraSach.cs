using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormQLTV.Bussiness_Logic_Layer;
using WinFormQLTV.Data_Access_Layer;

namespace WinFormQLTV.Presentation_Layer
{
    public partial class frmTraSach : Form
    {
        private BLL_Book book;
        private BLL_NguoiDung user;
        private BLL_PhieuMuon bill;
        private DAL_KetNoiDB kn;
        private string dauSachMa, maThongTin, isbn;
        private string username, docGiaMa;


        public frmTraSach()
        {
            kn = new DAL_KetNoiDB();
            book = new BLL_Book();
            bill = new BLL_PhieuMuon();
            InitializeComponent();
        }

        public frmTraSach(string username)
        {
            kn = new DAL_KetNoiDB();
            user = new BLL_NguoiDung();
            book = new BLL_Book();
            bill = new BLL_PhieuMuon();
            this.username = username;
            docGiaMa = user.getMaDocGia(username).ToString();
            InitializeComponent();
        }

        private void getDataFromDGV()
        {
            if (dgvSachMuon.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Chưa chọn bản ghi");
                return;
            }
            DataGridViewRow drv = dgvSachMuon.SelectedRows[0];
            DataRowView drview = (DataRowView)drv.DataBoundItem;
            if (drview == null)
            {
                MessageBox.Show("Không lấy được dữ liệu");
                return;
            }
            DataRow dr = drview.Row;
            if (dr == null)
            {
                MessageBox.Show("Không lấy được dữ liệu");
                return;
            }

            maThongTin = dr["maThongTin"].ToString();
            isbn = dr["isbnMa"].ToString();
            dauSachMa = dr["dauSachMa"].ToString();
        }

        private void showDataSachMuon()
        {
            string sqlCommand = @"select maThongTin, isbnMa, dauSachMa, tieuDe, ngayMuon, ngayHetHan from ThongTinMuon where ngayTra = ngayMuon ";
            kn.Open();

            dgvSachMuon.DataSource = kn.GetDataSet(sqlCommand, "DSSM");
            dgvSachMuon.DataMember = "DSSM";


            dgvSachMuon.Columns[0].HeaderText = "Mã thông tin";
            dgvSachMuon.Columns[0].Width = 100;
            dgvSachMuon.Columns[1].HeaderText = "Mã ISBN";
            dgvSachMuon.Columns[1].Width = 100;
            dgvSachMuon.Columns[2].HeaderText = "Đầu Sách Mã";
            dgvSachMuon.Columns[2].Width = 100;
            dgvSachMuon.Columns[3].HeaderText = "Tiêu Đề";
            dgvSachMuon.Columns[3].Width = 200;
            dgvSachMuon.Columns[4].HeaderText = "Ngày Mượn";
            dgvSachMuon.Columns[4].Width = 200;
            dgvSachMuon.Columns[5].HeaderText = "Ngày Hết Hạn";
            dgvSachMuon.Columns[5].Width = 100;

            kn.Close();
        }

        private void frmTraSach_Load(object sender, EventArgs e)
        {
            showDataSachMuon();
        }

        private void btnTraSach_Click(object sender, EventArgs e)
        {
            getDataFromDGV();

            DateTime ngayHetHan = bill.getNgayHetHan(maThongTin);
            DateTime ngayTra = DateTime.Now;

            int isDungHan = isTraSachDungHan(ngayHetHan, ngayTra);
            string ngayTraSach = ngayTra.ToString();

            List<SqlParameter> listParams = new List<SqlParameter>();
            int ret = 0;

            SqlParameter param;

            param = new SqlParameter("@maThongTin", SqlDbType.VarChar);
            param.Value = maThongTin;
            listParams.Add(param);

            param = new SqlParameter("@ngayTra", SqlDbType.SmallDateTime);
            param.Value = ngayTraSach;
            listParams.Add(param);

            param = new SqlParameter("@traDungHan", SqlDbType.Bit);
            param.Value = isDungHan;
            listParams.Add(param);

            param = new SqlParameter("@dauSachMa", SqlDbType.Int);
            param.Value = dauSachMa;
            listParams.Add(param);

            DialogResult result = MessageBox.Show("Bạn chắc chắn?", "Thông Báo",
                  MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                ret = kn.doStoredProceduce("traSach", listParams.ToArray());
                kn.Close();
                if (ret < 0)
                {
                    MessageBox.Show("Lỗi ghi dữ liệu", "Thông báo");
                }
                else
                {
                    MessageBox.Show("Bạn đã trả lại sách", "Thông báo");
                    frmTraSach_Load(sender, e);
                }
            }
        }

        private int isTraSachDungHan(DateTime ngayHetHan, DateTime ngayTra)
        {
            int compare = DateTime.Compare(ngayHetHan, ngayTra);
            if (compare < 0)
            {
                return 0;
            }
            return 1;
        }
    }
}

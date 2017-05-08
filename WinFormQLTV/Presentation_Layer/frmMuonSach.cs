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
    public partial class frmMuonSach : Form
    {
        private BLL_Book book;
        private BLL_NguoiDung user;
        private BLL_PhieuMuon bill;
        private DAL_KetNoiDB kn;
        private string maDauSach, tieuDe, dauSachMa, maThongTin, isbn;
        private string username, docGiaMa;


        public frmMuonSach()
        {
            kn = new DAL_KetNoiDB();
            book = new BLL_Book();
            bill = new BLL_PhieuMuon();
            InitializeComponent();
        }

        public frmMuonSach(string username)
        {
            kn = new DAL_KetNoiDB();
            user = new BLL_NguoiDung();
            book = new BLL_Book();
             bill = new BLL_PhieuMuon();
            this.username = username;
            docGiaMa = user.getMaDocGia(username).ToString();
            InitializeComponent();
        }

        private void frmMuonSach_Load(object sender, EventArgs e)
        {
            showDataKhoSach();
            showDataSachMuon();
        }

        /**********************************************PHẦN MƯỢN SÁCH*************************************************************************************/

        private void showDataKhoSach()
        {
            string sqlHienThi = @"select maDauSach, tieuDe, theLoai, ngonNgu, tacGia, soLuong from DauSach";
            kn.Open();

            dgvKhoSach.DataSource = kn.GetDataSet(sqlHienThi, "DSS");
            dgvKhoSach.DataMember = "DSS";

            dgvKhoSach.Columns[0].HeaderText = "Mã Đầu Sách";
            dgvKhoSach.Columns[0].Width = 40;
            dgvKhoSach.Columns[1].HeaderText = "Tiêu Đề";
            dgvKhoSach.Columns[1].Width = 200;
            dgvKhoSach.Columns[2].HeaderText = "Thể Loại";
            dgvKhoSach.Columns[2].Width = 100;
            dgvKhoSach.Columns[3].HeaderText = "Ngôn Ngữ";
            dgvKhoSach.Columns[3].Width = 100;
            dgvKhoSach.Columns[4].HeaderText = "Tác Giả";
            dgvKhoSach.Columns[4].Width = 100;
            dgvKhoSach.Columns[5].HeaderText = "Số Lượng";
            dgvKhoSach.Columns[5].Width = 100;

            kn.Close();
        }

        private void getDataFromDgvKhoSach()
        {
            if (dgvKhoSach.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Chưa chọn bản ghi");
                return;
            }
            DataGridViewRow drv = dgvKhoSach.SelectedRows[0];
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

            maDauSach = dr["maDauSach"].ToString();
            tieuDe = dr["tieuDe"].ToString();
        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            getDataFromDgvKhoSach();
            if(book.getSoLuong(maDauSach) > 0)
            {
                string cuonSachMa = book.getMaxMaCS(maDauSach).ToString();
                string maISBN = book.getISBN(maDauSach, cuonSachMa);

                DateTime ngayMuon = DateTime.Now;
                DateTime ngayHetHan = ngayMuon.AddDays(3);

                string startDay = ngayMuon.ToString();
                string expiredDay = ngayHetHan.ToString();
                string maThongTin = DateTime.Now.ToString().Replace("/","").Replace(":","");

                List<SqlParameter> listParams = new List<SqlParameter>();
                int ret = 0;

                SqlParameter param;

                param = new SqlParameter("@maThongTin", SqlDbType.VarChar);
                param.Value = maThongTin;
                listParams.Add(param);

                param = new SqlParameter("@ngayMuon", SqlDbType.SmallDateTime);
                param.Value = startDay;
                listParams.Add(param);

                param = new SqlParameter("@ngayHetHan", SqlDbType.SmallDateTime);
                param.Value = expiredDay;
                listParams.Add(param);

                param = new SqlParameter("@tieuDe", SqlDbType.NVarChar);
                param.Value = tieuDe;
                listParams.Add(param);

                param = new SqlParameter("@isbnMa", SqlDbType.VarChar);
                param.Value = maISBN;
                listParams.Add(param);

                param = new SqlParameter("@docGiaMa", SqlDbType.Int);
                param.Value = docGiaMa;
                listParams.Add(param);

                param = new SqlParameter("@dauSachMa", SqlDbType.Int);
                param.Value = maDauSach;
                listParams.Add(param);

                DialogResult result = MessageBox.Show("Bạn chắc chắn?", "Thông Báo",
                   MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    ret = kn.doStoredProceduce("muonSach", listParams.ToArray());
                    kn.Close();
                    if (ret < 0)
                    {
                        MessageBox.Show("Lỗi ghi dữ liệu", "Thông báo");
                    }
                    else
                    {
                        frmMuonSach_Load(sender, e);
                    }
                }
            }
            else
            {
                MessageBox.Show("Sách này đã không còn trong kho, vui lòng mượn cuốn khác", "Thông báo");
            }
        }

        /**********************************************PHẦN TRẢ SÁCH*************************************************************************************/

        private void showDataSachMuon()
        {
            string sqlCommand = @"select maThongTin, isbnMa, dauSachMa, tieuDe, ngayMuon, ngayHetHan from ThongTinMuon where ngayTra = ngayMuon and docGiaMa =  "+docGiaMa;
            kn.Open();

            dgvSachMuon.DataSource = kn.GetDataSet(sqlCommand, "DSSM");
            dgvSachMuon.DataMember = "DSSM";


            dgvSachMuon.Columns[0].HeaderText = "Mã thông tin";
            dgvSachMuon.Columns[0].Width = 100;
            dgvSachMuon.Columns[1].HeaderText = "Mã ISBN";
            dgvSachMuon.Columns[1].Width = 100;
            dgvSachMuon.Columns[2].HeaderText = "Đầu Sách Mã";
            dgvSachMuon.Columns[2].Width = 100;
            dgvSachMuon.Columns[2].Visible = false;
            dgvSachMuon.Columns[3].HeaderText = "Tiêu Đề";
            dgvSachMuon.Columns[3].Width = 200;
            dgvSachMuon.Columns[4].HeaderText = "Ngày Mượn";
            dgvSachMuon.Columns[4].Width = 200;
            dgvSachMuon.Columns[5].HeaderText = "Ngày Hết Hạn";
            dgvSachMuon.Columns[5].Width = 100;

            kn.Close();
        }

        private void getDataSachMuon()
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

        private void btnTraSach_Click(object sender, EventArgs e)
        {
            getDataSachMuon();

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
                    frmMuonSach_Load(sender, e);
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

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }
    }
}

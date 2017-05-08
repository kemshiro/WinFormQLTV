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
    public partial class frmThemDauSach : Form
    {
        private BLL_Book book;
        private List<SqlParameter> listParams;
        private DAL_KetNoiDB kn;
        private int maDauSachMoi;
        private int maCuonSachMoi;

        public frmThemDauSach()
        {
            kn = new DAL_KetNoiDB();
            book = new BLL_Book();
            maDauSachMoi = book.getMaxMaDauSach() + 1;
            maCuonSachMoi = book.getMaxMaCuonSach() + 1;
            InitializeComponent();
            initForms();
        }

        private void initForms()
        {
            tbMaDauSach1.Text = maDauSachMoi.ToString();
        }

        private void rtbTomTatNoiDung_Click(object sender, EventArgs e)
        {
            rtbTomTatNoiDung.Text = "";
        }

        private void btnHoanTat_Click(object sender, EventArgs e)
        {
            string maDauSach = tbMaDauSach1.Text;
            string tieuDe = tbTieuDe.Text;
            string ngonNgu = tbNgonNgu.Text;
            string tacGia = tbTacGia.Text;
            string theLoai = tbTheLoai.Text;
            string tomTatND = rtbTomTatNoiDung.Text;
            string maCuonSach = maCuonSachMoi.ToString();

            listParams = new List<SqlParameter>();
            int ret = 0;


            SqlParameter param;

            param = new SqlParameter("@maDauSach", SqlDbType.Int);
            param.Value = maDauSach;
            listParams.Add(param);

            param = new SqlParameter("@tieuDe", SqlDbType.NVarChar);
            param.Value = tieuDe;
            listParams.Add(param);

            param = new SqlParameter("@ngonNgu", SqlDbType.NVarChar);
            param.Value = ngonNgu;
            listParams.Add(param);

            param = new SqlParameter("@tacGia", SqlDbType.NVarChar);
            param.Value = tacGia;
            listParams.Add(param);

            param = new SqlParameter("@theLoai", SqlDbType.NVarChar);
            param.Value = theLoai;
            listParams.Add(param);

            param = new SqlParameter("@tomTatNoiDung", SqlDbType.NVarChar);
            param.Value = tomTatND;
            listParams.Add(param);

            DialogResult result = MessageBox.Show("Bạn chắc chắn?", "Thông Báo",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                ret = kn.doStoredProceduce("addNewDauSach", listParams.ToArray());
                kn.Close();
                if (ret < 0)
                {
                    MessageBox.Show("Lỗi ghi dữ liệu", "Thông báo");
                }
                else
                {
                    MessageBox.Show("Thêm đầu sách thành công!", "Thông báo");
                }
            }
            else
            {
                this.Close();
            }
            this.Dispose();
        }

    }
}

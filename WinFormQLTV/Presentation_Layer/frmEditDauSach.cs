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
    public partial class frmEditDauSach : Form
    {
        private DAL_KetNoiDB kn;
        private BLL_Book book;
        private List<SqlParameter> listParams;

        private string maDauSach, tieuDe, theLoai, ngonNgu, tacGia, tomTatNoiDung;

        public frmEditDauSach()
        {
            InitializeComponent();
        }

        public frmEditDauSach(string maDauSach, string tieuDe, string theLoai, string ngonNgu, string tacGia, string tomTatNoiDung)
        {
            kn = new DAL_KetNoiDB();
            book = new BLL_Book();
            this.maDauSach = maDauSach;
            this.tieuDe = tieuDe;
            this.theLoai = theLoai;
            this.ngonNgu = ngonNgu;
            this.tacGia = tacGia;
            this.tomTatNoiDung = tomTatNoiDung;
            InitializeComponent();
            tbMaDauSach.Text = maDauSach;
            tbTieuDe.Text = tieuDe;
            tbTheLoai.Text = theLoai;
            tbTacGia.Text = tacGia;
            tbNgonNgu.Text = ngonNgu;
            rtbTomTatNoiDung.Text = tomTatNoiDung;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void btnHoanTat_Click(object sender, EventArgs e)
        {
            string ma = tbMaDauSach.Text;
            string ten = tbTieuDe.Text;
            string tg = tbTacGia.Text;
            string tl = tbTheLoai.Text;
            string tt = rtbTomTatNoiDung.Text;
            string nn = tbNgonNgu.Text;
            listParams = new List<SqlParameter>();
            int ret = 0;

            SqlParameter param;

            param = new SqlParameter("@maDauSach", SqlDbType.Int);
            param.Value = ma;
            listParams.Add(param);

            param = new SqlParameter("@tieuDe", SqlDbType.NVarChar);
            param.Value = ten;
            listParams.Add(param);

            param = new SqlParameter("@tacGia", SqlDbType.NVarChar);
            param.Value = tg;
            listParams.Add(param);
          
            param = new SqlParameter("@theLoai", SqlDbType.NVarChar);
            param.Value = tl;
            listParams.Add(param);

            param = new SqlParameter("@tomTatNoiDung", SqlDbType.NVarChar);
            param.Value = tt;
            listParams.Add(param);

            param = new SqlParameter("@ngonNgu", SqlDbType.NVarChar);
            param.Value = nn;
            listParams.Add(param);


            DialogResult result = MessageBox.Show("Bạn chắc chắn?", "Thông Báo",
               MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                ret = kn.doStoredProceduce("editDauSach", listParams.ToArray());
                kn.Close();
                if (ret < 0)
                {
                    MessageBox.Show("Lỗi ghi dữ liệu", "Thông báo");
                }
                else
                {
                    MessageBox.Show("Sửa thành công!", "Thông báo");
                    this.Close();
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

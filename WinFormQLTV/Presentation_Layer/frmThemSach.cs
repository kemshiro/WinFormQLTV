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
    public partial class frmThemSach : Form
    {
        public Boolean isRowSelected { get; set; }
        public string maDauSachKhoiTao { get; set; }
        private BLL_Book book;
        private List<SqlParameter> listParams;
        private DAL_KetNoiDB kn;

        public frmThemSach(Boolean isRowSelected)
        {
            kn = new DAL_KetNoiDB();
            book = new BLL_Book();
            this.isRowSelected = isRowSelected;
            InitializeComponent();
            initForms();
        }

        private void initForms()
        {
            if (isRowSelected == false)
            {
                int maDauSachMoi = book.getMaxMaDauSach() + 1;
                int maCuonSachMoi = book.getMaxMaCuonSach() + 1;

                tbMaDauSach1.Text = ""+maDauSachMoi;
                tbMaDauSach2.Text = tbMaDauSach1.Text;
                tbMaCuonSach.Text = ""+maCuonSachMoi;
            }
            else
            {
                tbMaDauSach1.Text = maDauSachKhoiTao;
                tbMaDauSach2.Text = tbMaDauSach1.Text;
                tbMaCuonSach.Text = (book.getMaxMaCuonSach() + 1).ToString();
            }
        }

        private void btnHoanTat_Click(object sender, EventArgs e)
        {
            string maDauSach = tbMaDauSach1.Text;
            string tieuDe = tbTieuDe.Text;
            string ngonNgu = tbNgonNgu.Text;
            string tacGia = tbTacGia.Text;
            string theLoai = tbTheLoai.Text;
            string tomTatND = rtbTomTatNoiDung.Text;

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
                    this.Close();
                }
            }
            else
            {
                this.Close();
            }
        }

        private void btnThemCuonSach_Click(object sender, EventArgs e)
        {
            string maDauSach = tbMaDauSach2.Text;
            listParams = new List<SqlParameter>();
            int ret = 0;


            SqlParameter param;

            param = new SqlParameter("@maDauSach", SqlDbType.Int);
            param.Value = maDauSach;
            listParams.Add(param);

            string sqlCommand = "insert into CuonSach (dauSachMa) values(" + maDauSach + ")";

            DialogResult result = MessageBox.Show("Bạn chắc chắn?", "Thông Báo",
               MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                ret = kn.doSQL(sqlCommand, listParams.ToArray());
                kn.Close();
                if (ret < 0)
                {
                    MessageBox.Show("Lỗi ghi dữ liệu", "Thông báo");
                }
                else
                {
                    MessageBox.Show("Thêm cuốn thành công!", "Thông báo");
                    this.Close();
                }
            }
            else
            {
                this.Close();
            }
        }
    }
}

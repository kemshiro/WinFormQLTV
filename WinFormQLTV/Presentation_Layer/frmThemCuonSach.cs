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
    public partial class frmThemCuonSach : Form
    {
        private string maDauSach;
        private string tenDauSach;
        private int cuonSachMa;
        private DAL_KetNoiDB kn;
        private BLL_Book book;
        private List<SqlParameter> listParams;
    

        public frmThemCuonSach()
        {
            kn = new DAL_KetNoiDB();
            book = new BLL_Book();

            InitializeComponent();
        }

        public frmThemCuonSach(string maDauSach, string tenDauSach)
        {
            kn = new DAL_KetNoiDB();
            book = new BLL_Book();
            this.maDauSach = maDauSach;
            this.tenDauSach = tenDauSach;
            cuonSachMa = book.getMaxMaCuonSach() + 1;
            InitializeComponent();
            tbDauSachMa.Text = maDauSach;
            tbDauSachTen.Text = tenDauSach;
            tbMaCuonSach.Text = cuonSachMa.ToString();
        }

        private void btnThemCuonSach_Click(object sender, EventArgs e)
        {
            string dauSachMa = tbDauSachMa.Text;
            string maCuonSach = tbMaCuonSach.Text;
            string isbn = tbISBN.Text;

            listParams = new List<SqlParameter>();
            int ret = 0;

            SqlParameter param;

            param = new SqlParameter("@maISBN", SqlDbType.VarChar);
            param.Value = isbn;
            listParams.Add(param);

            param = new SqlParameter("@dauSachMa", SqlDbType.Int);
            param.Value = dauSachMa;
            listParams.Add(param);

            param = new SqlParameter("@maCuonSach", SqlDbType.Int);
            param.Value = maCuonSach;
            listParams.Add(param);

            DialogResult result = MessageBox.Show("Bạn chắc chắn?", "Thông Báo",
               MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                ret = kn.doStoredProceduce("addNewCuonSach", listParams.ToArray());
                kn.Close();
                if (ret < 0)
                {
                    MessageBox.Show("Lỗi ghi dữ liệu", "Thông báo");
                }
                else
                {
                    MessageBox.Show("Thêm cuốn sách thành công!", "Thông báo");
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

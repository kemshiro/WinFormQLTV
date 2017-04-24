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
    public partial class frmChiTietDauSach : Form
    {

        private DAL_KetNoiDB kn;
        private BLL_Book book;
        private string maDauSach;

        public frmChiTietDauSach()
        {
            InitializeComponent();
        }

        public frmChiTietDauSach(string maDauSach)
        {
            kn = new DAL_KetNoiDB();
            book = new BLL_Book();
            this.maDauSach = maDauSach;
            InitializeComponent();
            
        }

        private void frmChiTietDauSach_Load(object sender, EventArgs e)
        {
            kn.Open();
            string sqlHienThi = @"select cs.maCuonSach, ds.tieuDe from DauSach ds inner join CuonSach cs on ds.maDauSach  = cs.dauSachMa and ds.maDauSach = " + maDauSach;
            dgvListSach.DataSource = kn.GetDataSet(sqlHienThi, "DSS");
            dgvListSach.DataMember = "DSS";

            dgvListSach.Columns[0].HeaderText = "Mã Cuốn Sách";
            dgvListSach.Columns[0].Width = 40;
            dgvListSach.Columns[1].HeaderText = "Tiêu Đề";
            dgvListSach.Columns[1].Width = 200;

            kn.Close();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvListSach.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Chưa chọn bản ghi");
                return;
            }
            DataGridViewRow drv = dgvListSach.SelectedRows[0];
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

            string maCuonSach = dr["maCuonSach"].ToString();

            string sqlCommand = "delete from CuonSach where maCuonSach = " + maCuonSach;
            List<SqlParameter> listParams = new List<SqlParameter>();
            int ret = 0;

            SqlParameter param;
            param = new SqlParameter("@maCuonSach", SqlDbType.Int);
            param.Value = maCuonSach;
            listParams.Add(param);

            DialogResult result = MessageBox.Show("Bạn chắc chắn?", "Thông Báo",
           MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                ret = kn.doSQL(sqlCommand, listParams.ToArray());
                kn.Close();
                if (ret < 0)
                {
                    MessageBox.Show("Lỗi khi xoá", "Thông báo");
                }
                else
                {
                    MessageBox.Show("Xóa thành công", "Thông báo");
                    frmChiTietDauSach_Load(sender, e);
                }
            }
        }
    }
}

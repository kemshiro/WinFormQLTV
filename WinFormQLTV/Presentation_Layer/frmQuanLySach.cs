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
using WinFormQLTV.Data_Access_Layer;

namespace WinFormQLTV.Presentation_Layer
{
    public partial class frmQuanLySach : Form
    {
        private DAL_KetNoiDB kn;
        private SqlDataAdapter adp;
        private DataSet listSachs;
        private frmThemSach frmThemSach;

        public frmQuanLySach()
        {
            kn = new DAL_KetNoiDB();
            listSachs = new DataSet();
            InitializeComponent();
        }

        private void frnQuanLySach_Load(object sender, EventArgs e)
        {
            kn.Open();
            string sqlHienThi = @"select ds.maDauSach, cs.maCuonSach, ds.tieuDe, ds.theLoai, ds.ngonNgu, ds.tacGia, ds.soLuong from DauSach ds inner join CuonSach cs on ds.maDauSach  = cs.dauSachMa";
            dgvListSach.DataSource = kn.GetDataSet(sqlHienThi, "DSS");
            dgvListSach.DataMember = "DSS";


            dgvListSach.Columns[0].HeaderText = "Mã Đầu Sách";
            dgvListSach.Columns[0].Width = 40;
            dgvListSach.Columns[1].HeaderText = "Mã Cuốn Sách";
            dgvListSach.Columns[1].Width = 40;
            dgvListSach.Columns[2].HeaderText = "Tiêu Đề";
            dgvListSach.Columns[2].Width = 200;
            dgvListSach.Columns[3].HeaderText = "Thể Loại";
            dgvListSach.Columns[3].Width = 100;
            dgvListSach.Columns[4].HeaderText = "Ngôn Ngữ";
            dgvListSach.Columns[4].Width = 100;
            dgvListSach.Columns[5].HeaderText = "Tác Giả";
            dgvListSach.Columns[5].Width = 100;
            dgvListSach.Columns[6].HeaderText = "Số Lượng";
            dgvListSach.Columns[6].Width = 100;

            kn.Close();

        }

        private void btnHuy_Click(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {

            if (dgvListSach.SelectedRows.Count <= 0)
            {
                frmThemSach = new frmThemSach(false);
                frmThemSach.ShowDialog();
            }
            else
            {
                DataGridViewRow dgvRow = dgvListSach.SelectedRows[0];
                DataRowView drView = (DataRowView)dgvRow.DataBoundItem;
                if(drView == null)
                {
                    MessageBox.Show("Không lấy được thông tin!", "Thông báo");
                    return;
                }
                DataRow dr = drView.Row;
                if(dr == null)
                {
                    MessageBox.Show("Không lấy được thông tin!", "Thông báo");
                }
                string maDauSach = dr["maDauSach"].ToString();

                frmThemSach = new frmThemSach(true);
                frmThemSach.ShowDialog();
                frmThemSach.maDauSachKhoiTao = maDauSach;
 
            }
        }
    }
}

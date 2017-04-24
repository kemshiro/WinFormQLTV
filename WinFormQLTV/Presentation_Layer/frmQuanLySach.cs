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
    public partial class frmQuanLySach : Form
    {
        private DAL_KetNoiDB kn;
        private frmThemDauSach frmThemDauSach;
        private frmThemCuonSach frmThemCuonSach;
        private BLL_Book book;
        private frmEditDauSach frmEditDauSach;
        private frmChiTietDauSach frmChiTiet;

        private string maDauSach, tieuDe, theLoai, ngonNgu, tacGia, tomTatNoiDung;

        public frmQuanLySach()
        {
            kn = new DAL_KetNoiDB();
            book = new BLL_Book();
            InitializeComponent();
        }

        private void showData(string sqlCommand)
        {
            kn.Open();
            
            dgvListSach.DataSource = kn.GetDataSet(sqlCommand, "DSS");
            dgvListSach.DataMember = "DSS";


            dgvListSach.Columns[0].HeaderText = "Mã Đầu Sách";
            dgvListSach.Columns[0].Width = 40;
            dgvListSach.Columns[1].HeaderText = "Tiêu Đề";
            dgvListSach.Columns[1].Width = 200;
            dgvListSach.Columns[2].HeaderText = "Thể Loại";
            dgvListSach.Columns[2].Width = 100;
            dgvListSach.Columns[3].HeaderText = "Ngôn Ngữ";
            dgvListSach.Columns[3].Width = 100;
            dgvListSach.Columns[4].HeaderText = "Tác Giả";
            dgvListSach.Columns[4].Width = 100;
            dgvListSach.Columns[5].HeaderText = "Số Lượng";
            dgvListSach.Columns[5].Width = 100;

            kn.Close();
        }

        private void frnQuanLySach_Load(object sender, EventArgs e)
        {
            string sqlHienThi = @"select maDauSach, tieuDe, theLoai, ngonNgu, tacGia, soLuong from DauSach";
            showData(sqlHienThi);
        }

        private void getDataFromDgv()
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

            maDauSach = dr["maDauSach"].ToString();
            tieuDe = dr["tieuDe"].ToString();
            theLoai = dr["theLoai"].ToString();
            ngonNgu = dr["ngonNgu"].ToString();
            tacGia = dr["tacGia"].ToString();
            tomTatNoiDung = book.getNoiDung(maDauSach);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            if(tbSearch.Text == "")
            {
                frnQuanLySach_Load(sender, e);
            }
            else
            {
                string sqlTimKiem = @"select maDauSach, tieuDe, theLoai, ngonNgu, tacGia, soLuong from DauSach where tieuDe like '%" + tbSearch.Text + "%'";
                showData(sqlTimKiem);
            }
        }

        private void tbSearch_Click(object sender, EventArgs e)
        {
            tbSearch.Text = "";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            frmThemDauSach = new frmThemDauSach();
            frmThemDauSach.ShowDialog();
            if (frmThemDauSach.IsDisposed)
            {
                frnQuanLySach_Load(sender, e);
            }
        }

        private void btnThemCuonSach_Click(object sender, EventArgs e)
        {
            getDataFromDgv();
            frmThemCuonSach = new frmThemCuonSach(maDauSach, tieuDe);
            frmThemCuonSach.ShowDialog();
            if (frmThemCuonSach.IsDisposed)
            {
                frnQuanLySach_Load(sender, e);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            getDataFromDgv();
            frmEditDauSach = new frmEditDauSach(maDauSach, tieuDe, theLoai, ngonNgu, tacGia, tomTatNoiDung);
            frmEditDauSach.ShowDialog();
            if (frmEditDauSach.IsDisposed)
            {
                frnQuanLySach_Load(sender, e);
            }
        }

        private void btnChiTiet_Click(object sender, EventArgs e)
        {
            getDataFromDgv();
            frmChiTiet = new frmChiTietDauSach(maDauSach);
            frmChiTiet.ShowDialog();
            if (frmChiTiet.IsDisposed)
            {
                frnQuanLySach_Load(sender, e);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            getDataFromDgv();
            string sqlCommand = "delete from DauSach where maDauSach = " + maDauSach;
            List<SqlParameter> listParams = new List<SqlParameter>();
            int ret = 0;

            SqlParameter param;
            param = new SqlParameter("@maDauSach", SqlDbType.Int);
            param.Value = maDauSach;
            listParams.Add(param);

            if(book.getSoLuong(maDauSach) == 0)
            {
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
                        frnQuanLySach_Load(sender, e);
                    }
                }
                else
                {
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Vẫn còn sách được quản lý bởi đầu sách, không thể xóa!", "Không thể xóa");
            }
            frnQuanLySach_Load(sender, e);
        }
    }
}

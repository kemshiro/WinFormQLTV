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
    public partial class frmQuanLyNguoiDung : Form
    {
        private DAL_KetNoiDB kn;
        private BLL_NguoiDung user;
        private string maDocGia, hoTen, gioiTinh, ngaySinh, lopHoc, username;
        private int soCMND;

        public frmQuanLyNguoiDung()
        {
            kn = new DAL_KetNoiDB();
            user = new BLL_NguoiDung();
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();
        }

        private void showData(string sqlCommand)
        {
            kn.Open();

            dgvUser.DataSource = kn.GetDataSet(sqlCommand, "DSND");
            dgvUser.DataMember = "DSND";


            dgvUser.Columns[0].HeaderText = "Mã Độc Giả";
            dgvUser.Columns[0].Width = 70;
            dgvUser.Columns[1].HeaderText = "Tài Khoản";
            dgvUser.Columns[1].Width = 150;

            kn.Close();
        }

        private void dgvUser_SelectionChanged(object sender, EventArgs e)
        {
            getDataFromDgv();
            if (user.getTen(maDocGia) == null)
            {
                MessageBox.Show("Tài khoản chưa được kích hoạt", "Thông báo");
                tbHoTen.Text = "";
                tbGioiTinh.Text = "";
                tbLopHoc.Text = "";
                tbSoCMND.Text = "";
                tbNgaySinh.Text = "";
            }

            tbHoTen.Text = hoTen;
            tbGioiTinh.Text = gioiTinh;
            tbLopHoc.Text = lopHoc;
            tbSoCMND.Text = soCMND.ToString();
            tbNgaySinh.Text = ngaySinh;
        }

        private void getDataFromDgv()
        {
            if (dgvUser.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Chưa chọn bản ghi");
                return;
            }
            DataGridViewRow drv = dgvUser.SelectedRows[0];
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

            maDocGia = dr["docGiaMa"].ToString();
            hoTen = user.getTen(maDocGia);
            gioiTinh = user.getGioiTinh(maDocGia);
            lopHoc = user.getLopHoc(maDocGia);
            soCMND = user.getSoCMND(maDocGia);
            DateTime date = user.getNgaySinh(maDocGia);
            ngaySinh = date.ToString().Substring(0, 10);

        }

        private void frmQuanLyNguoiDung_Load(object sender, EventArgs e)
        {
            string sqlCommand = @"select DangKyDocGia.docGiaMa, DangKyDocGia.username from DangKyDocGia inner join DocGia on DangKyDocGia.docGiaMa = DocGia.maDocGia";
            showData(sqlCommand);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            getDataFromDgv();
            List<SqlParameter> listParams = new List<SqlParameter>();
            int ret = 0;

            SqlParameter param;
            param = new SqlParameter("@maDocGia", SqlDbType.Int);
            param.Value = maDocGia;
            listParams.Add(param);

            DialogResult result = MessageBox.Show("Bạn chắc chắn?", "Thông Báo",
           MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            ret = kn.doStoredProceduce("delteDocGia", listParams.ToArray());
            kn.Close();
            if (ret < 0)
            {
                MessageBox.Show("Lỗi khi xoá", "Thông báo");
            }
            else
            {
                MessageBox.Show("Xóa thành công", "Thông báo");
                frmQuanLyNguoiDung_Load(sender, e);
            }

           
        }
    }
}

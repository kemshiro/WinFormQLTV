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
    public partial class frmPersonalDetails : Form
    {
        private int maDocGia;
        private BLL_NguoiDung user;
        private DAL_KetNoiDB kn;
        private List<SqlParameter> listParams;
        private frmMainUser frmMain;
        private string username;

        public frmPersonalDetails()
        {
            InitializeComponent();
        }

        public frmPersonalDetails(int maDocGia)
        {
            this.maDocGia = maDocGia;
            user = new BLL_NguoiDung();
            kn = new DAL_KetNoiDB();
            InitializeComponent();
            tbMaDocGia.Text = "" + maDocGia;
        }

        private void btnHoanTat_Click(object sender, EventArgs e)
        {
            if (tbGioiTinh.Text == "" || tbHoTen.Text == "" || tbLop.Text == "" || tbSoCMND.Text == "")
            {
                MessageBox.Show("Phải điền đầy đủ thông tin", "Thông báo");
                return;
            }

            string gioiTinh = tbGioiTinh.Text;
            string hoTen = tbHoTen.Text;
            string ngaySinh = dtPNgaySinh.Text;
            string lopHoc = tbLop.Text;
            string soCMND = tbSoCMND.Text;

            int ret = 0;

            listParams = new List<SqlParameter>();
            SqlParameter param;

            param = new SqlParameter("@maDocGia", SqlDbType.Int);
            param.Value = maDocGia;
            listParams.Add(param);

            param = new SqlParameter("@hoten", SqlDbType.NVarChar);
            param.Value = hoTen;
            listParams.Add(param);

            param = new SqlParameter("@ngaySinh", SqlDbType.DateTime);
            param.Value = ngaySinh;
            listParams.Add(param);

            param = new SqlParameter("@gioiTinh", SqlDbType.NVarChar);
            param.Value = gioiTinh;
            listParams.Add(param);

            param = new SqlParameter("@lopHoc", SqlDbType.VarChar);
            param.Value = lopHoc;
            listParams.Add(param);

            param = new SqlParameter("@soCMND", SqlDbType.Int);
            param.Value = soCMND;
            listParams.Add(param);

            DialogResult result = MessageBox.Show("Bạn muốn lưu thông tin không ?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(result == DialogResult.Yes)
            {
                ret = kn.doStoredProceduce("fillAccDetails", listParams.ToArray());
                kn.Close();
                if (ret < 0)
                {
                    MessageBox.Show("Lỗi ghi dữ liệu", "Thông báo");
                }
                else
                {
                    MessageBox.Show("Bạn đã hoàn tất đăng kí, bắt đầu sử dụng!", "Thông báo");
                    frmMain = new frmMainUser();
                    frmMain.Show();
                    this.Close();
                }
            }
        }
    }
}

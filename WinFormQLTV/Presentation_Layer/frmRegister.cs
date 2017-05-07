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
    public partial class frmRegister : Form
    {
        private BLL_NguoiDung user;
        private DAL_KetNoiDB kn;
        private List<SqlParameter> listParams;

        public frmRegister()
        {
            user = new BLL_NguoiDung();
            kn = new DAL_KetNoiDB();
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();

            if (tbUsername.Text == "" || tbPassword.Text == "" || tbConfirm.Text == "")
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Thông báo");
            }

            if (tbConfirm.Text.Equals(tbPassword.Text) == false)
            {
                MessageBox.Show("Mật khẩu và Xác nhận không trùng nhau!", "Thông báo");
                tbConfirm.Text = "";
                tbPassword.Text = "";
            }
            else
            {
                if (user.checkRegister(tbUsername.Text) != 0)
                {
                    MessageBox.Show("Tên đăng nhập đã tồn tại. Vui lòng thử lại", "Thông báo");
                    tbConfirm.Text = "";
                    tbPassword.Text = "";
                    tbUsername.Text = "";
                }
                else
                {
                    string username = tbUsername.Text;
                    string password = tbPassword.Text;
                    int maDocGia = user.getMaxMaDocGia() + 1;

                    int ret = 0;

                    listParams = new List<SqlParameter>();
                    SqlParameter param;

                    param = new SqlParameter("@docGiaMa", SqlDbType.Int);
                    param.Value = maDocGia;
                    listParams.Add(param);

                    param = new SqlParameter("@username", SqlDbType.VarChar);
                    param.Value = username;
                    listParams.Add(param);

                    param = new SqlParameter("@password", SqlDbType.VarChar);
                    param.Value = password;
                    listParams.Add(param);

                    DialogResult result = MessageBox.Show("Bạn chắc chắn?", "Thông Báo",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        ret = kn.doStoredProceduce("registerAcc", listParams.ToArray());
                        kn.Close();
                        if (ret < 0)
                        {
                            MessageBox.Show("Lỗi ghi dữ liệu", "Thông báo");
                        }
                        else
                        {
                            MessageBox.Show("Đăng kí thành công!\nMã tài khoản của bạn là: " + maDocGia, "Thông báo");
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();
        }
    }
}

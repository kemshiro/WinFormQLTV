using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormQLTV.Bussiness_Logic_Layer;
using WinFormQLTV.Presentation_Layer;

namespace WinFormQLTV
{
    public partial class frmLogin : Form
    {
        private BLL_NguoiDung user;
        private frmMainUser frmMainUser;
        private frmRegister frmRegister;
        private frmPersonalDetails frmPersonalDetails;
        private frmMainAdmin frmMainAdmin;


        public frmLogin()
        {
            user = new BLL_NguoiDung();
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(tbUsername.Text =="linh" && tbPassword.Text == "123")
            {
                frmMainAdmin = new frmMainAdmin();
                frmMainAdmin.ShowDialog();
            }
            else
            {
                if (user.checkLogin(tbUsername.Text, tbPassword.Text) == 1)
                {
                    if (user.getTenDocGia(tbUsername.Text, tbPassword.Text) != null)
                    {
                        string username = tbUsername.Text;
                        frmMainUser = new frmMainUser(username);
                        frmMainUser.ShowDialog();
                    }
                    else
                    {
                        frmPersonalDetails = new frmPersonalDetails(user.getMaDocGia(tbUsername.Text, tbPassword.Text));
                        frmPersonalDetails.ShowDialog();
                    }

                }
                else
                {
                    MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu!", "Thông báo");
                }
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            frmRegister = new frmRegister();
            frmRegister.ShowDialog();
        }

        private void tbUsername_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

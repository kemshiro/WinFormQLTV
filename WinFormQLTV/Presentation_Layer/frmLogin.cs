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
        private frmMain frmMain;
        private frmRegister frmRegister;
        private frmPersonalDetails frmPersonalDetails;



        public frmLogin()
        {
            user = new BLL_NguoiDung();
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (user.checkLogin(tbUsername.Text, tbPassword.Text) == 1)
            {
                if(user.getTenDocGia(tbUsername.Text, tbPassword.Text) != null)
                {
                    frmMain main = new frmMain();
                    main.ShowDialog();
                    this.Visible = false;
                }
                else
                {
                    frmPersonalDetails = new frmPersonalDetails(user.getMaDocGia(tbUsername.Text, tbPassword.Text));
                    frmPersonalDetails.ShowDialog();
                    this.Visible = false;
                }

            }
            else
            {
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu!", "Thông báo");
            }

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            frmRegister = new frmRegister();
            frmRegister.ShowDialog();
        }
    }
}

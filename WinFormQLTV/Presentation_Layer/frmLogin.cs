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
        BLL_NguoiDung user = new BLL_NguoiDung();
        frmMain frmMain;
        frmRegister frmRegister;
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (user.checkLogin(tbUsername.Text, tbPassword.Text) == 1)
            {
                this.Visible = false;
                frmMain main = new frmMain();
                main.ShowDialog();
                this.Visible = false;
            }

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            frmRegister = new frmRegister();
            frmRegister.ShowDialog();
        }
    }
}

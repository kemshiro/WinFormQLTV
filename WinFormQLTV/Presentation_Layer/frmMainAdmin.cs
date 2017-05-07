using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormQLTV.Presentation_Layer
{
    public partial class frmMainAdmin : Form
    {
        private frmQuanLySach frmQuanLySach;
        private frmQuanLyNguoiDung frmQuanLyNguoiDung;
        public frmMainAdmin()
        {
            InitializeComponent();
        }

        private void btnQuanLySach_Click(object sender, EventArgs e)
        {
            frmQuanLySach = new frmQuanLySach();
            frmQuanLySach.ShowDialog();
        }

        private void btnQuanLyUser_Click(object sender, EventArgs e)
        {
            frmQuanLyNguoiDung = new frmQuanLyNguoiDung();
            frmQuanLyNguoiDung.ShowDialog();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

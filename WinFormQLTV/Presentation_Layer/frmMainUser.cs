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
    public partial class frmMainUser : Form
    {
        private string username;
        private frmMuonSach frmMuonSach;
        private frmLichSuMuonTra frmLichSu;

        public frmMainUser(string username)
        {
            this.username = username;
            InitializeComponent();
        }

        public frmMainUser()
        {
            InitializeComponent();
        }

        private void btnMuonSach_Click(object sender, EventArgs e)
        {
            frmMuonSach = new frmMuonSach(username);
            frmMuonSach.ShowDialog();
            
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnLichSu_Click(object sender, EventArgs e)
        {
            frmLichSu = new frmLichSuMuonTra(username);
            frmLichSu.ShowDialog();
        }
    }
}

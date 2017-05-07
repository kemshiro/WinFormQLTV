﻿using System;
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
    public partial class frmMuonSach : Form
    {
        private BLL_Book book;
        private BLL_NguoiDung user;
        private DAL_KetNoiDB kn;
        private string maDauSach, tieuDe, theLoai, ngonNgu, tacGia, tomTatNoiDung;
        private string username, docGiaMa;


        public frmMuonSach()
        {
            kn = new DAL_KetNoiDB();
            book = new BLL_Book();
            InitializeComponent();
        }

        public frmMuonSach(string username)
        {
            kn = new DAL_KetNoiDB();
            user = new BLL_NguoiDung();
            book = new BLL_Book();
            this.username = username;
            docGiaMa = user.getMaDocGia(username).ToString();
            InitializeComponent();
        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            getDataFromDgvKhoSach();
            string cuonSachMa = book.getMaxMaCuonSach(maDauSach).ToString();
            string maISBN = book.getISBN(maDauSach, cuonSachMa);
            DateTime ngayMuon = DateTime.Now;
            DateTime ngayHetHan = new DateTime(ngayMuon.Year, ngayMuon.Month, ngayMuon.Day + 3);
            string startDay = ngayMuon.ToString();
            string expiredDay = ngayHetHan.ToString();
            string maThongTin = DateTime.Now.ToString();

            List<SqlParameter> listParams = new List<SqlParameter>();
            int ret = 0;

            SqlParameter param;

            param = new SqlParameter("@maThongTin", SqlDbType.VarChar);
            param.Value = maThongTin;
            listParams.Add(param);

            param = new SqlParameter("@ngayMuon", SqlDbType.SmallDateTime);
            param.Value = startDay;
            listParams.Add(param);

            param = new SqlParameter("@ngayHetHan", SqlDbType.SmallDateTime);
            param.Value = expiredDay;
            listParams.Add(param);

            param = new SqlParameter("@tieuDe", SqlDbType.NVarChar);
            param.Value = tieuDe;
            listParams.Add(param);

            param = new SqlParameter("@isbnMa", SqlDbType.VarChar);
            param.Value = maISBN;
            listParams.Add(param);

            param = new SqlParameter("@docGiaMa", SqlDbType.Int);
            param.Value = docGiaMa;
            listParams.Add(param);

            DialogResult result = MessageBox.Show("Bạn chắc chắn?", "Thông Báo",
               MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                ret = kn.doStoredProceduce("addNewCuonSach", listParams.ToArray());
                kn.Close();
                if (ret < 0)
                {
                    MessageBox.Show("Lỗi ghi dữ liệu", "Thông báo");
                }
                else
                {
                    MessageBox.Show("Thêm cuốn sách thành công!", "Thông báo");
                    this.Close();
                }
            }
            else
            {
                this.Close();
            }

            this.Dispose();
        }

        private void getDataFromDgvKhoSach()
        {
            if (dgvKhoSach.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Chưa chọn bản ghi");
                return;
            }
            DataGridViewRow drv = dgvKhoSach.SelectedRows[0];
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

        private void showData(string sqlCommand)
        {
            kn.Open();

            dgvKhoSach.DataSource = kn.GetDataSet(sqlCommand, "DSS");
            dgvKhoSach.DataMember = "DSS";


            dgvKhoSach.Columns[0].HeaderText = "Mã Đầu Sách";
            dgvKhoSach.Columns[0].Width = 40;
            dgvKhoSach.Columns[0].Visible = false;
            dgvKhoSach.Columns[1].HeaderText = "Tiêu Đề";
            dgvKhoSach.Columns[1].Width = 200;
            dgvKhoSach.Columns[2].HeaderText = "Thể Loại";
            dgvKhoSach.Columns[2].Width = 100;
            dgvKhoSach.Columns[3].HeaderText = "Ngôn Ngữ";
            dgvKhoSach.Columns[3].Width = 100;
            dgvKhoSach.Columns[4].HeaderText = "Tác Giả";
            dgvKhoSach.Columns[4].Width = 100;
            dgvKhoSach.Columns[5].HeaderText = "Số Lượng";
            dgvKhoSach.Columns[5].Width = 100;

            kn.Close();
        }

        private void frmMuonSach_Load(object sender, EventArgs e)
        {
            string sqlHienThi = @"select maDauSach, tieuDe, theLoai, ngonNgu, tacGia, soLuong from DauSach";
            showData(sqlHienThi);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }
    }
}
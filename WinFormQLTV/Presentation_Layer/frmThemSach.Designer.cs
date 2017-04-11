namespace WinFormQLTV.Presentation_Layer
{
    partial class frmThemSach
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabThemMoi = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.tbNgonNgu = new System.Windows.Forms.TextBox();
            this.tbTacGia = new System.Windows.Forms.TextBox();
            this.tbTieuDe = new System.Windows.Forms.TextBox();
            this.rtbTomTatNoiDung = new System.Windows.Forms.RichTextBox();
            this.lblNgonNgu = new System.Windows.Forms.Label();
            this.lblTacGia = new System.Windows.Forms.Label();
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.lblMaDauSach = new System.Windows.Forms.Label();
            this.tbMaDauSach1 = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.tbMaDauSach2 = new System.Windows.Forms.TextBox();
            this.tbMaCuonSach = new System.Windows.Forms.TextBox();
            this.lblDauSachMa = new System.Windows.Forms.Label();
            this.lblMaCuonSach = new System.Windows.Forms.Label();
            this.btnThemDauSach = new System.Windows.Forms.Button();
            this.lblTheLoai = new System.Windows.Forms.Label();
            this.tbTheLoai = new System.Windows.Forms.TextBox();
            this.btnThemCuonSach = new System.Windows.Forms.Button();
            this.tabThemMoi.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabThemMoi
            // 
            this.tabThemMoi.Controls.Add(this.tabPage1);
            this.tabThemMoi.Controls.Add(this.tabPage2);
            this.tabThemMoi.Location = new System.Drawing.Point(0, 0);
            this.tabThemMoi.Name = "tabThemMoi";
            this.tabThemMoi.SelectedIndex = 0;
            this.tabThemMoi.Size = new System.Drawing.Size(409, 588);
            this.tabThemMoi.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.OldLace;
            this.tabPage1.Controls.Add(this.btnThemDauSach);
            this.tabPage1.Controls.Add(this.tbTheLoai);
            this.tabPage1.Controls.Add(this.lblTheLoai);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.tbNgonNgu);
            this.tabPage1.Controls.Add(this.tbTacGia);
            this.tabPage1.Controls.Add(this.tbTieuDe);
            this.tabPage1.Controls.Add(this.rtbTomTatNoiDung);
            this.tabPage1.Controls.Add(this.lblNgonNgu);
            this.tabPage1.Controls.Add(this.lblTacGia);
            this.tabPage1.Controls.Add(this.lblTieuDe);
            this.tabPage1.Controls.Add(this.lblMaDauSach);
            this.tabPage1.Controls.Add(this.tbMaDauSach1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(401, 562);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label1.Location = new System.Drawing.Point(9, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(386, 28);
            this.label1.TabIndex = 9;
            this.label1.Text = "Thêm thông tin cho một đầu sách mới";
            // 
            // tbNgonNgu
            // 
            this.tbNgonNgu.Location = new System.Drawing.Point(171, 237);
            this.tbNgonNgu.Name = "tbNgonNgu";
            this.tbNgonNgu.Size = new System.Drawing.Size(148, 20);
            this.tbNgonNgu.TabIndex = 8;
            // 
            // tbTacGia
            // 
            this.tbTacGia.Location = new System.Drawing.Point(171, 183);
            this.tbTacGia.Name = "tbTacGia";
            this.tbTacGia.Size = new System.Drawing.Size(195, 20);
            this.tbTacGia.TabIndex = 7;
            // 
            // tbTieuDe
            // 
            this.tbTieuDe.Location = new System.Drawing.Point(171, 126);
            this.tbTieuDe.Multiline = true;
            this.tbTieuDe.Name = "tbTieuDe";
            this.tbTieuDe.Size = new System.Drawing.Size(202, 28);
            this.tbTieuDe.TabIndex = 6;
            // 
            // rtbTomTatNoiDung
            // 
            this.rtbTomTatNoiDung.Location = new System.Drawing.Point(33, 335);
            this.rtbTomTatNoiDung.Name = "rtbTomTatNoiDung";
            this.rtbTomTatNoiDung.Size = new System.Drawing.Size(340, 130);
            this.rtbTomTatNoiDung.TabIndex = 5;
            this.rtbTomTatNoiDung.Text = "Tóm tắt nội dung chính....";
            // 
            // lblNgonNgu
            // 
            this.lblNgonNgu.AutoSize = true;
            this.lblNgonNgu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblNgonNgu.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.lblNgonNgu.Location = new System.Drawing.Point(32, 235);
            this.lblNgonNgu.Name = "lblNgonNgu";
            this.lblNgonNgu.Size = new System.Drawing.Size(78, 20);
            this.lblNgonNgu.TabIndex = 4;
            this.lblNgonNgu.Text = "Ngôn ngữ";
            // 
            // lblTacGia
            // 
            this.lblTacGia.AutoSize = true;
            this.lblTacGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTacGia.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.lblTacGia.Location = new System.Drawing.Point(33, 183);
            this.lblTacGia.Name = "lblTacGia";
            this.lblTacGia.Size = new System.Drawing.Size(60, 20);
            this.lblTacGia.TabIndex = 3;
            this.lblTacGia.Text = "Tác giả";
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.AutoSize = true;
            this.lblTieuDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTieuDe.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.lblTieuDe.Location = new System.Drawing.Point(32, 134);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(61, 20);
            this.lblTieuDe.TabIndex = 2;
            this.lblTieuDe.Text = "Tiêu đề";
            // 
            // lblMaDauSach
            // 
            this.lblMaDauSach.AutoSize = true;
            this.lblMaDauSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblMaDauSach.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.lblMaDauSach.Location = new System.Drawing.Point(29, 82);
            this.lblMaDauSach.Name = "lblMaDauSach";
            this.lblMaDauSach.Size = new System.Drawing.Size(100, 20);
            this.lblMaDauSach.TabIndex = 1;
            this.lblMaDauSach.Text = "Mã đầu sách";
            // 
            // tbMaDauSach1
            // 
            this.tbMaDauSach1.BackColor = System.Drawing.Color.SeaShell;
            this.tbMaDauSach1.Location = new System.Drawing.Point(171, 84);
            this.tbMaDauSach1.Name = "tbMaDauSach1";
            this.tbMaDauSach1.ReadOnly = true;
            this.tbMaDauSach1.Size = new System.Drawing.Size(100, 20);
            this.tbMaDauSach1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Info;
            this.tabPage2.Controls.Add(this.btnThemCuonSach);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.tbMaDauSach2);
            this.tabPage2.Controls.Add(this.tbMaCuonSach);
            this.tabPage2.Controls.Add(this.lblDauSachMa);
            this.tabPage2.Controls.Add(this.lblMaCuonSach);
            this.tabPage2.ForeColor = System.Drawing.Color.White;
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(401, 562);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.label2.Location = new System.Drawing.Point(19, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(363, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Thêm thông tin chi tiết cho một cuốn sách";
            // 
            // tbMaDauSach2
            // 
            this.tbMaDauSach2.BackColor = System.Drawing.Color.SeaShell;
            this.tbMaDauSach2.Location = new System.Drawing.Point(212, 205);
            this.tbMaDauSach2.Name = "tbMaDauSach2";
            this.tbMaDauSach2.ReadOnly = true;
            this.tbMaDauSach2.Size = new System.Drawing.Size(100, 20);
            this.tbMaDauSach2.TabIndex = 6;
            // 
            // tbMaCuonSach
            // 
            this.tbMaCuonSach.BackColor = System.Drawing.Color.SeaShell;
            this.tbMaCuonSach.Location = new System.Drawing.Point(212, 125);
            this.tbMaCuonSach.Name = "tbMaCuonSach";
            this.tbMaCuonSach.ReadOnly = true;
            this.tbMaCuonSach.Size = new System.Drawing.Size(100, 20);
            this.tbMaCuonSach.TabIndex = 5;
            // 
            // lblDauSachMa
            // 
            this.lblDauSachMa.AutoSize = true;
            this.lblDauSachMa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblDauSachMa.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.lblDauSachMa.Location = new System.Drawing.Point(37, 203);
            this.lblDauSachMa.Name = "lblDauSachMa";
            this.lblDauSachMa.Size = new System.Drawing.Size(100, 20);
            this.lblDauSachMa.TabIndex = 4;
            this.lblDauSachMa.Text = "Mã đầu sách";
            // 
            // lblMaCuonSach
            // 
            this.lblMaCuonSach.AutoSize = true;
            this.lblMaCuonSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblMaCuonSach.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.lblMaCuonSach.Location = new System.Drawing.Point(37, 125);
            this.lblMaCuonSach.Name = "lblMaCuonSach";
            this.lblMaCuonSach.Size = new System.Drawing.Size(108, 20);
            this.lblMaCuonSach.TabIndex = 2;
            this.lblMaCuonSach.Text = "Mã cuốn sách";
            // 
            // btnThemDauSach
            // 
            this.btnThemDauSach.BackColor = System.Drawing.Color.Firebrick;
            this.btnThemDauSach.ForeColor = System.Drawing.Color.DarkOrange;
            this.btnThemDauSach.Location = new System.Drawing.Point(139, 503);
            this.btnThemDauSach.Name = "btnThemDauSach";
            this.btnThemDauSach.Size = new System.Drawing.Size(117, 37);
            this.btnThemDauSach.TabIndex = 8;
            this.btnThemDauSach.Text = "Thêm Đầu Sách";
            this.btnThemDauSach.UseVisualStyleBackColor = false;
            this.btnThemDauSach.Click += new System.EventHandler(this.btnHoanTat_Click);
            // 
            // lblTheLoai
            // 
            this.lblTheLoai.AutoSize = true;
            this.lblTheLoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTheLoai.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.lblTheLoai.Location = new System.Drawing.Point(29, 290);
            this.lblTheLoai.Name = "lblTheLoai";
            this.lblTheLoai.Size = new System.Drawing.Size(70, 20);
            this.lblTheLoai.TabIndex = 10;
            this.lblTheLoai.Text = "Thể Loại";
            // 
            // tbTheLoai
            // 
            this.tbTheLoai.Location = new System.Drawing.Point(171, 290);
            this.tbTheLoai.Name = "tbTheLoai";
            this.tbTheLoai.Size = new System.Drawing.Size(148, 20);
            this.tbTheLoai.TabIndex = 11;
            // 
            // btnThemCuonSach
            // 
            this.btnThemCuonSach.BackColor = System.Drawing.Color.Firebrick;
            this.btnThemCuonSach.ForeColor = System.Drawing.Color.DarkOrange;
            this.btnThemCuonSach.Location = new System.Drawing.Point(128, 491);
            this.btnThemCuonSach.Name = "btnThemCuonSach";
            this.btnThemCuonSach.Size = new System.Drawing.Size(131, 45);
            this.btnThemCuonSach.TabIndex = 9;
            this.btnThemCuonSach.Text = "Thêm Cuốn Sách";
            this.btnThemCuonSach.UseVisualStyleBackColor = false;
            this.btnThemCuonSach.Click += new System.EventHandler(this.btnThemCuonSach_Click);
            // 
            // frmThemSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(409, 590);
            this.Controls.Add(this.tabThemMoi);
            this.Name = "frmThemSach";
            this.Text = "Thêm Mới Sách";
            this.tabThemMoi.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabThemMoi;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label lblNgonNgu;
        private System.Windows.Forms.Label lblTacGia;
        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.Label lblMaDauSach;
        private System.Windows.Forms.TextBox tbMaDauSach1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.RichTextBox rtbTomTatNoiDung;
        private System.Windows.Forms.TextBox tbNgonNgu;
        private System.Windows.Forms.TextBox tbTacGia;
        private System.Windows.Forms.TextBox tbTieuDe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbMaDauSach2;
        private System.Windows.Forms.TextBox tbMaCuonSach;
        private System.Windows.Forms.Label lblDauSachMa;
        private System.Windows.Forms.Label lblMaCuonSach;
        private System.Windows.Forms.Button btnThemDauSach;
        private System.Windows.Forms.TextBox tbTheLoai;
        private System.Windows.Forms.Label lblTheLoai;
        private System.Windows.Forms.Button btnThemCuonSach;
    }
}
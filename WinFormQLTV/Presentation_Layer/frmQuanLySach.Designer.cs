namespace WinFormQLTV.Presentation_Layer
{
    partial class frmQuanLySach
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuanLySach));
            this.dgvListSach = new System.Windows.Forms.DataGridView();
            this.btnThemDauSach = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnChiTiet = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.grbChucNang = new System.Windows.Forms.GroupBox();
            this.btnThemCuonSach = new System.Windows.Forms.Button();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListSach)).BeginInit();
            this.grbChucNang.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvListSach
            // 
            this.dgvListSach.AllowUserToAddRows = false;
            this.dgvListSach.AllowUserToDeleteRows = false;
            this.dgvListSach.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvListSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListSach.Location = new System.Drawing.Point(56, 68);
            this.dgvListSach.Name = "dgvListSach";
            this.dgvListSach.ReadOnly = true;
            this.dgvListSach.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListSach.Size = new System.Drawing.Size(682, 328);
            this.dgvListSach.TabIndex = 0;
            // 
            // btnThemDauSach
            // 
            this.btnThemDauSach.Location = new System.Drawing.Point(108, 36);
            this.btnThemDauSach.Name = "btnThemDauSach";
            this.btnThemDauSach.Size = new System.Drawing.Size(100, 42);
            this.btnThemDauSach.TabIndex = 1;
            this.btnThemDauSach.Text = "Thêm Đầu Sách";
            this.btnThemDauSach.UseVisualStyleBackColor = true;
            this.btnThemDauSach.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(293, 36);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(93, 42);
            this.btnSua.TabIndex = 2;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(465, 36);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(98, 42);
            this.btnXoa.TabIndex = 3;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnChiTiet
            // 
            this.btnChiTiet.Location = new System.Drawing.Point(293, 101);
            this.btnChiTiet.Name = "btnChiTiet";
            this.btnChiTiet.Size = new System.Drawing.Size(93, 42);
            this.btnChiTiet.TabIndex = 6;
            this.btnChiTiet.Text = "Chi Tiết";
            this.btnChiTiet.UseVisualStyleBackColor = true;
            this.btnChiTiet.Click += new System.EventHandler(this.btnChiTiet_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(465, 101);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(100, 42);
            this.btnThoat.TabIndex = 7;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // grbChucNang
            // 
            this.grbChucNang.Controls.Add(this.btnThemCuonSach);
            this.grbChucNang.Controls.Add(this.btnThemDauSach);
            this.grbChucNang.Controls.Add(this.btnSua);
            this.grbChucNang.Controls.Add(this.btnThoat);
            this.grbChucNang.Controls.Add(this.btnXoa);
            this.grbChucNang.Controls.Add(this.btnChiTiet);
            this.grbChucNang.Location = new System.Drawing.Point(56, 402);
            this.grbChucNang.Name = "grbChucNang";
            this.grbChucNang.Size = new System.Drawing.Size(682, 149);
            this.grbChucNang.TabIndex = 10;
            this.grbChucNang.TabStop = false;
            this.grbChucNang.Text = "Chức năng";
            // 
            // btnThemCuonSach
            // 
            this.btnThemCuonSach.Location = new System.Drawing.Point(108, 101);
            this.btnThemCuonSach.Name = "btnThemCuonSach";
            this.btnThemCuonSach.Size = new System.Drawing.Size(100, 42);
            this.btnThemCuonSach.TabIndex = 8;
            this.btnThemCuonSach.Text = "Thêm Cuốn Sách";
            this.btnThemCuonSach.UseVisualStyleBackColor = true;
            this.btnThemCuonSach.Click += new System.EventHandler(this.btnThemCuonSach_Click);
            // 
            // tbSearch
            // 
            this.tbSearch.Location = new System.Drawing.Point(489, 28);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(249, 20);
            this.tbSearch.TabIndex = 11;
            this.tbSearch.Text = "Tìm kiếm";
            this.tbSearch.Click += new System.EventHandler(this.tbSearch_Click);
            this.tbSearch.TextChanged += new System.EventHandler(this.tbSearch_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(53, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(308, 18);
            this.label1.TabIndex = 12;
            this.label1.Text = "Danh Sách Các Đầu Sách Hiện Có";
            // 
            // frmQuanLySach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 567);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.grbChucNang);
            this.Controls.Add(this.dgvListSach);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmQuanLySach";
            this.Text = "Quản Lý Sách";
            this.Load += new System.EventHandler(this.frnQuanLySach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListSach)).EndInit();
            this.grbChucNang.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListSach;
        private System.Windows.Forms.Button btnThemDauSach;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnChiTiet;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.GroupBox grbChucNang;
        private System.Windows.Forms.Button btnThemCuonSach;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Label label1;
    }
}
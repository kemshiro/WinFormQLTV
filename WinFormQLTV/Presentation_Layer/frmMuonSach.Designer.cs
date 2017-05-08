namespace WinFormQLTV.Presentation_Layer
{
    partial class frmMuonSach
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
            this.grbKhoSach = new System.Windows.Forms.GroupBox();
            this.dgvKhoSach = new System.Windows.Forms.DataGridView();
            this.btnChon = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnBoSach = new System.Windows.Forms.Button();
            this.grbSachMuon = new System.Windows.Forms.GroupBox();
            this.dgvSachMuon = new System.Windows.Forms.DataGridView();
            this.tbTimKiem = new System.Windows.Forms.TextBox();
            this.btnTraSach = new System.Windows.Forms.Button();
            this.grbKhoSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhoSach)).BeginInit();
            this.grbSachMuon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSachMuon)).BeginInit();
            this.SuspendLayout();
            // 
            // grbKhoSach
            // 
            this.grbKhoSach.Controls.Add(this.dgvKhoSach);
            this.grbKhoSach.Location = new System.Drawing.Point(15, 65);
            this.grbKhoSach.Name = "grbKhoSach";
            this.grbKhoSach.Size = new System.Drawing.Size(718, 274);
            this.grbKhoSach.TabIndex = 0;
            this.grbKhoSach.TabStop = false;
            this.grbKhoSach.Text = "Kho Sách";
            // 
            // dgvKhoSach
            // 
            this.dgvKhoSach.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvKhoSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKhoSach.Location = new System.Drawing.Point(22, 19);
            this.dgvKhoSach.Name = "dgvKhoSach";
            this.dgvKhoSach.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKhoSach.Size = new System.Drawing.Size(684, 242);
            this.dgvKhoSach.TabIndex = 0;
            // 
            // btnChon
            // 
            this.btnChon.BackColor = System.Drawing.Color.White;
            this.btnChon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnChon.Location = new System.Drawing.Point(60, 584);
            this.btnChon.Name = "btnChon";
            this.btnChon.Size = new System.Drawing.Size(75, 33);
            this.btnChon.TabIndex = 2;
            this.btnChon.Text = "Chọn Sách";
            this.btnChon.UseVisualStyleBackColor = false;
            this.btnChon.Click += new System.EventHandler(this.btnChon_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnThoat.Location = new System.Drawing.Point(591, 584);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 33);
            this.btnThoat.TabIndex = 4;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnBoSach
            // 
            this.btnBoSach.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnBoSach.Location = new System.Drawing.Point(231, 584);
            this.btnBoSach.Name = "btnBoSach";
            this.btnBoSach.Size = new System.Drawing.Size(75, 33);
            this.btnBoSach.TabIndex = 5;
            this.btnBoSach.Text = "Bỏ Sách";
            this.btnBoSach.UseVisualStyleBackColor = true;
            // 
            // grbSachMuon
            // 
            this.grbSachMuon.Controls.Add(this.dgvSachMuon);
            this.grbSachMuon.Location = new System.Drawing.Point(15, 361);
            this.grbSachMuon.Name = "grbSachMuon";
            this.grbSachMuon.Size = new System.Drawing.Size(718, 208);
            this.grbSachMuon.TabIndex = 1;
            this.grbSachMuon.TabStop = false;
            this.grbSachMuon.Text = "Sách Mượn";
            // 
            // dgvSachMuon
            // 
            this.dgvSachMuon.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvSachMuon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSachMuon.Location = new System.Drawing.Point(19, 29);
            this.dgvSachMuon.Name = "dgvSachMuon";
            this.dgvSachMuon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSachMuon.Size = new System.Drawing.Size(684, 156);
            this.dgvSachMuon.TabIndex = 0;
            // 
            // tbTimKiem
            // 
            this.tbTimKiem.Location = new System.Drawing.Point(522, 22);
            this.tbTimKiem.Name = "tbTimKiem";
            this.tbTimKiem.Size = new System.Drawing.Size(196, 20);
            this.tbTimKiem.TabIndex = 1;
            this.tbTimKiem.Text = "Tìm Kiếm";
            // 
            // btnTraSach
            // 
            this.btnTraSach.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnTraSach.Location = new System.Drawing.Point(393, 584);
            this.btnTraSach.Name = "btnTraSach";
            this.btnTraSach.Size = new System.Drawing.Size(75, 33);
            this.btnTraSach.TabIndex = 6;
            this.btnTraSach.Text = "Trả Sách";
            this.btnTraSach.UseVisualStyleBackColor = true;
            this.btnTraSach.Click += new System.EventHandler(this.btnTraSach_Click);
            // 
            // frmMuonSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Firebrick;
            this.ClientSize = new System.Drawing.Size(745, 629);
            this.Controls.Add(this.btnTraSach);
            this.Controls.Add(this.tbTimKiem);
            this.Controls.Add(this.grbSachMuon);
            this.Controls.Add(this.btnBoSach);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnChon);
            this.Controls.Add(this.grbKhoSach);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "frmMuonSach";
            this.Text = "Mượn Sách";
            this.Load += new System.EventHandler(this.frmMuonSach_Load);
            this.grbKhoSach.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhoSach)).EndInit();
            this.grbSachMuon.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSachMuon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbKhoSach;
        private System.Windows.Forms.DataGridView dgvKhoSach;
        private System.Windows.Forms.Button btnChon;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnBoSach;
        private System.Windows.Forms.GroupBox grbSachMuon;
        private System.Windows.Forms.DataGridView dgvSachMuon;
        private System.Windows.Forms.TextBox tbTimKiem;
        private System.Windows.Forms.Button btnTraSach;
    }
}
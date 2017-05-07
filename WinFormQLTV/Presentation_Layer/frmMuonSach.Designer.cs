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
            this.grbSachMuon = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnChon = new System.Windows.Forms.Button();
            this.btnXacNhan = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.grbKhoSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhoSach)).BeginInit();
            this.grbSachMuon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // grbKhoSach
            // 
            this.grbKhoSach.Controls.Add(this.dgvKhoSach);
            this.grbKhoSach.Location = new System.Drawing.Point(12, 12);
            this.grbKhoSach.Name = "grbKhoSach";
            this.grbKhoSach.Size = new System.Drawing.Size(718, 303);
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
            this.dgvKhoSach.Size = new System.Drawing.Size(684, 266);
            this.dgvKhoSach.TabIndex = 0;
            // 
            // grbSachMuon
            // 
            this.grbSachMuon.Controls.Add(this.dataGridView1);
            this.grbSachMuon.Location = new System.Drawing.Point(12, 335);
            this.grbSachMuon.Name = "grbSachMuon";
            this.grbSachMuon.Size = new System.Drawing.Size(718, 227);
            this.grbSachMuon.TabIndex = 1;
            this.grbSachMuon.TabStop = false;
            this.grbSachMuon.Text = "Sách được mượn";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(22, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(684, 202);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnChon
            // 
            this.btnChon.BackColor = System.Drawing.Color.White;
            this.btnChon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnChon.Location = new System.Drawing.Point(64, 584);
            this.btnChon.Name = "btnChon";
            this.btnChon.Size = new System.Drawing.Size(75, 33);
            this.btnChon.TabIndex = 2;
            this.btnChon.Text = "Chọn Sách";
            this.btnChon.UseVisualStyleBackColor = false;
            this.btnChon.Click += new System.EventHandler(this.btnChon_Click);
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnXacNhan.Location = new System.Drawing.Point(405, 584);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(75, 33);
            this.btnXacNhan.TabIndex = 3;
            this.btnXacNhan.Text = "Xác nhận";
            this.btnXacNhan.UseVisualStyleBackColor = true;
            // 
            // btnThoat
            // 
            this.btnThoat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnThoat.Location = new System.Drawing.Point(578, 584);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 33);
            this.btnThoat.TabIndex = 4;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnXoa.Location = new System.Drawing.Point(227, 584);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 33);
            this.btnXoa.TabIndex = 5;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // frmMuonSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Firebrick;
            this.ClientSize = new System.Drawing.Size(745, 629);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXacNhan);
            this.Controls.Add(this.btnChon);
            this.Controls.Add(this.grbSachMuon);
            this.Controls.Add(this.grbKhoSach);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "frmMuonSach";
            this.Text = "Mượn Sách";
            this.Load += new System.EventHandler(this.frmMuonSach_Load);
            this.grbKhoSach.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhoSach)).EndInit();
            this.grbSachMuon.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbKhoSach;
        private System.Windows.Forms.DataGridView dgvKhoSach;
        private System.Windows.Forms.GroupBox grbSachMuon;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnChon;
        private System.Windows.Forms.Button btnXacNhan;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnXoa;
    }
}
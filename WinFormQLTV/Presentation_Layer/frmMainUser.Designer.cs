namespace WinFormQLTV.Presentation_Layer
{
    partial class frmMainUser
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
            this.btnLichSu = new System.Windows.Forms.Button();
            this.btnMuonSach = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLichSu
            // 
            this.btnLichSu.Location = new System.Drawing.Point(107, 136);
            this.btnLichSu.Name = "btnLichSu";
            this.btnLichSu.Size = new System.Drawing.Size(136, 99);
            this.btnLichSu.TabIndex = 1;
            this.btnLichSu.Text = "Lịch sử mượn trả";
            this.btnLichSu.UseVisualStyleBackColor = true;
            // 
            // btnMuonSach
            // 
            this.btnMuonSach.Location = new System.Drawing.Point(374, 136);
            this.btnMuonSach.Name = "btnMuonSach";
            this.btnMuonSach.Size = new System.Drawing.Size(128, 99);
            this.btnMuonSach.TabIndex = 2;
            this.btnMuonSach.Text = "Mượn sách";
            this.btnMuonSach.UseVisualStyleBackColor = true;
            // 
            // frmMainUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 402);
            this.Controls.Add(this.btnMuonSach);
            this.Controls.Add(this.btnLichSu);
            this.Name = "frmMainUser";
            this.Text = "Quản Lý Thư Viện";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnLichSu;
        private System.Windows.Forms.Button btnMuonSach;
    }
}
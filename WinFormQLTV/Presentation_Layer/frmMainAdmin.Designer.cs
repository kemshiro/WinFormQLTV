namespace WinFormQLTV.Presentation_Layer
{
    partial class frmMainAdmin
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
            this.btnQuanLySach = new System.Windows.Forms.Button();
            this.btnQuanLyUser = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnQuanLySach
            // 
            this.btnQuanLySach.Location = new System.Drawing.Point(94, 151);
            this.btnQuanLySach.Name = "btnQuanLySach";
            this.btnQuanLySach.Size = new System.Drawing.Size(108, 90);
            this.btnQuanLySach.TabIndex = 0;
            this.btnQuanLySach.Text = "Quản Lý Sách";
            this.btnQuanLySach.UseVisualStyleBackColor = true;
            this.btnQuanLySach.Click += new System.EventHandler(this.btnQuanLySach_Click);
            // 
            // btnQuanLyUser
            // 
            this.btnQuanLyUser.Location = new System.Drawing.Point(297, 151);
            this.btnQuanLyUser.Name = "btnQuanLyUser";
            this.btnQuanLyUser.Size = new System.Drawing.Size(108, 90);
            this.btnQuanLyUser.TabIndex = 4;
            this.btnQuanLyUser.Text = "Quản Lý Thông Tin Người Dùng";
            this.btnQuanLyUser.UseVisualStyleBackColor = true;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(521, 151);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(108, 90);
            this.btnThoat.TabIndex = 5;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            // 
            // frmMainAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 402);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnQuanLyUser);
            this.Controls.Add(this.btnQuanLySach);
            this.Name = "frmMainAdmin";
            this.Text = "frmMainAdmin";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnQuanLySach;
        private System.Windows.Forms.Button btnQuanLyUser;
        private System.Windows.Forms.Button btnThoat;
    }
}
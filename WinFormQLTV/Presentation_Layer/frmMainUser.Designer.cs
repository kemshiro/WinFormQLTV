﻿namespace WinFormQLTV.Presentation_Layer
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
            this.btnTraSach = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLichSu
            // 
            this.btnLichSu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnLichSu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnLichSu.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnLichSu.Location = new System.Drawing.Point(44, 136);
            this.btnLichSu.Name = "btnLichSu";
            this.btnLichSu.Size = new System.Drawing.Size(136, 99);
            this.btnLichSu.TabIndex = 1;
            this.btnLichSu.Text = "Lịch sử mượn trả";
            this.btnLichSu.UseVisualStyleBackColor = false;
            // 
            // btnMuonSach
            // 
            this.btnMuonSach.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnMuonSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnMuonSach.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnMuonSach.Location = new System.Drawing.Point(251, 136);
            this.btnMuonSach.Name = "btnMuonSach";
            this.btnMuonSach.Size = new System.Drawing.Size(128, 99);
            this.btnMuonSach.TabIndex = 2;
            this.btnMuonSach.Text = "Mượn sách";
            this.btnMuonSach.UseVisualStyleBackColor = false;
            this.btnMuonSach.Click += new System.EventHandler(this.btnMuonSach_Click);
            // 
            // btnTraSach
            // 
            this.btnTraSach.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnTraSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnTraSach.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnTraSach.Location = new System.Drawing.Point(460, 136);
            this.btnTraSach.Name = "btnTraSach";
            this.btnTraSach.Size = new System.Drawing.Size(128, 99);
            this.btnTraSach.TabIndex = 3;
            this.btnTraSach.Text = "Trả Sách";
            this.btnTraSach.UseVisualStyleBackColor = false;
            this.btnTraSach.Click += new System.EventHandler(this.btnTraSach_Click);
            // 
            // frmMainUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(644, 402);
            this.Controls.Add(this.btnTraSach);
            this.Controls.Add(this.btnMuonSach);
            this.Controls.Add(this.btnLichSu);
            this.Name = "frmMainUser";
            this.Text = "Quản Lý Thư Viện";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnLichSu;
        private System.Windows.Forms.Button btnMuonSach;
        private System.Windows.Forms.Button btnTraSach;
    }
}
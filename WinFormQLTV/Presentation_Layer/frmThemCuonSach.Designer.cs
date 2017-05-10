namespace WinFormQLTV.Presentation_Layer
{
    partial class frmThemCuonSach
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmThemCuonSach));
            this.tbDauSachMa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbDauSachTen = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbMaCuonSach = new System.Windows.Forms.TextBox();
            this.btnThemCuonSach = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.tbISBN = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbDauSachMa
            // 
            this.tbDauSachMa.Location = new System.Drawing.Point(157, 72);
            this.tbDauSachMa.Name = "tbDauSachMa";
            this.tbDauSachMa.ReadOnly = true;
            this.tbDauSachMa.Size = new System.Drawing.Size(100, 20);
            this.tbDauSachMa.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.Purple;
            this.label1.Location = new System.Drawing.Point(29, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã Đầu Sách";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label2.Location = new System.Drawing.Point(78, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Thêm 1 cuốn sách mới";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.ForeColor = System.Drawing.Color.Purple;
            this.label3.Location = new System.Drawing.Point(24, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tên Đầu Sách";
            // 
            // tbDauSachTen
            // 
            this.tbDauSachTen.Location = new System.Drawing.Point(157, 114);
            this.tbDauSachTen.Name = "tbDauSachTen";
            this.tbDauSachTen.ReadOnly = true;
            this.tbDauSachTen.Size = new System.Drawing.Size(179, 20);
            this.tbDauSachTen.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.ForeColor = System.Drawing.Color.Purple;
            this.label4.Location = new System.Drawing.Point(29, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Mã Cuốn Sách";
            // 
            // tbMaCuonSach
            // 
            this.tbMaCuonSach.Location = new System.Drawing.Point(157, 159);
            this.tbMaCuonSach.Name = "tbMaCuonSach";
            this.tbMaCuonSach.ReadOnly = true;
            this.tbMaCuonSach.Size = new System.Drawing.Size(100, 20);
            this.tbMaCuonSach.TabIndex = 6;
            // 
            // btnThemCuonSach
            // 
            this.btnThemCuonSach.BackColor = System.Drawing.Color.Maroon;
            this.btnThemCuonSach.ForeColor = System.Drawing.Color.Gold;
            this.btnThemCuonSach.Location = new System.Drawing.Point(117, 249);
            this.btnThemCuonSach.Name = "btnThemCuonSach";
            this.btnThemCuonSach.Size = new System.Drawing.Size(108, 37);
            this.btnThemCuonSach.TabIndex = 7;
            this.btnThemCuonSach.Text = "Thêm Cuốn Sách";
            this.btnThemCuonSach.UseVisualStyleBackColor = false;
            this.btnThemCuonSach.Click += new System.EventHandler(this.btnThemCuonSach_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.ForeColor = System.Drawing.Color.Purple;
            this.label5.Location = new System.Drawing.Point(29, 203);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "ISBN";
            // 
            // tbISBN
            // 
            this.tbISBN.Location = new System.Drawing.Point(157, 199);
            this.tbISBN.Name = "tbISBN";
            this.tbISBN.Size = new System.Drawing.Size(100, 20);
            this.tbISBN.TabIndex = 9;
            // 
            // frmThemCuonSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.ClientSize = new System.Drawing.Size(362, 298);
            this.Controls.Add(this.tbISBN);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnThemCuonSach);
            this.Controls.Add(this.tbMaCuonSach);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbDauSachTen);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbDauSachMa);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmThemCuonSach";
            this.Text = "Thêm Cuốn Sách";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbDauSachMa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbDauSachTen;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbMaCuonSach;
        private System.Windows.Forms.Button btnThemCuonSach;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbISBN;
    }
}
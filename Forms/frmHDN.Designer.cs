namespace QuanLyCuaHangDienThoai.Forms
{
    partial class frmHDN
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
            this.grbChitietHDN = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.cboMaSP = new System.Windows.Forms.ComboBox();
            this.cboMaHD = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtGiamgia = new System.Windows.Forms.TextBox();
            this.txtThanhtien = new System.Windows.Forms.TextBox();
            this.txtSoluong = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.grbHDN = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMahoadon = new System.Windows.Forms.TextBox();
            this.txtNgaynhap = new System.Windows.Forms.TextBox();
            this.cboMaNCC = new System.Windows.Forms.ComboBox();
            this.cboManhanvien = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDong = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.grbChitietHDN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.grbHDN.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbChitietHDN
            // 
            this.grbChitietHDN.BackColor = System.Drawing.Color.LightCoral;
            this.grbChitietHDN.Controls.Add(this.label10);
            this.grbChitietHDN.Controls.Add(this.txtDonGia);
            this.grbChitietHDN.Controls.Add(this.btnAdd);
            this.grbChitietHDN.Controls.Add(this.cboMaSP);
            this.grbChitietHDN.Controls.Add(this.cboMaHD);
            this.grbChitietHDN.Controls.Add(this.dataGridView1);
            this.grbChitietHDN.Controls.Add(this.txtGiamgia);
            this.grbChitietHDN.Controls.Add(this.txtThanhtien);
            this.grbChitietHDN.Controls.Add(this.txtSoluong);
            this.grbChitietHDN.Controls.Add(this.label9);
            this.grbChitietHDN.Controls.Add(this.label6);
            this.grbChitietHDN.Controls.Add(this.label4);
            this.grbChitietHDN.Controls.Add(this.label3);
            this.grbChitietHDN.Controls.Add(this.label2);
            this.grbChitietHDN.Location = new System.Drawing.Point(37, 165);
            this.grbChitietHDN.Name = "grbChitietHDN";
            this.grbChitietHDN.Size = new System.Drawing.Size(891, 340);
            this.grbChitietHDN.TabIndex = 31;
            this.grbChitietHDN.TabStop = false;
            this.grbChitietHDN.Text = "Chi tiết hóa đơn nhập";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(444, 46);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 20);
            this.label10.TabIndex = 15;
            this.label10.Text = "Đơn giá";
            // 
            // txtDonGia
            // 
            this.txtDonGia.Location = new System.Drawing.Point(438, 69);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(133, 26);
            this.txtDonGia.TabIndex = 14;
            this.txtDonGia.TextChanged += new System.EventHandler(this.txtDonGia_TextChanged);
            this.txtDonGia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDonGia_KeyPress);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.LightCoral;
            this.btnAdd.Location = new System.Drawing.Point(841, 67);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(50, 28);
            this.btnAdd.TabIndex = 13;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cboMaSP
            // 
            this.cboMaSP.FormattingEnabled = true;
            this.cboMaSP.Location = new System.Drawing.Point(174, 67);
            this.cboMaSP.Name = "cboMaSP";
            this.cboMaSP.Size = new System.Drawing.Size(131, 28);
            this.cboMaSP.TabIndex = 12;
            this.cboMaSP.TextChanged += new System.EventHandler(this.cboMaSP_TextChanged);
            this.cboMaSP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboMaSP_KeyPress);
            // 
            // cboMaHD
            // 
            this.cboMaHD.FormattingEnabled = true;
            this.cboMaHD.Location = new System.Drawing.Point(36, 67);
            this.cboMaHD.Name = "cboMaHD";
            this.cboMaHD.Size = new System.Drawing.Size(132, 28);
            this.cboMaHD.TabIndex = 11;
            this.cboMaHD.SelectedIndexChanged += new System.EventHandler(this.cboMaHD_SelectedIndexChanged);
            this.cboMaHD.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboMaHD_KeyPress);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(38, 101);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(802, 179);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // txtGiamgia
            // 
            this.txtGiamgia.Location = new System.Drawing.Point(714, 69);
            this.txtGiamgia.Name = "txtGiamgia";
            this.txtGiamgia.Size = new System.Drawing.Size(121, 26);
            this.txtGiamgia.TabIndex = 9;
            this.txtGiamgia.TextChanged += new System.EventHandler(this.txtGiamgia_TextChanged);
            this.txtGiamgia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGiamgia_KeyPress);
            // 
            // txtThanhtien
            // 
            this.txtThanhtien.Location = new System.Drawing.Point(577, 69);
            this.txtThanhtien.Name = "txtThanhtien";
            this.txtThanhtien.Size = new System.Drawing.Size(131, 26);
            this.txtThanhtien.TabIndex = 8;
            this.txtThanhtien.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtThanhtien_KeyPress);
            // 
            // txtSoluong
            // 
            this.txtSoluong.Location = new System.Drawing.Point(311, 69);
            this.txtSoluong.Name = "txtSoluong";
            this.txtSoluong.Size = new System.Drawing.Size(121, 26);
            this.txtSoluong.TabIndex = 7;
            this.txtSoluong.TextChanged += new System.EventHandler(this.txtSoluong_TextChanged);
            this.txtSoluong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoluong_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(585, 46);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 20);
            this.label9.TabIndex = 4;
            this.label9.Text = "Thành tiền";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(713, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 20);
            this.label6.TabIndex = 3;
            this.label6.Text = "Giảm giá";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(190, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Mã sản phẩm";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(330, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Số lượng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã hóa đơn";
            // 
            // grbHDN
            // 
            this.grbHDN.Controls.Add(this.label11);
            this.grbHDN.Controls.Add(this.txtTongTien);
            this.grbHDN.Controls.Add(this.label8);
            this.grbHDN.Controls.Add(this.label5);
            this.grbHDN.Controls.Add(this.label7);
            this.grbHDN.Controls.Add(this.txtMahoadon);
            this.grbHDN.Controls.Add(this.txtNgaynhap);
            this.grbHDN.Controls.Add(this.cboMaNCC);
            this.grbHDN.Controls.Add(this.cboManhanvien);
            this.grbHDN.Controls.Add(this.label1);
            this.grbHDN.Location = new System.Drawing.Point(37, 6);
            this.grbHDN.Name = "grbHDN";
            this.grbHDN.Size = new System.Drawing.Size(869, 153);
            this.grbHDN.TabIndex = 30;
            this.grbHDN.TabStop = false;
            this.grbHDN.Text = "Hóa đơn nhập";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(62, 114);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(75, 20);
            this.label11.TabIndex = 18;
            this.label11.Text = "Tổng tiền";
            // 
            // txtTongTien
            // 
            this.txtTongTien.Location = new System.Drawing.Point(143, 114);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(259, 26);
            this.txtTongTien.TabIndex = 17;
            this.txtTongTien.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTongTien_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(480, 85);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 20);
            this.label8.TabIndex = 7;
            this.label8.Text = "Mã nhân viên";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(44, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Mã hóa đơn";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(52, 82);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Ngày nhập";
            // 
            // txtMahoadon
            // 
            this.txtMahoadon.Location = new System.Drawing.Point(143, 49);
            this.txtMahoadon.Name = "txtMahoadon";
            this.txtMahoadon.Size = new System.Drawing.Size(259, 26);
            this.txtMahoadon.TabIndex = 9;
            // 
            // txtNgaynhap
            // 
            this.txtNgaynhap.Location = new System.Drawing.Point(143, 82);
            this.txtNgaynhap.Name = "txtNgaynhap";
            this.txtNgaynhap.Size = new System.Drawing.Size(259, 26);
            this.txtNgaynhap.TabIndex = 10;
            // 
            // cboMaNCC
            // 
            this.cboMaNCC.FormattingEnabled = true;
            this.cboMaNCC.Location = new System.Drawing.Point(589, 46);
            this.cboMaNCC.Name = "cboMaNCC";
            this.cboMaNCC.Size = new System.Drawing.Size(259, 28);
            this.cboMaNCC.TabIndex = 16;
            // 
            // cboManhanvien
            // 
            this.cboManhanvien.FormattingEnabled = true;
            this.cboManhanvien.Location = new System.Drawing.Point(589, 85);
            this.cboManhanvien.Name = "cboManhanvien";
            this.cboManhanvien.Size = new System.Drawing.Size(259, 28);
            this.cboManhanvien.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(452, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã nhà cung cấp";
            // 
            // btnDong
            // 
            this.btnDong.Location = new System.Drawing.Point(754, 538);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(121, 33);
            this.btnDong.TabIndex = 29;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(521, 538);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(121, 33);
            this.btnHuy.TabIndex = 27;
            this.btnHuy.Text = "Hủy hóa đơn";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(299, 538);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(121, 33);
            this.btnLuu.TabIndex = 26;
            this.btnLuu.Text = "Lưu hóa đơn";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(73, 538);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(121, 33);
            this.btnThem.TabIndex = 25;
            this.btnThem.Text = "Thêm hóa đơn";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // frmHDN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCoral;
            this.ClientSize = new System.Drawing.Size(953, 595);
            this.Controls.Add(this.grbChitietHDN);
            this.Controls.Add(this.grbHDN);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnThem);
            this.Name = "frmHDN";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Hóa đơn nhập hàng";
            this.Load += new System.EventHandler(this.frmHDN_Load);
            this.grbChitietHDN.ResumeLayout(false);
            this.grbChitietHDN.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.grbHDN.ResumeLayout(false);
            this.grbHDN.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbChitietHDN;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtGiamgia;
        private System.Windows.Forms.TextBox txtThanhtien;
        private System.Windows.Forms.TextBox txtSoluong;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox grbHDN;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMahoadon;
        private System.Windows.Forms.TextBox txtNgaynhap;
        private System.Windows.Forms.ComboBox cboMaNCC;
        private System.Windows.Forms.ComboBox cboManhanvien;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.ComboBox cboMaSP;
        private System.Windows.Forms.ComboBox cboMaHD;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtTongTien;
    }
}
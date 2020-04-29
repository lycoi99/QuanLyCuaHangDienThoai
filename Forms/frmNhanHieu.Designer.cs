namespace QuanLyCuaHangDienThoai.Forms
{
    partial class frmNhanHieu
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaNhanHieu = new System.Windows.Forms.TextBox();
            this.txtTenNhanHieu = new System.Windows.Forms.TextBox();
            this.DataGridView_NhanHieu = new System.Windows.Forms.DataGridView();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnDong = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_NhanHieu)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên Nhãn Hiệu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã Nhãn Hiệu";
            // 
            // txtMaNhanHieu
            // 
            this.txtMaNhanHieu.Location = new System.Drawing.Point(205, 35);
            this.txtMaNhanHieu.Name = "txtMaNhanHieu";
            this.txtMaNhanHieu.Size = new System.Drawing.Size(263, 26);
            this.txtMaNhanHieu.TabIndex = 2;
            // 
            // txtTenNhanHieu
            // 
            this.txtTenNhanHieu.Location = new System.Drawing.Point(205, 86);
            this.txtTenNhanHieu.Name = "txtTenNhanHieu";
            this.txtTenNhanHieu.Size = new System.Drawing.Size(263, 26);
            this.txtTenNhanHieu.TabIndex = 3;
            // 
            // DataGridView_NhanHieu
            // 
            this.DataGridView_NhanHieu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView_NhanHieu.Location = new System.Drawing.Point(111, 166);
            this.DataGridView_NhanHieu.Name = "DataGridView_NhanHieu";
            this.DataGridView_NhanHieu.RowHeadersWidth = 62;
            this.DataGridView_NhanHieu.RowTemplate.Height = 28;
            this.DataGridView_NhanHieu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridView_NhanHieu.Size = new System.Drawing.Size(634, 195);
            this.DataGridView_NhanHieu.TabIndex = 4;
            this.DataGridView_NhanHieu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView_NhanHieu_CellClick);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(31, 391);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(124, 29);
            this.btnThem.TabIndex = 5;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(161, 391);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(124, 29);
            this.btnSua.TabIndex = 6;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click_1);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(291, 391);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(124, 29);
            this.btnXoa.TabIndex = 7;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(421, 391);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(124, 29);
            this.btnLuu.TabIndex = 8;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click_1);
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(551, 391);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(124, 29);
            this.btnHuy.TabIndex = 9;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnDong
            // 
            this.btnDong.Location = new System.Drawing.Point(681, 391);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(124, 29);
            this.btnDong.TabIndex = 10;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click_1);
            // 
            // frmNhanHieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 450);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.DataGridView_NhanHieu);
            this.Controls.Add(this.txtTenNhanHieu);
            this.Controls.Add(this.txtMaNhanHieu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmNhanHieu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhãn Hiệu";
            this.Activated += new System.EventHandler(this.frmNhanHieu_Activated_1);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmNhanHieu_FormClosed);
            this.Load += new System.EventHandler(this.frmNhanHieu_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_NhanHieu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaNhanHieu;
        private System.Windows.Forms.TextBox txtTenNhanHieu;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.DataGridView DataGridView_NhanHieu;
    }
}
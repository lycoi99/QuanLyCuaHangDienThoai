using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;




namespace QuanLyCuaHangDienThoai.Forms
{
    public partial class frmSanPham : Form
    {
        public frmSanPham()
        {
            InitializeComponent();
        }
        private void Hienthi_Luoi()
        {
            string sql;

            DataTable tblSanPham;

            sql = "select MaSP, TenSP, MaLoai, MaNhanHieu, GiaNhap, GiaBan, SoLuong, ThoiGianBaoHanh, MaManHinh, AmThanh, Anh, ChupAnh from tblSanPham";

            tblSanPham = ThucThiSQL.DocBang(sql);

            DataGridView_SP.DataSource = tblSanPham;

            DataGridView_SP.Columns[0].HeaderText = "Mã sản phẩm";

            DataGridView_SP.Columns[1].HeaderText = "Tên sản phẩm";

            DataGridView_SP.Columns[2].HeaderText = "Mã loại";

            DataGridView_SP.Columns[3].HeaderText = "Mã nhãn hiệu";

            DataGridView_SP.Columns[4].HeaderText = "Giá nhập";

            DataGridView_SP.Columns[5].HeaderText = "Giá bán";

            DataGridView_SP.Columns[6].HeaderText = "Số lượng";

            DataGridView_SP.Columns[7].HeaderText = "Thời gian BH";

            DataGridView_SP.Columns[8].HeaderText = "Mã màn hình";

            DataGridView_SP.Columns[9].HeaderText = "Âm thanh";

            DataGridView_SP.Columns[10].HeaderText = "Ảnh";

            DataGridView_SP.Columns[11].HeaderText = "Chụp Ảnh";

            DataGridView_SP.Columns[0].Width = 50;

            DataGridView_SP.Columns[1].Width = 100;

            DataGridView_SP.Columns[2].Width = 50;

            DataGridView_SP.Columns[3].Width = 50;

            DataGridView_SP.Columns[4].Width = 50;

            DataGridView_SP.Columns[5].Width = 50;

            DataGridView_SP.Columns[5].Width = 50;

            DataGridView_SP.Columns[6].Width = 50;

            DataGridView_SP.Columns[7].Width = 50;

            DataGridView_SP.Columns[8].Width = 50;

            DataGridView_SP.Columns[9].Width = 50;

            DataGridView_SP.Columns[10].Width = 50;

            DataGridView_SP.Columns[11].Width = 50;

            DataGridView_SP.AllowUserToAddRows = false;

            DataGridView_SP.EditMode = DataGridViewEditMode.EditProgrammatically;
            tblSanPham.Dispose();
        }

        private void frmSanPham_Load(object sender, EventArgs e)
        {

            Hienthi_Luoi();
            cboMaLoai.DataSource = ThucThiSQL.DocBang("SELECT MaLoai FROM tblLoai");
            cboMaLoai.DisplayMember = "MaLoai";
            cboMaLoai.SelectedIndex = -1;
            cboMaNhanHieu.DataSource = ThucThiSQL.DocBang("SELECT MaNhanHieu FROM tblNhanHieu");
            cboMaNhanHieu.DisplayMember = "MaNhanHieu";
            cboMaNhanHieu.SelectedIndex = -1;
            cboMaManHinh.DataSource = ThucThiSQL.DocBang("SELECT MaManHinh FROM tblManHinh");
            cboMaManHinh.DisplayMember = "MaManHinh";
            cboMaManHinh.SelectedIndex = -1;



        }

        private void frmSanPham_Activated(object sender, EventArgs e)
        {
            Hienthi_Luoi();
        }
        private void ResetValues()
        {
            txtMaSP.Text = "";

            txtAmThanh.Text = "";

            txtAnh.Text = "";

            txtChupAnh.Text = "";

            txtGiaBan.Text = "";

            txtGiaNhap.Text = "";

            cboMaNhanHieu.Text = "";

            txtSoLuong.Text = "";

            txtTenSanPham.Text = "";

            txtThoiGianBaoHanh.Text = "";

            cboMaLoai.Text = "";

            cboMaManHinh.Text = "";

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnSua.Enabled = false;
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            btnHuy.Enabled = true;
            btnLuu.Enabled = true;
            btnDong.Enabled = true;
            ResetValues();
            txtMaSP.Enabled = true;
            txtMaSP.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql;
            DataTable tblSanPham;
            sql = "SELECT MaSP, TenSP, MaLoai, MaNhanHieu, GiaNhap, GiaBan, SoLuong, ThoiGianBaoHanh, MaManHinh, AmThanh, Anh, ChupAnh from tblSanPham";
            tblSanPham = ThucThiSQL.DocBang(sql);

            {
                if (tblSanPham.Rows.Count == 0)
                {
                    MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (txtMaSP.Text == "")
                {
                    MessageBox.Show("Bạn chưa chọn bản ghi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (txtTenSanPham.Text.Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập tên sản phẩm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtTenSanPham.Focus();
                    return;
                }
                if (cboMaLoai.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập mã loại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cboMaLoai.Focus();
                    return;
                }
                if (cboMaNhanHieu.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập mã nhãn hiệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cboMaNhanHieu.Focus();
                    return;
                }
                if (txtGiaNhap.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập giá nhập!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtGiaNhap.Focus();
                    return;
                }
                
                if (txtSoLuong.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập số lượng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtSoLuong.Focus();
                    return;
                }
                if (txtThoiGianBaoHanh.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập thời gian bảo hành!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtThoiGianBaoHanh.Focus();
                    return;
                }
                if (cboMaManHinh.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập mã màn hình!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cboMaManHinh.Focus();
                    return;
                }
                if (txtAmThanh.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập âm thanh!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtAmThanh.Focus();
                    return;
                }

                sql = "UPDATE tblSanPham SET TenSP=N'" + txtTenSanPham.Text + "', MaLoai = '" + cboMaLoai.Text.Trim() + "', MaNhanHieu = '" + cboMaNhanHieu.Text.Trim() + "', GiaNhap = '" + Convert.ToDouble(txtGiaNhap.Text) + "', GiaBan = '" + Convert.ToDouble(txtGiaBan.Text) + "', SoLuong = '" + Convert.ToDouble(txtSoLuong.Text) + "', ThoiGianBaoHanh =  '" + Convert.ToDouble(txtThoiGianBaoHanh.Text) + "', MaManHinh =  '" + cboMaManHinh.Text.Trim() + "', AmThanh = N'"  + txtAmThanh.Text.Trim() +  "', Anh = N'" + txtAnh.Text.Trim() + "', ChupAnh = N'" + txtChupAnh.Text.Trim() + "' WHERE MaSP = N'" + txtMaSP.Text.Trim() + "'";
                ThucThiSQL.CapNhatDuLieu(sql);
                Hienthi_Luoi();
                ResetValues();
                btnLuu.Enabled = false;
                btnXoa.Enabled = false;
                btnThem.Enabled = false;
                txtMaSP.Enabled = false;
            }

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql;
            {
                if (txtMaSP.Text == "")
                {
                    MessageBox.Show("Bạn chưa nhập mã sản phẩm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtMaSP.Focus();
                    return;
                }
                if (txtTenSanPham.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập tên sản phẩm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtTenSanPham.Focus();
                    return;
                }
                if (cboMaLoai.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập mã loại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cboMaLoai.Focus();
                    return;
                }
                if (cboMaNhanHieu.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập mã nhãn hiệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cboMaNhanHieu.Focus();
                    return;
                }
                //if (txtGiaNhap.Text.Trim().Length == 0)
                //{
                //    MessageBox.Show("Bạn phải nhập giá nhập!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //    txtGiaNhap.Focus();
                //    return;
                //}

                
                if (txtSoLuong.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập số lượng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtSoLuong.Focus();
                    return;
                }
                if (txtThoiGianBaoHanh.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập thời gian bảo hành!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtThoiGianBaoHanh.Focus();
                    return;
                }
                if (cboMaManHinh.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập mã màn hình!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cboMaManHinh.Focus();
                    return;
                }
                if (txtAmThanh.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập âm thanh!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtAmThanh.Focus();
                    return;
                }
               

                sql = "SELECT MaSP FROM tblSanPham WHERE MaSP=N'" + txtMaSP.Text + "'";
                DataTable tblSanPham = ThucThiSQL.DocBang(sql);
                if (tblSanPham.Rows.Count > 0)
                {
                    MessageBox.Show("Mã sản phẩm này đã có, bạn phải nhập mã khác !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    
                    txtMaSP.Text = "";
                    txtMaSP.Focus();
                    return;
                }
                sql = "INSERT INTO tblSanPham(MaSP, TenSP, MaLoai, MaNhanHieu, GiaNhap, GiaBan, SoLuong, ThoiGianBaoHanh, MaManHinh," + "AmThanh, Anh, ChupAnh)values" + "(N'" + txtMaSP.Text.Trim() + "',N'" + txtTenSanPham.Text + "','" + cboMaLoai.Text.Trim() + "','" + cboMaNhanHieu.Text.Trim()
                   + "','" + Convert.ToDouble(txtGiaNhap.Text) + "','" + Convert.ToDouble(txtGiaBan.Text)
                    + "','" + Convert.ToDouble(txtSoLuong.Text) + "','" + Convert.ToDouble(txtThoiGianBaoHanh.Text) + "','" + cboMaManHinh.Text.Trim() + "','" + txtAmThanh.Text.Trim() + "',N'" + txtAnh.Text + "','" + txtChupAnh.Text + "')";
                ThucThiSQL.CapNhatDuLieu(sql);
                Hienthi_Luoi();

            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void txtGiaNhap_TextChanged(object sender, EventArgs e)
        {
            double giaban, gianhap;
            if (txtGiaNhap.Text == "")
            {
                giaban = 0;
                gianhap = 0;
            }
            else gianhap = Convert.ToDouble(txtGiaNhap.Text);
            giaban = gianhap + (gianhap / 10);
            txtGiaBan.Text = giaban.ToString();
        }

        private void txtGiaNhap_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void cboMaLoai_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar))
            {
                MessageBox.Show("Bạn vui lòng chọn dữ liệu đã có!", "Thông báo");
                e.Handled = true;
            }
        }

        private void cboMaNhanHieu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar))
            {
                MessageBox.Show("Bạn vui lòng chọn dữ liệu đã có!", "Thông báo");
                e.Handled = true;
            }
        }

        private void cboMaManHinh_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar))
            {
                MessageBox.Show("Bạn vui lòng chọn dữ liệu đã có!", "Thông báo");
                e.Handled = true;
            }
        }

        private void txtSoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (DataGridView_SP.CurrentRow.Cells["MaSP"].Value.ToString() == "")
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo");
                return;
            }
            string mt;
            mt = DataGridView_SP.CurrentRow.Cells["MaSP"].Value.ToString();
            if (MessageBox.Show("Bạn có muốn xóa không ?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                sql = "DELETE tblSanPham WHERE MaSP = N'" + mt + "'";
                ThucThiSQL.CapNhatDuLieu(sql);
                Hienthi_Luoi();
            }
        }

        private void txtThoiGianBaoHanh_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void DataGridView_SP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int numrow;
            numrow = e.RowIndex;
            txtMaSP.Text = DataGridView_SP.Rows[numrow].Cells[0].Value.ToString();
            txtTenSanPham.Text = DataGridView_SP.Rows[numrow].Cells[1].Value.ToString();
            cboMaLoai.Text = DataGridView_SP.Rows[numrow].Cells[2].Value.ToString();
            cboMaNhanHieu.Text = DataGridView_SP.Rows[numrow].Cells[3].Value.ToString();
            txtGiaNhap.Text = DataGridView_SP.Rows[numrow].Cells[4].Value.ToString();
            txtGiaBan.Text = DataGridView_SP.Rows[numrow].Cells[5].Value.ToString();
            txtSoLuong.Text = DataGridView_SP.Rows[numrow].Cells[6].Value.ToString();
            txtThoiGianBaoHanh.Text = DataGridView_SP.Rows[numrow].Cells[7].Value.ToString();
            cboMaManHinh.Text = DataGridView_SP.Rows[numrow].Cells[8].Value.ToString();
            txtAmThanh.Text = DataGridView_SP.Rows[numrow].Cells[9].Value.ToString();
            txtAnh.Text = DataGridView_SP.Rows[numrow].Cells[10].Value.ToString();
            txtChupAnh.Text = DataGridView_SP.Rows[numrow].Cells[11].Value.ToString();
            pictureBox1.Image = Image.FromFile(txtAnh.Text);
            

        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            ResetValues();
            txtMaSP.Enabled = true;
            btnHuy.Enabled = false;
            btnLuu.Enabled = false;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
        }

        private void btnMo_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlgOpen = new OpenFileDialog();
            dlgOpen.Filter = "Ảnh jpg|*.jpg|Ảnh bitmap|*.bmp|All files|*.*";
            dlgOpen.InitialDirectory = "D:\\Lập trình 2\\Ảnh";
            dlgOpen.FilterIndex = 2;
            dlgOpen.Title = "Chọn ảnh để hiển thị";
            if (dlgOpen.ShowDialog() == DialogResult.OK)
            {
                txtAnh.Text = dlgOpen.FileName;
                pictureBox1.Image = Image.FromFile(dlgOpen.FileName);
            }
        }

        private void txtMaSP_TextChanged(object sender, EventArgs e)
        {

            /*string gianhap;
            gianhap = "SELECT DonGia FROM tblChitietHDN WHERE MaSP=N'" + txtMaSP.Text + "'";
            txtGiaNhap.Text = gianhap.ToString();*/
        }

        private void txtGiaBan_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

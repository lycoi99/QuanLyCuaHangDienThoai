using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCuaHangDienThoai.Forms
{
    public partial class frmNhaCungCap : Form
    {
        public frmNhaCungCap()
        {
            InitializeComponent();
        }
        private void Hienthi_Luoi()
        {
            string sql;
            DataTable tblNhaCungCap;
            sql = "SELECT MaNCC, TenNCC, DiaChi, SDT from tblNhaCungCap";
            tblNhaCungCap = ThucThiSQL.DocBang(sql);
            DataGridView_NCC.DataSource = tblNhaCungCap;
            DataGridView_NCC.Columns[0].HeaderText = "Mã nhà cung cấp";
            DataGridView_NCC.Columns[1].HeaderText = "Tên nhà cung cấp";
            DataGridView_NCC.Columns[2].HeaderText = "SĐT";
            DataGridView_NCC.Columns[3].HeaderText = "Địa chỉ";
            DataGridView_NCC.Columns[0].Width = 100;
            DataGridView_NCC.Columns[1].Width = 300;
            DataGridView_NCC.Columns[2].Width = 100;
            DataGridView_NCC.Columns[3].Width = 300;
            DataGridView_NCC.AllowUserToAddRows = false;
            DataGridView_NCC.EditMode = DataGridViewEditMode.EditProgrammatically;



        }
        private void frmNhaCungCap_Load(object sender, EventArgs e)
        {
            Hienthi_Luoi();
        }

        private void frmNhaCungCap_Activated(object sender, EventArgs e)
        {
            Hienthi_Luoi();
        }

        private void ResetValues()
        {
            txtMaNCC.Text = "";
            txtTenNCC.Text = "";
            txtDiaChi.Text = "";
            txtSDT.Text = "";
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
            txtMaNCC.Enabled = true;
            txtMaNCC.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql;
            DataTable tblNhaCungCap;
            sql = "Select MaNCC, TenNCC, DiaChi,SDT from tblNhaCungCap";
            tblNhaCungCap = ThucThiSQL.DocBang(sql);
            if (tblNhaCungCap.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }     
            if (txtMaNCC.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }    
            if (txtTenNCC.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên nhà cung cấp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenNCC.Focus();
                return;
            }    
            if (txtDiaChi.Text.Trim().Length==0)
            {
                MessageBox.Show("Bạn phải nhập địa chỉ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDiaChi.Focus();
                return;
            }    
            if (txtSDT.Text.Trim().Length==0)
            {
                MessageBox.Show("Bạn phải nhập số điện thoại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSDT.Focus();
                return;
            }    
             sql = "UPDATE tblNhaCungCap SET TenNCC=N'" + txtTenNCC.Text + "', DiaChi = N'" + txtDiaChi.Text.Trim() + "', SDT = N'" + txtSDT.Text.Trim() + "' WHERE MaNCC = N'" + txtMaNCC.Text.Trim() + "'";
            ThucThiSQL.CapNhatDuLieu(sql);
            Hienthi_Luoi();
            ResetValues();
            btnLuu.Enabled = false;
            btnXoa.Enabled = false;
            btnThem.Enabled = false;
            txtMaNCC.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (DataGridView_NCC.CurrentRow.Cells["MaNCC"].Value.ToString() == "")
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo");
                return;
            }
            string mt;
            mt = DataGridView_NCC.CurrentRow.Cells["MaNCC"].Value.ToString();
            if (MessageBox.Show("Bạn có muốn xóa không ?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                sql = "DELETE tblNhaCungCap WHERE MaNCC = N'" + mt + "'";
                ThucThiSQL.CapNhatDuLieu(sql);
                Hienthi_Luoi();
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {

            string sql;
            if (txtMaNCC.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã nhà cung cấp !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaNCC.Focus();
                return;
            }
            if (txtTenNCC.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên nhà cung cấp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenNCC.Focus();
                return;
            }
            if (txtDiaChi.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập địa chỉ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDiaChi.Focus();
                return;
            }
            if (txtSDT.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập số điện thoại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSDT.Focus();
                return;
            }

            sql = "SELECT MaNCC FROM tblNCC WHERE MaNCC=N'" + txtMaNCC.Text + "'";
            DataTable tblNCC = ThucThiSQL.DocBang(sql);
            if (tblNCC.Rows.Count > 0)
            {
                MessageBox.Show("Mã nhà cung cấp này đã có, bạn phải nhập mã khác !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaNCC.Focus();
                txtMaNCC.Text = "";
                return;
            }

            sql = "INSERT INTO tblNhaCungCap(MaNCC,TenNCC, DiaChi, SDT) VALUES(N'" + txtMaNCC.Text.Trim() + "', N'" + txtTenNCC.Text.Trim() + "', N'" + txtDiaChi.Text.Trim() + "', N'" + txtSDT.Text.Trim() + "')";


            ThucThiSQL.CapNhatDuLieu(sql);

            Hienthi_Luoi();

            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnHuy.Enabled = false;
            btnLuu.Enabled = false;
            txtMaNCC.Enabled = false;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            ResetValues();
            txtMaNCC.Enabled = true;
            btnHuy.Enabled = false;
            btnLuu.Enabled = false;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
      
        }
    }
}

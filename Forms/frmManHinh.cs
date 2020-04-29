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
    public partial class frmManHinh : Form
    {
        public frmManHinh()
        {
            InitializeComponent();
        }
        private void Hienthi_Luoi()
        {
            string sql;

            DataTable tblManHinh;

            sql = "SELECT MaManHinh,TenManHinh FROM tblManHinh";

            tblManHinh = ThucThiSQL.DocBang(sql);
            DataGridView_ManHinh.DataSource = tblManHinh;
            DataGridView_ManHinh.Columns[0].HeaderText = "Mã Loại";

            DataGridView_ManHinh.Columns[1].HeaderText = "Tên Loại";

            DataGridView_ManHinh.Columns[0].Width = 100;

            DataGridView_ManHinh.Columns[1].Width = 300;
            DataGridView_ManHinh.AllowUserToAddRows = false;

            DataGridView_ManHinh.EditMode = DataGridViewEditMode.EditProgrammatically;

        }



        private void frmManHinh_Load(object sender, EventArgs e)
        {
            Hienthi_Luoi();
        }

        private void frmManHinh_Activated(object sender, EventArgs e)
        {
            Hienthi_Luoi();
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
            txtMaManHinh.Enabled = true;
            txtTenManHinh.Focus();
        }
        private void ResetValues()
        {
            txtMaManHinh.Text = "";
            txtTenManHinh.Text = "";
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql;
            DataTable tblManHinh;
            sql = "SELECT MaManHinh, TenManHinh FROM tblManHinh";
            tblManHinh = ThucThiSQL.DocBang(sql);
            if (tblManHinh.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMaManHinh.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtTenManHinh.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên loại!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenManHinh.Focus();
                return;
            }
            sql = "UPDATE tblManHinh SET TenManHinh=N'" + txtTenManHinh.Text.Trim() + "' WHERE MaLoai = N'" + txtMaManHinh.Text.Trim() + "'";
            ThucThiSQL.CapNhatDuLieu(sql);
            Hienthi_Luoi();
            ResetValues();
            btnLuu.Enabled = false;
            btnXoa.Enabled = false;
            btnThem.Enabled = false;
            txtMaManHinh.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (DataGridView_ManHinh.CurrentRow.Cells["MaManHinh"].Value.ToString() == "")
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo");
                return;
            }
            string mt;
            mt = DataGridView_ManHinh.CurrentRow.Cells["MaManHinh"].Value.ToString();
            if (MessageBox.Show("Bạn có muốn xóa không ?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                sql = "DELETE tblManHinh WHERE MaManHinh = N'" + mt + "'";
                ThucThiSQL.CapNhatDuLieu(sql);
                Hienthi_Luoi();
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql;
            if (txtMaManHinh.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã màn hình !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaManHinh.Focus();
                return;
            }
            if (txtMaManHinh.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên màn hình !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenManHinh.Focus();
                return;
            }
            sql = "SELECT MaManHinh FROM tblManHinh WHERE MaManHinh=N'" + txtMaManHinh.Text + "'";
            DataTable tblManHinh = ThucThiSQL.DocBang(sql);
            if (tblManHinh.Rows.Count > 0)
            {
                MessageBox.Show("Mã màn hình này đã có, bạn phải nhập mã khác !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaManHinh.Focus();
                txtMaManHinh.Text = "";
                return;
            }

            sql = "INSERT INTO tblManHinh (MaManHinh,TenManHinh) VALUES(N'" + txtMaManHinh.Text.Trim() + "', N'" + txtTenManHinh.Text.Trim() + "')";


            ThucThiSQL.CapNhatDuLieu(sql);

            Hienthi_Luoi();

            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnHuy.Enabled = false;
            btnLuu.Enabled = false;
            txtMaManHinh.Enabled = false;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            ResetValues();
            txtMaManHinh.Enabled = true;
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

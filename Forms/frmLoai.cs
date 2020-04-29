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
    public partial class frmLoai : Form
    {
        public frmLoai()
        {
            InitializeComponent();
        }
        private void Hienthi_Luoi()
        {
            string sql;

            DataTable tblLoai;

            sql = "SELECT MaLoai,TenLoai FROM tblLoai";

            tblLoai = ThucThiSQL.DocBang(sql);
            DataGridView_Loai.DataSource = tblLoai;
            DataGridView_Loai.Columns[0].HeaderText = "Mã Loại";

            DataGridView_Loai.Columns[1].HeaderText = "Tên Loại";

            DataGridView_Loai.Columns[0].Width = 100;

            DataGridView_Loai.Columns[1].Width = 300;
            DataGridView_Loai.AllowUserToAddRows = false;

            DataGridView_Loai.EditMode = DataGridViewEditMode.EditProgrammatically;

        }
        private void frmLoai_Load(object sender, EventArgs e)
        {
            Hienthi_Luoi();

        }

        private void frmLoai_Activated(object sender, EventArgs e)
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
            txtMaLoai.Enabled = true;
            txtTenLoai.Focus();
        }
        private void ResetValues()
        {
            txtMaLoai.Text = "";
            txtTenLoai.Text = "";
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql;
            DataTable tblLoai;
            sql = "SELECT MaLoai, TenLoai FROM tblLoai";
            tblLoai = ThucThiSQL.DocBang(sql);
            if (tblLoai.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMaLoai.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtTenLoai.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên loại!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenLoai.Focus();
                return;
            }
            sql = "UPDATE tblLoai SET TenLoai=N'" + txtTenLoai.Text.Trim() + "' WHERE MaLoai = N'" + txtMaLoai.Text.Trim() + "'";
            ThucThiSQL.CapNhatDuLieu(sql);
            Hienthi_Luoi();
            ResetValues();
            btnLuu.Enabled = false;
            btnXoa.Enabled = false;
            btnThem.Enabled = false;
            txtMaLoai.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (DataGridView_Loai.CurrentRow.Cells["MaLoai"].Value.ToString() == "")
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo");
                return;
            }
            string mt;
            mt = DataGridView_Loai.CurrentRow.Cells["MaLoai"].Value.ToString();
            if (MessageBox.Show("Bạn có muốn xóa không ?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                sql = "DELETE tblLoai WHERE MaLoai = N'" + mt + "'";
                ThucThiSQL.CapNhatDuLieu(sql);
                Hienthi_Luoi();
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql;
            if (txtMaLoai.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã loại !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaLoai.Focus();
                return;
            }
            if (txtTenLoai.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên loại !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenLoai.Focus();
                return;
            }
            sql = "SELECT MaLoai FROM tblLoai WHERE MaLoai=N'" + txtMaLoai.Text + "'";
            DataTable tblLoai = ThucThiSQL.DocBang(sql);
            if (tblLoai.Rows.Count > 0)
            {
                MessageBox.Show("Mã loại này đã có, bạn phải nhập mã khác !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaLoai.Focus();
                txtMaLoai.Text = "";
                return;
            }

            sql = "INSERT INTO tblLoai (MaLoai,TenLoai) VALUES(N'" + txtMaLoai.Text.Trim() + "', N'" + txtTenLoai.Text.Trim() + "')";


            ThucThiSQL.CapNhatDuLieu(sql);

            Hienthi_Luoi();

            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnHuy.Enabled = false;
            btnLuu.Enabled = false;
            txtMaLoai.Enabled = false;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            ResetValues();
            txtMaLoai.Enabled = true;
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

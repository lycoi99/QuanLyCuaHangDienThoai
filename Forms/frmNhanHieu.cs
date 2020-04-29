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
    public partial class frmNhanHieu : Form
    {
        public frmNhanHieu()
        {
            InitializeComponent();

            ThucThiSQL.KetNoiCSDL();

        }
        private void Hienthi_Luoi()
        {
            string sql;

            DataTable tblNhanHieu;

            sql = "SELECT MaNhanHieu,TenNhanHieu FROM tblNhanHieu";

            tblNhanHieu = ThucThiSQL.DocBang(sql);
            DataGridView_NhanHieu.DataSource = tblNhanHieu;
            DataGridView_NhanHieu.Columns[0].HeaderText = "Mã Nhãn Hiệu";

            DataGridView_NhanHieu.Columns[1].HeaderText = "Tên Nhãn Hiệu";

            DataGridView_NhanHieu.Columns[0].Width = 100;

            DataGridView_NhanHieu.Columns[1].Width = 300;

            DataGridView_NhanHieu.AllowUserToAddRows = false;

            DataGridView_NhanHieu.EditMode = DataGridViewEditMode.EditProgrammatically;

        }

        private void frmNhanHieu_Load_1(object sender, EventArgs e)
        {
            Hienthi_Luoi();
        }

        private void frmNhanHieu_Activated_1(object sender, EventArgs e)
        {
            Hienthi_Luoi();
        }

        private void frmNhanHieu_FormClosed(object sender, FormClosedEventArgs e)
        {
           
        }
        private void ResetValues()
        {
            txtMaNhanHieu.Text = "";
            txtMaNhanHieu.Text = "";
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
            txtMaNhanHieu.Enabled = true;
            txtMaNhanHieu.Focus();
        }
       
       private void  btnLuu_Click_1(object sender, EventArgs e)
        {
            string sql;
            if (txtMaNhanHieu.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã nhãn hiệu !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaNhanHieu.Focus();
                return;
            }
            if (txtTenNhanHieu.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên nhãn hiệu !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenNhanHieu.Focus();
                return;
            }
            sql = "SELECT MaNhanHieu FROM tblNhanHieu WHERE MaNhanHieu=N'" + txtMaNhanHieu.Text + "'";
            DataTable tblNhanHieu = ThucThiSQL.DocBang(sql);
            if (tblNhanHieu.Rows.Count > 0)
            {
                MessageBox.Show("Mã nhãn hiệu này đã có, bạn phải nhập mã khác !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaNhanHieu.Focus();
                txtMaNhanHieu.Text = "";
                return;
            }
            
            sql = "INSERT INTO tblNhanHieu (MaNhanHieu,TenNhanHieu) VALUES(N'" + txtMaNhanHieu.Text.Trim() + "', N'" + txtTenNhanHieu.Text.Trim()+ "')";
            

            ThucThiSQL.CapNhatDuLieu(sql);

            Hienthi_Luoi();

            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnHuy.Enabled = false;
            btnLuu.Enabled = false;
            txtMaNhanHieu.Enabled = false;
        }

       

        private void btnDong_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (DataGridView_NhanHieu.CurrentRow.Cells["MaNhanHieu"].Value.ToString() == "")
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo");
                return;
            }
            string mt;
            mt = DataGridView_NhanHieu.CurrentRow.Cells["MaNhanHieu"].Value.ToString();
            if (MessageBox.Show("Bạn có muốn xóa không ?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                sql = "DELETE tblNhanHieu WHERE MaNhanHieu = N'" + mt + "'";
                ThucThiSQL.CapNhatDuLieu(sql);
                Hienthi_Luoi();
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            ResetValues();
            txtMaNhanHieu.Enabled = true;
            btnHuy.Enabled = false;
            btnLuu.Enabled = false;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
        }

        private void btnSua_Click_1(object sender, EventArgs e)
        {
            string sql;
            DataTable tblNhanHieu;
            sql = "SELECT MaNhanHieu, TenNhanHieu FROM tblNhanHieu";
            tblNhanHieu = ThucThiSQL.DocBang(sql);
            if (tblNhanHieu.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMaNhanHieu.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtTenNhanHieu.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên nhãn hiệu!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenNhanHieu.Focus();
                return;
            }
            sql = "UPDATE tblNhanHieu SET TenNhanHieu=N'" + txtTenNhanHieu.Text.Trim() + "' WHERE MaNhanHieu = N'" + txtMaNhanHieu.Text.Trim() + "'";
            ThucThiSQL.CapNhatDuLieu(sql);
            Hienthi_Luoi();
            ResetValues();
            btnLuu.Enabled = false;
            btnXoa.Enabled = false;
            btnThem.Enabled = false;
            txtMaNhanHieu.Enabled = false;
        }

        private void DataGridView_NhanHieu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int numrow;
            numrow = e.RowIndex;
            txtMaNhanHieu.Text = DataGridView_NhanHieu.Rows[numrow].Cells[0].Value.ToString();
            txtTenNhanHieu.Text = DataGridView_NhanHieu.Rows[numrow].Cells[1].Value.ToString();
        }
    }
    }

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using COMExcel = Microsoft.Office.Interop.Excel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCuaHangDienThoai.Forms
{
    public partial class frmHDN : Form
    {
        public frmHDN()
        {
            InitializeComponent();
        }

        private void Hienthi_Luoi()
        {
            string sql;
            DataTable tblChitietHDN;
            sql = "SELECT MaHDN, MaSP, SoLuong, DonGia, ThanhTien, KhuyenMai FROM tblChitietHDN";
            ThucThiSQL.KetNoiCSDL();
            tblChitietHDN = ThucThiSQL.DocBang(sql);
            dataGridView1.DataSource = tblChitietHDN;
            dataGridView1.Columns[0].HeaderText = "Mã hóa đơn";
            dataGridView1.Columns[1].HeaderText = "Mã sản phẩm";
            dataGridView1.Columns[2].HeaderText = "Số lượng";
            dataGridView1.Columns[3].HeaderText = "Đơn giá ";
            dataGridView1.Columns[4].HeaderText = "Thành tiền";
            dataGridView1.Columns[5].HeaderText = "Khuyến Mại";
            dataGridView1.Columns[0].Width = 100;
            dataGridView1.Columns[1].Width = 100;
            dataGridView1.Columns[2].Width = 100;
            dataGridView1.Columns[3].Width = 100;
            dataGridView1.Columns[4].Width = 100;
            dataGridView1.Columns[5].Width = 100;

        }
        private void frmHDN_Load(object sender, EventArgs e)
        {
            btnThem.Enabled = true;
            btnLuu.Enabled = false;
            //btnIn.Enabled = false;
            btnHuy.Enabled = false;
            btnDong.Enabled = false;
            txtMahoadon.Enabled = true;
            txtNgaynhap.Enabled = true;
            txtSoluong.Enabled = true;
            txtThanhtien.Text = "0";
            txtGiamgia.Text = "0";
            cboMaSP.DataSource = ThucThiSQL.DocBang("SELECT MaSP FROM tblSanPham");
            cboMaSP.DisplayMember = "MaSP";
            cboMaSP.SelectedIndex = -1;
            cboMaHD.DataSource = ThucThiSQL.DocBang("SELECT MaHDN FROM tblHoaDonNhap");
            cboMaHD.DisplayMember = "MaHDN";
            cboMaHD.SelectedIndex = -1;
            cboMaNCC.DataSource = ThucThiSQL.DocBang("SELECT MaKH FROM tblKhachHang");
            cboMaNCC.DisplayMember = "MaKH";
            cboMaNCC.SelectedIndex = -1;
            cboManhanvien.DataSource = ThucThiSQL.DocBang("SELECT MaNV FROM tblNhanVien");
            cboManhanvien.DisplayMember = "MaNV";
            cboManhanvien.SelectedIndex = -1;
            cboMaNCC.DataSource = ThucThiSQL.DocBang("select MaNCC from tblNhaCungCap");
            cboMaNCC.DisplayMember = "MaNCC";
            cboMaNCC.SelectedIndex = -1;

            if (txtMahoadon.Text != "")
            {

                //btnIn.Enabled = true;
                btnHuy.Enabled = true;

            }
            Hienthi_Luoi();



        }

        private void ResetValues()
        {
            txtMahoadon.Text = "";

            txtGiamgia.Text = "";

            txtNgaynhap.Text = "";

            txtSoluong.Text = "";

            txtTongTien.Text = "";

            cboMaHD.Text = "";
            cboMaNCC.Text = "";
            cboManhanvien.Text = "";
            cboMaSP.Text = "";

        }
        private void btnThem_Click(object sender, EventArgs e)
        {

            btnThem.Enabled = false;
            //btnIn.Enabled = false;
            btnHuy.Enabled = true;
            btnLuu.Enabled = true;
            btnDong.Enabled = true;
            ResetValues();
            grbChitietHDN.Enabled = false;
            grbHDN.Enabled = true;
            txtMahoadon.Enabled = true;
            txtMahoadon.Focus();
            txtNgaynhap.Text = DateTime.Now.ToShortDateString();
            dataGridView1.DataSource = null;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql;
            if (txtMahoadon.Text.Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã hóa đơn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMahoadon.Focus();
                return;

            }
            if (txtNgaynhap.Text.Length == 0)
            {
                MessageBox.Show("Bạn phải nhập ngày nhập!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNgaynhap.Focus();
                return;

            }
            if (cboMaNCC.Text.Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã nhà cung cấp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboMaNCC.Focus();
                return;

            }
            if (cboManhanvien.Text.Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã nhân viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboManhanvien.Focus();
                return;
            }
            sql = "Insert into tblHoaDonNhap(MaHDN, NgayNhap, MaNV, MaNCC, TongTien) values ( N'" + txtMahoadon.Text.Trim() + "', '" + ThucThiSQL.ConvertDateTime(txtNgaynhap.Text) + "', N'" + cboManhanvien.Text.Trim() + "', N'" + cboMaNCC.Text.Trim() + "', N'" + Convert.ToDouble(txtThanhtien.Text) + "')";
            ThucThiSQL.CapNhatDuLieu(sql);
            btnLuu.Enabled = false;
            grbChitietHDN.Enabled = true;
            Hienthi_Luoi();

        }
        private void DelUpdateHang(string mahangxoa, double slxoa, double dongiaxoa)
        {
            //Cập nhật sl hàng vào bảng hàng theo công thức slmoi=sl trong bảng hàng-sl đã bị xóa
            double sl = Convert.ToDouble(ThucThiSQL.DocBang("select SoLuong from tblSanPham where MaSP=N'" + mahangxoa + "'").Rows[0][0].ToString());
            double slmoi = sl - slxoa;
            string sql = "update tblSanPham set SoLuong=" + slmoi + "where MaSP=N'" + mahangxoa + "'";
            ThucThiSQL.CapNhatDuLieu(sql);
        }
        //private void DelUpdateTongtien(string mahoadonxoa, double thanhtienxoa)
        //{
        //    double tong = Convert.ToDouble(ThucThiSQL.DocBang("Select TongTien from tblHoaDonNhap where MaHDN=N'" + mahoadonxoa + "'").Rows[0][0].ToString());
        //    double tongmoi = tong - thanhtienxoa;
        //    string sql = "UPDATE tblHoaDonNhap SET TongTien =" + tongmoi + " WHERE MaHDN = N'" + mahoadonxoa + "'";
        //    ThucThiSQL.CapNhatDuLieu(sql);
        //    txtThanhtien.Text = tongmoi.ToString();

        //}

        private void btnHuy_Click(object sender, EventArgs e)
        {
            //Lấy thông tin các mặt hàng sẽ bị xóa
            string sql = "select MaSP,SoLuong,DonGia from tblChitietHDN where MaHDN=N'" + txtMahoadon.Text + "'";
            DataTable tbl = ThucThiSQL.DocBang(sql);
            //Xóa hóa đơn
            sql = "Delete tblHoaDonNhap where MaHDN=N'" + txtMahoadon.Text + "'";
            ThucThiSQL.CapNhatDuLieu(sql);
            ResetValues();
            dataGridView1.DataSource = "";
            //Cập nhật số lượng hàng đơn giá nhập, đơn giá bán cho từng mặt hàng sẽ bị xóa
            for (int i = 0; i < tbl.Rows.Count; i++)
            {
                DelUpdateHang(tbl.Rows[i][0].ToString(), Convert.ToDouble(tbl.Rows[i][1]), Convert.ToDouble(tbl.Rows[i][2]));
            }
            btnHuy.Enabled = false;
            //btnIn.Enabled = true;
            btnThem.Enabled = true;
            grbHDN.Enabled = true;
            grbChitietHDN.Enabled = true;
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            string sql = "Select * from tblChitietHDN where MaHDN=N'" + cboMaHD.Text + "'";
            if (ThucThiSQL.DocBang(sql).Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                //Lấy thông tin Mã hóa đơn, mã hàng, số lượng, giá nhập, thành tiền của dòng dl muốn xóa
                string mahdxoa = dataGridView1.CurrentRow.Cells["MaHDN"].Value.ToString();
                string mahangxoa = dataGridView1.CurrentRow.Cells["MaSP"].Value.ToString();
                double slxoa = Convert.ToDouble(dataGridView1.CurrentRow.Cells["SoLuong"].Value.ToString());
                double dongiaxoa = Convert.ToDouble(dataGridView1.CurrentRow.Cells["DonGia"].Value.ToString());
                double thanhtienxoa = Convert.ToDouble(dataGridView1.CurrentRow.Cells["ThanhTien"].Value.ToString());
                //Xóa hàng trong bảng Chi tiết HDN
                sql = "Delete tblChitietHDN where MaHDN=N'" + cboMaHD.Text + "'AND MaSP=N'" + mahangxoa + "'";
                ThucThiSQL.CapNhatDuLieu(sql);
                Hienthi_Luoi();
                //Cập nhật lại số lượng hàng, đơn giá nhập, đơn giá bán
                DelUpdateHang(mahangxoa, slxoa, dongiaxoa);
                //Cập nhật lại tổng tiền cho hóa đơn nhập
                //DelUpdateTongtien(txtMahoadon.Text, thanhtienxoa);
            }


        }
        private void ResetValuesHang()
        {
            cboMaSP.Text = "";
            txtSoluong.Text = "";
            txtDonGia.Text = "";
            txtGiamgia.Text = "";
            cboMaHD.Text = "";
            txtThanhtien.Text = "0";

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (cboMaHD.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã hóa đơn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboMaHD.Focus();
                return;
            }

            if (cboMaSP.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã sản phẩm !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboMaSP.Focus();
                return;
            }
            if (txtSoluong.Text.Trim().Length == 0 || (txtSoluong.Text == "0"))
            {
                MessageBox.Show("Bạn phải nhập số lượng !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSoluong.Focus();
                return;
            }
            if (txtDonGia.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập đơn giá !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDonGia.Focus();
                return;
            }
            //if (txtGiamgia.Text.Trim().Length == 0)
            //{
            //    MessageBox.Show("Bạn phải nhập giảm giá !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    txtGiamgia.Focus();
            //    return;
            //}
            string sql = "SELECT MaSP FROM tblChitietHDN WHERE MaSP=N'" + cboMaSP.Text + "'AND MaHDN=N'" + txtMahoadon.Text.Trim() + "'";
            if (ThucThiSQL.DocBang(sql).Rows.Count > 0)
            {
                MessageBox.Show("Mã sản phẩm này đã có, bạn phải nhập mã khác !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ResetValuesHang();
                cboMaSP.Focus();
                return;
            }
            sql = "INSERT INTO tblChitietHDN(MaHDN,MaSP,SoLuong,DonGia,ThanhTien,KhuyenMai) VALUES(N'" + cboMaHD.Text.Trim() + "',N'" + cboMaSP.Text.ToString() + "'," + txtSoluong.Text + "," + txtDonGia.Text.Trim() + "," + txtThanhtien.Text + ", " + txtGiamgia.Text + ")";
            ThucThiSQL.CapNhatDuLieu(sql);
            Hienthi_Luoi();
            // Cập nhật số lượng mới vào bảng theo công thức
            double sl = Convert.ToDouble(ThucThiSQL.DocBang("SELECT SoLuong FROM tblSanPham WHERE MaSP = N'"
                + cboMaSP.Text + "'").Rows[0][0].ToString());
            double slmoi = sl + Convert.ToDouble(txtSoluong.Text);
            sql = "UPDATE tblSanPham SET SoLuong = " + slmoi + "WHERE MaSP = N'" + cboMaSP.Text + "'";
            ThucThiSQL.CapNhatDuLieu(sql);
            //Cập nhật giá nhập vào bảng sản phẩm
            double dg = Convert.ToDouble(ThucThiSQL.DocBang("Select GiaNhap from tblSanPham where MaSP = N'"
                + cboMaSP.Text + "'").Rows[0][0].ToString());
            double dgmoi = dg + Convert.ToDouble(txtDonGia.Text);
            sql = "update tblSanPham Set GiaNhap = " + dgmoi + "Where MaSP = N'" + cboMaSP.Text + "'";
            btnHuy.Enabled = true;

        }


        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cboMaSP_TextChanged(object sender, EventArgs e)
        {

            string gn;
            if (cboMaSP.Text == "")
            {

                txtDonGia.Text = "";
                return;
            }
            gn = "SELECT GiaNhap FROM tblSanPham WHERE MaSP=N'" + cboMaSP.Text + "'";
            DataTable a = ThucThiSQL.DocBang(gn);

            if (a.Rows.Count > 0)
            {
                txtDonGia.Text = a.Rows[0][0].ToString();
            }

        }

        private void txtSoluong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtThanhtien_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtGiamgia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtDonGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtTongTien_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void cboMaSP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar))
            {
                MessageBox.Show("Bạn vui lòng chọn dữ liệu đã có!", "Thông báo");
                e.Handled = true;
            }
        }

        private void cboMaHD_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar))
            {
                MessageBox.Show("Bạn vui lòng chọn dữ liệu đã có!", "Thông báo");
                e.Handled = true;
            }
        }

        private void txtSoluong_TextChanged(object sender, EventArgs e)
        {
            double sl, dg, tt, gg;
            if (txtSoluong.Text == "" || txtDonGia.Text == "")
            {

                tt = 0;
                return;
            }
            else
            {
                sl = Convert.ToDouble(txtSoluong.Text);
                dg = Convert.ToDouble(txtDonGia.Text);
                gg = Convert.ToDouble(txtGiamgia.Text);
                tt = sl * dg - sl * dg * gg / 100;
                txtThanhtien.Text = Convert.ToString(tt);
                return;
            }
        }

        private void txtGiamgia_TextChanged(object sender, EventArgs e)
        {
            /*double sl, dg, tt, gg;
            if (txtSoluong.Text == "" || txtDonGia.Text == "")
            {

                tt = 0;
                return;
            }
            else
            {
                sl = Convert.ToDouble(txtSoluong.Text);
                dg = Convert.ToDouble(txtDonGia.Text);
                gg = Convert.ToDouble(txtGiamgia.Text);
                tt = sl * dg - sl * dg * gg / 100;
                txtThanhtien.Text = Convert.ToString(tt);
                return;
            }*/
        }

        private void txtDonGia_TextChanged(object sender, EventArgs e)
        {
            double sl, dg, tt, gg;
            if (txtSoluong.Text == "" || txtDonGia.Text == "")
            {

                tt = 0;
                return;
            }
            else
            {
                sl = Convert.ToDouble(txtSoluong.Text);
                dg = Convert.ToDouble(txtDonGia.Text);
                gg = Convert.ToDouble(txtGiamgia.Text);
                tt = sl * dg - sl * dg * gg / 100;
                txtThanhtien.Text = Convert.ToString(tt);
                return;
            }
        }

        private void cboMaHD_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
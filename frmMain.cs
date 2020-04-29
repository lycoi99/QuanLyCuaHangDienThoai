using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCuaHangDienThoai
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void nhãnHiệuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.frmNhanHieu f = new Forms.frmNhanHieu();
            f.StartPosition = FormStartPosition.CenterScreen;
            f.Show();
        }

        private void loạiToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Forms.frmLoai f = new Forms.frmLoai();
            f.StartPosition = FormStartPosition.CenterScreen;
            f.Show();
        }

        private void mànHìnhToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Forms.frmManHinh f = new Forms.frmManHinh();
            f.StartPosition = FormStartPosition.CenterScreen;
            f.Show();
        }

        private void nhàCungCấpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.frmNhaCungCap f = new Forms.frmNhaCungCap();
            f.StartPosition = FormStartPosition.CenterScreen;
            f.Show();
        }


        private void sảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.frmSanPham f = new Forms.frmSanPham();
            f.StartPosition = FormStartPosition.CenterScreen;
            f.Show();
        }

        private void trợGiúpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không ?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
                Application.Exit();
            }
        }

        private void hóaĐơnNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.frmHDN f = new Forms.frmHDN();
            f.StartPosition = FormStartPosition.CenterScreen;
            f.Show();
        }
    }
}

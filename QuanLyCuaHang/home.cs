using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCuaHang
{
    public partial class home : Form
    {
        public home()
        {
            InitializeComponent();
        }

        private void btSanPham_Click(object sender, EventArgs e)
        {
            this.Hide();
            SanPham sanPham = new SanPham();

            sanPham.ShowDialog();
            this.Show();
        }

        private void btKhachHang_Click(object sender, EventArgs e)
        {

            this.Hide();
            KhachHang khachHang= new KhachHang();

            khachHang.ShowDialog();
            this.Show();
        }

        private void btDonHang_Click(object sender, EventArgs e)
        {

            this.Hide();
            DonHang donHang = new DonHang();

            donHang.ShowDialog();
            this.Show();
        }

        private void btNCC_Click(object sender, EventArgs e)
        {

            this.Hide();
            NCC ncc = new NCC();

            ncc.ShowDialog();
            this.Show();
        }
    }
}
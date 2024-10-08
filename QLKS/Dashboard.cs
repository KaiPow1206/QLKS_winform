using QLKS.user_control;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLKS
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {

        }

        private void btn_themPhong_Click(object sender, EventArgs e)
        {

            p1.Visible = true;
            p2.Visible=false; p3.Visible=false;p4.Visible=false;p5.Visible=false;
            uc_addroom1.Visible = true;
            uc_addroom1.BringToFront();
        }

        private void btn_dangKiKhachHang_Click(object sender, EventArgs e)
        {
            p2.Visible = true;
            p1.Visible=false;p3.Visible=false;p4.Visible=false;p5.Visible = false;
            uc_registercustomer1.Visible = true;
            uc_registercustomer1.BringToFront();
        }

        private void btn_thanhToan_Click(object sender, EventArgs e)
        {
            p3.Visible = true;
            p1.Visible = false;p2.Visible=false;p4.Visible=false;p5.Visible = false;
        }

        private void btn_chiTietKhachHang_Click(object sender, EventArgs e)
        {
            p4.Visible = true;
            p1.Visible = false; p2.Visible = false; p3.Visible = false; p5.Visible = false;
        }

        private void btn_nhanVien_Click(object sender, EventArgs e)
        {
            p5.Visible = true;
            p1.Visible = false; p2.Visible = false; p3.Visible = false; p4.Visible = false;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            
        }

        private void guna2PictureBox3_Click(object sender, EventArgs e)
        {

        }
    }
}

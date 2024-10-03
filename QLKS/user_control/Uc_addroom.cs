using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLKS.user_control
{
    public partial class Uc_addroom : UserControl
    {
        func fn =new func();
        string query;

        public Uc_addroom()
        {
            InitializeComponent();
        }

        private void guna2TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_cancelAddRoom_Click(object sender, EventArgs e)
        {
           txt_numberRoom.Clear();
           txt_priceRoom.Clear();
           cb_typeOfBed.Items.Clear();
           cb_typeOfRoom.Items.Clear();
           cb_statusClean.Items.Clear();
           cb_service.Items.Clear();
           cb_statusRoom.Items.Clear();
        }

        private void btn_cancelService_Click(object sender, EventArgs e)
        {
            cb_statusClean.Items.Clear();
            cb_service.Items.Clear();
            cb_statusRoom.Items.Clear();
        }

        private void txt_priceRoom_TextChanged(object sender, EventArgs e)
        {
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.Show(); // Hiển thị form Dashboard
            this.Hide();      // Ẩn form hiện tại (form chứa btn_back)
        }

        private void Uc_addroom_Load(object sender, EventArgs e)
        {
            //query = "select * from rooms";
            //DataSet ds = fn.getDaTa(query);
            //DataGridView1.DataSource= ds.Tables[0];
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {

        }
    }
}

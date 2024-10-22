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
    public partial class Uc_customerdetails : UserControl
    {
        func fn = new func();
        string query;
        public Uc_customerdetails()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_cancelAddRoom_Click(object sender, EventArgs e)
        {
            cb_details.SelectedIndex = -1;
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            if (cb_details.SelectedIndex==0)
            {
                query = @" SELECT customer.*, rooms.roomNum, rooms.roomType, rooms.bed, rooms.price FROM customer INNER JOIN rooms ON customer.roomid = rooms.roomid";
                getSubmit(query);
            }
            else if (cb_details.SelectedIndex == 1)
            {
                query = @" SELECT customer.*, rooms.roomNum, rooms.roomType, rooms.bed, rooms.price FROM customer INNER JOIN rooms ON customer.roomid = rooms.roomid where customer.checkout = 'NO'";
                getSubmit(query);
            }
            else if(cb_details.SelectedIndex == 2)
            {
                query = @" SELECT customer.*, rooms.roomNum, rooms.roomType, rooms.bed, rooms.price FROM customer INNER JOIN rooms ON customer.roomid = rooms.roomid where customer.checkout = 'YES'";
                getSubmit(query);
            }
        }
        private void getSubmit(string query)
        {
            DataSet ds = fn.getDaTa(query);
            DataGridView1.DataSource = ds.Tables[0];
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}

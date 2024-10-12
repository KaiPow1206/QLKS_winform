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
    public partial class Uc_payment : UserControl
    {
        func fn = new func();
        string query;
        public Uc_payment()
        {
            InitializeComponent();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
            this.Hide();
        }

        private void btn_cancelAddRoom_Click(object sender, EventArgs e)
        {
            txt_nameCustomer.Clear();
            txt_numberRoom.Clear();
            txt_id.Clear();
            date_checkout.ResetText();
        }

        private void Uc_payment_Load(object sender, EventArgs e)
        {
            query = @" SELECT customer.*, rooms.roomNum, rooms.roomType, rooms.bed, rooms.price FROM customer INNER JOIN rooms ON customer.roomid = rooms.roomid where customer.checkout = 'NO' ";
            DataSet ds = fn.getDaTa(query);
            DataGridView1.DataSource = ds.Tables[0];
            DataGridView1.Columns["checkin"].Width = 150;
            DataGridView1.Columns["birthday"].Width = 150;
        }

        private void txt_nameCustomer_TextChanged(object sender, EventArgs e)
        {
            query = @" SELECT customer.*, rooms.roomNum, rooms.roomType, rooms.bed, rooms.price FROM customer INNER JOIN rooms ON customer.roomid = rooms.roomid where cname like '"+ txt_nameCustomer.Text +"' and customer.checkout = 'NO' ";
            DataSet ds = fn.getDaTa(query);
            DataGridView1.DataSource = ds.Tables[0];
        }
        int id;
        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DataGridView1.Rows[e.RowIndex].Cells[0].Value != null)
            {
                id = int.Parse(DataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                txt_numberRoom.Text = DataGridView1.Rows[e.RowIndex].Cells[12].Value.ToString();
                txt_id.Text = DataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            }
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_nameCustomer.Text != " ")
                {
                    if (MessageBox.Show("Submit check out for customer ??", "Yes", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                    {
                        String checkoudate = date_checkout.Text;
                        query = "UPDATE customer SET checkout = 'YES', daycheckout = '" + checkoudate + "' WHERE cid = " + id + "; " +
                                "UPDATE rooms SET statusRoom = 'Chill', statusClean = 'Not Clean' WHERE roomNum = '" + txt_numberRoom.Text + "';";

                        fn.setData(query, "Success check out for customer");
                        Uc_payment_Load(this, null);
                        clearAll();
                    }
                    else
                    {
                        MessageBox.Show("Not found customer to check out !!!", "Warning !!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch 
            {
                MessageBox.Show("Something Wrong Check Information !!! ", "Error !!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void clearAll()
        {
            txt_nameCustomer.Clear();
            txt_numberRoom.Clear();
            txt_id.Clear();
            date_checkout.ResetText();
        }
    }
}

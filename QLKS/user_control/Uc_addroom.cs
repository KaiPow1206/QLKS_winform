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
            cb_typeOfBed.SelectedIndex = -1;
            cb_typeOfRoom.SelectedIndex = -1;
            cb_statusClean.SelectedIndex = -1;
            cb_service.SelectedIndex = -1;
            cb_statusRoom.SelectedIndex = -1;
        }

        private void txt_priceRoom_TextChanged(object sender, EventArgs e)
        {
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
            this.Hide();      
        }

        private void Uc_addroom_Load(object sender, EventArgs e)
        {
            query = "select * from rooms";
            DataSet ds = fn.getDaTa(query);
            DataGridView1.DataSource = ds.Tables[0];
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {

            try
            {
                if (txt_numberRoom.Text != "" && cb_typeOfRoom.Text != "" && cb_typeOfBed.Text != "" && txt_priceRoom.Text != "" && cb_service.Text != "")
                {
                    Int64 roomnumber = Int64.Parse(txt_numberRoom.Text);
                    String roomtype = cb_typeOfRoom.Text;
                    String bedtype = cb_typeOfBed.Text;
                    Int64 priceroom = Int64.Parse(txt_priceRoom.Text);
                    String service = cb_service.Text;

                    if (cb_statusClean.Text != "" && cb_statusRoom.Text != "")
                    {
                        String statusroom = cb_statusRoom.Text;
                        String statusclean = cb_statusClean.Text;

                        query = "INSERT INTO rooms(roomNum, roomType, bed, price, service, statusRoom, statusClean) " +
                                "VALUES('" + roomnumber + "','" + roomtype + "','" + bedtype + "','" + priceroom + "','" + service + "','" + statusroom + "','" + statusclean + "')";
                    }
                    else
                    {
                        query = "INSERT INTO rooms(roomNum, roomType, bed, price, service) " +
                                "VALUES('" + roomnumber + "','" + roomtype + "','" + bedtype + "','" + priceroom + "','" + service + "')";
                    }

                    fn.setData(query, "Add Room Successful!");
                    Uc_addroom_Load(this, null);
                    clearAll();
                }
                else
                {
                    MessageBox.Show("Please complete information !!!", "Warning !!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch(Exception) {
                MessageBox.Show("Something Wrong Check Information !!! (Room Number and Price must be a number)","Error !!!",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Uc_addroom_Enter(object sender, EventArgs e)
        {
            Uc_addroom_Load(this, null);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        void clearAll()
        {
            txt_numberRoom.Clear();
            txt_priceRoom.Clear();
            cb_typeOfBed.SelectedIndex = -1;
            cb_typeOfRoom.SelectedIndex = -1;
            cb_statusClean.SelectedIndex = -1;
            cb_service.SelectedIndex = -1;
            cb_statusRoom.SelectedIndex = -1;
        }
    }
}

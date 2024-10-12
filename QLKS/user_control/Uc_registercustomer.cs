using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLKS.user_control
{
    public partial class Uc_registercustomer : UserControl
    {
        func fn = new func();
        String query;
        int roomid;
        public Uc_registercustomer()
        {
            InitializeComponent();
        }


        public void setComBoBox(String query, ComboBox combo)
        {
            SqlDataReader sdr = fn.getCombo(query);
            while (sdr.Read())
            {
                for (int i=0;i< sdr.FieldCount; i++)
                {
                    combo.Items.Add(sdr.GetString(i));
                }
            }
            sdr.Close();
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
            txt_phoneNum.Clear();
            txt_nation.Clear();
            cb_gender.SelectedIndex = -1;
            txt_id.Clear();
            txt_addr.Clear();
            date_birth.ResetText();
            date_checkIn.ResetText();
            cb_numRoom.Items.Clear();
            cb_typeOfRoom.SelectedIndex = -1;
            cb_typeOfBed.SelectedIndex = -1;
            txt_priceRoom.Clear();
        }

        private void cb_typeOfBed_SelectedIndexChanged(object sender, EventArgs e)
        {
            cb_typeOfRoom.SelectedIndex = -1;
            cb_numRoom.Items.Clear();
            txt_priceRoom.Clear();
        }

        private void cb_typeOfRoom_SelectedIndexChanged(object sender, EventArgs e)
        {
            cb_numRoom.Items.Clear();
            query = "SELECT roomNum FROM rooms WHERE bed ='" + cb_typeOfBed.Text + "' AND roomType = '" + cb_typeOfRoom.Text + "' AND statusRoom = 'Chill'";
            setComBoBox(query,cb_numRoom);
        }

        private void cb_numRoom_SelectedIndexChanged(object sender, EventArgs e)
        {
             
            query = "select price, roomid from rooms where roomNum = '" + cb_numRoom.Text + "'";
            DataSet ds = fn.getDaTa(query);
            txt_priceRoom.Text = ds.Tables[0].Rows[0][0].ToString();
            roomid = int.Parse(ds.Tables[0].Rows[0][1].ToString());
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            try
            {
                if(txt_nameCustomer.Text != "" && txt_phoneNum.Text != "" && txt_nation.Text != "" && cb_gender.Text != "" && txt_id.Text != "" && txt_addr.Text != "" && date_birth.Text != "" && date_checkIn.Text != "" && cb_typeOfBed.Text != "" && cb_typeOfRoom.Text != "" && cb_numRoom.Text != "")
                {
                    String name = txt_nameCustomer.Text;
                    Int64 phone = Int64.Parse(txt_phoneNum.Text);
                    String nation = txt_nation.Text;
                    String gender = cb_gender.Text;
                    Int64 id = Int64.Parse(txt_id.Text);
                    String addr = txt_addr.Text;
                    String checkin = date_checkIn.Text;
                    String birthday =date_birth.Text;


                    query = "INSERT INTO customer (cname, phone, nationality, gender, birthday, id, address, checkin, roomid) " +
                            "VALUES ('" + name + "', '" + phone + "', '" + nation + "', '" + gender + "', '" + birthday + "', '" + id + "', '" + addr + "', '" + checkin + "', '" + roomid + "'); " +
                            "UPDATE rooms SET statusRoom = 'Full' WHERE roomNum = '" + cb_numRoom.Text + "';";

                    fn.setData(query, "Success register room " + cb_numRoom.Text + " For " + txt_nameCustomer.Text);
                    clearAll();
                }
                else
                {
                    MessageBox.Show("Please complete information !!!", "Warning !!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch
            {
                MessageBox.Show("Something Wrong Check Information !!! (Phone Number and CCCD must be a number)", "Error !!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        void clearAll()
        {
            txt_nameCustomer.Clear();
            txt_phoneNum.Clear();
            txt_nation.Clear();
            cb_gender.SelectedIndex = -1;
            txt_id.Clear();
            txt_addr.Clear();
            date_birth.ResetText();
            date_checkIn.ResetText();
            cb_numRoom.Items.Clear();
            cb_typeOfRoom.SelectedIndex = -1;
            cb_typeOfBed.SelectedIndex = -1;
            txt_priceRoom.Clear();
        }
    }
}

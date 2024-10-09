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
            cb_sex.SelectedIndex = -1;
            txt_id.Clear();
            txt_addr.Clear();
            cb_numRoom.SelectedIndex=-1;
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
            query = "select roomNum from rooms where bed ='" + cb_typeOfBed + "' and roomType = '" + cb_typeOfRoom + "' and statusRoom = 'Chill'";
            setComBoBox(query, cb_numRoom);
        }

        private void cb_numRoom_SelectedIndexChanged(object sender, EventArgs e)
        {
            query = "select price, roomid from rooms where roomNum = '" + cb_numRoom + "'";
        }
    }
}

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
    public partial class Uc_registercustomer : UserControl
    {
        public Uc_registercustomer()
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
            txt_phoneNum.Clear();
            txt_nation.Clear();
            cb_sex.SelectedIndex = -1;
            txt_id.Clear();
            txt_addr.Clear();
            txt_numberRoom.Clear();
            cb_typeOfRoom.SelectedIndex = -1;
            cb_typeOfBed.SelectedIndex = -1;
            txt_priceRoom.Clear();
        }
    }
}

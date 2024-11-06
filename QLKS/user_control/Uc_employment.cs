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
    public partial class Uc_employment : UserControl
    {

        func fn = new func();
        String query;
        public Uc_employment()
        {
            InitializeComponent();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
            this.Hide();
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_nameofemployment.Text != "" && txt_phoneofemployment.Text != "" && txt_addrofemployment.Text != "" && cb_genderofemployment.Text != "" && txt_gmailofemployment.Text != "" && txt_useremployment.Text != "" && txt_passwordemployment.Text != "")
                {
                    String name = txt_nameofemployment.Text;
                    Int64 phone = Int64.Parse(txt_phoneofemployment.Text);
                    String gender = cb_genderofemployment.Text;
                    String addr = txt_addrofemployment.Text;
                    String gmail = txt_gmailofemployment.Text;
                    String pass = txt_passwordemployment.Text;
                    String user = txt_useremployment.Text;


                    query = "INSERT INTO employee (ename, mobile, gender, address, gmailid, pass, username) " +
                            "VALUES ('" + name + "', '" + phone + "', '" + gender + "', '" + addr + "', '" + gmail + "', '" + pass + "', '" + user + "')";
                    fn.setData(query, "Successful Register Employee!!!");
                    clearAll();
                    getMaxID();
                }
                else
                {
                    MessageBox.Show("Please complete information !!!", "Warning !!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Something Wrong Check Information !!! (Phone must be a number)", "Error !!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Uc_employment_Load(object sender, EventArgs e)
        {
            getMaxID();
        }

        public void getMaxID()
        {
            query = "select max(eid) from employee";
            DataSet ds = fn.getDaTa(query);
            if (ds.Tables[0].Rows[0][0].ToString() != "")
            {
                Int64 number = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());
                setlabel.Text = (number).ToString();
            }
            else
            {
                setlabel.Text = "1";
            }
        }
        public void clearAll()
        {
            txt_nameofemployment.Clear();
            txt_phoneofemployment.Clear();
            txt_addrofemployment.Clear();
            cb_genderofemployment.SelectedIndex = -1;
            txt_gmailofemployment.Clear();
            txt_passwordemployment.Clear();
            txt_useremployment.Clear();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            txt_nameofemployment.Clear();
            txt_phoneofemployment.Clear();
            txt_addrofemployment.Clear();
            cb_genderofemployment.SelectedIndex = -1;
            txt_gmailofemployment.Clear();
            txt_passwordemployment.Clear();
            txt_useremployment.Clear();
        }

        private void tabEmployment_SelectedIndexChanged(object sender, EventArgs e)
        {
           if(tabEmployment.SelectedIndex ==1)
           {
                dataEmployee(DataGridView1);
                DataGridView1.Columns["gmailid"].Width = 200;
           } else if(tabEmployment.SelectedIndex == 2)
           {
                dataEmployee(DataGridView2);
                DataGridView2.Columns["gmailid"].Width = 200;
           }else if (tabEmployment.SelectedIndex == 3)
           {
                serviceRoom(DataGridView3);
                serviceEmployee(DataGridView4);
            }
        }

        public void dataEmployee(DataGridView dgv)
        {
            query = "SELECT * FROM employee";
            DataSet ds = fn.getDaTa(query);
            dgv.DataSource=ds.Tables[0];
        }

        private void btn_deletegmail_Click(object sender, EventArgs e)
        {
            if (txt_id.Text != "")
            {
                if (MessageBox.Show("Do you wanna do this action ??", "Yes", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    query = "DELETE FROM employee WHERE eid = " + txt_id.Text + "";
                    fn.setData(query, "Successful Delete Employee");
                    tabEmployment_SelectedIndexChanged(this, null);
                    getMaxID();
                }
            }
        }

        public void serviceEmployee(DataGridView dgv)
        {
            query = "SELECT eid,ename,mobile,gender FROM employee";
            DataSet ds = fn.getDaTa(query);
            dgv.DataSource = ds.Tables[0];
        }
        public void serviceRoom(DataGridView dgv)
        {
            query = "SELECT roomid,roomNum,roomType,statusClean FROM rooms";
            DataSet ds = fn.getDaTa(query);
            dgv.DataSource = ds.Tables[0];
        }
        private void clear()
        {
            txt_num_room.Clear();
            txt_id_service.Clear();
        }

        private void btn_cleaned_Click(object sender, EventArgs e)
        {
            if (txt_id_service.Text != "" && txt_num_room.Text != "")
            {
                if (MessageBox.Show("Do you wanna do this action ??", "Yes", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    Int64 employee = Int64.Parse(txt_id_service.Text);
                    Int64 room = Int64.Parse(txt_num_room.Text);



                    query = "UPDATE employee SET roomid = NULL WHERE eid = " + employee + "; " +
                            "UPDATE rooms SET statusClean = 'Clean' WHERE roomid = '" + txt_num_room.Text + "';";
                    fn.setData(query, "Successful Clean Room");
                    tabEmployment_SelectedIndexChanged(this, null);
                    clear();
                }
            }
        }

        private void btn_cleanning_Click(object sender, EventArgs e)
        {

            if (txt_id_service.Text != "" && txt_num_room.Text != "")
            {
                if (MessageBox.Show("Do you wanna do this action ??", "Yes", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    Int64 employee = Int64.Parse(txt_id_service.Text);
                    Int64 room = Int64.Parse(txt_num_room.Text);



                    query = "UPDATE employee SET roomid = '" + room + "' WHERE eid = " + employee + "; " +
                            "UPDATE rooms SET statusClean = 'Cleaning' WHERE roomid = '" + txt_num_room.Text + "';";
                    fn.setData(query, "Successful Add Employee Cleaning Room");
                    tabEmployment_SelectedIndexChanged(this, null);
                    clear();
                }
            }
        }


        private void txt_num_room_TextChanged(object sender, EventArgs e)
        {

        }
    }
}


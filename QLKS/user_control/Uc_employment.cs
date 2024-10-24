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
    }
}


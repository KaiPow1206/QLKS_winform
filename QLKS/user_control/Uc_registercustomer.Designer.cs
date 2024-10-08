namespace QLKS.user_control
{
    partial class Uc_registercustomer
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btn_back = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_cancelAddRoom = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btn_submit = new Guna.UI2.WinForms.Guna2GradientButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txt_numberRoom = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_priceRoom = new Guna.UI2.WinForms.Guna2TextBox();
            this.cb_typeOfBed = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cb_typeOfRoom = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.date_birth = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.date_checkIn = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_addr = new Guna.UI2.WinForms.Guna2TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_id = new Guna.UI2.WinForms.Guna2TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cb_sex = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_nation = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_phoneNum = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_nameCustomer = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse3 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse4 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse5 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_back
            // 
            this.btn_back.Animated = true;
            this.btn_back.BorderRadius = 10;
            this.btn_back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_back.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_back.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_back.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_back.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_back.FillColor = System.Drawing.Color.Transparent;
            this.btn_back.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_back.ForeColor = System.Drawing.Color.White;
            this.btn_back.Image = global::QLKS.Properties.Resources.back;
            this.btn_back.ImageSize = new System.Drawing.Size(50, 50);
            this.btn_back.Location = new System.Drawing.Point(462, 0);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(71, 60);
            this.btn_back.TabIndex = 15;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(444, 31);
            this.label1.TabIndex = 24;
            this.label1.Text = "Register Customer For KaiHouse";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PeachPuff;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btn_cancelAddRoom);
            this.panel1.Controls.Add(this.btn_submit);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(18, 120);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1453, 740);
            this.panel1.TabIndex = 26;
            // 
            // btn_cancelAddRoom
            // 
            this.btn_cancelAddRoom.Animated = true;
            this.btn_cancelAddRoom.BorderRadius = 10;
            this.btn_cancelAddRoom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cancelAddRoom.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_cancelAddRoom.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_cancelAddRoom.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_cancelAddRoom.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_cancelAddRoom.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_cancelAddRoom.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_cancelAddRoom.ForeColor = System.Drawing.Color.White;
            this.btn_cancelAddRoom.Image = global::QLKS.Properties.Resources.pngwing_com;
            this.btn_cancelAddRoom.ImageSize = new System.Drawing.Size(40, 40);
            this.btn_cancelAddRoom.Location = new System.Drawing.Point(512, 615);
            this.btn_cancelAddRoom.Name = "btn_cancelAddRoom";
            this.btn_cancelAddRoom.Size = new System.Drawing.Size(196, 99);
            this.btn_cancelAddRoom.TabIndex = 14;
            this.btn_cancelAddRoom.Text = "Clean Infromation";
            this.btn_cancelAddRoom.Click += new System.EventHandler(this.btn_cancelAddRoom_Click);
            // 
            // btn_submit
            // 
            this.btn_submit.Animated = true;
            this.btn_submit.BorderRadius = 10;
            this.btn_submit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_submit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_submit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_submit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_submit.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_submit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_submit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_submit.ForeColor = System.Drawing.Color.White;
            this.btn_submit.Image = global::QLKS.Properties.Resources.save_button;
            this.btn_submit.ImageSize = new System.Drawing.Size(40, 40);
            this.btn_submit.Location = new System.Drawing.Point(714, 615);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(196, 99);
            this.btn_submit.TabIndex = 13;
            this.btn_submit.Text = "Submit Register Customer";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.White;
            this.groupBox3.Controls.Add(this.txt_numberRoom);
            this.groupBox3.Controls.Add(this.txt_priceRoom);
            this.groupBox3.Controls.Add(this.cb_typeOfBed);
            this.groupBox3.Controls.Add(this.cb_typeOfRoom);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Location = new System.Drawing.Point(1033, 79);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(373, 518);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            // 
            // txt_numberRoom
            // 
            this.txt_numberRoom.Animated = true;
            this.txt_numberRoom.BorderRadius = 8;
            this.txt_numberRoom.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_numberRoom.DefaultText = "";
            this.txt_numberRoom.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_numberRoom.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_numberRoom.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_numberRoom.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_numberRoom.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_numberRoom.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_numberRoom.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_numberRoom.Location = new System.Drawing.Point(20, 58);
            this.txt_numberRoom.Name = "txt_numberRoom";
            this.txt_numberRoom.PasswordChar = '\0';
            this.txt_numberRoom.PlaceholderText = "Enter Number Of Room..";
            this.txt_numberRoom.SelectedText = "";
            this.txt_numberRoom.Size = new System.Drawing.Size(336, 36);
            this.txt_numberRoom.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txt_numberRoom.TabIndex = 9;
            // 
            // txt_priceRoom
            // 
            this.txt_priceRoom.BorderRadius = 8;
            this.txt_priceRoom.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_priceRoom.DefaultText = "";
            this.txt_priceRoom.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_priceRoom.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_priceRoom.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_priceRoom.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_priceRoom.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_priceRoom.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_priceRoom.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_priceRoom.Location = new System.Drawing.Point(20, 402);
            this.txt_priceRoom.Name = "txt_priceRoom";
            this.txt_priceRoom.PasswordChar = '\0';
            this.txt_priceRoom.PlaceholderText = "Price..";
            this.txt_priceRoom.ReadOnly = true;
            this.txt_priceRoom.SelectedText = "";
            this.txt_priceRoom.Size = new System.Drawing.Size(336, 36);
            this.txt_priceRoom.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txt_priceRoom.TabIndex = 12;
            // 
            // cb_typeOfBed
            // 
            this.cb_typeOfBed.BackColor = System.Drawing.Color.Transparent;
            this.cb_typeOfBed.BorderRadius = 10;
            this.cb_typeOfBed.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cb_typeOfBed.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_typeOfBed.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cb_typeOfBed.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cb_typeOfBed.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cb_typeOfBed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cb_typeOfBed.ItemHeight = 30;
            this.cb_typeOfBed.Items.AddRange(new object[] {
            "Single ",
            "Double",
            "King",
            "Family"});
            this.cb_typeOfBed.Location = new System.Drawing.Point(20, 278);
            this.cb_typeOfBed.Name = "cb_typeOfBed";
            this.cb_typeOfBed.Size = new System.Drawing.Size(336, 36);
            this.cb_typeOfBed.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.cb_typeOfBed.TabIndex = 11;
            // 
            // cb_typeOfRoom
            // 
            this.cb_typeOfRoom.BackColor = System.Drawing.Color.Transparent;
            this.cb_typeOfRoom.BorderRadius = 10;
            this.cb_typeOfRoom.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cb_typeOfRoom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_typeOfRoom.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cb_typeOfRoom.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cb_typeOfRoom.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cb_typeOfRoom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cb_typeOfRoom.ItemHeight = 30;
            this.cb_typeOfRoom.Items.AddRange(new object[] {
            "AC",
            "Non-AC",
            "Full"});
            this.cb_typeOfRoom.Location = new System.Drawing.Point(20, 166);
            this.cb_typeOfRoom.Name = "cb_typeOfRoom";
            this.cb_typeOfRoom.Size = new System.Drawing.Size(336, 36);
            this.cb_typeOfRoom.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.cb_typeOfRoom.TabIndex = 10;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label10.Location = new System.Drawing.Point(15, 360);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 25);
            this.label10.TabIndex = 18;
            this.label10.Text = "Price :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label11.Location = new System.Drawing.Point(15, 236);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(127, 25);
            this.label11.TabIndex = 22;
            this.label11.Text = "Type of bed :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label12.Location = new System.Drawing.Point(15, 124);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(138, 25);
            this.label12.TabIndex = 19;
            this.label12.Text = "Type of room :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label13.Location = new System.Drawing.Point(15, 16);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(162, 25);
            this.label13.TabIndex = 16;
            this.label13.Text = "Number of room :";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.date_birth);
            this.groupBox2.Controls.Add(this.date_checkIn);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txt_addr);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txt_id);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Location = new System.Drawing.Point(529, 79);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(361, 518);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // date_birth
            // 
            this.date_birth.Animated = true;
            this.date_birth.BorderRadius = 10;
            this.date_birth.Checked = true;
            this.date_birth.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(221)))));
            this.date_birth.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.date_birth.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.date_birth.Location = new System.Drawing.Point(11, 278);
            this.date_birth.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.date_birth.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.date_birth.Name = "date_birth";
            this.date_birth.Size = new System.Drawing.Size(332, 36);
            this.date_birth.TabIndex = 7;
            this.date_birth.Value = new System.DateTime(2024, 10, 8, 17, 36, 23, 0);
            // 
            // date_checkIn
            // 
            this.date_checkIn.BorderRadius = 10;
            this.date_checkIn.Checked = true;
            this.date_checkIn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(221)))));
            this.date_checkIn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.date_checkIn.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.date_checkIn.Location = new System.Drawing.Point(10, 402);
            this.date_checkIn.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.date_checkIn.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.date_checkIn.Name = "date_checkIn";
            this.date_checkIn.Size = new System.Drawing.Size(332, 36);
            this.date_checkIn.TabIndex = 8;
            this.date_checkIn.Value = new System.DateTime(2024, 10, 8, 13, 46, 58, 553);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label6.Location = new System.Drawing.Point(6, 236);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 25);
            this.label6.TabIndex = 12;
            this.label6.Text = "Date Of Birth";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label7.Location = new System.Drawing.Point(6, 360);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 25);
            this.label7.TabIndex = 14;
            this.label7.Text = "Check In :";
            // 
            // txt_addr
            // 
            this.txt_addr.Animated = true;
            this.txt_addr.BorderRadius = 10;
            this.txt_addr.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_addr.DefaultText = "";
            this.txt_addr.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_addr.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_addr.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_addr.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_addr.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_addr.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_addr.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_addr.Location = new System.Drawing.Point(11, 166);
            this.txt_addr.Name = "txt_addr";
            this.txt_addr.PasswordChar = '\0';
            this.txt_addr.PlaceholderText = "Enter Address..";
            this.txt_addr.SelectedText = "";
            this.txt_addr.Size = new System.Drawing.Size(331, 36);
            this.txt_addr.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txt_addr.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label8.Location = new System.Drawing.Point(6, 124);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(202, 25);
            this.label8.TabIndex = 12;
            this.label8.Text = "Address of customer :";
            // 
            // txt_id
            // 
            this.txt_id.Animated = true;
            this.txt_id.BorderRadius = 10;
            this.txt_id.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_id.DefaultText = "";
            this.txt_id.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_id.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_id.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_id.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_id.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_id.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_id.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_id.Location = new System.Drawing.Point(11, 58);
            this.txt_id.Name = "txt_id";
            this.txt_id.PasswordChar = '\0';
            this.txt_id.PlaceholderText = "Enter CCCD..";
            this.txt_id.SelectedText = "";
            this.txt_id.Size = new System.Drawing.Size(331, 36);
            this.txt_id.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txt_id.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label9.Location = new System.Drawing.Point(6, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(188, 25);
            this.label9.TabIndex = 10;
            this.label9.Text = "CCCD of customer :";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.cb_sex);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txt_nation);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txt_phoneNum);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_nameCustomer);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(31, 79);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(361, 518);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // cb_sex
            // 
            this.cb_sex.BackColor = System.Drawing.Color.Transparent;
            this.cb_sex.BorderRadius = 10;
            this.cb_sex.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cb_sex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_sex.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cb_sex.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cb_sex.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cb_sex.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cb_sex.ItemHeight = 30;
            this.cb_sex.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cb_sex.Location = new System.Drawing.Point(11, 402);
            this.cb_sex.Name = "cb_sex";
            this.cb_sex.Size = new System.Drawing.Size(336, 36);
            this.cb_sex.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.cb_sex.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label5.Location = new System.Drawing.Point(6, 360);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 25);
            this.label5.TabIndex = 10;
            this.label5.Text = "Sex :";
            // 
            // txt_nation
            // 
            this.txt_nation.Animated = true;
            this.txt_nation.BorderRadius = 10;
            this.txt_nation.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_nation.DefaultText = "";
            this.txt_nation.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_nation.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_nation.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_nation.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_nation.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_nation.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_nation.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_nation.Location = new System.Drawing.Point(11, 278);
            this.txt_nation.Name = "txt_nation";
            this.txt_nation.PasswordChar = '\0';
            this.txt_nation.PlaceholderText = "Enter National..";
            this.txt_nation.SelectedText = "";
            this.txt_nation.Size = new System.Drawing.Size(331, 36);
            this.txt_nation.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txt_nation.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label4.Location = new System.Drawing.Point(6, 236);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(219, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Nationality of customer :";
            // 
            // txt_phoneNum
            // 
            this.txt_phoneNum.Animated = true;
            this.txt_phoneNum.BorderRadius = 10;
            this.txt_phoneNum.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_phoneNum.DefaultText = "";
            this.txt_phoneNum.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_phoneNum.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_phoneNum.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_phoneNum.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_phoneNum.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_phoneNum.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_phoneNum.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_phoneNum.Location = new System.Drawing.Point(11, 166);
            this.txt_phoneNum.Name = "txt_phoneNum";
            this.txt_phoneNum.PasswordChar = '\0';
            this.txt_phoneNum.PlaceholderText = "Enter Phone Number..";
            this.txt_phoneNum.SelectedText = "";
            this.txt_phoneNum.Size = new System.Drawing.Size(331, 36);
            this.txt_phoneNum.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txt_phoneNum.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label3.Location = new System.Drawing.Point(6, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(257, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Phone number of customer :";
            // 
            // txt_nameCustomer
            // 
            this.txt_nameCustomer.Animated = true;
            this.txt_nameCustomer.BorderRadius = 10;
            this.txt_nameCustomer.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_nameCustomer.DefaultText = "";
            this.txt_nameCustomer.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_nameCustomer.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_nameCustomer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_nameCustomer.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_nameCustomer.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_nameCustomer.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_nameCustomer.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_nameCustomer.Location = new System.Drawing.Point(11, 58);
            this.txt_nameCustomer.Name = "txt_nameCustomer";
            this.txt_nameCustomer.PasswordChar = '\0';
            this.txt_nameCustomer.PlaceholderText = "Enter Name..";
            this.txt_nameCustomer.SelectedText = "";
            this.txt_nameCustomer.Size = new System.Drawing.Size(331, 36);
            this.txt_nameCustomer.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txt_nameCustomer.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label2.Location = new System.Drawing.Point(6, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Name of customer :";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(-17, 900);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(1515, 88);
            this.button1.TabIndex = 26;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 10;
            this.guna2Elipse1.TargetControl = this;
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.BorderRadius = 10;
            this.guna2Elipse2.TargetControl = this.groupBox1;
            // 
            // guna2Elipse3
            // 
            this.guna2Elipse3.BorderRadius = 10;
            this.guna2Elipse3.TargetControl = this.groupBox2;
            // 
            // guna2Elipse4
            // 
            this.guna2Elipse4.BorderRadius = 10;
            this.guna2Elipse4.TargetControl = this.groupBox3;
            // 
            // guna2Elipse5
            // 
            this.guna2Elipse5.BorderRadius = 10;
            this.guna2Elipse5.TargetControl = this.panel1;
            // 
            // Uc_registercustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.label1);
            this.Name = "Uc_registercustomer";
            this.Size = new System.Drawing.Size(1489, 975);
            this.panel1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btn_back;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private Guna.UI2.WinForms.Guna2GradientButton btn_cancelAddRoom;
        private Guna.UI2.WinForms.Guna2GradientButton btn_submit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2TextBox txt_nation;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox txt_phoneNum;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox txt_nameCustomer;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2TextBox txt_addr;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2TextBox txt_id;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private Guna.UI2.WinForms.Guna2ComboBox cb_sex;
        private Guna.UI2.WinForms.Guna2ComboBox cb_typeOfBed;
        private Guna.UI2.WinForms.Guna2ComboBox cb_typeOfRoom;
        private Guna.UI2.WinForms.Guna2DateTimePicker date_checkIn;
        private Guna.UI2.WinForms.Guna2DateTimePicker date_birth;
        private Guna.UI2.WinForms.Guna2TextBox txt_priceRoom;
        private Guna.UI2.WinForms.Guna2TextBox txt_numberRoom;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse3;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse4;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse5;
    }
}

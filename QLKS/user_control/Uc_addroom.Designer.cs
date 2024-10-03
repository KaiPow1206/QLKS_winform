namespace QLKS.user_control
{
    partial class Uc_addroom
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_priceRoom = new Guna.UI2.WinForms.Guna2TextBox();
            this.cb_typeOfBed = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cb_typeOfRoom = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_numberRoom = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cb_statusClean = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cb_statusRoom = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cb_service = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.btn_cancelAddRoom = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btn_submit = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btn_back = new Guna.UI2.WinForms.Guna2Button();
            this.DataGridView1 = new Guna.UI2.WinForms.Guna2DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.BorderRadius = 10;
            this.guna2Elipse2.TargetControl = this.panel1;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.txt_priceRoom);
            this.panel1.Controls.Add(this.cb_typeOfBed);
            this.panel1.Controls.Add(this.cb_typeOfRoom);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txt_numberRoom);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(251, 328);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(487, 475);
            this.panel1.TabIndex = 14;
            // 
            // txt_priceRoom
            // 
            this.txt_priceRoom.Animated = true;
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
            this.txt_priceRoom.Location = new System.Drawing.Point(29, 415);
            this.txt_priceRoom.Name = "txt_priceRoom";
            this.txt_priceRoom.PasswordChar = '\0';
            this.txt_priceRoom.PlaceholderText = "";
            this.txt_priceRoom.SelectedText = "";
            this.txt_priceRoom.Size = new System.Drawing.Size(440, 36);
            this.txt_priceRoom.TabIndex = 13;
            this.txt_priceRoom.TextChanged += new System.EventHandler(this.txt_priceRoom_TextChanged);
            // 
            // cb_typeOfBed
            // 
            this.cb_typeOfBed.BackColor = System.Drawing.Color.Transparent;
            this.cb_typeOfBed.BorderRadius = 8;
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
            this.cb_typeOfBed.Location = new System.Drawing.Point(29, 295);
            this.cb_typeOfBed.Name = "cb_typeOfBed";
            this.cb_typeOfBed.Size = new System.Drawing.Size(440, 36);
            this.cb_typeOfBed.TabIndex = 12;
            // 
            // cb_typeOfRoom
            // 
            this.cb_typeOfRoom.BackColor = System.Drawing.Color.Transparent;
            this.cb_typeOfRoom.BorderRadius = 8;
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
            this.cb_typeOfRoom.Location = new System.Drawing.Point(29, 182);
            this.cb_typeOfRoom.Name = "cb_typeOfRoom";
            this.cb_typeOfRoom.Size = new System.Drawing.Size(440, 36);
            this.cb_typeOfRoom.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label5.Location = new System.Drawing.Point(23, 356);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(182, 31);
            this.label5.TabIndex = 9;
            this.label5.Text = "Price of room:";
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
            this.txt_numberRoom.Location = new System.Drawing.Point(29, 67);
            this.txt_numberRoom.Name = "txt_numberRoom";
            this.txt_numberRoom.PasswordChar = '\0';
            this.txt_numberRoom.PlaceholderText = "";
            this.txt_numberRoom.SelectedText = "";
            this.txt_numberRoom.Size = new System.Drawing.Size(440, 36);
            this.txt_numberRoom.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label4.Location = new System.Drawing.Point(23, 252);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(174, 31);
            this.label4.TabIndex = 6;
            this.label4.Text = "Type Of Bed:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label3.Location = new System.Drawing.Point(23, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(181, 31);
            this.label3.TabIndex = 5;
            this.label3.Text = "Type of room:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label2.Location = new System.Drawing.Point(23, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(216, 31);
            this.label2.TabIndex = 3;
            this.label2.Text = "Number of room:";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.cb_statusClean);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.cb_statusRoom);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.cb_service);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Location = new System.Drawing.Point(759, 328);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(489, 475);
            this.panel2.TabIndex = 15;
            // 
            // cb_statusClean
            // 
            this.cb_statusClean.BackColor = System.Drawing.Color.Transparent;
            this.cb_statusClean.BorderRadius = 8;
            this.cb_statusClean.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cb_statusClean.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_statusClean.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cb_statusClean.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cb_statusClean.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cb_statusClean.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cb_statusClean.ItemHeight = 30;
            this.cb_statusClean.Items.AddRange(new object[] {
            "Not Clean",
            "Cleaning"});
            this.cb_statusClean.Location = new System.Drawing.Point(18, 395);
            this.cb_statusClean.Name = "cb_statusClean";
            this.cb_statusClean.Size = new System.Drawing.Size(440, 36);
            this.cb_statusClean.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label7.Location = new System.Drawing.Point(17, 340);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(178, 31);
            this.label7.TabIndex = 17;
            this.label7.Text = "Status Clean:";
            // 
            // cb_statusRoom
            // 
            this.cb_statusRoom.BackColor = System.Drawing.Color.Transparent;
            this.cb_statusRoom.BorderRadius = 8;
            this.cb_statusRoom.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cb_statusRoom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_statusRoom.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cb_statusRoom.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cb_statusRoom.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cb_statusRoom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cb_statusRoom.ItemHeight = 30;
            this.cb_statusRoom.Items.AddRange(new object[] {
            "Full",
            "Deposit"});
            this.cb_statusRoom.Location = new System.Drawing.Point(18, 279);
            this.cb_statusRoom.Name = "cb_statusRoom";
            this.cb_statusRoom.Size = new System.Drawing.Size(440, 36);
            this.cb_statusRoom.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label6.Location = new System.Drawing.Point(12, 223);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(179, 31);
            this.label6.TabIndex = 15;
            this.label6.Text = "Status Room:";
            // 
            // cb_service
            // 
            this.cb_service.BackColor = System.Drawing.Color.Transparent;
            this.cb_service.BorderRadius = 8;
            this.cb_service.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cb_service.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_service.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cb_service.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cb_service.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cb_service.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cb_service.ItemHeight = 30;
            this.cb_service.Items.AddRange(new object[] {
            "Yes",
            "No",
            "One Of them"});
            this.cb_service.Location = new System.Drawing.Point(18, 159);
            this.cb_service.Name = "cb_service";
            this.cb_service.Size = new System.Drawing.Size(440, 36);
            this.cb_service.TabIndex = 14;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label10.Font = new System.Drawing.Font("Microsoft Uighur", 30F, System.Drawing.FontStyle.Underline);
            this.label10.ForeColor = System.Drawing.Color.Tomato;
            this.label10.Location = new System.Drawing.Point(260, 18);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(128, 53);
            this.label10.TabIndex = 13;
            this.label10.Text = "18003108";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label8.Location = new System.Drawing.Point(17, 103);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(386, 31);
            this.label8.TabIndex = 5;
            this.label8.Text = "Drop Off And Pick Up Service: ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label9.Location = new System.Drawing.Point(12, 24);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(216, 31);
            this.label9.TabIndex = 3;
            this.label9.Text = "Service Number:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(10, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(335, 31);
            this.label1.TabIndex = 13;
            this.label1.Text = "Add Room For KaiHouse";
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 15;
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
            this.btn_cancelAddRoom.Location = new System.Drawing.Point(557, 809);
            this.btn_cancelAddRoom.Name = "btn_cancelAddRoom";
            this.btn_cancelAddRoom.Size = new System.Drawing.Size(181, 99);
            this.btn_cancelAddRoom.TabIndex = 19;
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
            this.btn_submit.Location = new System.Drawing.Point(759, 809);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(181, 99);
            this.btn_submit.TabIndex = 17;
            this.btn_submit.Text = "Submit Add Room";
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
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
            this.btn_back.Location = new System.Drawing.Point(351, 3);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(71, 60);
            this.btn_back.TabIndex = 23;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // DataGridView1
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.DataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.DataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridView1.Location = new System.Drawing.Point(77, 69);
            this.DataGridView1.Name = "DataGridView1";
            this.DataGridView1.RowHeadersVisible = false;
            this.DataGridView1.Size = new System.Drawing.Size(1332, 253);
            this.DataGridView1.TabIndex = 24;
            this.DataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGridView1.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DataGridView1.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.DataGridView1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DataGridView1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DataGridView1.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView1.ThemeStyle.HeaderStyle.Height = 4;
            this.DataGridView1.ThemeStyle.ReadOnly = false;
            this.DataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGridView1.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DataGridView1.ThemeStyle.RowsStyle.Height = 22;
            this.DataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(-10, 914);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(1515, 75);
            this.button1.TabIndex = 25;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // Uc_addroom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.DataGridView1);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_cancelAddRoom);
            this.Controls.Add(this.btn_submit);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "Uc_addroom";
            this.Size = new System.Drawing.Size(1489, 975);
            this.Load += new System.EventHandler(this.Uc_addroom_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2TextBox txt_priceRoom;
        private Guna.UI2.WinForms.Guna2ComboBox cb_typeOfBed;
        private Guna.UI2.WinForms.Guna2ComboBox cb_typeOfRoom;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2TextBox txt_numberRoom;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2GradientButton btn_cancelAddRoom;
        private Guna.UI2.WinForms.Guna2GradientButton btn_submit;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2ComboBox cb_statusClean;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2ComboBox cb_statusRoom;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2ComboBox cb_service;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Button btn_back;
        private Guna.UI2.WinForms.Guna2DataGridView DataGridView1;
        private System.Windows.Forms.Button button1;
    }
}

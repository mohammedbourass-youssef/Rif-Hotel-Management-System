namespace SamplePortProject
{
    partial class frmTicketInfo
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTicketInfo));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btmCancel = new System.Windows.Forms.Button();
            this.lblticketID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.lblNumberOFDays = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lblRoomType = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblRoomNumber = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblCompanion = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblBookingPrice = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblBookingDate = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblReservationID = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblamount = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblStartTime = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblGuestID = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblFullName = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(12)))), ((int)(((byte)(24)))));
            this.panel1.Controls.Add(this.btmCancel);
            this.panel1.Controls.Add(this.lblticketID);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1003, 37);
            this.panel1.TabIndex = 0;
            // 
            // btmCancel
            // 
            this.btmCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btmCancel.Image = ((System.Drawing.Image)(resources.GetObject("btmCancel.Image")));
            this.btmCancel.Location = new System.Drawing.Point(955, 3);
            this.btmCancel.Name = "btmCancel";
            this.btmCancel.Size = new System.Drawing.Size(45, 27);
            this.btmCancel.TabIndex = 2;
            this.btmCancel.UseVisualStyleBackColor = true;
            this.btmCancel.Click += new System.EventHandler(this.btmCancel_Click);
            // 
            // lblticketID
            // 
            this.lblticketID.AutoSize = true;
            this.lblticketID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblticketID.ForeColor = System.Drawing.Color.White;
            this.lblticketID.Location = new System.Drawing.Point(385, 6);
            this.lblticketID.Name = "lblticketID";
            this.lblticketID.Size = new System.Drawing.Size(60, 24);
            this.lblticketID.TabIndex = 1;
            this.lblticketID.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(230, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ticket Number : ";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(12)))), ((int)(((byte)(24)))));
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(13, 41);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(979, 426);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ticket";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HotelManagementSystem.Properties.Resources.Screenshot_2025_03_11_192558;
            this.pictureBox1.Location = new System.Drawing.Point(750, 162);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(229, 260);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(12)))), ((int)(((byte)(24)))));
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.lblNumberOFDays);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.lblRoomType);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.lblRoomNumber);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.lblCompanion);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.lblBookingPrice);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.lblBookingDate);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.lblReservationID);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.lblamount);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.lblEndDate);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.lblStartTime);
            this.groupBox4.ForeColor = System.Drawing.Color.White;
            this.groupBox4.Location = new System.Drawing.Point(11, 155);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(733, 267);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "other information";
            this.groupBox4.Enter += new System.EventHandler(this.groupBox4_Enter);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(361, 134);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(153, 20);
            this.label14.TabIndex = 23;
            this.label14.Text = "Number Of Dates   : ";
            this.label14.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label14.UseMnemonic = false;
            // 
            // lblNumberOFDays
            // 
            this.lblNumberOFDays.AutoSize = true;
            this.lblNumberOFDays.Location = new System.Drawing.Point(561, 134);
            this.lblNumberOFDays.Name = "lblNumberOFDays";
            this.lblNumberOFDays.Size = new System.Drawing.Size(36, 20);
            this.lblNumberOFDays.TabIndex = 22;
            this.lblNumberOFDays.Text = "+++";
            this.lblNumberOFDays.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(361, 78);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(154, 20);
            this.label13.TabIndex = 21;
            this.label13.Text = "Room Type              : ";
            // 
            // lblRoomType
            // 
            this.lblRoomType.AutoSize = true;
            this.lblRoomType.Location = new System.Drawing.Point(561, 78);
            this.lblRoomType.Name = "lblRoomType";
            this.lblRoomType.Size = new System.Drawing.Size(36, 20);
            this.lblRoomType.TabIndex = 20;
            this.lblRoomType.Text = "+++";
            this.lblRoomType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(361, 34);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(156, 20);
            this.label12.TabIndex = 19;
            this.label12.Text = "Room Number         : ";
            // 
            // lblRoomNumber
            // 
            this.lblRoomNumber.AutoSize = true;
            this.lblRoomNumber.Location = new System.Drawing.Point(561, 34);
            this.lblRoomNumber.Name = "lblRoomNumber";
            this.lblRoomNumber.Size = new System.Drawing.Size(36, 20);
            this.lblRoomNumber.TabIndex = 18;
            this.lblRoomNumber.Text = "+++";
            this.lblRoomNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 225);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 20);
            this.label3.TabIndex = 17;
            this.label3.Text = "Companion                  : ";
            // 
            // lblCompanion
            // 
            this.lblCompanion.AutoSize = true;
            this.lblCompanion.Location = new System.Drawing.Point(208, 225);
            this.lblCompanion.Name = "lblCompanion";
            this.lblCompanion.Size = new System.Drawing.Size(206, 20);
            this.lblCompanion.TabIndex = 16;
            this.lblCompanion.Text = "[?????????????????????]";
            this.lblCompanion.UseMnemonic = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(10, 111);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(158, 20);
            this.label11.TabIndex = 15;
            this.label11.Text = "Booking Price           : ";
            // 
            // lblBookingPrice
            // 
            this.lblBookingPrice.AutoSize = true;
            this.lblBookingPrice.Location = new System.Drawing.Point(208, 111);
            this.lblBookingPrice.Name = "lblBookingPrice";
            this.lblBookingPrice.Size = new System.Drawing.Size(54, 20);
            this.lblBookingPrice.TabIndex = 14;
            this.lblBookingPrice.Text = "00000";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(10, 78);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(162, 20);
            this.label10.TabIndex = 13;
            this.label10.Text = "Booking Date            : ";
            // 
            // lblBookingDate
            // 
            this.lblBookingDate.AutoSize = true;
            this.lblBookingDate.Location = new System.Drawing.Point(206, 78);
            this.lblBookingDate.Name = "lblBookingDate";
            this.lblBookingDate.Size = new System.Drawing.Size(36, 20);
            this.lblBookingDate.TabIndex = 12;
            this.lblBookingDate.Text = "+++";
            this.lblBookingDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 34);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(163, 20);
            this.label9.TabIndex = 11;
            this.label9.Text = "Reservation ID          : ";
            // 
            // lblReservationID
            // 
            this.lblReservationID.AutoSize = true;
            this.lblReservationID.Location = new System.Drawing.Point(208, 34);
            this.lblReservationID.Name = "lblReservationID";
            this.lblReservationID.Size = new System.Drawing.Size(36, 20);
            this.lblReservationID.TabIndex = 10;
            this.lblReservationID.Text = "+++";
            this.lblReservationID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(361, 189);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(157, 20);
            this.label7.TabIndex = 9;
            this.label7.Text = "AMOUNT                  : ";
            // 
            // lblamount
            // 
            this.lblamount.AutoSize = true;
            this.lblamount.Location = new System.Drawing.Point(561, 189);
            this.lblamount.Name = "lblamount";
            this.lblamount.Size = new System.Drawing.Size(54, 20);
            this.lblamount.TabIndex = 8;
            this.lblamount.Text = "00000";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(157, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "End Date                  : ";
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Location = new System.Drawing.Point(208, 189);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(88, 20);
            this.lblEndDate.TabIndex = 6;
            this.lblEndDate.Text = "lblEndDate";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 152);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(155, 20);
            this.label8.TabIndex = 5;
            this.label8.Text = "START TIME           : ";
            // 
            // lblStartTime
            // 
            this.lblStartTime.AutoSize = true;
            this.lblStartTime.Location = new System.Drawing.Point(208, 152);
            this.lblStartTime.Name = "lblStartTime";
            this.lblStartTime.Size = new System.Drawing.Size(39, 20);
            this.lblStartTime.TabIndex = 4;
            this.lblStartTime.Text = "time";
            this.lblStartTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(12)))), ((int)(((byte)(24)))));
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.lblDate);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.lblUserName);
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(518, 17);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(456, 139);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "User Info";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Date                         : ";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(202, 77);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(55, 20);
            this.lblDate.TabIndex = 6;
            this.lblDate.Text = "NAME";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(153, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "UserName               : ";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(193, 40);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(91, 20);
            this.lblUserName.TabIndex = 4;
            this.lblUserName.Text = "travel name";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(12)))), ((int)(((byte)(24)))));
            this.groupBox2.Controls.Add(this.lblGuestID);
            this.groupBox2.Controls.Add(this.lblName);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.lblFullName);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(11, 17);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(501, 139);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Guest Information";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // lblGuestID
            // 
            this.lblGuestID.AutoSize = true;
            this.lblGuestID.Location = new System.Drawing.Point(203, 77);
            this.lblGuestID.Name = "lblGuestID";
            this.lblGuestID.Size = new System.Drawing.Size(39, 20);
            this.lblGuestID.TabIndex = 3;
            this.lblGuestID.Text = "jdud";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(10, 77);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(181, 20);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Gust ID                           : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Full Name                         : ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Location = new System.Drawing.Point(206, 41);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(93, 20);
            this.lblFullName.TabIndex = 0;
            this.lblFullName.Text = "Mohamemd";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(38)))), ((int)(((byte)(70)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 522);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1003, 22);
            this.panel2.TabIndex = 3;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.BalloonTipClicked += new System.EventHandler(this.notifyIcon1_BalloonTipClicked);
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(38)))), ((int)(((byte)(70)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(12)))), ((int)(((byte)(24)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(399, 472);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(199, 43);
            this.button1.TabIndex = 4;
            this.button1.Text = "DOWNLOAD";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.MouseEnter += new System.EventHandler(this.button1_MouseEnter);
            this.button1.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            // 
            // frmTicketInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(12)))), ((int)(((byte)(24)))));
            this.ClientSize = new System.Drawing.Size(1003, 544);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmTicketInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmTicketInfo_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btmCancel;
        private System.Windows.Forms.Label lblticketID;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblGuestID;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblamount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblStartTime;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblReservationID;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblBookingDate;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblBookingPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblCompanion;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblNumberOFDays;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblRoomType;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblRoomNumber;
    }
}
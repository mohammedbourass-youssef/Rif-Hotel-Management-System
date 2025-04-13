namespace HotelManagementSystem.orders
{
    partial class frmAllOrders
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
            this.pnlheader = new System.Windows.Forms.Panel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.pnlBody = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.gunaLabel6 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel5 = new Guna.UI.WinForms.GunaLabel();
            this.pnlOrderItems = new Guna.UI2.WinForms.Guna2Panel();
            this.lblRoomNumber = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.lblName = new Guna.UI.WinForms.GunaLabel();
            this.pbProfile = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.gpnlHeaderAllOrders = new Guna.UI2.WinForms.Guna2Panel();
            this.btnAdd = new Guna.UI2.WinForms.Guna2Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnAlChangeRoomType = new System.Windows.Forms.Button();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.pnlAllOrders = new System.Windows.Forms.Panel();
            this.pnlheader.SuspendLayout();
            this.pnlBody.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbProfile)).BeginInit();
            this.gpnlHeaderAllOrders.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlheader
            // 
            this.pnlheader.Controls.Add(this.gunaLabel1);
            this.pnlheader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlheader.Location = new System.Drawing.Point(0, 0);
            this.pnlheader.Name = "pnlheader";
            this.pnlheader.Size = new System.Drawing.Size(1189, 44);
            this.pnlheader.TabIndex = 0;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(70)))));
            this.gunaLabel1.Location = new System.Drawing.Point(12, 1);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(234, 40);
            this.gunaLabel1.TabIndex = 8;
            this.gunaLabel1.Text = "CLIENT ORDERS";
            this.gunaLabel1.UseMnemonic = false;
            // 
            // pnlBody
            // 
            this.pnlBody.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnlBody.Controls.Add(this.panel1);
            this.pnlBody.Controls.Add(this.guna2Panel2);
            this.pnlBody.Controls.Add(this.gpnlHeaderAllOrders);
            this.pnlBody.Controls.Add(this.pnlAllOrders);
            this.pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBody.Location = new System.Drawing.Point(0, 44);
            this.pnlBody.Name = "pnlBody";
            this.pnlBody.Size = new System.Drawing.Size(1189, 734);
            this.pnlBody.TabIndex = 1;
            this.pnlBody.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlBody_Paint);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Location = new System.Drawing.Point(494, 100);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(692, 13);
            this.panel1.TabIndex = 1;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BorderRadius = 20;
            this.guna2Panel2.Controls.Add(this.gunaLabel6);
            this.guna2Panel2.Controls.Add(this.gunaLabel5);
            this.guna2Panel2.Controls.Add(this.pnlOrderItems);
            this.guna2Panel2.Controls.Add(this.lblRoomNumber);
            this.guna2Panel2.Controls.Add(this.gunaLabel4);
            this.guna2Panel2.Controls.Add(this.lblName);
            this.guna2Panel2.Controls.Add(this.pbProfile);
            this.guna2Panel2.Controls.Add(this.gunaLabel3);
            this.guna2Panel2.FillColor = System.Drawing.Color.White;
            this.guna2Panel2.Location = new System.Drawing.Point(498, 29);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.ShadowDecoration.Parent = this.guna2Panel2;
            this.guna2Panel2.Size = new System.Drawing.Size(679, 678);
            this.guna2Panel2.TabIndex = 3;
            // 
            // gunaLabel6
            // 
            this.gunaLabel6.AutoSize = true;
            this.gunaLabel6.BackColor = System.Drawing.Color.Transparent;
            this.gunaLabel6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.gunaLabel6.Location = new System.Drawing.Point(38, 128);
            this.gunaLabel6.Name = "gunaLabel6";
            this.gunaLabel6.Size = new System.Drawing.Size(109, 21);
            this.gunaLabel6.TabIndex = 17;
            this.gunaLabel6.Text = "#100000000$";
            this.gunaLabel6.UseMnemonic = false;
            // 
            // gunaLabel5
            // 
            this.gunaLabel5.AutoSize = true;
            this.gunaLabel5.BackColor = System.Drawing.Color.Transparent;
            this.gunaLabel5.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(70)))));
            this.gunaLabel5.Location = new System.Drawing.Point(3, 88);
            this.gunaLabel5.Name = "gunaLabel5";
            this.gunaLabel5.Size = new System.Drawing.Size(191, 40);
            this.gunaLabel5.TabIndex = 16;
            this.gunaLabel5.Text = "TOTAL PRICE";
            this.gunaLabel5.UseMnemonic = false;
            // 
            // pnlOrderItems
            // 
            this.pnlOrderItems.BackColor = System.Drawing.Color.White;
            this.pnlOrderItems.BorderRadius = 17;
            this.pnlOrderItems.FillColor = System.Drawing.Color.WhiteSmoke;
            this.pnlOrderItems.Location = new System.Drawing.Point(9, 302);
            this.pnlOrderItems.Name = "pnlOrderItems";
            this.pnlOrderItems.ShadowDecoration.Parent = this.pnlOrderItems;
            this.pnlOrderItems.Size = new System.Drawing.Size(661, 364);
            this.pnlOrderItems.TabIndex = 15;
            // 
            // lblRoomNumber
            // 
            this.lblRoomNumber.AutoSize = true;
            this.lblRoomNumber.BackColor = System.Drawing.Color.Transparent;
            this.lblRoomNumber.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoomNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(70)))));
            this.lblRoomNumber.Location = new System.Drawing.Point(473, 3);
            this.lblRoomNumber.Name = "lblRoomNumber";
            this.lblRoomNumber.Size = new System.Drawing.Size(98, 21);
            this.lblRoomNumber.TabIndex = 14;
            this.lblRoomNumber.Text = "BILLING TO ";
            this.lblRoomNumber.UseMnemonic = false;
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.BackColor = System.Drawing.Color.Transparent;
            this.gunaLabel4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(70)))));
            this.gunaLabel4.Location = new System.Drawing.Point(392, 3);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(269, 21);
            this.gunaLabel4.TabIndex = 13;
            this.gunaLabel4.Text = "Ocupped                             Between :";
            this.gunaLabel4.UseMnemonic = false;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.lblName.Location = new System.Drawing.Point(199, 33);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(102, 21);
            this.lblName.TabIndex = 12;
            this.lblName.Text = "BILLING TO :";
            this.lblName.UseMnemonic = false;
            // 
            // pbProfile
            // 
            this.pbProfile.BackColor = System.Drawing.Color.Transparent;
            this.pbProfile.FillColor = System.Drawing.Color.DarkGray;
            this.pbProfile.Location = new System.Drawing.Point(109, 25);
            this.pbProfile.Name = "pbProfile";
            this.pbProfile.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.pbProfile.ShadowDecoration.Parent = this.pbProfile;
            this.pbProfile.Size = new System.Drawing.Size(48, 42);
            this.pbProfile.TabIndex = 11;
            this.pbProfile.TabStop = false;
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.BackColor = System.Drawing.Color.Transparent;
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(70)))));
            this.gunaLabel3.Location = new System.Drawing.Point(25, 3);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(102, 21);
            this.gunaLabel3.TabIndex = 10;
            this.gunaLabel3.Text = "BILLING TO :";
            this.gunaLabel3.UseMnemonic = false;
            // 
            // gpnlHeaderAllOrders
            // 
            this.gpnlHeaderAllOrders.BorderRadius = 17;
            this.gpnlHeaderAllOrders.Controls.Add(this.btnAdd);
            this.gpnlHeaderAllOrders.Controls.Add(this.button1);
            this.gpnlHeaderAllOrders.Controls.Add(this.btnAlChangeRoomType);
            this.gpnlHeaderAllOrders.Controls.Add(this.gunaLabel2);
            this.gpnlHeaderAllOrders.FillColor = System.Drawing.Color.White;
            this.gpnlHeaderAllOrders.Location = new System.Drawing.Point(19, 29);
            this.gpnlHeaderAllOrders.Name = "gpnlHeaderAllOrders";
            this.gpnlHeaderAllOrders.ShadowDecoration.Parent = this.gpnlHeaderAllOrders;
            this.gpnlHeaderAllOrders.Size = new System.Drawing.Size(456, 63);
            this.gpnlHeaderAllOrders.TabIndex = 1;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnAdd.BorderRadius = 17;
            this.btnAdd.CheckedState.Parent = this.btnAdd;
            this.btnAdd.CustomImages.Parent = this.btnAdd;
            this.btnAdd.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(70)))));
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(138)))), ((int)(((byte)(20)))));
            this.btnAdd.HoverState.Parent = this.btnAdd;
            this.btnAdd.Image = global::HotelManagementSystem.Properties.Resources.icons8_add_40;
            this.btnAdd.ImageSize = new System.Drawing.Size(40, 40);
            this.btnAdd.Location = new System.Drawing.Point(367, 13);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.ShadowDecoration.Parent = this.btnAdd;
            this.btnAdd.Size = new System.Drawing.Size(67, 36);
            this.btnAdd.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::HotelManagementSystem.Properties.Resources.icons8_search_30;
            this.button1.Location = new System.Drawing.Point(296, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(49, 47);
            this.button1.TabIndex = 11;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btnAlChangeRoomType
            // 
            this.btnAlChangeRoomType.BackColor = System.Drawing.Color.Transparent;
            this.btnAlChangeRoomType.FlatAppearance.BorderSize = 0;
            this.btnAlChangeRoomType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlChangeRoomType.Image = global::HotelManagementSystem.Properties.Resources.icons8_expand_arrow_20;
            this.btnAlChangeRoomType.Location = new System.Drawing.Point(154, 21);
            this.btnAlChangeRoomType.Name = "btnAlChangeRoomType";
            this.btnAlChangeRoomType.Size = new System.Drawing.Size(34, 18);
            this.btnAlChangeRoomType.TabIndex = 10;
            this.btnAlChangeRoomType.UseVisualStyleBackColor = false;
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.BackColor = System.Drawing.Color.Transparent;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(70)))));
            this.gunaLabel2.Location = new System.Drawing.Point(13, 18);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(141, 21);
            this.gunaLabel2.TabIndex = 9;
            this.gunaLabel2.Text = "All Rooms Orders";
            this.gunaLabel2.UseMnemonic = false;
            // 
            // pnlAllOrders
            // 
            this.pnlAllOrders.AutoScroll = true;
            this.pnlAllOrders.Location = new System.Drawing.Point(19, 103);
            this.pnlAllOrders.Name = "pnlAllOrders";
            this.pnlAllOrders.Size = new System.Drawing.Size(469, 604);
            this.pnlAllOrders.TabIndex = 0;
            // 
            // frmAllOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1189, 778);
            this.Controls.Add(this.pnlBody);
            this.Controls.Add(this.pnlheader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAllOrders";
            this.Load += new System.EventHandler(this.frmAllOrders_Load);
            this.pnlheader.ResumeLayout(false);
            this.pnlheader.PerformLayout();
            this.pnlBody.ResumeLayout(false);
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbProfile)).EndInit();
            this.gpnlHeaderAllOrders.ResumeLayout(false);
            this.gpnlHeaderAllOrders.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlheader;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private System.Windows.Forms.Panel pnlBody;
        private System.Windows.Forms.Panel pnlAllOrders;
        private Guna.UI2.WinForms.Guna2Panel gpnlHeaderAllOrders;
        private System.Windows.Forms.Button btnAlChangeRoomType;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private System.Windows.Forms.Button button1;
        private Guna.UI2.WinForms.Guna2Button btnAdd;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI.WinForms.GunaLabel lblName;
        private Guna.UI2.WinForms.Guna2CirclePictureBox pbProfile;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI.WinForms.GunaLabel lblRoomNumber;
        private Guna.UI2.WinForms.Guna2Panel pnlOrderItems;
        private Guna.UI.WinForms.GunaLabel gunaLabel6;
        private Guna.UI.WinForms.GunaLabel gunaLabel5;
    }
}
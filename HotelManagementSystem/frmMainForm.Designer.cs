namespace HotelManagementSystem
{
    partial class frmMainForm
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
            this.pnlBody = new Guna.UI2.WinForms.Guna2Panel();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnRoomsServices = new Guna.UI2.WinForms.Guna2Button();
            this.btnReport = new Guna.UI2.WinForms.Guna2Button();
            this.btnManageGuests = new Guna.UI2.WinForms.Guna2Button();
            this.pnlRoomsContiner = new System.Windows.Forms.Panel();
            this.btnRoomsCategories = new Guna.UI2.WinForms.Guna2Button();
            this.btnManageRooms = new Guna.UI2.WinForms.Guna2Button();
            this.btnManagePersons = new Guna.UI2.WinForms.Guna2Button();
            this.btnManageUsers = new Guna.UI2.WinForms.Guna2Button();
            this.pnlEmployeesCountiner = new System.Windows.Forms.Panel();
            this.btnShowRoles = new Guna.UI2.WinForms.Guna2Button();
            this.btnEmployee = new Guna.UI2.WinForms.Guna2Button();
            this.btnReservation = new Guna.UI2.WinForms.Guna2Button();
            this.btnDashboad = new Guna.UI2.WinForms.Guna2Button();
            this.btnLogout = new Guna.UI2.WinForms.Guna2Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlMenu.SuspendLayout();
            this.pnlRoomsContiner.SuspendLayout();
            this.pnlEmployeesCountiner.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlBody
            // 
            this.pnlBody.BackColor = System.Drawing.Color.Transparent;
            this.pnlBody.BorderRadius = 40;
            this.pnlBody.FillColor = System.Drawing.Color.White;
            this.pnlBody.Location = new System.Drawing.Point(291, 27);
            this.pnlBody.Name = "pnlBody";
            this.pnlBody.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(70)))));
            this.pnlBody.ShadowDecoration.Enabled = true;
            this.pnlBody.ShadowDecoration.Parent = this.pnlBody;
            this.pnlBody.Size = new System.Drawing.Size(1189, 778);
            this.pnlBody.TabIndex = 0;
            // 
            // pnlMenu
            // 
            this.pnlMenu.Controls.Add(this.btnRoomsServices);
            this.pnlMenu.Controls.Add(this.btnReport);
            this.pnlMenu.Controls.Add(this.btnManageGuests);
            this.pnlMenu.Controls.Add(this.pnlRoomsContiner);
            this.pnlMenu.Controls.Add(this.btnManagePersons);
            this.pnlMenu.Controls.Add(this.btnManageUsers);
            this.pnlMenu.Controls.Add(this.pnlEmployeesCountiner);
            this.pnlMenu.Controls.Add(this.btnReservation);
            this.pnlMenu.Controls.Add(this.btnDashboad);
            this.pnlMenu.Location = new System.Drawing.Point(17, 177);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(257, 563);
            this.pnlMenu.TabIndex = 9;
            // 
            // btnRoomsServices
            // 
            this.btnRoomsServices.BorderRadius = 20;
            this.btnRoomsServices.CheckedState.Parent = this.btnRoomsServices;
            this.btnRoomsServices.CustomImages.Parent = this.btnRoomsServices;
            this.btnRoomsServices.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRoomsServices.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(70)))));
            this.btnRoomsServices.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRoomsServices.ForeColor = System.Drawing.Color.White;
            this.btnRoomsServices.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(138)))), ((int)(((byte)(20)))));
            this.btnRoomsServices.HoverState.Parent = this.btnRoomsServices;
            this.btnRoomsServices.Image = global::HotelManagementSystem.Properties.Resources.icons8_dining_40;
            this.btnRoomsServices.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnRoomsServices.ImageSize = new System.Drawing.Size(45, 45);
            this.btnRoomsServices.Location = new System.Drawing.Point(0, 355);
            this.btnRoomsServices.Name = "btnRoomsServices";
            this.btnRoomsServices.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.btnRoomsServices.PressedDepth = 100;
            this.btnRoomsServices.ShadowDecoration.Parent = this.btnRoomsServices;
            this.btnRoomsServices.Size = new System.Drawing.Size(257, 43);
            this.btnRoomsServices.TabIndex = 18;
            this.btnRoomsServices.Text = "Room Services";
            this.btnRoomsServices.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.btnRoomsServices.Click += new System.EventHandler(this.btnRoomsServices_Click);
            // 
            // btnReport
            // 
            this.btnReport.BorderRadius = 20;
            this.btnReport.CheckedState.Parent = this.btnReport;
            this.btnReport.CustomImages.Parent = this.btnReport;
            this.btnReport.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReport.FillColor = System.Drawing.Color.Transparent;
            this.btnReport.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReport.ForeColor = System.Drawing.Color.White;
            this.btnReport.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(138)))), ((int)(((byte)(20)))));
            this.btnReport.HoverState.Parent = this.btnReport;
            this.btnReport.Image = global::HotelManagementSystem.Properties.Resources.icons8_statistics_report_40;
            this.btnReport.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnReport.ImageSize = new System.Drawing.Size(45, 45);
            this.btnReport.Location = new System.Drawing.Point(0, 310);
            this.btnReport.Name = "btnReport";
            this.btnReport.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.btnReport.PressedDepth = 100;
            this.btnReport.ShadowDecoration.Parent = this.btnReport;
            this.btnReport.Size = new System.Drawing.Size(257, 45);
            this.btnReport.TabIndex = 17;
            this.btnReport.Text = "         Statistic & Payements";
            this.btnReport.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // btnManageGuests
            // 
            this.btnManageGuests.BorderRadius = 20;
            this.btnManageGuests.CheckedState.Parent = this.btnManageGuests;
            this.btnManageGuests.CustomImages.Parent = this.btnManageGuests;
            this.btnManageGuests.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnManageGuests.FillColor = System.Drawing.Color.Transparent;
            this.btnManageGuests.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageGuests.ForeColor = System.Drawing.Color.White;
            this.btnManageGuests.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(138)))), ((int)(((byte)(20)))));
            this.btnManageGuests.HoverState.Parent = this.btnManageGuests;
            this.btnManageGuests.Image = global::HotelManagementSystem.Properties.Resources.icons8_reception_40;
            this.btnManageGuests.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnManageGuests.ImageSize = new System.Drawing.Size(45, 45);
            this.btnManageGuests.Location = new System.Drawing.Point(0, 265);
            this.btnManageGuests.Name = "btnManageGuests";
            this.btnManageGuests.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.btnManageGuests.PressedDepth = 100;
            this.btnManageGuests.ShadowDecoration.Parent = this.btnManageGuests;
            this.btnManageGuests.Size = new System.Drawing.Size(257, 45);
            this.btnManageGuests.TabIndex = 16;
            this.btnManageGuests.Text = "Manage Guests";
            this.btnManageGuests.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.btnManageGuests.Click += new System.EventHandler(this.btnManageGuests_Click);
            // 
            // pnlRoomsContiner
            // 
            this.pnlRoomsContiner.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(40)))), ((int)(((byte)(70)))));
            this.pnlRoomsContiner.Controls.Add(this.btnRoomsCategories);
            this.pnlRoomsContiner.Controls.Add(this.btnManageRooms);
            this.pnlRoomsContiner.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlRoomsContiner.Location = new System.Drawing.Point(0, 223);
            this.pnlRoomsContiner.Name = "pnlRoomsContiner";
            this.pnlRoomsContiner.Size = new System.Drawing.Size(257, 42);
            this.pnlRoomsContiner.TabIndex = 15;
            // 
            // btnRoomsCategories
            // 
            this.btnRoomsCategories.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(40)))), ((int)(((byte)(70)))));
            this.btnRoomsCategories.BorderRadius = 10;
            this.btnRoomsCategories.CheckedState.Parent = this.btnRoomsCategories;
            this.btnRoomsCategories.CustomImages.Parent = this.btnRoomsCategories;
            this.btnRoomsCategories.FillColor = System.Drawing.Color.Transparent;
            this.btnRoomsCategories.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRoomsCategories.ForeColor = System.Drawing.Color.White;
            this.btnRoomsCategories.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(138)))), ((int)(((byte)(20)))));
            this.btnRoomsCategories.HoverState.Parent = this.btnRoomsCategories;
            this.btnRoomsCategories.Image = global::HotelManagementSystem.Properties.Resources.icons8_category_40;
            this.btnRoomsCategories.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnRoomsCategories.ImageSize = new System.Drawing.Size(30, 30);
            this.btnRoomsCategories.Location = new System.Drawing.Point(28, 49);
            this.btnRoomsCategories.Name = "btnRoomsCategories";
            this.btnRoomsCategories.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.btnRoomsCategories.PressedDepth = 100;
            this.btnRoomsCategories.ShadowDecoration.Parent = this.btnRoomsCategories;
            this.btnRoomsCategories.Size = new System.Drawing.Size(229, 27);
            this.btnRoomsCategories.TabIndex = 10;
            this.btnRoomsCategories.Text = "Rooms Category";
            this.btnRoomsCategories.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.btnRoomsCategories.Click += new System.EventHandler(this.btnRoomsCategories_Click);
            // 
            // btnManageRooms
            // 
            this.btnManageRooms.BorderRadius = 20;
            this.btnManageRooms.CheckedState.Parent = this.btnManageRooms;
            this.btnManageRooms.CustomImages.Parent = this.btnManageRooms;
            this.btnManageRooms.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnManageRooms.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(70)))));
            this.btnManageRooms.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageRooms.ForeColor = System.Drawing.Color.White;
            this.btnManageRooms.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(138)))), ((int)(((byte)(20)))));
            this.btnManageRooms.HoverState.Parent = this.btnManageRooms;
            this.btnManageRooms.Image = global::HotelManagementSystem.Properties.Resources.icons8_keys_40;
            this.btnManageRooms.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnManageRooms.ImageSize = new System.Drawing.Size(45, 45);
            this.btnManageRooms.Location = new System.Drawing.Point(0, 0);
            this.btnManageRooms.Name = "btnManageRooms";
            this.btnManageRooms.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.btnManageRooms.PressedDepth = 100;
            this.btnManageRooms.ShadowDecoration.Parent = this.btnManageRooms;
            this.btnManageRooms.Size = new System.Drawing.Size(257, 43);
            this.btnManageRooms.TabIndex = 9;
            this.btnManageRooms.Text = "Manage Rooms";
            this.btnManageRooms.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.btnManageRooms.Click += new System.EventHandler(this.guna2Button2_Click_1);
            // 
            // btnManagePersons
            // 
            this.btnManagePersons.BorderRadius = 20;
            this.btnManagePersons.CheckedState.Parent = this.btnManagePersons;
            this.btnManagePersons.CustomImages.Parent = this.btnManagePersons;
            this.btnManagePersons.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnManagePersons.FillColor = System.Drawing.Color.Transparent;
            this.btnManagePersons.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManagePersons.ForeColor = System.Drawing.Color.White;
            this.btnManagePersons.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(138)))), ((int)(((byte)(20)))));
            this.btnManagePersons.HoverState.Parent = this.btnManagePersons;
            this.btnManagePersons.Image = global::HotelManagementSystem.Properties.Resources.icons8_user_account_50;
            this.btnManagePersons.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnManagePersons.ImageSize = new System.Drawing.Size(45, 45);
            this.btnManagePersons.Location = new System.Drawing.Point(0, 178);
            this.btnManagePersons.Name = "btnManagePersons";
            this.btnManagePersons.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.btnManagePersons.PressedDepth = 100;
            this.btnManagePersons.ShadowDecoration.Parent = this.btnManagePersons;
            this.btnManagePersons.Size = new System.Drawing.Size(257, 45);
            this.btnManagePersons.TabIndex = 14;
            this.btnManagePersons.Text = "Manage People";
            this.btnManagePersons.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.btnManagePersons.Click += new System.EventHandler(this.btnManagePersons_Click);
            // 
            // btnManageUsers
            // 
            this.btnManageUsers.BorderRadius = 20;
            this.btnManageUsers.CheckedState.Parent = this.btnManageUsers;
            this.btnManageUsers.CustomImages.Parent = this.btnManageUsers;
            this.btnManageUsers.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnManageUsers.FillColor = System.Drawing.Color.Transparent;
            this.btnManageUsers.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageUsers.ForeColor = System.Drawing.Color.White;
            this.btnManageUsers.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(138)))), ((int)(((byte)(20)))));
            this.btnManageUsers.HoverState.Parent = this.btnManageUsers;
            this.btnManageUsers.Image = global::HotelManagementSystem.Properties.Resources.icons8_users_settings_64;
            this.btnManageUsers.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnManageUsers.ImageSize = new System.Drawing.Size(45, 45);
            this.btnManageUsers.Location = new System.Drawing.Point(0, 133);
            this.btnManageUsers.Name = "btnManageUsers";
            this.btnManageUsers.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.btnManageUsers.PressedDepth = 100;
            this.btnManageUsers.ShadowDecoration.Parent = this.btnManageUsers;
            this.btnManageUsers.Size = new System.Drawing.Size(257, 45);
            this.btnManageUsers.TabIndex = 13;
            this.btnManageUsers.Text = "Manage Users";
            this.btnManageUsers.TextOffset = new System.Drawing.Point(-5, 0);
            this.btnManageUsers.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.btnManageUsers.Click += new System.EventHandler(this.btnUsers_Click);
            // 
            // pnlEmployeesCountiner
            // 
            this.pnlEmployeesCountiner.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(40)))), ((int)(((byte)(70)))));
            this.pnlEmployeesCountiner.Controls.Add(this.btnShowRoles);
            this.pnlEmployeesCountiner.Controls.Add(this.btnEmployee);
            this.pnlEmployeesCountiner.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlEmployeesCountiner.Location = new System.Drawing.Point(0, 90);
            this.pnlEmployeesCountiner.Name = "pnlEmployeesCountiner";
            this.pnlEmployeesCountiner.Size = new System.Drawing.Size(257, 43);
            this.pnlEmployeesCountiner.TabIndex = 10;
            // 
            // btnShowRoles
            // 
            this.btnShowRoles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(40)))), ((int)(((byte)(70)))));
            this.btnShowRoles.BorderRadius = 10;
            this.btnShowRoles.CheckedState.Parent = this.btnShowRoles;
            this.btnShowRoles.CustomImages.Parent = this.btnShowRoles;
            this.btnShowRoles.FillColor = System.Drawing.Color.Transparent;
            this.btnShowRoles.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowRoles.ForeColor = System.Drawing.Color.White;
            this.btnShowRoles.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(138)))), ((int)(((byte)(20)))));
            this.btnShowRoles.HoverState.Parent = this.btnShowRoles;
            this.btnShowRoles.Image = global::HotelManagementSystem.Properties.Resources.icons8_users_64;
            this.btnShowRoles.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnShowRoles.ImageSize = new System.Drawing.Size(30, 30);
            this.btnShowRoles.Location = new System.Drawing.Point(28, 49);
            this.btnShowRoles.Name = "btnShowRoles";
            this.btnShowRoles.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.btnShowRoles.PressedDepth = 100;
            this.btnShowRoles.ShadowDecoration.Parent = this.btnShowRoles;
            this.btnShowRoles.Size = new System.Drawing.Size(229, 27);
            this.btnShowRoles.TabIndex = 10;
            this.btnShowRoles.Text = "Employees Roles";
            this.btnShowRoles.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.btnShowRoles.Click += new System.EventHandler(this.btnShowRoles_Click);
            // 
            // btnEmployee
            // 
            this.btnEmployee.BorderRadius = 20;
            this.btnEmployee.CheckedState.Parent = this.btnEmployee;
            this.btnEmployee.CustomImages.Parent = this.btnEmployee;
            this.btnEmployee.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEmployee.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(70)))));
            this.btnEmployee.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmployee.ForeColor = System.Drawing.Color.White;
            this.btnEmployee.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(138)))), ((int)(((byte)(20)))));
            this.btnEmployee.HoverState.Parent = this.btnEmployee;
            this.btnEmployee.Image = global::HotelManagementSystem.Properties.Resources.icons8_businessman_50;
            this.btnEmployee.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnEmployee.ImageSize = new System.Drawing.Size(45, 45);
            this.btnEmployee.Location = new System.Drawing.Point(0, 0);
            this.btnEmployee.Name = "btnEmployee";
            this.btnEmployee.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.btnEmployee.PressedDepth = 100;
            this.btnEmployee.ShadowDecoration.Parent = this.btnEmployee;
            this.btnEmployee.Size = new System.Drawing.Size(257, 45);
            this.btnEmployee.TabIndex = 9;
            this.btnEmployee.Text = "Manage Employees";
            this.btnEmployee.TextOffset = new System.Drawing.Point(16, 0);
            this.btnEmployee.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.btnEmployee.Click += new System.EventHandler(this.btnEmployee_Click);
            // 
            // btnReservation
            // 
            this.btnReservation.BorderRadius = 20;
            this.btnReservation.CheckedState.Parent = this.btnReservation;
            this.btnReservation.CustomImages.Parent = this.btnReservation;
            this.btnReservation.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReservation.FillColor = System.Drawing.Color.Transparent;
            this.btnReservation.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReservation.ForeColor = System.Drawing.Color.White;
            this.btnReservation.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(138)))), ((int)(((byte)(20)))));
            this.btnReservation.HoverState.Parent = this.btnReservation;
            this.btnReservation.Image = global::HotelManagementSystem.Properties.Resources.icons8_travel_portal_64;
            this.btnReservation.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnReservation.ImageSize = new System.Drawing.Size(45, 45);
            this.btnReservation.Location = new System.Drawing.Point(0, 45);
            this.btnReservation.Name = "btnReservation";
            this.btnReservation.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.btnReservation.PressedDepth = 100;
            this.btnReservation.ShadowDecoration.Parent = this.btnReservation;
            this.btnReservation.Size = new System.Drawing.Size(257, 45);
            this.btnReservation.TabIndex = 12;
            this.btnReservation.Text = "Reservations";
            this.btnReservation.TextOffset = new System.Drawing.Point(-12, 0);
            this.btnReservation.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.btnReservation.Click += new System.EventHandler(this.btnReservation_Click);
            // 
            // btnDashboad
            // 
            this.btnDashboad.BorderRadius = 20;
            this.btnDashboad.CheckedState.Parent = this.btnDashboad;
            this.btnDashboad.CustomImages.Parent = this.btnDashboad;
            this.btnDashboad.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDashboad.FillColor = System.Drawing.Color.Transparent;
            this.btnDashboad.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboad.ForeColor = System.Drawing.Color.White;
            this.btnDashboad.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(138)))), ((int)(((byte)(20)))));
            this.btnDashboad.HoverState.Parent = this.btnDashboad;
            this.btnDashboad.Image = global::HotelManagementSystem.Properties.Resources.icons8_home_50;
            this.btnDashboad.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnDashboad.ImageSize = new System.Drawing.Size(45, 45);
            this.btnDashboad.Location = new System.Drawing.Point(0, 0);
            this.btnDashboad.Name = "btnDashboad";
            this.btnDashboad.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.btnDashboad.PressedDepth = 100;
            this.btnDashboad.ShadowDecoration.Parent = this.btnDashboad;
            this.btnDashboad.Size = new System.Drawing.Size(257, 45);
            this.btnDashboad.TabIndex = 11;
            this.btnDashboad.Text = "DASHBOARD";
            this.btnDashboad.TextOffset = new System.Drawing.Point(-12, 0);
            this.btnDashboad.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.btnDashboad.Click += new System.EventHandler(this.btnDashboad_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BorderRadius = 20;
            this.btnLogout.CheckedState.Parent = this.btnLogout;
            this.btnLogout.CustomImages.Parent = this.btnLogout;
            this.btnLogout.FillColor = System.Drawing.Color.Transparent;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(138)))), ((int)(((byte)(20)))));
            this.btnLogout.HoverState.Parent = this.btnLogout;
            this.btnLogout.Image = global::HotelManagementSystem.Properties.Resources.icons8_login_rounded_64;
            this.btnLogout.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnLogout.ImageSize = new System.Drawing.Size(45, 45);
            this.btnLogout.Location = new System.Drawing.Point(17, 772);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.btnLogout.PressedDepth = 100;
            this.btnLogout.ShadowDecoration.Parent = this.btnLogout;
            this.btnLogout.Size = new System.Drawing.Size(257, 45);
            this.btnLogout.TabIndex = 5;
            this.btnLogout.Text = "LOGOUT";
            this.btnLogout.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::HotelManagementSystem.Properties.Resources.Screenshot_2025_02_15_161348_removebg_preview;
            this.pictureBox1.Location = new System.Drawing.Point(28, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(233, 159);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // frmMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(70)))));
            this.ClientSize = new System.Drawing.Size(1516, 826);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pnlBody);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmMainForm_Load);
            this.pnlMenu.ResumeLayout(false);
            this.pnlRoomsContiner.ResumeLayout(false);
            this.pnlEmployeesCountiner.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnlBody;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2Button btnLogout;
        private System.Windows.Forms.Panel pnlMenu;
        private Guna.UI2.WinForms.Guna2Button btnManageUsers;
        private System.Windows.Forms.Panel pnlEmployeesCountiner;
        private Guna.UI2.WinForms.Guna2Button btnShowRoles;
        private Guna.UI2.WinForms.Guna2Button btnEmployee;
        private Guna.UI2.WinForms.Guna2Button btnReservation;
        private Guna.UI2.WinForms.Guna2Button btnDashboad;
        private Guna.UI2.WinForms.Guna2Button btnManagePersons;
        private System.Windows.Forms.Panel pnlRoomsContiner;
        private Guna.UI2.WinForms.Guna2Button btnRoomsCategories;
        private Guna.UI2.WinForms.Guna2Button btnManageRooms;
        private Guna.UI2.WinForms.Guna2Button btnManageGuests;
        private Guna.UI2.WinForms.Guna2Button btnReport;
        private Guna.UI2.WinForms.Guna2Button btnRoomsServices;
    }
}


namespace HotelManagementSystem.Users
{
    partial class frmManageUsers
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cmFilter = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPeople = new System.Windows.Forms.Label();
            this.dgvAllUsers = new Guna.UI.WinForms.GunaDataGridView();
            this.g = new Guna.UI.WinForms.GunaContextMenuStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnAddNewUser = new Guna.UI.WinForms.GunaButton();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.UserPErmissions = new System.Windows.Forms.ToolStripMenuItem();
            this.FiredItems = new System.Windows.Forms.ToolStripMenuItem();
            this.changePassword = new System.Windows.Forms.ToolStripMenuItem();
            this.changeUSername = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllUsers)).BeginInit();
            this.g.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmFilter
            // 
            this.cmFilter.BackColor = System.Drawing.Color.Transparent;
            this.cmFilter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(70)))));
            this.cmFilter.BorderRadius = 20;
            this.cmFilter.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmFilter.FocusedColor = System.Drawing.Color.Empty;
            this.cmFilter.FocusedState.Parent = this.cmFilter;
            this.cmFilter.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmFilter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmFilter.FormattingEnabled = true;
            this.cmFilter.HoverState.Parent = this.cmFilter;
            this.cmFilter.ItemHeight = 30;
            this.cmFilter.Items.AddRange(new object[] {
            "None",
            "ID",
            "User Name",
            "Full Name"});
            this.cmFilter.ItemsAppearance.Parent = this.cmFilter;
            this.cmFilter.Location = new System.Drawing.Point(106, 260);
            this.cmFilter.Name = "cmFilter";
            this.cmFilter.ShadowDecoration.Parent = this.cmFilter;
            this.cmFilter.Size = new System.Drawing.Size(238, 36);
            this.cmFilter.TabIndex = 26;
            this.cmFilter.SelectedIndexChanged += new System.EventHandler(this.cmFilter_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Variable Display", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(70)))));
            this.label1.Location = new System.Drawing.Point(13, 260);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 28);
            this.label1.TabIndex = 24;
            this.label1.Text = "Filter By : ";
            // 
            // lblPeople
            // 
            this.lblPeople.AutoSize = true;
            this.lblPeople.BackColor = System.Drawing.Color.Transparent;
            this.lblPeople.Font = new System.Drawing.Font("Segoe UI Variable Display", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeople.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(70)))));
            this.lblPeople.Location = new System.Drawing.Point(461, 191);
            this.lblPeople.Name = "lblPeople";
            this.lblPeople.Size = new System.Drawing.Size(266, 49);
            this.lblPeople.TabIndex = 23;
            this.lblPeople.Text = "Manage Users";
            // 
            // dgvAllUsers
            // 
            this.dgvAllUsers.AllowDrop = true;
            this.dgvAllUsers.AllowUserToAddRows = false;
            this.dgvAllUsers.AllowUserToDeleteRows = false;
            this.dgvAllUsers.AllowUserToResizeColumns = false;
            this.dgvAllUsers.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvAllUsers.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAllUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAllUsers.BackgroundColor = System.Drawing.Color.White;
            this.dgvAllUsers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAllUsers.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dgvAllUsers.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(138)))), ((int)(((byte)(20)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAllUsers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAllUsers.ColumnHeadersHeight = 30;
            this.dgvAllUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvAllUsers.ContextMenuStrip = this.g;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(138)))), ((int)(((byte)(20)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAllUsers.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvAllUsers.EnableHeadersVisualStyles = false;
            this.dgvAllUsers.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(138)))), ((int)(((byte)(20)))));
            this.dgvAllUsers.Location = new System.Drawing.Point(12, 321);
            this.dgvAllUsers.Name = "dgvAllUsers";
            this.dgvAllUsers.ReadOnly = true;
            this.dgvAllUsers.RowHeadersVisible = false;
            this.dgvAllUsers.RowTemplate.Height = 30;
            this.dgvAllUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAllUsers.Size = new System.Drawing.Size(1160, 441);
            this.dgvAllUsers.TabIndex = 22;
            this.dgvAllUsers.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.dgvAllUsers.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvAllUsers.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvAllUsers.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvAllUsers.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvAllUsers.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvAllUsers.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvAllUsers.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(138)))), ((int)(((byte)(20)))));
            this.dgvAllUsers.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.dgvAllUsers.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dgvAllUsers.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvAllUsers.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvAllUsers.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvAllUsers.ThemeStyle.HeaderStyle.Height = 30;
            this.dgvAllUsers.ThemeStyle.ReadOnly = true;
            this.dgvAllUsers.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvAllUsers.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dgvAllUsers.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvAllUsers.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvAllUsers.ThemeStyle.RowsStyle.Height = 30;
            this.dgvAllUsers.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvAllUsers.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(138)))), ((int)(((byte)(20)))));
            this.dgvAllUsers.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAllUsers_CellDoubleClick);
            // 
            // g
            // 
            this.g.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(70)))));
            this.g.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem4,
            this.UserPErmissions,
            this.FiredItems,
            this.toolStripSeparator1,
            this.changePassword,
            this.changeUSername,
            this.toolStripSeparator2,
            this.toolStripMenuItem1,
            this.toolStripMenuItem3,
            this.toolStripMenuItem6});
            this.g.Name = "g";
            this.g.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.g.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro;
            this.g.RenderStyle.ColorTable = null;
            this.g.RenderStyle.RoundedEdges = true;
            this.g.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
            this.g.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(138)))), ((int)(((byte)(20)))));
            this.g.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.g.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro;
            this.g.RenderStyle.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.SystemDefault;
            this.g.Size = new System.Drawing.Size(424, 486);
            this.g.Opening += new System.ComponentModel.CancelEventHandler(this.g_Opening);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.toolStripSeparator1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(138)))), ((int)(((byte)(20)))));
            this.toolStripSeparator1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(138)))), ((int)(((byte)(20)))));
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(420, 6);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(420, 6);
            // 
            // txtSearch
            // 
            this.txtSearch.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(70)))));
            this.txtSearch.BorderRadius = 20;
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.DefaultText = "";
            this.txtSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.DisabledState.Parent = this.txtSearch;
            this.txtSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.FocusedState.Parent = this.txtSearch;
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.Color.Black;
            this.txtSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.HoverState.Parent = this.txtSearch;
            this.txtSearch.Location = new System.Drawing.Point(352, 260);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PlaceholderText = "Search";
            this.txtSearch.SelectedText = "";
            this.txtSearch.ShadowDecoration.Parent = this.txtSearch;
            this.txtSearch.Size = new System.Drawing.Size(272, 37);
            this.txtSearch.TabIndex = 25;
            this.txtSearch.Visible = false;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            this.txtSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearch_KeyPress);
            // 
            // btnAddNewUser
            // 
            this.btnAddNewUser.AnimationHoverSpeed = 0.07F;
            this.btnAddNewUser.AnimationSpeed = 0.03F;
            this.btnAddNewUser.BackColor = System.Drawing.Color.Transparent;
            this.btnAddNewUser.BaseColor = System.Drawing.Color.Transparent;
            this.btnAddNewUser.BorderColor = System.Drawing.Color.Black;
            this.btnAddNewUser.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAddNewUser.FocusedColor = System.Drawing.Color.Empty;
            this.btnAddNewUser.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAddNewUser.ForeColor = System.Drawing.Color.White;
            this.btnAddNewUser.Image = global::HotelManagementSystem.Properties.Resources._9453898;
            this.btnAddNewUser.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAddNewUser.ImageSize = new System.Drawing.Size(60, 60);
            this.btnAddNewUser.Location = new System.Drawing.Point(1109, 240);
            this.btnAddNewUser.Name = "btnAddNewUser";
            this.btnAddNewUser.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.btnAddNewUser.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnAddNewUser.OnHoverForeColor = System.Drawing.Color.White;
            this.btnAddNewUser.OnHoverImage = null;
            this.btnAddNewUser.OnPressedColor = System.Drawing.Color.Black;
            this.btnAddNewUser.Radius = 30;
            this.btnAddNewUser.Size = new System.Drawing.Size(63, 64);
            this.btnAddNewUser.TabIndex = 28;
            this.btnAddNewUser.Click += new System.EventHandler(this.btnAddNewUser_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem4.ForeColor = System.Drawing.Color.White;
            this.toolStripMenuItem4.Image = global::HotelManagementSystem.Properties.Resources.icons8_more_info_50;
            this.toolStripMenuItem4.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(423, 56);
            this.toolStripMenuItem4.Text = "        Details";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.toolStripMenuItem4_Click);
            // 
            // UserPErmissions
            // 
            this.UserPErmissions.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserPErmissions.ForeColor = System.Drawing.Color.White;
            this.UserPErmissions.Image = global::HotelManagementSystem.Properties.Resources.icons8_user_50;
            this.UserPErmissions.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.UserPErmissions.Name = "UserPErmissions";
            this.UserPErmissions.Size = new System.Drawing.Size(423, 56);
            this.UserPErmissions.Text = "        Chnage User Permissions";
            // 
            // FiredItems
            // 
            this.FiredItems.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FiredItems.ForeColor = System.Drawing.Color.White;
            this.FiredItems.Image = global::HotelManagementSystem.Properties.Resources.icons8_stop_gesture_40;
            this.FiredItems.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.FiredItems.Name = "FiredItems";
            this.FiredItems.Size = new System.Drawing.Size(423, 56);
            this.FiredItems.Text = "       Termination Of User Access";
            this.FiredItems.Click += new System.EventHandler(this.FiredItems_Click);
            // 
            // changePassword
            // 
            this.changePassword.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changePassword.ForeColor = System.Drawing.Color.IndianRed;
            this.changePassword.Image = global::HotelManagementSystem.Properties.Resources.icons8_password_48__1_;
            this.changePassword.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.changePassword.Name = "changePassword";
            this.changePassword.Size = new System.Drawing.Size(423, 56);
            this.changePassword.Text = "     Change Password";
            this.changePassword.Click += new System.EventHandler(this.changePassword_Click);
            // 
            // changeUSername
            // 
            this.changeUSername.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeUSername.ForeColor = System.Drawing.Color.White;
            this.changeUSername.Image = global::HotelManagementSystem.Properties.Resources.icons8_edit_profile_40;
            this.changeUSername.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.changeUSername.Name = "changeUSername";
            this.changeUSername.Size = new System.Drawing.Size(423, 56);
            this.changeUSername.Text = "    Change UserName";
            this.changeUSername.Click += new System.EventHandler(this.changeUSername_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.toolStripMenuItem1.Image = global::HotelManagementSystem.Properties.Resources.icons8_call_40__1_;
            this.toolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(423, 56);
            this.toolStripMenuItem1.Text = "        Send Local Message";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.toolStripMenuItem3.Image = global::HotelManagementSystem.Properties.Resources.icons8_call_40__1_;
            this.toolStripMenuItem3.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(423, 56);
            this.toolStripMenuItem3.Text = "        Call ";
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.toolStripMenuItem6.Image = global::HotelManagementSystem.Properties.Resources.icons8_email_40;
            this.toolStripMenuItem6.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(423, 56);
            this.toolStripMenuItem6.Text = "      Send Email";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HotelManagementSystem.Properties.Resources.Screenshot_2025_02_19_150514;
            this.pictureBox1.Location = new System.Drawing.Point(409, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(382, 185);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // frmManageUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1189, 778);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnAddNewUser);
            this.Controls.Add(this.cmFilter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblPeople);
            this.Controls.Add(this.dgvAllUsers);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmManageUsers";
            this.Text = "frmManageUsers";
            this.Load += new System.EventHandler(this.frmManageUsers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllUsers)).EndInit();
            this.g.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI.WinForms.GunaButton btnAddNewUser;
        private Guna.UI2.WinForms.Guna2ComboBox cmFilter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPeople;
        private Guna.UI.WinForms.GunaDataGridView dgvAllUsers;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI.WinForms.GunaContextMenuStrip g;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem UserPErmissions;
        private System.Windows.Forms.ToolStripMenuItem FiredItems;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem changePassword;
        private System.Windows.Forms.ToolStripMenuItem changeUSername;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
    }
}
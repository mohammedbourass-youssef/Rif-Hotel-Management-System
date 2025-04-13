namespace HotelManagementSystem.Reservations
{
    partial class frmReservations
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.cmResStatus = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cmFilter = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPeople = new System.Windows.Forms.Label();
            this.dgvAllReservations = new Guna.UI.WinForms.GunaDataGridView();
            this.g = new Guna.UI.WinForms.GunaContextMenuStrip();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.cmType = new Guna.UI2.WinForms.Guna2ComboBox();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.gunaButton1 = new Guna.UI.WinForms.GunaButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Ticket = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.check_in = new System.Windows.Forms.ToolStripMenuItem();
            this.Check_out = new System.Windows.Forms.ToolStripMenuItem();
            this.Extend = new System.Windows.Forms.ToolStripMenuItem();
            this.Cancel = new System.Windows.Forms.ToolStripMenuItem();
            this.GuestInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.roommateinfo = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllReservations)).BeginInit();
            this.g.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
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
            this.txtSearch.Location = new System.Drawing.Point(413, 216);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PlaceholderText = "Search";
            this.txtSearch.SelectedText = "";
            this.txtSearch.ShadowDecoration.Parent = this.txtSearch;
            this.txtSearch.Size = new System.Drawing.Size(372, 37);
            this.txtSearch.TabIndex = 48;
            this.txtSearch.Visible = false;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            this.txtSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearch_KeyPress);
            // 
            // cmResStatus
            // 
            this.cmResStatus.BackColor = System.Drawing.Color.Transparent;
            this.cmResStatus.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(70)))));
            this.cmResStatus.BorderRadius = 20;
            this.cmResStatus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmResStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmResStatus.FocusedColor = System.Drawing.Color.Empty;
            this.cmResStatus.FocusedState.Parent = this.cmResStatus;
            this.cmResStatus.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmResStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmResStatus.FormattingEnabled = true;
            this.cmResStatus.HoverState.Parent = this.cmResStatus;
            this.cmResStatus.ItemHeight = 30;
            this.cmResStatus.Items.AddRange(new object[] {
            "none",
            "New",
            "Cancelled",
            "Completed",
            "Pending"});
            this.cmResStatus.ItemsAppearance.Parent = this.cmResStatus;
            this.cmResStatus.Location = new System.Drawing.Point(413, 216);
            this.cmResStatus.Name = "cmResStatus";
            this.cmResStatus.ShadowDecoration.Parent = this.cmResStatus;
            this.cmResStatus.Size = new System.Drawing.Size(255, 36);
            this.cmResStatus.TabIndex = 47;
            this.cmResStatus.Visible = false;
            this.cmResStatus.SelectedIndexChanged += new System.EventHandler(this.cmResStatus_SelectedIndexChanged);
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
            "ReservationID",
            "Room",
            "Full Name",
            "Res Status",
            "Res Type"});
            this.cmFilter.ItemsAppearance.Parent = this.cmFilter;
            this.cmFilter.Location = new System.Drawing.Point(138, 220);
            this.cmFilter.Name = "cmFilter";
            this.cmFilter.ShadowDecoration.Parent = this.cmFilter;
            this.cmFilter.Size = new System.Drawing.Size(238, 36);
            this.cmFilter.TabIndex = 46;
            this.cmFilter.SelectedIndexChanged += new System.EventHandler(this.cmFilter_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Variable Display", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(70)))));
            this.label1.Location = new System.Drawing.Point(23, 220);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 28);
            this.label1.TabIndex = 45;
            this.label1.Text = "Filter By : ";
            // 
            // lblPeople
            // 
            this.lblPeople.AutoSize = true;
            this.lblPeople.BackColor = System.Drawing.Color.Transparent;
            this.lblPeople.Font = new System.Drawing.Font("Segoe UI Variable Display", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeople.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(70)))));
            this.lblPeople.Location = new System.Drawing.Point(388, 155);
            this.lblPeople.Name = "lblPeople";
            this.lblPeople.Size = new System.Drawing.Size(393, 49);
            this.lblPeople.TabIndex = 44;
            this.lblPeople.Text = "Manage Reservations";
            // 
            // dgvAllReservations
            // 
            this.dgvAllReservations.AllowDrop = true;
            this.dgvAllReservations.AllowUserToAddRows = false;
            this.dgvAllReservations.AllowUserToDeleteRows = false;
            this.dgvAllReservations.AllowUserToResizeColumns = false;
            this.dgvAllReservations.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvAllReservations.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAllReservations.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAllReservations.BackgroundColor = System.Drawing.Color.White;
            this.dgvAllReservations.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAllReservations.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dgvAllReservations.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(138)))), ((int)(((byte)(20)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAllReservations.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAllReservations.ColumnHeadersHeight = 30;
            this.dgvAllReservations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvAllReservations.ContextMenuStrip = this.g;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(138)))), ((int)(((byte)(20)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAllReservations.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvAllReservations.EnableHeadersVisualStyles = false;
            this.dgvAllReservations.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(138)))), ((int)(((byte)(20)))));
            this.dgvAllReservations.Location = new System.Drawing.Point(12, 262);
            this.dgvAllReservations.Name = "dgvAllReservations";
            this.dgvAllReservations.ReadOnly = true;
            this.dgvAllReservations.RowHeadersVisible = false;
            this.dgvAllReservations.RowTemplate.Height = 30;
            this.dgvAllReservations.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAllReservations.Size = new System.Drawing.Size(1176, 493);
            this.dgvAllReservations.TabIndex = 43;
            this.dgvAllReservations.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.dgvAllReservations.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvAllReservations.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvAllReservations.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvAllReservations.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvAllReservations.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvAllReservations.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvAllReservations.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(138)))), ((int)(((byte)(20)))));
            this.dgvAllReservations.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.dgvAllReservations.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dgvAllReservations.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvAllReservations.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvAllReservations.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvAllReservations.ThemeStyle.HeaderStyle.Height = 30;
            this.dgvAllReservations.ThemeStyle.ReadOnly = true;
            this.dgvAllReservations.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvAllReservations.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dgvAllReservations.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvAllReservations.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvAllReservations.ThemeStyle.RowsStyle.Height = 30;
            this.dgvAllReservations.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvAllReservations.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(138)))), ((int)(((byte)(20)))));
            // 
            // g
            // 
            this.g.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(70)))));
            this.g.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Ticket,
            this.toolStripMenuItem4,
            this.toolStripSeparator3,
            this.check_in,
            this.Check_out,
            this.toolStripSeparator1,
            this.Extend,
            this.Cancel,
            this.toolStripSeparator2,
            this.GuestInfo,
            this.roommateinfo});
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
            this.g.Size = new System.Drawing.Size(329, 390);
            this.g.Opening += new System.ComponentModel.CancelEventHandler(this.g_Opening);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(325, 6);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.toolStripSeparator1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(138)))), ((int)(((byte)(20)))));
            this.toolStripSeparator1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(138)))), ((int)(((byte)(20)))));
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(325, 6);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(325, 6);
            // 
            // cmType
            // 
            this.cmType.BackColor = System.Drawing.Color.Transparent;
            this.cmType.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(70)))));
            this.cmType.BorderRadius = 20;
            this.cmType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmType.FocusedColor = System.Drawing.Color.Empty;
            this.cmType.FocusedState.Parent = this.cmType;
            this.cmType.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmType.FormattingEnabled = true;
            this.cmType.HoverState.Parent = this.cmType;
            this.cmType.ItemHeight = 30;
            this.cmType.Items.AddRange(new object[] {
            "none",
            "Extend",
            "New"});
            this.cmType.ItemsAppearance.Parent = this.cmType;
            this.cmType.Location = new System.Drawing.Point(413, 216);
            this.cmType.Name = "cmType";
            this.cmType.ShadowDecoration.Parent = this.cmType;
            this.cmType.Size = new System.Drawing.Size(278, 36);
            this.cmType.TabIndex = 51;
            this.cmType.Visible = false;
            this.cmType.SelectedIndexChanged += new System.EventHandler(this.guna2ComboBox1_SelectedIndexChanged);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.Click += new System.EventHandler(this.notifyIcon1_Click);
            // 
            // gunaButton1
            // 
            this.gunaButton1.AnimationHoverSpeed = 0.07F;
            this.gunaButton1.AnimationSpeed = 0.03F;
            this.gunaButton1.BackColor = System.Drawing.Color.Transparent;
            this.gunaButton1.BaseColor = System.Drawing.Color.Transparent;
            this.gunaButton1.BorderColor = System.Drawing.Color.Black;
            this.gunaButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaButton1.ForeColor = System.Drawing.Color.White;
            this.gunaButton1.Image = global::HotelManagementSystem.Properties.Resources._10337440;
            this.gunaButton1.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaButton1.ImageSize = new System.Drawing.Size(60, 60);
            this.gunaButton1.Location = new System.Drawing.Point(1070, 172);
            this.gunaButton1.Name = "gunaButton1";
            this.gunaButton1.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.gunaButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton1.OnHoverImage = null;
            this.gunaButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton1.Radius = 30;
            this.gunaButton1.Size = new System.Drawing.Size(93, 76);
            this.gunaButton1.TabIndex = 50;
            this.gunaButton1.Click += new System.EventHandler(this.gunaButton1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HotelManagementSystem.Properties.Resources._15748843;
            this.pictureBox1.Location = new System.Drawing.Point(466, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(225, 164);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 49;
            this.pictureBox1.TabStop = false;
            // 
            // Ticket
            // 
            this.Ticket.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ticket.ForeColor = System.Drawing.Color.White;
            this.Ticket.Image = global::HotelManagementSystem.Properties.Resources.icons8_ticket_40;
            this.Ticket.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Ticket.Name = "Ticket";
            this.Ticket.Size = new System.Drawing.Size(328, 46);
            this.Ticket.Text = "        Ticket";
            this.Ticket.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem4.ForeColor = System.Drawing.Color.White;
            this.toolStripMenuItem4.Image = global::HotelManagementSystem.Properties.Resources.icons8_information_40;
            this.toolStripMenuItem4.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(328, 46);
            this.toolStripMenuItem4.Text = "        Details";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.toolStripMenuItem4_Click);
            // 
            // check_in
            // 
            this.check_in.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.check_in.ForeColor = System.Drawing.Color.White;
            this.check_in.Image = global::HotelManagementSystem.Properties.Resources.icons8_instagram_check_mark_40;
            this.check_in.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.check_in.Name = "check_in";
            this.check_in.Size = new System.Drawing.Size(328, 46);
            this.check_in.Text = "      Check In ";
            this.check_in.Click += new System.EventHandler(this.check_in_Click);
            // 
            // Check_out
            // 
            this.Check_out.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Check_out.ForeColor = System.Drawing.Color.White;
            this.Check_out.Image = global::HotelManagementSystem.Properties.Resources.icons8_check_out_40;
            this.Check_out.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Check_out.Name = "Check_out";
            this.Check_out.Size = new System.Drawing.Size(328, 46);
            this.Check_out.Text = "    Check Out";
            this.Check_out.Click += new System.EventHandler(this.Check_out_Click);
            // 
            // Extend
            // 
            this.Extend.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Extend.ForeColor = System.Drawing.Color.White;
            this.Extend.Image = global::HotelManagementSystem.Properties.Resources.icons8_extend_40;
            this.Extend.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Extend.Name = "Extend";
            this.Extend.Size = new System.Drawing.Size(328, 46);
            this.Extend.Text = "     Extend Another Res";
            this.Extend.Click += new System.EventHandler(this.Extend_Click);
            // 
            // Cancel
            // 
            this.Cancel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancel.ForeColor = System.Drawing.Color.White;
            this.Cancel.Image = global::HotelManagementSystem.Properties.Resources.icons8_cancel_40__1_;
            this.Cancel.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(328, 46);
            this.Cancel.Text = "     Cancel ";
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // GuestInfo
            // 
            this.GuestInfo.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GuestInfo.ForeColor = System.Drawing.Color.White;
            this.GuestInfo.Image = global::HotelManagementSystem.Properties.Resources.icons8_person_40;
            this.GuestInfo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.GuestInfo.Name = "GuestInfo";
            this.GuestInfo.Size = new System.Drawing.Size(328, 46);
            this.GuestInfo.Text = "    Guest Info";
            this.GuestInfo.Click += new System.EventHandler(this.GuestInfo_Click);
            // 
            // roommateinfo
            // 
            this.roommateinfo.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roommateinfo.ForeColor = System.Drawing.Color.White;
            this.roommateinfo.Image = global::HotelManagementSystem.Properties.Resources.icons8_whose_quest_40;
            this.roommateinfo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.roommateinfo.Name = "roommateinfo";
            this.roommateinfo.Size = new System.Drawing.Size(328, 46);
            this.roommateinfo.Text = "    Roommate Info";
            this.roommateinfo.Click += new System.EventHandler(this.roommateinfo_Click);
            // 
            // frmReservations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1189, 778);
            this.Controls.Add(this.cmType);
            this.Controls.Add(this.gunaButton1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.cmResStatus);
            this.Controls.Add(this.cmFilter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblPeople);
            this.Controls.Add(this.dgvAllReservations);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmReservations";
            this.Load += new System.EventHandler(this.frmReservations_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllReservations)).EndInit();
            this.g.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaButton gunaButton1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private Guna.UI2.WinForms.Guna2ComboBox cmResStatus;
        private Guna.UI2.WinForms.Guna2ComboBox cmFilter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPeople;
        private Guna.UI.WinForms.GunaDataGridView dgvAllReservations;
        private Guna.UI2.WinForms.Guna2ComboBox cmType;
        private Guna.UI.WinForms.GunaContextMenuStrip g;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem Cancel;
        private System.Windows.Forms.ToolStripMenuItem check_in;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem Check_out;
        private System.Windows.Forms.ToolStripMenuItem GuestInfo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem roommateinfo;
        private System.Windows.Forms.ToolStripMenuItem Extend;
        private System.Windows.Forms.ToolStripMenuItem Ticket;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}
namespace HotelManagementSystem.Rooms
{
    partial class frmManageRooms
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
            this.lblPeople = new System.Windows.Forms.Label();
            this.dgvAllRooms = new Guna.UI.WinForms.GunaDataGridView();
            this.g = new Guna.UI.WinForms.GunaContextMenuStrip();
            this.occupants = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.maintenance = new System.Windows.Forms.ToolStripMenuItem();
            this.SetAvailable = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.cmFilter = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmRoomStatus = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.cmCategory = new Guna.UI2.WinForms.Guna2ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllRooms)).BeginInit();
            this.g.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPeople
            // 
            this.lblPeople.AutoSize = true;
            this.lblPeople.BackColor = System.Drawing.Color.Transparent;
            this.lblPeople.Font = new System.Drawing.Font("Segoe UI Variable Display", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeople.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(70)))));
            this.lblPeople.Location = new System.Drawing.Point(420, 168);
            this.lblPeople.Name = "lblPeople";
            this.lblPeople.Size = new System.Drawing.Size(289, 49);
            this.lblPeople.TabIndex = 26;
            this.lblPeople.Text = "Manage Rooms";
            // 
            // dgvAllRooms
            // 
            this.dgvAllRooms.AllowDrop = true;
            this.dgvAllRooms.AllowUserToAddRows = false;
            this.dgvAllRooms.AllowUserToDeleteRows = false;
            this.dgvAllRooms.AllowUserToResizeColumns = false;
            this.dgvAllRooms.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvAllRooms.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAllRooms.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAllRooms.BackgroundColor = System.Drawing.Color.White;
            this.dgvAllRooms.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAllRooms.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dgvAllRooms.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(138)))), ((int)(((byte)(20)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAllRooms.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAllRooms.ColumnHeadersHeight = 30;
            this.dgvAllRooms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvAllRooms.ContextMenuStrip = this.g;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(138)))), ((int)(((byte)(20)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAllRooms.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvAllRooms.EnableHeadersVisualStyles = false;
            this.dgvAllRooms.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(138)))), ((int)(((byte)(20)))));
            this.dgvAllRooms.Location = new System.Drawing.Point(1, 275);
            this.dgvAllRooms.Name = "dgvAllRooms";
            this.dgvAllRooms.ReadOnly = true;
            this.dgvAllRooms.RowHeadersVisible = false;
            this.dgvAllRooms.RowTemplate.Height = 30;
            this.dgvAllRooms.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAllRooms.Size = new System.Drawing.Size(1160, 445);
            this.dgvAllRooms.TabIndex = 25;
            this.dgvAllRooms.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.dgvAllRooms.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvAllRooms.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvAllRooms.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvAllRooms.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvAllRooms.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvAllRooms.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvAllRooms.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(138)))), ((int)(((byte)(20)))));
            this.dgvAllRooms.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.dgvAllRooms.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dgvAllRooms.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvAllRooms.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvAllRooms.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvAllRooms.ThemeStyle.HeaderStyle.Height = 30;
            this.dgvAllRooms.ThemeStyle.ReadOnly = true;
            this.dgvAllRooms.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvAllRooms.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dgvAllRooms.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvAllRooms.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvAllRooms.ThemeStyle.RowsStyle.Height = 30;
            this.dgvAllRooms.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvAllRooms.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(138)))), ((int)(((byte)(20)))));
            // 
            // g
            // 
            this.g.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(70)))));
            this.g.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.occupants,
            this.toolStripSeparator1,
            this.maintenance,
            this.SetAvailable,
            this.toolStripSeparator2,
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
            this.g.Size = new System.Drawing.Size(333, 268);
            this.g.Opening += new System.ComponentModel.CancelEventHandler(this.g_Opening);
            // 
            // occupants
            // 
            this.occupants.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.occupants.ForeColor = System.Drawing.Color.White;
            this.occupants.Image = global::HotelManagementSystem.Properties.Resources.icons8_occupied_bed_40;
            this.occupants.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.occupants.Name = "occupants";
            this.occupants.Size = new System.Drawing.Size(332, 46);
            this.occupants.Text = "        Room occupants";
            this.occupants.Click += new System.EventHandler(this.occupants_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.toolStripSeparator1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(138)))), ((int)(((byte)(20)))));
            this.toolStripSeparator1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(138)))), ((int)(((byte)(20)))));
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(329, 6);
            // 
            // maintenance
            // 
            this.maintenance.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maintenance.ForeColor = System.Drawing.Color.White;
            this.maintenance.Image = global::HotelManagementSystem.Properties.Resources.icons8_online_maintenance_portal_40;
            this.maintenance.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.maintenance.Name = "maintenance";
            this.maintenance.Size = new System.Drawing.Size(332, 46);
            this.maintenance.Text = "    Set  for maintenance";
            this.maintenance.Click += new System.EventHandler(this.maintenance_Click);
            // 
            // SetAvailable
            // 
            this.SetAvailable.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SetAvailable.ForeColor = System.Drawing.Color.White;
            this.SetAvailable.Image = global::HotelManagementSystem.Properties.Resources.icons8_check_mark_40;
            this.SetAvailable.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.SetAvailable.Name = "SetAvailable";
            this.SetAvailable.Size = new System.Drawing.Size(332, 46);
            this.SetAvailable.Text = "    Set Available";
            this.SetAvailable.Click += new System.EventHandler(this.SetAvailable_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(329, 6);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.toolStripMenuItem3.Image = global::HotelManagementSystem.Properties.Resources.icons8_call_40__1_;
            this.toolStripMenuItem3.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(332, 46);
            this.toolStripMenuItem3.Text = "        Call ";
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.toolStripMenuItem6.Image = global::HotelManagementSystem.Properties.Resources.icons8_email_40;
            this.toolStripMenuItem6.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(332, 46);
            this.toolStripMenuItem6.Text = "      Send Email";
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
            "RoomID",
            "RoomNumber",
            "Room Status",
            "Category"});
            this.cmFilter.ItemsAppearance.Parent = this.cmFilter;
            this.cmFilter.Location = new System.Drawing.Point(127, 220);
            this.cmFilter.Name = "cmFilter";
            this.cmFilter.ShadowDecoration.Parent = this.cmFilter;
            this.cmFilter.Size = new System.Drawing.Size(238, 36);
            this.cmFilter.TabIndex = 28;
            this.cmFilter.SelectedIndexChanged += new System.EventHandler(this.cmFilter_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Variable Display", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(70)))));
            this.label1.Location = new System.Drawing.Point(12, 220);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 28);
            this.label1.TabIndex = 27;
            this.label1.Text = "Filter By : ";
            // 
            // cmRoomStatus
            // 
            this.cmRoomStatus.BackColor = System.Drawing.Color.Transparent;
            this.cmRoomStatus.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(70)))));
            this.cmRoomStatus.BorderRadius = 20;
            this.cmRoomStatus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmRoomStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmRoomStatus.FocusedColor = System.Drawing.Color.Empty;
            this.cmRoomStatus.FocusedState.Parent = this.cmRoomStatus;
            this.cmRoomStatus.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmRoomStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmRoomStatus.FormattingEnabled = true;
            this.cmRoomStatus.HoverState.Parent = this.cmRoomStatus;
            this.cmRoomStatus.ItemHeight = 30;
            this.cmRoomStatus.Items.AddRange(new object[] {
            "None",
            "Available",
            "Occupied",
            "Under Maintenance"});
            this.cmRoomStatus.ItemsAppearance.Parent = this.cmRoomStatus;
            this.cmRoomStatus.Location = new System.Drawing.Point(371, 220);
            this.cmRoomStatus.Name = "cmRoomStatus";
            this.cmRoomStatus.ShadowDecoration.Parent = this.cmRoomStatus;
            this.cmRoomStatus.Size = new System.Drawing.Size(374, 36);
            this.cmRoomStatus.TabIndex = 29;
            this.cmRoomStatus.Visible = false;
            this.cmRoomStatus.SelectedIndexChanged += new System.EventHandler(this.cmRoomStatus_SelectedIndexChanged);
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
            this.txtSearch.Location = new System.Drawing.Point(373, 220);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PlaceholderText = "Search";
            this.txtSearch.SelectedText = "";
            this.txtSearch.ShadowDecoration.Parent = this.txtSearch;
            this.txtSearch.Size = new System.Drawing.Size(372, 37);
            this.txtSearch.TabIndex = 30;
            this.txtSearch.Visible = false;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            this.txtSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearch_KeyPress);
            // 
            // cmCategory
            // 
            this.cmCategory.BackColor = System.Drawing.Color.Transparent;
            this.cmCategory.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(70)))));
            this.cmCategory.BorderRadius = 20;
            this.cmCategory.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmCategory.FocusedColor = System.Drawing.Color.Empty;
            this.cmCategory.FocusedState.Parent = this.cmCategory;
            this.cmCategory.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmCategory.FormattingEnabled = true;
            this.cmCategory.HoverState.Parent = this.cmCategory;
            this.cmCategory.ItemHeight = 30;
            this.cmCategory.Items.AddRange(new object[] {
            "None"});
            this.cmCategory.ItemsAppearance.Parent = this.cmCategory;
            this.cmCategory.Location = new System.Drawing.Point(373, 220);
            this.cmCategory.Name = "cmCategory";
            this.cmCategory.ShadowDecoration.Parent = this.cmCategory;
            this.cmCategory.Size = new System.Drawing.Size(372, 36);
            this.cmCategory.TabIndex = 31;
            this.cmCategory.Visible = false;
            this.cmCategory.SelectedIndexChanged += new System.EventHandler(this.cmCategory_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HotelManagementSystem.Properties.Resources._5102089;
            this.pictureBox1.Location = new System.Drawing.Point(396, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(349, 164);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 33;
            this.pictureBox1.TabStop = false;
            // 
            // frmManageRooms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1173, 739);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cmCategory);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.cmRoomStatus);
            this.Controls.Add(this.cmFilter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblPeople);
            this.Controls.Add(this.dgvAllRooms);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmManageRooms";
            this.Text = "frmManageRooms";
            this.Load += new System.EventHandler(this.frmManageRooms_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllRooms)).EndInit();
            this.g.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPeople;
        private Guna.UI.WinForms.GunaDataGridView dgvAllRooms;
        private Guna.UI2.WinForms.Guna2ComboBox cmFilter;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ComboBox cmRoomStatus;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private Guna.UI2.WinForms.Guna2ComboBox cmCategory;
        private Guna.UI.WinForms.GunaContextMenuStrip g;
        private System.Windows.Forms.ToolStripMenuItem occupants;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem maintenance;
        private System.Windows.Forms.ToolStripMenuItem SetAvailable;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
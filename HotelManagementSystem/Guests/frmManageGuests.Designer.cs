namespace HotelManagementSystem.Guests
{
    partial class frmManageGuests
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
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.cmCountries = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cmFilter = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPeople = new System.Windows.Forms.Label();
            this.dgvAllGuests = new Guna.UI.WinForms.GunaDataGridView();
            this.g = new Guna.UI.WinForms.GunaContextMenuStrip();
            this.ADD_New_Reservation = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.GuestInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAdd = new Guna.UI.WinForms.GunaButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSave = new Guna.UI.WinForms.GunaButton();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllGuests)).BeginInit();
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
            this.txtSearch.Location = new System.Drawing.Point(403, 229);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PlaceholderText = "Search";
            this.txtSearch.SelectedText = "";
            this.txtSearch.ShadowDecoration.Parent = this.txtSearch;
            this.txtSearch.Size = new System.Drawing.Size(372, 37);
            this.txtSearch.TabIndex = 39;
            this.txtSearch.Visible = false;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            this.txtSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearch_KeyPress);
            // 
            // cmCountries
            // 
            this.cmCountries.BackColor = System.Drawing.Color.Transparent;
            this.cmCountries.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(70)))));
            this.cmCountries.BorderRadius = 20;
            this.cmCountries.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmCountries.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmCountries.FocusedColor = System.Drawing.Color.Empty;
            this.cmCountries.FocusedState.Parent = this.cmCountries;
            this.cmCountries.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmCountries.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmCountries.FormattingEnabled = true;
            this.cmCountries.HoverState.Parent = this.cmCountries;
            this.cmCountries.ItemHeight = 30;
            this.cmCountries.Items.AddRange(new object[] {
            "none"});
            this.cmCountries.ItemsAppearance.Parent = this.cmCountries;
            this.cmCountries.Location = new System.Drawing.Point(401, 229);
            this.cmCountries.Name = "cmCountries";
            this.cmCountries.ShadowDecoration.Parent = this.cmCountries;
            this.cmCountries.Size = new System.Drawing.Size(374, 36);
            this.cmCountries.TabIndex = 38;
            this.cmCountries.Visible = false;
            this.cmCountries.SelectedIndexChanged += new System.EventHandler(this.cmCountries_SelectedIndexChanged);
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
            "GuestID",
            "Full Name",
            "Country"});
            this.cmFilter.ItemsAppearance.Parent = this.cmFilter;
            this.cmFilter.Location = new System.Drawing.Point(132, 229);
            this.cmFilter.Name = "cmFilter";
            this.cmFilter.ShadowDecoration.Parent = this.cmFilter;
            this.cmFilter.Size = new System.Drawing.Size(238, 36);
            this.cmFilter.TabIndex = 37;
            this.cmFilter.SelectedIndexChanged += new System.EventHandler(this.cmFilter_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Variable Display", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(70)))));
            this.label1.Location = new System.Drawing.Point(17, 229);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 28);
            this.label1.TabIndex = 36;
            this.label1.Text = "Filter By : ";
            // 
            // lblPeople
            // 
            this.lblPeople.AutoSize = true;
            this.lblPeople.BackColor = System.Drawing.Color.Transparent;
            this.lblPeople.Font = new System.Drawing.Font("Segoe UI Variable Display", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeople.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(70)))));
            this.lblPeople.Location = new System.Drawing.Point(425, 177);
            this.lblPeople.Name = "lblPeople";
            this.lblPeople.Size = new System.Drawing.Size(288, 49);
            this.lblPeople.TabIndex = 35;
            this.lblPeople.Text = "Manage Guests";
            // 
            // dgvAllGuests
            // 
            this.dgvAllGuests.AllowDrop = true;
            this.dgvAllGuests.AllowUserToAddRows = false;
            this.dgvAllGuests.AllowUserToDeleteRows = false;
            this.dgvAllGuests.AllowUserToResizeColumns = false;
            this.dgvAllGuests.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvAllGuests.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAllGuests.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAllGuests.BackgroundColor = System.Drawing.Color.White;
            this.dgvAllGuests.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAllGuests.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dgvAllGuests.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(138)))), ((int)(((byte)(20)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAllGuests.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAllGuests.ColumnHeadersHeight = 30;
            this.dgvAllGuests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(138)))), ((int)(((byte)(20)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAllGuests.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvAllGuests.EnableHeadersVisualStyles = false;
            this.dgvAllGuests.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(138)))), ((int)(((byte)(20)))));
            this.dgvAllGuests.Location = new System.Drawing.Point(6, 284);
            this.dgvAllGuests.Name = "dgvAllGuests";
            this.dgvAllGuests.ReadOnly = true;
            this.dgvAllGuests.RowHeadersVisible = false;
            this.dgvAllGuests.RowTemplate.Height = 30;
            this.dgvAllGuests.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAllGuests.Size = new System.Drawing.Size(1160, 445);
            this.dgvAllGuests.TabIndex = 34;
            this.dgvAllGuests.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.dgvAllGuests.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvAllGuests.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvAllGuests.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvAllGuests.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvAllGuests.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvAllGuests.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvAllGuests.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(138)))), ((int)(((byte)(20)))));
            this.dgvAllGuests.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.dgvAllGuests.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dgvAllGuests.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvAllGuests.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvAllGuests.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvAllGuests.ThemeStyle.HeaderStyle.Height = 30;
            this.dgvAllGuests.ThemeStyle.ReadOnly = true;
            this.dgvAllGuests.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvAllGuests.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dgvAllGuests.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvAllGuests.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvAllGuests.ThemeStyle.RowsStyle.Height = 30;
            this.dgvAllGuests.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvAllGuests.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(138)))), ((int)(((byte)(20)))));
            // 
            // g
            // 
            this.g.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(70)))));
            this.g.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ADD_New_Reservation,
            this.toolStripSeparator2,
            this.GuestInfo});
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
            this.g.Size = new System.Drawing.Size(348, 102);
            // 
            // ADD_New_Reservation
            // 
            this.ADD_New_Reservation.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ADD_New_Reservation.ForeColor = System.Drawing.Color.White;
            this.ADD_New_Reservation.Image = global::HotelManagementSystem.Properties.Resources.icons8_add_properties_40;
            this.ADD_New_Reservation.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ADD_New_Reservation.Name = "ADD_New_Reservation";
            this.ADD_New_Reservation.Size = new System.Drawing.Size(347, 46);
            this.ADD_New_Reservation.Text = "     Add New Reservation";
            this.ADD_New_Reservation.Click += new System.EventHandler(this.ADD_New_Reservation_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(344, 6);
            // 
            // GuestInfo
            // 
            this.GuestInfo.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GuestInfo.ForeColor = System.Drawing.Color.White;
            this.GuestInfo.Image = global::HotelManagementSystem.Properties.Resources.icons8_person_40;
            this.GuestInfo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.GuestInfo.Name = "GuestInfo";
            this.GuestInfo.Size = new System.Drawing.Size(347, 46);
            this.GuestInfo.Text = "    Guest Info";
            this.GuestInfo.Click += new System.EventHandler(this.GuestInfo_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.AnimationHoverSpeed = 0.07F;
            this.btnAdd.AnimationSpeed = 0.03F;
            this.btnAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnAdd.BaseColor = System.Drawing.Color.Transparent;
            this.btnAdd.BorderColor = System.Drawing.Color.Black;
            this.btnAdd.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAdd.FocusedColor = System.Drawing.Color.Empty;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Image = global::HotelManagementSystem.Properties.Resources._9453898;
            this.btnAdd.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAdd.ImageSize = new System.Drawing.Size(60, 60);
            this.btnAdd.Location = new System.Drawing.Point(1087, 193);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.btnAdd.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnAdd.OnHoverForeColor = System.Drawing.Color.White;
            this.btnAdd.OnHoverImage = null;
            this.btnAdd.OnPressedColor = System.Drawing.Color.Black;
            this.btnAdd.Radius = 30;
            this.btnAdd.Size = new System.Drawing.Size(63, 64);
            this.btnAdd.TabIndex = 42;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HotelManagementSystem.Properties.Resources.Screenshot_2025_03_11_231053;
            this.pictureBox1.Location = new System.Drawing.Point(401, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(349, 162);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 41;
            this.pictureBox1.TabStop = false;
            // 
            // btnSave
            // 
            this.btnSave.AnimationHoverSpeed = 0.07F;
            this.btnSave.AnimationSpeed = 0.03F;
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.BaseColor = System.Drawing.Color.Transparent;
            this.btnSave.BorderColor = System.Drawing.Color.Black;
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSave.FocusedColor = System.Drawing.Color.Empty;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Image = global::HotelManagementSystem.Properties.Resources._9131872;
            this.btnSave.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnSave.ImageSize = new System.Drawing.Size(60, 60);
            this.btnSave.Location = new System.Drawing.Point(1018, 193);
            this.btnSave.Name = "btnSave";
            this.btnSave.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.btnSave.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnSave.OnHoverForeColor = System.Drawing.Color.White;
            this.btnSave.OnHoverImage = null;
            this.btnSave.OnPressedColor = System.Drawing.Color.Black;
            this.btnSave.Radius = 30;
            this.btnSave.Size = new System.Drawing.Size(63, 64);
            this.btnSave.TabIndex = 44;
            this.btnSave.Visible = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Image = global::HotelManagementSystem.Properties.Resources.icons8_close_52__2_;
            this.btnCancel.Location = new System.Drawing.Point(1106, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(64, 52);
            this.btnCancel.TabIndex = 45;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Visible = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmManageGuests
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1173, 739);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.cmCountries);
            this.Controls.Add(this.cmFilter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblPeople);
            this.Controls.Add(this.dgvAllGuests);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmManageGuests";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmManageGuests";
            this.Load += new System.EventHandler(this.frmManageGuests_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllGuests)).EndInit();
            this.g.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private Guna.UI2.WinForms.Guna2ComboBox cmCountries;
        private Guna.UI2.WinForms.Guna2ComboBox cmFilter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPeople;
        private Guna.UI.WinForms.GunaDataGridView dgvAllGuests;
        private Guna.UI.WinForms.GunaButton btnAdd;
        private Guna.UI.WinForms.GunaContextMenuStrip g;
        private System.Windows.Forms.ToolStripMenuItem ADD_New_Reservation;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem GuestInfo;
        private Guna.UI.WinForms.GunaButton btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}
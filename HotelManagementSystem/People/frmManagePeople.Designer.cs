namespace HotelManagementSystem.People
{
    partial class frmManagePeople
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
            this.dgvAllPeople = new Guna.UI.WinForms.GunaDataGridView();
            this.g = new Guna.UI.WinForms.GunaContextMenuStrip();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.SetAsEmployee = new System.Windows.Forms.ToolStripMenuItem();
            this.setGuests = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.lblPeople = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.cmFilter = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cmCountries = new Guna.UI2.WinForms.Guna2ComboBox();
            this.gunaButton1 = new Guna.UI.WinForms.GunaButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllPeople)).BeginInit();
            this.g.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAllPeople
            // 
            this.dgvAllPeople.AllowDrop = true;
            this.dgvAllPeople.AllowUserToAddRows = false;
            this.dgvAllPeople.AllowUserToDeleteRows = false;
            this.dgvAllPeople.AllowUserToResizeColumns = false;
            this.dgvAllPeople.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvAllPeople.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAllPeople.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAllPeople.BackgroundColor = System.Drawing.Color.White;
            this.dgvAllPeople.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAllPeople.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dgvAllPeople.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(138)))), ((int)(((byte)(20)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAllPeople.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAllPeople.ColumnHeadersHeight = 30;
            this.dgvAllPeople.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvAllPeople.ContextMenuStrip = this.g;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(138)))), ((int)(((byte)(20)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAllPeople.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvAllPeople.EnableHeadersVisualStyles = false;
            this.dgvAllPeople.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(138)))), ((int)(((byte)(20)))));
            this.dgvAllPeople.Location = new System.Drawing.Point(27, 272);
            this.dgvAllPeople.Name = "dgvAllPeople";
            this.dgvAllPeople.ReadOnly = true;
            this.dgvAllPeople.RowHeadersVisible = false;
            this.dgvAllPeople.RowTemplate.Height = 30;
            this.dgvAllPeople.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAllPeople.Size = new System.Drawing.Size(1126, 420);
            this.dgvAllPeople.TabIndex = 1;
            this.dgvAllPeople.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.dgvAllPeople.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvAllPeople.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvAllPeople.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvAllPeople.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvAllPeople.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvAllPeople.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvAllPeople.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(138)))), ((int)(((byte)(20)))));
            this.dgvAllPeople.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.dgvAllPeople.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dgvAllPeople.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvAllPeople.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvAllPeople.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvAllPeople.ThemeStyle.HeaderStyle.Height = 30;
            this.dgvAllPeople.ThemeStyle.ReadOnly = true;
            this.dgvAllPeople.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvAllPeople.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dgvAllPeople.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvAllPeople.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvAllPeople.ThemeStyle.RowsStyle.Height = 30;
            this.dgvAllPeople.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvAllPeople.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(138)))), ((int)(((byte)(20)))));
            this.dgvAllPeople.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAllPeople_CellDoubleClick);
            // 
            // g
            // 
            this.g.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(70)))));
            this.g.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem4,
            this.toolStripMenuItem2,
            this.toolStripMenuItem1,
            this.toolStripSeparator1,
            this.SetAsEmployee,
            this.setGuests,
            this.toolStripSeparator2,
            this.toolStripMenuItem5,
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
            this.g.Size = new System.Drawing.Size(301, 430);
            this.g.Opening += new System.ComponentModel.CancelEventHandler(this.g_Opening);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem4.ForeColor = System.Drawing.Color.White;
            this.toolStripMenuItem4.Image = global::HotelManagementSystem.Properties.Resources.icons8_more_info_50;
            this.toolStripMenuItem4.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(300, 56);
            this.toolStripMenuItem4.Text = "        Details";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.toolStripMenuItem4_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem2.ForeColor = System.Drawing.Color.White;
            this.toolStripMenuItem2.Image = global::HotelManagementSystem.Properties.Resources.icons8_edit_account_50;
            this.toolStripMenuItem2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(300, 56);
            this.toolStripMenuItem2.Text = "     Edit Person";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem1.ForeColor = System.Drawing.Color.White;
            this.toolStripMenuItem1.Image = global::HotelManagementSystem.Properties.Resources.icons8_delete_40;
            this.toolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(300, 56);
            this.toolStripMenuItem1.Text = "      Delete";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.toolStripSeparator1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(138)))), ((int)(((byte)(20)))));
            this.toolStripSeparator1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(138)))), ((int)(((byte)(20)))));
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(297, 6);
            // 
            // SetAsEmployee
            // 
            this.SetAsEmployee.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SetAsEmployee.ForeColor = System.Drawing.Color.White;
            this.SetAsEmployee.Image = global::HotelManagementSystem.Properties.Resources.icons8_edit_profile_40;
            this.SetAsEmployee.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.SetAsEmployee.Name = "SetAsEmployee";
            this.SetAsEmployee.Size = new System.Drawing.Size(300, 56);
            this.SetAsEmployee.Text = "    Set As Employee";
            this.SetAsEmployee.Click += new System.EventHandler(this.SetAsEmployee_Click);
            // 
            // setGuests
            // 
            this.setGuests.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setGuests.ForeColor = System.Drawing.Color.White;
            this.setGuests.Image = global::HotelManagementSystem.Properties.Resources.icons8_edit_profile_40;
            this.setGuests.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.setGuests.Name = "setGuests";
            this.setGuests.Size = new System.Drawing.Size(300, 56);
            this.setGuests.Text = "    Set Guets";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(297, 6);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.toolStripMenuItem5.Image = global::HotelManagementSystem.Properties.Resources.icons8_call_40__1_;
            this.toolStripMenuItem5.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(300, 56);
            this.toolStripMenuItem5.Text = "        Call ";
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.toolStripMenuItem6.Image = global::HotelManagementSystem.Properties.Resources.icons8_email_40;
            this.toolStripMenuItem6.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(300, 56);
            this.toolStripMenuItem6.Text = "      Send Email";
            // 
            // lblPeople
            // 
            this.lblPeople.AutoSize = true;
            this.lblPeople.BackColor = System.Drawing.Color.Transparent;
            this.lblPeople.Font = new System.Drawing.Font("Segoe UI Variable Display", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeople.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(70)))));
            this.lblPeople.Location = new System.Drawing.Point(446, 170);
            this.lblPeople.Name = "lblPeople";
            this.lblPeople.Size = new System.Drawing.Size(287, 49);
            this.lblPeople.TabIndex = 2;
            this.lblPeople.Text = "Manage People";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Variable Display", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(70)))));
            this.label1.Location = new System.Drawing.Point(22, 225);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 28);
            this.label1.TabIndex = 3;
            this.label1.Text = "Filter By : ";
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
            this.txtSearch.Location = new System.Drawing.Point(361, 225);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PlaceholderText = "Search";
            this.txtSearch.SelectedText = "";
            this.txtSearch.ShadowDecoration.Parent = this.txtSearch;
            this.txtSearch.Size = new System.Drawing.Size(272, 37);
            this.txtSearch.TabIndex = 4;
            this.txtSearch.Visible = false;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            this.txtSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearch_KeyPress);
            this.txtSearch.Validating += new System.ComponentModel.CancelEventHandler(this.txtSearch_Validating);
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
            "PersonID",
            "Full Name",
            "Nationnal Number",
            "Passport Number",
            "Country"});
            this.cmFilter.ItemsAppearance.Parent = this.cmFilter;
            this.cmFilter.Location = new System.Drawing.Point(115, 225);
            this.cmFilter.Name = "cmFilter";
            this.cmFilter.ShadowDecoration.Parent = this.cmFilter;
            this.cmFilter.Size = new System.Drawing.Size(238, 36);
            this.cmFilter.TabIndex = 6;
            this.cmFilter.SelectedIndexChanged += new System.EventHandler(this.cmFilter_SelectedIndexChanged);
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
            this.cmCountries.ItemsAppearance.Parent = this.cmCountries;
            this.cmCountries.Location = new System.Drawing.Point(361, 225);
            this.cmCountries.Name = "cmCountries";
            this.cmCountries.ShadowDecoration.Parent = this.cmCountries;
            this.cmCountries.Size = new System.Drawing.Size(272, 36);
            this.cmCountries.TabIndex = 7;
            this.cmCountries.Visible = false;
            this.cmCountries.SelectedIndexChanged += new System.EventHandler(this.cmCountries_SelectedIndexChanged);
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
            this.gunaButton1.Image = global::HotelManagementSystem.Properties.Resources._9453898;
            this.gunaButton1.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaButton1.ImageSize = new System.Drawing.Size(60, 60);
            this.gunaButton1.Location = new System.Drawing.Point(1114, 202);
            this.gunaButton1.Name = "gunaButton1";
            this.gunaButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.gunaButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton1.OnHoverImage = null;
            this.gunaButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton1.Radius = 30;
            this.gunaButton1.Size = new System.Drawing.Size(63, 64);
            this.gunaButton1.TabIndex = 8;
            this.gunaButton1.Click += new System.EventHandler(this.gunaButton1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HotelManagementSystem.Properties.Resources.Screenshot_2025_02_19_150754;
            this.pictureBox1.Location = new System.Drawing.Point(339, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(532, 164);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // frmManagePeople
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1189, 778);
            this.Controls.Add(this.gunaButton1);
            this.Controls.Add(this.cmCountries);
            this.Controls.Add(this.cmFilter);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblPeople);
            this.Controls.Add(this.dgvAllPeople);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmManagePeople";
            this.Text = "frmManagePeople";
            this.Load += new System.EventHandler(this.frmManagePeople_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllPeople)).EndInit();
            this.g.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI.WinForms.GunaDataGridView dgvAllPeople;
        private System.Windows.Forms.Label lblPeople;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private Guna.UI2.WinForms.Guna2ComboBox cmFilter;
        private Guna.UI2.WinForms.Guna2ComboBox cmCountries;
        private Guna.UI.WinForms.GunaButton gunaButton1;
        private Guna.UI.WinForms.GunaContextMenuStrip g;
        private System.Windows.Forms.ToolStripMenuItem setGuests;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem SetAsEmployee;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
    }
}
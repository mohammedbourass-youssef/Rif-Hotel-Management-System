namespace HotelManagementSystem.Employee
{
    partial class frmManageEmployee
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
            this.cmCountries = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cmFilter = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPeople = new System.Windows.Forms.Label();
            this.dgvAllEmployees = new Guna.UI.WinForms.GunaDataGridView();
            this.g = new Guna.UI.WinForms.GunaContextMenuStrip();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.EditEmployee = new System.Windows.Forms.ToolStripMenuItem();
            this.FiredItems = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.PayTheSalary = new System.Windows.Forms.ToolStripMenuItem();
            this.SetUSer = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.cmFired = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cmRoles = new Guna.UI2.WinForms.Guna2ComboBox();
            this.HireDate = new Guna.UI.WinForms.GunaDateTimePicker();
            this.cmSalaryComparaisom = new Guna.UI2.WinForms.Guna2ComboBox();
            this.gunaButton1 = new Guna.UI.WinForms.GunaButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllEmployees)).BeginInit();
            this.g.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
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
            this.cmCountries.Location = new System.Drawing.Point(350, 264);
            this.cmCountries.Name = "cmCountries";
            this.cmCountries.ShadowDecoration.Parent = this.cmCountries;
            this.cmCountries.Size = new System.Drawing.Size(272, 36);
            this.cmCountries.TabIndex = 15;
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
            "EmployeeID",
            "Full Name",
            "Role",
            "Country",
            "Hire Date",
            "Salary",
            "Fired"});
            this.cmFilter.ItemsAppearance.Parent = this.cmFilter;
            this.cmFilter.Location = new System.Drawing.Point(106, 264);
            this.cmFilter.Name = "cmFilter";
            this.cmFilter.ShadowDecoration.Parent = this.cmFilter;
            this.cmFilter.Size = new System.Drawing.Size(238, 36);
            this.cmFilter.TabIndex = 14;
            this.cmFilter.SelectedIndexChanged += new System.EventHandler(this.cmFilter_SelectedIndexChanged);
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
            this.txtSearch.Location = new System.Drawing.Point(350, 264);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PlaceholderText = "Search";
            this.txtSearch.SelectedText = "";
            this.txtSearch.ShadowDecoration.Parent = this.txtSearch;
            this.txtSearch.Size = new System.Drawing.Size(272, 37);
            this.txtSearch.TabIndex = 13;
            this.txtSearch.Visible = false;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            this.txtSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearch_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Variable Display", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(70)))));
            this.label1.Location = new System.Drawing.Point(13, 264);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 28);
            this.label1.TabIndex = 12;
            this.label1.Text = "Filter By : ";
            // 
            // lblPeople
            // 
            this.lblPeople.AutoSize = true;
            this.lblPeople.BackColor = System.Drawing.Color.Transparent;
            this.lblPeople.Font = new System.Drawing.Font("Segoe UI Variable Display", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeople.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(70)))));
            this.lblPeople.Location = new System.Drawing.Point(420, 195);
            this.lblPeople.Name = "lblPeople";
            this.lblPeople.Size = new System.Drawing.Size(357, 49);
            this.lblPeople.TabIndex = 11;
            this.lblPeople.Text = "Manage Employees";
            // 
            // dgvAllEmployees
            // 
            this.dgvAllEmployees.AllowDrop = true;
            this.dgvAllEmployees.AllowUserToAddRows = false;
            this.dgvAllEmployees.AllowUserToDeleteRows = false;
            this.dgvAllEmployees.AllowUserToResizeColumns = false;
            this.dgvAllEmployees.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvAllEmployees.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAllEmployees.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAllEmployees.BackgroundColor = System.Drawing.Color.White;
            this.dgvAllEmployees.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAllEmployees.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dgvAllEmployees.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(138)))), ((int)(((byte)(20)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAllEmployees.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAllEmployees.ColumnHeadersHeight = 30;
            this.dgvAllEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvAllEmployees.ContextMenuStrip = this.g;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(138)))), ((int)(((byte)(20)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAllEmployees.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvAllEmployees.EnableHeadersVisualStyles = false;
            this.dgvAllEmployees.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(138)))), ((int)(((byte)(20)))));
            this.dgvAllEmployees.Location = new System.Drawing.Point(12, 325);
            this.dgvAllEmployees.Name = "dgvAllEmployees";
            this.dgvAllEmployees.ReadOnly = true;
            this.dgvAllEmployees.RowHeadersVisible = false;
            this.dgvAllEmployees.RowTemplate.Height = 30;
            this.dgvAllEmployees.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAllEmployees.Size = new System.Drawing.Size(1160, 441);
            this.dgvAllEmployees.TabIndex = 10;
            this.dgvAllEmployees.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.dgvAllEmployees.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvAllEmployees.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvAllEmployees.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvAllEmployees.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvAllEmployees.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvAllEmployees.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvAllEmployees.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(138)))), ((int)(((byte)(20)))));
            this.dgvAllEmployees.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.dgvAllEmployees.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dgvAllEmployees.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvAllEmployees.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvAllEmployees.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvAllEmployees.ThemeStyle.HeaderStyle.Height = 30;
            this.dgvAllEmployees.ThemeStyle.ReadOnly = true;
            this.dgvAllEmployees.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvAllEmployees.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dgvAllEmployees.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvAllEmployees.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvAllEmployees.ThemeStyle.RowsStyle.Height = 30;
            this.dgvAllEmployees.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvAllEmployees.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(138)))), ((int)(((byte)(20)))));
            this.dgvAllEmployees.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAllEmployees_CellDoubleClick);
            // 
            // g
            // 
            this.g.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(70)))));
            this.g.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem4,
            this.EditEmployee,
            this.FiredItems,
            this.toolStripSeparator1,
            this.PayTheSalary,
            this.SetUSer,
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
            this.g.Size = new System.Drawing.Size(446, 464);
            this.g.Opening += new System.ComponentModel.CancelEventHandler(this.g_Opening);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem4.ForeColor = System.Drawing.Color.White;
            this.toolStripMenuItem4.Image = global::HotelManagementSystem.Properties.Resources.icons8_more_info_50;
            this.toolStripMenuItem4.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(445, 56);
            this.toolStripMenuItem4.Text = "        Details";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.toolStripMenuItem4_Click);
            // 
            // EditEmployee
            // 
            this.EditEmployee.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditEmployee.ForeColor = System.Drawing.Color.White;
            this.EditEmployee.Image = global::HotelManagementSystem.Properties.Resources.icons8_edit_account_50;
            this.EditEmployee.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.EditEmployee.Name = "EditEmployee";
            this.EditEmployee.Size = new System.Drawing.Size(445, 56);
            this.EditEmployee.Text = "        Edit Employee";
            this.EditEmployee.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // FiredItems
            // 
            this.FiredItems.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FiredItems.ForeColor = System.Drawing.Color.White;
            this.FiredItems.Image = global::HotelManagementSystem.Properties.Resources.icons8_end_40__1_;
            this.FiredItems.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.FiredItems.Name = "FiredItems";
            this.FiredItems.Size = new System.Drawing.Size(445, 56);
            this.FiredItems.Text = "       Termination Of Employement";
            this.FiredItems.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.toolStripSeparator1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(138)))), ((int)(((byte)(20)))));
            this.toolStripSeparator1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(138)))), ((int)(((byte)(20)))));
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(442, 6);
            // 
            // PayTheSalary
            // 
            this.PayTheSalary.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PayTheSalary.ForeColor = System.Drawing.Color.White;
            this.PayTheSalary.Image = global::HotelManagementSystem.Properties.Resources.icons8_pay_40;
            this.PayTheSalary.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.PayTheSalary.Name = "PayTheSalary";
            this.PayTheSalary.Size = new System.Drawing.Size(445, 56);
            this.PayTheSalary.Text = "    Pay The Salary Month";
            this.PayTheSalary.Click += new System.EventHandler(this.PayTheSalary_Click);
            // 
            // SetUSer
            // 
            this.SetUSer.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SetUSer.ForeColor = System.Drawing.Color.White;
            this.SetUSer.Image = global::HotelManagementSystem.Properties.Resources.icons8_edit_profile_40;
            this.SetUSer.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.SetUSer.Name = "SetUSer";
            this.SetUSer.Size = new System.Drawing.Size(445, 56);
            this.SetUSer.Text = "    Set User";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(442, 6);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.toolStripMenuItem1.Image = global::HotelManagementSystem.Properties.Resources.icons8_call_40__1_;
            this.toolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(445, 56);
            this.toolStripMenuItem1.Text = "        Send Local Message";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.toolStripMenuItem3.Image = global::HotelManagementSystem.Properties.Resources.icons8_call_40__1_;
            this.toolStripMenuItem3.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(445, 56);
            this.toolStripMenuItem3.Text = "        Call ";
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.toolStripMenuItem6.Image = global::HotelManagementSystem.Properties.Resources.icons8_email_40;
            this.toolStripMenuItem6.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(445, 56);
            this.toolStripMenuItem6.Text = "      Send Email";
            // 
            // cmFired
            // 
            this.cmFired.BackColor = System.Drawing.Color.Transparent;
            this.cmFired.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(70)))));
            this.cmFired.BorderRadius = 20;
            this.cmFired.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmFired.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmFired.FocusedColor = System.Drawing.Color.Empty;
            this.cmFired.FocusedState.Parent = this.cmFired;
            this.cmFired.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmFired.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmFired.FormattingEnabled = true;
            this.cmFired.HoverState.Parent = this.cmFired;
            this.cmFired.ItemHeight = 30;
            this.cmFired.Items.AddRange(new object[] {
            "NONE",
            "NO ",
            "YES"});
            this.cmFired.ItemsAppearance.Parent = this.cmFired;
            this.cmFired.Location = new System.Drawing.Point(352, 263);
            this.cmFired.Name = "cmFired";
            this.cmFired.ShadowDecoration.Parent = this.cmFired;
            this.cmFired.Size = new System.Drawing.Size(272, 36);
            this.cmFired.TabIndex = 17;
            this.cmFired.Visible = false;
            this.cmFired.SelectedIndexChanged += new System.EventHandler(this.cmFired_SelectedIndexChanged);
            // 
            // cmRoles
            // 
            this.cmRoles.BackColor = System.Drawing.Color.Transparent;
            this.cmRoles.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(70)))));
            this.cmRoles.BorderRadius = 20;
            this.cmRoles.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmRoles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmRoles.FocusedColor = System.Drawing.Color.Empty;
            this.cmRoles.FocusedState.Parent = this.cmRoles;
            this.cmRoles.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmRoles.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmRoles.FormattingEnabled = true;
            this.cmRoles.HoverState.Parent = this.cmRoles;
            this.cmRoles.ItemHeight = 30;
            this.cmRoles.ItemsAppearance.Parent = this.cmRoles;
            this.cmRoles.Location = new System.Drawing.Point(350, 264);
            this.cmRoles.Name = "cmRoles";
            this.cmRoles.ShadowDecoration.Parent = this.cmRoles;
            this.cmRoles.Size = new System.Drawing.Size(272, 36);
            this.cmRoles.TabIndex = 18;
            this.cmRoles.Visible = false;
            this.cmRoles.SelectedIndexChanged += new System.EventHandler(this.cmRoles_SelectedIndexChanged);
            // 
            // HireDate
            // 
            this.HireDate.BackColor = System.Drawing.Color.Transparent;
            this.HireDate.BaseColor = System.Drawing.Color.White;
            this.HireDate.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(70)))));
            this.HireDate.BorderSize = 1;
            this.HireDate.CustomFormat = null;
            this.HireDate.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.HireDate.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.HireDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.HireDate.ForeColor = System.Drawing.Color.Black;
            this.HireDate.Location = new System.Drawing.Point(352, 263);
            this.HireDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.HireDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.HireDate.Name = "HireDate";
            this.HireDate.OnHoverBaseColor = System.Drawing.Color.White;
            this.HireDate.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.HireDate.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.HireDate.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(70)))));
            this.HireDate.Radius = 18;
            this.HireDate.Size = new System.Drawing.Size(272, 38);
            this.HireDate.TabIndex = 19;
            this.HireDate.Text = "Wednesday, 19 February 2025";
            this.HireDate.Value = new System.DateTime(2025, 2, 19, 17, 18, 3, 386);
            this.HireDate.Visible = false;
            this.HireDate.ValueChanged += new System.EventHandler(this.HireDate_ValueChanged);
            // 
            // cmSalaryComparaisom
            // 
            this.cmSalaryComparaisom.BackColor = System.Drawing.Color.Transparent;
            this.cmSalaryComparaisom.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(70)))));
            this.cmSalaryComparaisom.BorderRadius = 20;
            this.cmSalaryComparaisom.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmSalaryComparaisom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmSalaryComparaisom.FocusedColor = System.Drawing.Color.Empty;
            this.cmSalaryComparaisom.FocusedState.Parent = this.cmSalaryComparaisom;
            this.cmSalaryComparaisom.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmSalaryComparaisom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmSalaryComparaisom.FormattingEnabled = true;
            this.cmSalaryComparaisom.HoverState.Parent = this.cmSalaryComparaisom;
            this.cmSalaryComparaisom.ItemHeight = 30;
            this.cmSalaryComparaisom.Items.AddRange(new object[] {
            "Less Than ",
            "More Than ",
            "Equial"});
            this.cmSalaryComparaisom.ItemsAppearance.Parent = this.cmSalaryComparaisom;
            this.cmSalaryComparaisom.Location = new System.Drawing.Point(630, 265);
            this.cmSalaryComparaisom.Name = "cmSalaryComparaisom";
            this.cmSalaryComparaisom.ShadowDecoration.Parent = this.cmSalaryComparaisom;
            this.cmSalaryComparaisom.Size = new System.Drawing.Size(161, 36);
            this.cmSalaryComparaisom.TabIndex = 20;
            this.cmSalaryComparaisom.Visible = false;
            this.cmSalaryComparaisom.SelectedIndexChanged += new System.EventHandler(this.cmSalaryComparaisom_SelectedIndexChanged);
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
            this.gunaButton1.Location = new System.Drawing.Point(1109, 244);
            this.gunaButton1.Name = "gunaButton1";
            this.gunaButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.gunaButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton1.OnHoverImage = null;
            this.gunaButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton1.Radius = 30;
            this.gunaButton1.Size = new System.Drawing.Size(63, 64);
            this.gunaButton1.TabIndex = 16;
            this.gunaButton1.Click += new System.EventHandler(this.gunaButton1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HotelManagementSystem.Properties.Resources.Screenshot_2025_02_19_152003;
            this.pictureBox1.Location = new System.Drawing.Point(409, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(382, 185);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // frmManageEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1189, 778);
            this.Controls.Add(this.cmSalaryComparaisom);
            this.Controls.Add(this.HireDate);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.cmRoles);
            this.Controls.Add(this.cmFired);
            this.Controls.Add(this.gunaButton1);
            this.Controls.Add(this.cmCountries);
            this.Controls.Add(this.cmFilter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblPeople);
            this.Controls.Add(this.dgvAllEmployees);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmManageEmployee";
            this.Text = "frmManageEmployee";
            this.Load += new System.EventHandler(this.frmManageEmployee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllEmployees)).EndInit();
            this.g.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaButton gunaButton1;
        private Guna.UI2.WinForms.Guna2ComboBox cmCountries;
        private Guna.UI2.WinForms.Guna2ComboBox cmFilter;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPeople;
        private Guna.UI.WinForms.GunaDataGridView dgvAllEmployees;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2ComboBox cmFired;
        private Guna.UI2.WinForms.Guna2ComboBox cmRoles;
        private Guna.UI.WinForms.GunaDateTimePicker HireDate;
        private Guna.UI2.WinForms.Guna2ComboBox cmSalaryComparaisom;
        private Guna.UI.WinForms.GunaContextMenuStrip g;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem EditEmployee;
        private System.Windows.Forms.ToolStripMenuItem FiredItems;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem PayTheSalary;
        private System.Windows.Forms.ToolStripMenuItem SetUSer;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
    }
}
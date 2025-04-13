namespace HotelManagementSystem.Payement
{
    partial class frmAllPayements
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.dgvAllPayements = new Guna.UI.WinForms.GunaDataGridView();
            this.btnPrevious = new Guna.UI.WinForms.GunaButton();
            this.btnNext = new Guna.UI.WinForms.GunaButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllPayements)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Variable Display", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(70)))));
            this.lblTitle.Location = new System.Drawing.Point(40, 224);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(338, 49);
            this.lblTitle.TabIndex = 35;
            this.lblTitle.Text = "Last 10 Payements";
            // 
            // dgvAllPayements
            // 
            this.dgvAllPayements.AllowDrop = true;
            this.dgvAllPayements.AllowUserToAddRows = false;
            this.dgvAllPayements.AllowUserToDeleteRows = false;
            this.dgvAllPayements.AllowUserToResizeColumns = false;
            this.dgvAllPayements.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvAllPayements.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAllPayements.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAllPayements.BackgroundColor = System.Drawing.Color.White;
            this.dgvAllPayements.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAllPayements.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dgvAllPayements.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(138)))), ((int)(((byte)(20)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAllPayements.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAllPayements.ColumnHeadersHeight = 30;
            this.dgvAllPayements.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(138)))), ((int)(((byte)(20)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAllPayements.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvAllPayements.EnableHeadersVisualStyles = false;
            this.dgvAllPayements.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(138)))), ((int)(((byte)(20)))));
            this.dgvAllPayements.Location = new System.Drawing.Point(4, 286);
            this.dgvAllPayements.Name = "dgvAllPayements";
            this.dgvAllPayements.ReadOnly = true;
            this.dgvAllPayements.RowHeadersVisible = false;
            this.dgvAllPayements.RowTemplate.Height = 30;
            this.dgvAllPayements.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAllPayements.Size = new System.Drawing.Size(1160, 433);
            this.dgvAllPayements.TabIndex = 34;
            this.dgvAllPayements.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.dgvAllPayements.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvAllPayements.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvAllPayements.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvAllPayements.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvAllPayements.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvAllPayements.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvAllPayements.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(138)))), ((int)(((byte)(20)))));
            this.dgvAllPayements.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.dgvAllPayements.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dgvAllPayements.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvAllPayements.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvAllPayements.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvAllPayements.ThemeStyle.HeaderStyle.Height = 30;
            this.dgvAllPayements.ThemeStyle.ReadOnly = true;
            this.dgvAllPayements.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvAllPayements.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dgvAllPayements.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvAllPayements.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvAllPayements.ThemeStyle.RowsStyle.Height = 30;
            this.dgvAllPayements.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvAllPayements.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(138)))), ((int)(((byte)(20)))));
            // 
            // btnPrevious
            // 
            this.btnPrevious.AnimationHoverSpeed = 0.07F;
            this.btnPrevious.AnimationSpeed = 0.03F;
            this.btnPrevious.BackColor = System.Drawing.Color.Transparent;
            this.btnPrevious.BaseColor = System.Drawing.Color.Transparent;
            this.btnPrevious.BorderColor = System.Drawing.Color.Black;
            this.btnPrevious.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnPrevious.FocusedColor = System.Drawing.Color.Empty;
            this.btnPrevious.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnPrevious.ForeColor = System.Drawing.Color.White;
            this.btnPrevious.Image = global::HotelManagementSystem.Properties.Resources.icons8_previous_40;
            this.btnPrevious.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnPrevious.ImageSize = new System.Drawing.Size(40, 40);
            this.btnPrevious.Location = new System.Drawing.Point(1040, 224);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.OnHoverBaseColor = System.Drawing.Color.Empty;
            this.btnPrevious.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnPrevious.OnHoverForeColor = System.Drawing.Color.White;
            this.btnPrevious.OnHoverImage = null;
            this.btnPrevious.OnPressedColor = System.Drawing.Color.Black;
            this.btnPrevious.Radius = 30;
            this.btnPrevious.Size = new System.Drawing.Size(68, 49);
            this.btnPrevious.TabIndex = 43;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnNext
            // 
            this.btnNext.AnimationHoverSpeed = 0.07F;
            this.btnNext.AnimationSpeed = 0.03F;
            this.btnNext.BackColor = System.Drawing.Color.Transparent;
            this.btnNext.BaseColor = System.Drawing.Color.Transparent;
            this.btnNext.BorderColor = System.Drawing.Color.Black;
            this.btnNext.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnNext.FocusedColor = System.Drawing.Color.Empty;
            this.btnNext.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnNext.ForeColor = System.Drawing.Color.White;
            this.btnNext.Image = global::HotelManagementSystem.Properties.Resources.icons8_next_40;
            this.btnNext.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnNext.ImageSize = new System.Drawing.Size(40, 40);
            this.btnNext.Location = new System.Drawing.Point(1101, 224);
            this.btnNext.Name = "btnNext";
            this.btnNext.OnHoverBaseColor = System.Drawing.Color.Empty;
            this.btnNext.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnNext.OnHoverForeColor = System.Drawing.Color.White;
            this.btnNext.OnHoverImage = null;
            this.btnNext.OnPressedColor = System.Drawing.Color.Black;
            this.btnNext.Radius = 30;
            this.btnNext.Size = new System.Drawing.Size(63, 49);
            this.btnNext.TabIndex = 42;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HotelManagementSystem.Properties.Resources.Top_10_Payment_Gateways_Devathon;
            this.pictureBox1.Location = new System.Drawing.Point(354, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(429, 216);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 41;
            this.pictureBox1.TabStop = false;
            // 
            // frmAllPayements
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1170, 739);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.dgvAllPayements);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmAllPayements";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmAllPayements_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllPayements)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblTitle;
        private Guna.UI.WinForms.GunaDataGridView dgvAllPayements;
        private Guna.UI.WinForms.GunaButton btnNext;
        private Guna.UI.WinForms.GunaButton btnPrevious;
    }
}
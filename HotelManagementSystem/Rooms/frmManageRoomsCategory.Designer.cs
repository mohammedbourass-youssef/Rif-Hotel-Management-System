namespace HotelManagementSystem.Rooms
{
    partial class frmManageRoomsCategory
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblPeople = new System.Windows.Forms.Label();
            this.dgvAllRooms = new Guna.UI.WinForms.GunaDataGridView();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllRooms)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPeople
            // 
            this.lblPeople.AutoSize = true;
            this.lblPeople.BackColor = System.Drawing.Color.Transparent;
            this.lblPeople.Font = new System.Drawing.Font("Segoe UI Variable Display", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeople.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(70)))));
            this.lblPeople.Location = new System.Drawing.Point(437, 238);
            this.lblPeople.Name = "lblPeople";
            this.lblPeople.Size = new System.Drawing.Size(338, 49);
            this.lblPeople.TabIndex = 23;
            this.lblPeople.Text = "Rooms Categories";
            // 
            // dgvAllRooms
            // 
            this.dgvAllRooms.AllowDrop = true;
            this.dgvAllRooms.AllowUserToAddRows = false;
            this.dgvAllRooms.AllowUserToDeleteRows = false;
            this.dgvAllRooms.AllowUserToResizeColumns = false;
            this.dgvAllRooms.AllowUserToResizeRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            this.dgvAllRooms.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvAllRooms.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAllRooms.BackgroundColor = System.Drawing.Color.White;
            this.dgvAllRooms.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAllRooms.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dgvAllRooms.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(138)))), ((int)(((byte)(20)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAllRooms.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvAllRooms.ColumnHeadersHeight = 30;
            this.dgvAllRooms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(138)))), ((int)(((byte)(20)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAllRooms.DefaultCellStyle = dataGridViewCellStyle9;
            this.dgvAllRooms.EnableHeadersVisualStyles = false;
            this.dgvAllRooms.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(138)))), ((int)(((byte)(20)))));
            this.dgvAllRooms.Location = new System.Drawing.Point(12, 299);
            this.dgvAllRooms.Name = "dgvAllRooms";
            this.dgvAllRooms.ReadOnly = true;
            this.dgvAllRooms.RowHeadersVisible = false;
            this.dgvAllRooms.RowTemplate.Height = 30;
            this.dgvAllRooms.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAllRooms.Size = new System.Drawing.Size(1160, 413);
            this.dgvAllRooms.TabIndex = 22;
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
            // pictureBox2
            // 
            this.pictureBox2.Image = global::HotelManagementSystem.Properties.Resources._4860540;
            this.pictureBox2.Location = new System.Drawing.Point(434, 1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(311, 243);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 25;
            this.pictureBox2.TabStop = false;
            // 
            // frmManageRoomsCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1189, 778);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lblPeople);
            this.Controls.Add(this.dgvAllRooms);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmManageRoomsCategory";
            this.Text = "frmManageRoomsCategory";
            this.Load += new System.EventHandler(this.frmManageRoomsCategory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllRooms)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblPeople;
        private Guna.UI.WinForms.GunaDataGridView dgvAllRooms;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}
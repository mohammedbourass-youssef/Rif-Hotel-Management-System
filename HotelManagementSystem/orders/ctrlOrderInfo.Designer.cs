namespace HotelManagementSystem.orders
{
    partial class ctrlOrderInfo
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnOptions = new System.Windows.Forms.Button();
            this.lblStatus = new Guna.UI.WinForms.GunaLabel();
            this.btnID = new Guna.UI2.WinForms.Guna2CircleButton();
            this.lblRoomNumber = new Guna.UI.WinForms.GunaLabel();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BorderRadius = 17;
            this.guna2Panel1.Controls.Add(this.btnOptions);
            this.guna2Panel1.Controls.Add(this.lblStatus);
            this.guna2Panel1.Controls.Add(this.btnID);
            this.guna2Panel1.Controls.Add(this.lblRoomNumber);
            this.guna2Panel1.FillColor = System.Drawing.Color.White;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(440, 63);
            this.guna2Panel1.TabIndex = 4;
            this.guna2Panel1.Click += new System.EventHandler(this.btnID_Click);
            this.guna2Panel1.MouseEnter += new System.EventHandler(this.btnID_MouseEnter);
            this.guna2Panel1.MouseLeave += new System.EventHandler(this.btnID_MouseLeave);
            // 
            // btnOptions
            // 
            this.btnOptions.BackColor = System.Drawing.Color.Transparent;
            this.btnOptions.FlatAppearance.BorderSize = 0;
            this.btnOptions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOptions.Image = global::HotelManagementSystem.Properties.Resources.icons8_menu_vertical_20;
            this.btnOptions.Location = new System.Drawing.Point(409, 7);
            this.btnOptions.Name = "btnOptions";
            this.btnOptions.Size = new System.Drawing.Size(27, 46);
            this.btnOptions.TabIndex = 12;
            this.btnOptions.UseVisualStyleBackColor = false;
            this.btnOptions.Click += new System.EventHandler(this.btnOptions_Click);
            this.btnOptions.MouseEnter += new System.EventHandler(this.btnID_MouseEnter);
            this.btnOptions.MouseLeave += new System.EventHandler(this.btnID_MouseLeave);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.BackColor = System.Drawing.Color.Transparent;
            this.lblStatus.Font = new System.Drawing.Font("Andalus", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.Red;
            this.lblStatus.Location = new System.Drawing.Point(87, 32);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(67, 30);
            this.lblStatus.TabIndex = 10;
            this.lblStatus.Text = "Status";
            this.lblStatus.UseMnemonic = false;
            this.lblStatus.Click += new System.EventHandler(this.btnID_Click);
            this.lblStatus.MouseEnter += new System.EventHandler(this.btnID_MouseEnter);
            this.lblStatus.MouseLeave += new System.EventHandler(this.btnID_MouseLeave);
            // 
            // btnID
            // 
            this.btnID.BackColor = System.Drawing.Color.Transparent;
            this.btnID.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(70)))));
            this.btnID.BorderThickness = 4;
            this.btnID.CheckedState.Parent = this.btnID;
            this.btnID.CustomImages.Parent = this.btnID;
            this.btnID.FillColor = System.Drawing.Color.White;
            this.btnID.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(70)))));
            this.btnID.HoverState.Parent = this.btnID;
            this.btnID.Location = new System.Drawing.Point(10, 7);
            this.btnID.Name = "btnID";
            this.btnID.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnID.ShadowDecoration.Parent = this.btnID;
            this.btnID.Size = new System.Drawing.Size(48, 46);
            this.btnID.TabIndex = 3;
            this.btnID.Text = "1";
            this.btnID.Click += new System.EventHandler(this.btnID_Click);
            this.btnID.MouseEnter += new System.EventHandler(this.btnID_MouseEnter);
            this.btnID.MouseLeave += new System.EventHandler(this.btnID_MouseLeave);
            // 
            // lblRoomNumber
            // 
            this.lblRoomNumber.AutoSize = true;
            this.lblRoomNumber.BackColor = System.Drawing.Color.Transparent;
            this.lblRoomNumber.Font = new System.Drawing.Font("Segoe UI Black", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoomNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(70)))));
            this.lblRoomNumber.Location = new System.Drawing.Point(75, 7);
            this.lblRoomNumber.Name = "lblRoomNumber";
            this.lblRoomNumber.Size = new System.Drawing.Size(164, 25);
            this.lblRoomNumber.TabIndex = 9;
            this.lblRoomNumber.Text = "ROOM NUMBER";
            this.lblRoomNumber.UseMnemonic = false;
            this.lblRoomNumber.Click += new System.EventHandler(this.btnID_Click);
            this.lblRoomNumber.MouseEnter += new System.EventHandler(this.btnID_MouseEnter);
            this.lblRoomNumber.MouseLeave += new System.EventHandler(this.btnID_MouseLeave);
            // 
            // ctrlOrderInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Controls.Add(this.guna2Panel1);
            this.Name = "ctrlOrderInfo";
            this.Size = new System.Drawing.Size(440, 68);
            this.Click += new System.EventHandler(this.ctrlOrderInfo_Click);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Button btnOptions;
        private Guna.UI.WinForms.GunaLabel lblStatus;
        private Guna.UI2.WinForms.Guna2CircleButton btnID;
        private Guna.UI.WinForms.GunaLabel lblRoomNumber;
    }
}

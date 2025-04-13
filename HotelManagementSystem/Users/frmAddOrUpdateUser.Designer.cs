namespace HotelManagementSystem.Users
{
    partial class frmAddOrUpdateUser
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
            this.ctrlFindEmployee1 = new HotelManagementSystem.Employee.ctrlFindEmployee();
            this.btnUserInfo = new Guna.UI2.WinForms.Guna2Button();
            this.btnEmploInfo = new Guna.UI2.WinForms.Guna2Button();
            this.pnlHeader = new Guna.UI2.WinForms.Guna2Panel();
            this.pnlJumper = new System.Windows.Forms.Panel();
            this.btnCancel = new Guna.UI2.WinForms.Guna2Button();
            this.pnlBody.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBody
            // 
            this.pnlBody.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(138)))), ((int)(((byte)(20)))));
            this.pnlBody.BorderThickness = 4;
            this.pnlBody.Controls.Add(this.ctrlFindEmployee1);
            this.pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBody.Location = new System.Drawing.Point(0, 69);
            this.pnlBody.Name = "pnlBody";
            this.pnlBody.ShadowDecoration.Parent = this.pnlBody;
            this.pnlBody.Size = new System.Drawing.Size(1085, 690);
            this.pnlBody.TabIndex = 1;
            // 
            // ctrlFindEmployee1
            // 
            this.ctrlFindEmployee1.Location = new System.Drawing.Point(5, 2);
            this.ctrlFindEmployee1.Name = "ctrlFindEmployee1";
            this.ctrlFindEmployee1.Size = new System.Drawing.Size(1075, 666);
            this.ctrlFindEmployee1.TabIndex = 0;
            // 
            // btnUserInfo
            // 
            this.btnUserInfo.BorderRadius = 20;
            this.btnUserInfo.CheckedState.Parent = this.btnUserInfo;
            this.btnUserInfo.CustomImages.Parent = this.btnUserInfo;
            this.btnUserInfo.FillColor = System.Drawing.Color.Transparent;
            this.btnUserInfo.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUserInfo.ForeColor = System.Drawing.Color.White;
            this.btnUserInfo.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(138)))), ((int)(((byte)(20)))));
            this.btnUserInfo.HoverState.Parent = this.btnUserInfo;
            this.btnUserInfo.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnUserInfo.ImageSize = new System.Drawing.Size(45, 45);
            this.btnUserInfo.Location = new System.Drawing.Point(255, 16);
            this.btnUserInfo.Name = "btnUserInfo";
            this.btnUserInfo.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.btnUserInfo.PressedDepth = 100;
            this.btnUserInfo.ShadowDecoration.Parent = this.btnUserInfo;
            this.btnUserInfo.Size = new System.Drawing.Size(212, 35);
            this.btnUserInfo.TabIndex = 22;
            this.btnUserInfo.Text = "User Info";
            this.btnUserInfo.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.btnUserInfo.Click += new System.EventHandler(this.btnUserInfo_Click);
            // 
            // btnEmploInfo
            // 
            this.btnEmploInfo.BorderRadius = 20;
            this.btnEmploInfo.CheckedState.Parent = this.btnEmploInfo;
            this.btnEmploInfo.CustomImages.Parent = this.btnEmploInfo;
            this.btnEmploInfo.FillColor = System.Drawing.Color.Transparent;
            this.btnEmploInfo.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmploInfo.ForeColor = System.Drawing.Color.White;
            this.btnEmploInfo.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(138)))), ((int)(((byte)(20)))));
            this.btnEmploInfo.HoverState.Parent = this.btnEmploInfo;
            this.btnEmploInfo.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnEmploInfo.ImageSize = new System.Drawing.Size(45, 45);
            this.btnEmploInfo.Location = new System.Drawing.Point(29, 14);
            this.btnEmploInfo.Name = "btnEmploInfo";
            this.btnEmploInfo.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.btnEmploInfo.PressedDepth = 100;
            this.btnEmploInfo.ShadowDecoration.Parent = this.btnEmploInfo;
            this.btnEmploInfo.Size = new System.Drawing.Size(209, 37);
            this.btnEmploInfo.TabIndex = 21;
            this.btnEmploInfo.Text = "Employee Info";
            this.btnEmploInfo.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.btnEmploInfo.Click += new System.EventHandler(this.btnPersonInfo_Click);
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(70)))));
            this.pnlHeader.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(138)))), ((int)(((byte)(20)))));
            this.pnlHeader.BorderThickness = 4;
            this.pnlHeader.Controls.Add(this.pnlJumper);
            this.pnlHeader.Controls.Add(this.btnCancel);
            this.pnlHeader.Controls.Add(this.btnUserInfo);
            this.pnlHeader.Controls.Add(this.btnEmploInfo);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.ShadowDecoration.Parent = this.pnlHeader;
            this.pnlHeader.Size = new System.Drawing.Size(1085, 69);
            this.pnlHeader.TabIndex = 2;
            this.pnlHeader.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlHeader_Paint);
            // 
            // pnlJumper
            // 
            this.pnlJumper.Location = new System.Drawing.Point(482, 14);
            this.pnlJumper.Name = "pnlJumper";
            this.pnlJumper.Size = new System.Drawing.Size(484, 30);
            this.pnlJumper.TabIndex = 24;
            // 
            // btnCancel
            // 
            this.btnCancel.BorderRadius = 30;
            this.btnCancel.CheckedState.Parent = this.btnCancel;
            this.btnCancel.CustomImages.Parent = this.btnCancel;
            this.btnCancel.FillColor = System.Drawing.Color.Transparent;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(138)))), ((int)(((byte)(20)))));
            this.btnCancel.HoverState.Parent = this.btnCancel;
            this.btnCancel.Image = global::HotelManagementSystem.Properties.Resources.icons8_cancel_40;
            this.btnCancel.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnCancel.ImageOffset = new System.Drawing.Point(-10, 0);
            this.btnCancel.ImageSize = new System.Drawing.Size(50, 50);
            this.btnCancel.Location = new System.Drawing.Point(1028, 7);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.btnCancel.PressedDepth = 100;
            this.btnCancel.ShadowDecoration.Parent = this.btnCancel;
            this.btnCancel.Size = new System.Drawing.Size(50, 50);
            this.btnCancel.TabIndex = 23;
            this.btnCancel.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.btnCancel.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // frmAddOrUpdateUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1085, 759);
            this.Controls.Add(this.pnlBody);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAddOrUpdateUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAddNewUser";
            this.Load += new System.EventHandler(this.frmAddOrUpdateUser_Load);
            this.pnlBody.ResumeLayout(false);
            this.pnlHeader.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Panel pnlBody;
        private Guna.UI2.WinForms.Guna2Button btnUserInfo;
        private Guna.UI2.WinForms.Guna2Button btnEmploInfo;
        private Guna.UI2.WinForms.Guna2Panel pnlHeader;
        private Guna.UI2.WinForms.Guna2Button btnCancel;
        private System.Windows.Forms.Panel pnlJumper;
        private Employee.ctrlFindEmployee ctrlFindEmployee1;
    }
}
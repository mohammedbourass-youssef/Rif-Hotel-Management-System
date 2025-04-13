namespace HotelManagementSystem
{
    partial class FrmLoginForm
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
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.pbEnter = new System.Windows.Forms.PictureBox();
            this.RemmberME = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.label1 = new System.Windows.Forms.Label();
            this.btnShowPassword = new Guna.UI2.WinForms.Guna2CircleButton();
            this.txtPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtUserName = new Guna.UI2.WinForms.Guna2TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.guna2GradientButton1 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2GradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbEnter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.BorderRadius = 300;
            this.guna2GradientPanel1.Controls.Add(this.pbEnter);
            this.guna2GradientPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(138)))), ((int)(((byte)(20)))));
            this.guna2GradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.guna2GradientPanel1.Location = new System.Drawing.Point(-215, -23);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.ShadowDecoration.Parent = this.guna2GradientPanel1;
            this.guna2GradientPanel1.Size = new System.Drawing.Size(758, 756);
            this.guna2GradientPanel1.TabIndex = 1;
            // 
            // pbEnter
            // 
            this.pbEnter.BackColor = System.Drawing.Color.Transparent;
            this.pbEnter.Image = global::HotelManagementSystem.Properties.Resources.Adobe_Express___file;
            this.pbEnter.Location = new System.Drawing.Point(201, 239);
            this.pbEnter.Name = "pbEnter";
            this.pbEnter.Size = new System.Drawing.Size(441, 517);
            this.pbEnter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbEnter.TabIndex = 0;
            this.pbEnter.TabStop = false;
            // 
            // RemmberME
            // 
            this.RemmberME.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.RemmberME.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.RemmberME.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.RemmberME.CheckedState.InnerColor = System.Drawing.Color.White;
            this.RemmberME.CheckedState.Parent = this.RemmberME;
            this.RemmberME.Location = new System.Drawing.Point(627, 421);
            this.RemmberME.Name = "RemmberME";
            this.RemmberME.ShadowDecoration.Parent = this.RemmberME;
            this.RemmberME.Size = new System.Drawing.Size(56, 24);
            this.RemmberME.TabIndex = 6;
            this.RemmberME.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.RemmberME.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.RemmberME.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.RemmberME.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.RemmberME.UncheckedState.Parent = this.RemmberME;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(62)))), ((int)(((byte)(93)))));
            this.label1.Location = new System.Drawing.Point(689, 416);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 29);
            this.label1.TabIndex = 7;
            this.label1.Text = "Remember  Me";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnShowPassword
            // 
            this.btnShowPassword.BorderRadius = 10;
            this.btnShowPassword.CheckedState.Parent = this.btnShowPassword;
            this.btnShowPassword.CustomImages.Parent = this.btnShowPassword;
            this.btnShowPassword.FillColor = System.Drawing.Color.White;
            this.btnShowPassword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnShowPassword.ForeColor = System.Drawing.Color.White;
            this.btnShowPassword.HoverState.Parent = this.btnShowPassword;
            this.btnShowPassword.Image = global::HotelManagementSystem.Properties.Resources.icons8_eye_40;
            this.btnShowPassword.ImageSize = new System.Drawing.Size(40, 40);
            this.btnShowPassword.Location = new System.Drawing.Point(975, 356);
            this.btnShowPassword.Name = "btnShowPassword";
            this.btnShowPassword.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnShowPassword.ShadowDecoration.Parent = this.btnShowPassword;
            this.btnShowPassword.Size = new System.Drawing.Size(45, 42);
            this.btnShowPassword.TabIndex = 8;
            this.btnShowPassword.Click += new System.EventHandler(this.btnShowPassword_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Animated = true;
            this.txtPassword.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(62)))), ((int)(((byte)(93)))));
            this.txtPassword.BorderRadius = 30;
            this.txtPassword.BorderThickness = 2;
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.DefaultText = "";
            this.txtPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPassword.DisabledState.Parent = this.txtPassword;
            this.txtPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPassword.FocusedState.Parent = this.txtPassword;
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(62)))), ((int)(((byte)(93)))));
            this.txtPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPassword.HoverState.Parent = this.txtPassword;
            this.txtPassword.IconLeft = global::HotelManagementSystem.Properties.Resources.icons8_password_52;
            this.txtPassword.IconLeftOffset = new System.Drawing.Point(3, 0);
            this.txtPassword.IconLeftSize = new System.Drawing.Size(40, 40);
            this.txtPassword.IconRightOffset = new System.Drawing.Point(3, 3);
            this.txtPassword.Location = new System.Drawing.Point(594, 346);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(62)))), ((int)(((byte)(93)))));
            this.txtPassword.PlaceholderText = "Password";
            this.txtPassword.SelectedText = "";
            this.txtPassword.ShadowDecoration.Parent = this.txtPassword;
            this.txtPassword.Size = new System.Drawing.Size(442, 65);
            this.txtPassword.TabIndex = 5;
            this.txtPassword.TextOffset = new System.Drawing.Point(50, 0);
            // 
            // txtUserName
            // 
            this.txtUserName.Animated = true;
            this.txtUserName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(62)))), ((int)(((byte)(93)))));
            this.txtUserName.BorderRadius = 30;
            this.txtUserName.BorderThickness = 2;
            this.txtUserName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUserName.DefaultText = "";
            this.txtUserName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtUserName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtUserName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUserName.DisabledState.Parent = this.txtUserName;
            this.txtUserName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUserName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUserName.FocusedState.Parent = this.txtUserName;
            this.txtUserName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(62)))), ((int)(((byte)(93)))));
            this.txtUserName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUserName.HoverState.Parent = this.txtUserName;
            this.txtUserName.IconLeft = global::HotelManagementSystem.Properties.Resources.icons8_username_52;
            this.txtUserName.IconLeftOffset = new System.Drawing.Point(3, 0);
            this.txtUserName.IconLeftSize = new System.Drawing.Size(50, 50);
            this.txtUserName.IconRightOffset = new System.Drawing.Point(3, 3);
            this.txtUserName.Location = new System.Drawing.Point(594, 251);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.PasswordChar = '\0';
            this.txtUserName.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(62)))), ((int)(((byte)(93)))));
            this.txtUserName.PlaceholderText = "UserName";
            this.txtUserName.SelectedText = "";
            this.txtUserName.ShadowDecoration.Parent = this.txtUserName;
            this.txtUserName.Size = new System.Drawing.Size(442, 65);
            this.txtUserName.TabIndex = 4;
            this.txtUserName.TextOffset = new System.Drawing.Point(40, 0);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::HotelManagementSystem.Properties.Resources.Screenshot_2025_02_15_123103_removebg_preview__1_;
            this.pictureBox1.Location = new System.Drawing.Point(661, 38);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(273, 190);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // btnCancel
            // 
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Image = global::HotelManagementSystem.Properties.Resources.icons8_close_52__2_;
            this.btnCancel.Location = new System.Drawing.Point(1012, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(64, 52);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // guna2GradientButton1
            // 
            this.guna2GradientButton1.BorderRadius = 30;
            this.guna2GradientButton1.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.ToogleButton;
            this.guna2GradientButton1.CheckedState.Parent = this.guna2GradientButton1;
            this.guna2GradientButton1.CustomImages.Parent = this.guna2GradientButton1;
            this.guna2GradientButton1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(138)))), ((int)(((byte)(20)))));
            this.guna2GradientButton1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.guna2GradientButton1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GradientButton1.ForeColor = System.Drawing.Color.White;
            this.guna2GradientButton1.HoverState.Parent = this.guna2GradientButton1;
            this.guna2GradientButton1.Location = new System.Drawing.Point(673, 461);
            this.guna2GradientButton1.Name = "guna2GradientButton1";
            this.guna2GradientButton1.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(62)))), ((int)(((byte)(93)))));
            this.guna2GradientButton1.ShadowDecoration.Parent = this.guna2GradientButton1;
            this.guna2GradientButton1.Size = new System.Drawing.Size(261, 65);
            this.guna2GradientButton1.TabIndex = 9;
            this.guna2GradientButton1.Text = "LOGIN";
            this.guna2GradientButton1.Click += new System.EventHandler(this.guna2GradientButton1_Click);
            // 
            // FrmLoginForm
            // 
            this.AcceptButton = this.guna2GradientButton1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1072, 722);
            this.Controls.Add(this.guna2GradientButton1);
            this.Controls.Add(this.btnShowPassword);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RemmberME);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.guna2GradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmLoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmLoginForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmLoginForm_KeyDown);
            this.guna2GradientPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbEnter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pbEnter;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2TextBox txtUserName;
        private Guna.UI2.WinForms.Guna2TextBox txtPassword;
        private Guna.UI2.WinForms.Guna2ToggleSwitch RemmberME;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2CircleButton btnShowPassword;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton1;
    }
}
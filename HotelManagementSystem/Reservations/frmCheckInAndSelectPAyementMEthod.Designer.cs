namespace HotelManagementSystem.Reservations
{
    partial class frmCheckInAndSelectPAyementMEthod
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
            this.guna2GroupBox4 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.Paypal = new Guna.UI.WinForms.GunaRadioButton();
            this.Visa = new Guna.UI.WinForms.GunaRadioButton();
            this.MasterCard = new Guna.UI.WinForms.GunaRadioButton();
            this.Cash = new Guna.UI.WinForms.GunaRadioButton();
            this.txtPricePerDay = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblPeople = new System.Windows.Forms.Label();
            this.gunaButton1 = new Guna.UI.WinForms.GunaButton();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTotalPrice = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2GroupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2GroupBox4
            // 
            this.guna2GroupBox4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(70)))));
            this.guna2GroupBox4.BorderRadius = 2;
            this.guna2GroupBox4.BorderThickness = 2;
            this.guna2GroupBox4.Controls.Add(this.pictureBox11);
            this.guna2GroupBox4.Controls.Add(this.Paypal);
            this.guna2GroupBox4.Controls.Add(this.pictureBox10);
            this.guna2GroupBox4.Controls.Add(this.Visa);
            this.guna2GroupBox4.Controls.Add(this.pictureBox9);
            this.guna2GroupBox4.Controls.Add(this.MasterCard);
            this.guna2GroupBox4.Controls.Add(this.pictureBox7);
            this.guna2GroupBox4.Controls.Add(this.Cash);
            this.guna2GroupBox4.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(70)))));
            this.guna2GroupBox4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GroupBox4.ForeColor = System.Drawing.Color.White;
            this.guna2GroupBox4.Location = new System.Drawing.Point(18, 179);
            this.guna2GroupBox4.Name = "guna2GroupBox4";
            this.guna2GroupBox4.ShadowDecoration.Parent = this.guna2GroupBox4;
            this.guna2GroupBox4.Size = new System.Drawing.Size(576, 153);
            this.guna2GroupBox4.TabIndex = 31;
            this.guna2GroupBox4.Text = "Payement Method";
            // 
            // Paypal
            // 
            this.Paypal.BaseColor = System.Drawing.SystemColors.Control;
            this.Paypal.CheckedOffColor = System.Drawing.Color.Gray;
            this.Paypal.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(70)))));
            this.Paypal.FillColor = System.Drawing.Color.White;
            this.Paypal.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Paypal.Location = new System.Drawing.Point(415, 91);
            this.Paypal.Name = "Paypal";
            this.Paypal.Size = new System.Drawing.Size(20, 20);
            this.Paypal.TabIndex = 6;
            this.Paypal.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.SingleBitPerPixelGridFit;
            this.Paypal.CheckedChanged += new System.EventHandler(this.Paypal_CheckedChanged);
            // 
            // Visa
            // 
            this.Visa.BaseColor = System.Drawing.SystemColors.Control;
            this.Visa.CheckedOffColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.Visa.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(70)))));
            this.Visa.FillColor = System.Drawing.Color.White;
            this.Visa.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Visa.Location = new System.Drawing.Point(6, 91);
            this.Visa.Name = "Visa";
            this.Visa.Size = new System.Drawing.Size(20, 20);
            this.Visa.TabIndex = 4;
            this.Visa.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.SingleBitPerPixelGridFit;
            this.Visa.CheckedChanged += new System.EventHandler(this.Visa_CheckedChanged);
            // 
            // MasterCard
            // 
            this.MasterCard.BaseColor = System.Drawing.SystemColors.Control;
            this.MasterCard.CheckedOffColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.MasterCard.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(70)))));
            this.MasterCard.FillColor = System.Drawing.Color.White;
            this.MasterCard.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MasterCard.Location = new System.Drawing.Point(139, 91);
            this.MasterCard.Name = "MasterCard";
            this.MasterCard.Size = new System.Drawing.Size(20, 20);
            this.MasterCard.TabIndex = 2;
            this.MasterCard.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.SingleBitPerPixelGridFit;
            this.MasterCard.CheckedChanged += new System.EventHandler(this.MasterCard_CheckedChanged);
            // 
            // Cash
            // 
            this.Cash.BaseColor = System.Drawing.SystemColors.Control;
            this.Cash.CheckedOffColor = System.Drawing.Color.Gray;
            this.Cash.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(70)))));
            this.Cash.FillColor = System.Drawing.Color.White;
            this.Cash.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cash.Location = new System.Drawing.Point(279, 91);
            this.Cash.Name = "Cash";
            this.Cash.Size = new System.Drawing.Size(20, 20);
            this.Cash.TabIndex = 0;
            this.Cash.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.SingleBitPerPixelGridFit;
            this.Cash.CheckedChanged += new System.EventHandler(this.Cash_CheckedChanged);
            // 
            // txtPricePerDay
            // 
            this.txtPricePerDay.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(70)))));
            this.txtPricePerDay.BorderRadius = 20;
            this.txtPricePerDay.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPricePerDay.DefaultText = "";
            this.txtPricePerDay.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPricePerDay.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPricePerDay.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPricePerDay.DisabledState.Parent = this.txtPricePerDay;
            this.txtPricePerDay.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPricePerDay.Enabled = false;
            this.txtPricePerDay.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPricePerDay.FocusedState.Parent = this.txtPricePerDay;
            this.txtPricePerDay.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPricePerDay.ForeColor = System.Drawing.Color.Black;
            this.txtPricePerDay.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPricePerDay.HoverState.Parent = this.txtPricePerDay;
            this.txtPricePerDay.Location = new System.Drawing.Point(143, 48);
            this.txtPricePerDay.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtPricePerDay.Name = "txtPricePerDay";
            this.txtPricePerDay.PasswordChar = '\0';
            this.txtPricePerDay.PlaceholderText = "Search";
            this.txtPricePerDay.SelectedText = "";
            this.txtPricePerDay.ShadowDecoration.Parent = this.txtPricePerDay;
            this.txtPricePerDay.Size = new System.Drawing.Size(372, 37);
            this.txtPricePerDay.TabIndex = 49;
            // 
            // lblPeople
            // 
            this.lblPeople.AutoSize = true;
            this.lblPeople.BackColor = System.Drawing.Color.Transparent;
            this.lblPeople.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeople.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(70)))));
            this.lblPeople.Location = new System.Drawing.Point(13, 14);
            this.lblPeople.Name = "lblPeople";
            this.lblPeople.Size = new System.Drawing.Size(275, 29);
            this.lblPeople.TabIndex = 50;
            this.lblPeople.Text = "Price Per Day (24 hour) : ";
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
            this.gunaButton1.Font = new System.Drawing.Font("Impact", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaButton1.ForeColor = System.Drawing.Color.Black;
            this.gunaButton1.Image = global::HotelManagementSystem.Properties.Resources.icons8_save_40;
            this.gunaButton1.ImageSize = new System.Drawing.Size(40, 40);
            this.gunaButton1.Location = new System.Drawing.Point(168, 338);
            this.gunaButton1.Name = "gunaButton1";
            this.gunaButton1.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.gunaButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton1.OnHoverForeColor = System.Drawing.Color.Turquoise;
            this.gunaButton1.OnHoverImage = null;
            this.gunaButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton1.Radius = 30;
            this.gunaButton1.Size = new System.Drawing.Size(149, 57);
            this.gunaButton1.TabIndex = 51;
            this.gunaButton1.Text = "Save ";
            this.gunaButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.gunaButton1.Click += new System.EventHandler(this.gunaButton1_Click);
            // 
            // pictureBox11
            // 
            this.pictureBox11.Image = global::HotelManagementSystem.Properties.Resources._9420097cf13df8dfb7bcb7b5db3607dd;
            this.pictureBox11.Location = new System.Drawing.Point(433, 75);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(138, 45);
            this.pictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox11.TabIndex = 7;
            this.pictureBox11.TabStop = false;
            this.pictureBox11.Click += new System.EventHandler(this.pictureBox11_Click);
            this.pictureBox11.MouseEnter += new System.EventHandler(this.pictureBox11_MouseEnter);
            this.pictureBox11.MouseLeave += new System.EventHandler(this.pictureBox11_MouseLeave);
            // 
            // pictureBox10
            // 
            this.pictureBox10.Image = global::HotelManagementSystem.Properties.Resources.transparent_credit_card_65b26beda31da9_4982493717061918536681;
            this.pictureBox10.Location = new System.Drawing.Point(299, 75);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(113, 45);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox10.TabIndex = 5;
            this.pictureBox10.TabStop = false;
            this.pictureBox10.Click += new System.EventHandler(this.pictureBox10_Click);
            this.pictureBox10.MouseEnter += new System.EventHandler(this.pictureBox11_MouseEnter);
            this.pictureBox10.MouseLeave += new System.EventHandler(this.pictureBox11_MouseLeave);
            // 
            // pictureBox9
            // 
            this.pictureBox9.Image = global::HotelManagementSystem.Properties.Resources._51c395b2f02d431bede033db795c3b60;
            this.pictureBox9.Location = new System.Drawing.Point(159, 75);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(113, 45);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox9.TabIndex = 3;
            this.pictureBox9.TabStop = false;
            this.pictureBox9.Click += new System.EventHandler(this.pictureBox9_Click);
            this.pictureBox9.MouseEnter += new System.EventHandler(this.pictureBox11_MouseEnter);
            this.pictureBox9.MouseLeave += new System.EventHandler(this.pictureBox11_MouseLeave);
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::HotelManagementSystem.Properties.Resources.dc139ffdf87e0bfe4b53f1afc7126e34;
            this.pictureBox7.Location = new System.Drawing.Point(26, 75);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(109, 45);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 1;
            this.pictureBox7.TabStop = false;
            this.pictureBox7.Click += new System.EventHandler(this.pictureBox7_Click);
            this.pictureBox7.MouseEnter += new System.EventHandler(this.pictureBox11_MouseEnter);
            this.pictureBox7.MouseLeave += new System.EventHandler(this.pictureBox11_MouseLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(70)))));
            this.label1.Location = new System.Drawing.Point(13, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 29);
            this.label1.TabIndex = 53;
            this.label1.Text = "Total Price : ";
            // 
            // txtTotalPrice
            // 
            this.txtTotalPrice.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(70)))));
            this.txtTotalPrice.BorderRadius = 20;
            this.txtTotalPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTotalPrice.DefaultText = "";
            this.txtTotalPrice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTotalPrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTotalPrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTotalPrice.DisabledState.Parent = this.txtTotalPrice;
            this.txtTotalPrice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTotalPrice.Enabled = false;
            this.txtTotalPrice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTotalPrice.FocusedState.Parent = this.txtTotalPrice;
            this.txtTotalPrice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalPrice.ForeColor = System.Drawing.Color.Black;
            this.txtTotalPrice.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTotalPrice.HoverState.Parent = this.txtTotalPrice;
            this.txtTotalPrice.Location = new System.Drawing.Point(143, 125);
            this.txtTotalPrice.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtTotalPrice.Name = "txtTotalPrice";
            this.txtTotalPrice.PasswordChar = '\0';
            this.txtTotalPrice.PlaceholderText = "Search";
            this.txtTotalPrice.SelectedText = "";
            this.txtTotalPrice.ShadowDecoration.Parent = this.txtTotalPrice;
            this.txtTotalPrice.Size = new System.Drawing.Size(372, 37);
            this.txtTotalPrice.TabIndex = 52;
            // 
            // frmCheckInAndSelectPAyementMEthod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 400);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTotalPrice);
            this.Controls.Add(this.gunaButton1);
            this.Controls.Add(this.lblPeople);
            this.Controls.Add(this.txtPricePerDay);
            this.Controls.Add(this.guna2GroupBox4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmCheckInAndSelectPAyementMEthod";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmCheckInAndSelectPAyementMEthod_Load);
            this.guna2GroupBox4.ResumeLayout(false);
            this.guna2GroupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox4;
        private System.Windows.Forms.PictureBox pictureBox11;
        private Guna.UI.WinForms.GunaRadioButton Paypal;
        private System.Windows.Forms.PictureBox pictureBox10;
        private Guna.UI.WinForms.GunaRadioButton Visa;
        private System.Windows.Forms.PictureBox pictureBox9;
        private Guna.UI.WinForms.GunaRadioButton MasterCard;
        private System.Windows.Forms.PictureBox pictureBox7;
        private Guna.UI.WinForms.GunaRadioButton Cash;
        private Guna.UI2.WinForms.Guna2TextBox txtPricePerDay;
        private System.Windows.Forms.Label lblPeople;
        private Guna.UI.WinForms.GunaButton gunaButton1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtTotalPrice;
    }
}
namespace HotelManagementSystem.People
{
    partial class frmSelectPerson
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
            this.ctrlFindAndPersonCard1 = new HotelManagementSystem.People.ctrlFindAndPersonCard();
            this.btnSave = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnSa = new Guna.UI2.WinForms.Guna2GradientButton();
            this.SuspendLayout();
            // 
            // ctrlFindAndPersonCard1
            // 
            this.ctrlFindAndPersonCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(70)))));
            this.ctrlFindAndPersonCard1.Location = new System.Drawing.Point(0, 1);
            this.ctrlFindAndPersonCard1.Name = "ctrlFindAndPersonCard1";
            this.ctrlFindAndPersonCard1.Size = new System.Drawing.Size(1077, 465);
            this.ctrlFindAndPersonCard1.TabIndex = 0;
            this.ctrlFindAndPersonCard1.OnPersonSelected += new System.EventHandler<BusnessLayer.clsPerson>(this.ctrlFindAndPersonCard1_OnPersonSelected);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.BorderRadius = 20;
            this.btnSave.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.ToogleButton;
            this.btnSave.CheckedState.Parent = this.btnSave;
            this.btnSave.CustomImages.Parent = this.btnSave;
            this.btnSave.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSave.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.HoverState.Parent = this.btnSave;
            this.btnSave.Location = new System.Drawing.Point(229, 465);
            this.btnSave.Name = "btnSave";
            this.btnSave.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnSave.ShadowDecoration.Parent = this.btnSave;
            this.btnSave.Size = new System.Drawing.Size(262, 48);
            this.btnSave.TabIndex = 26;
            this.btnSave.Text = "Cancel";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnSa
            // 
            this.btnSa.BackColor = System.Drawing.Color.Transparent;
            this.btnSa.BorderRadius = 20;
            this.btnSa.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.ToogleButton;
            this.btnSa.CheckedState.Parent = this.btnSa;
            this.btnSa.CustomImages.Parent = this.btnSa;
            this.btnSa.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSa.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.btnSa.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSa.ForeColor = System.Drawing.Color.White;
            this.btnSa.HoverState.Parent = this.btnSa;
            this.btnSa.Location = new System.Drawing.Point(559, 465);
            this.btnSa.Name = "btnSa";
            this.btnSa.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnSa.ShadowDecoration.Parent = this.btnSa;
            this.btnSa.Size = new System.Drawing.Size(262, 48);
            this.btnSa.TabIndex = 27;
            this.btnSa.Text = "Save";
            this.btnSa.Click += new System.EventHandler(this.btnSa_Click);
            // 
            // frmSelectPerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1077, 516);
            this.Controls.Add(this.btnSa);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.ctrlFindAndPersonCard1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmSelectPerson";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmSelectPerson_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ctrlFindAndPersonCard ctrlFindAndPersonCard1;
        private Guna.UI2.WinForms.Guna2GradientButton btnSave;
        private Guna.UI2.WinForms.Guna2GradientButton btnSa;
    }
}
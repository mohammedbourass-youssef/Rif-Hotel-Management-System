namespace HotelManagementSystem.Reservations
{
    partial class frmReservationDetatils
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
            this.ctrlReservationDetails1 = new HotelManagementSystem.Reservations.ctrlReservationDetails();
            this.SuspendLayout();
            // 
            // ctrlReservationDetails1
            // 
            this.ctrlReservationDetails1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(70)))));
            this.ctrlReservationDetails1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctrlReservationDetails1.Location = new System.Drawing.Point(0, 0);
            this.ctrlReservationDetails1.Name = "ctrlReservationDetails1";
            this.ctrlReservationDetails1.Size = new System.Drawing.Size(845, 675);
            this.ctrlReservationDetails1.TabIndex = 0;
            // 
            // frmReservationDetatils
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 675);
            this.Controls.Add(this.ctrlReservationDetails1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmReservationDetatils";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmReservationDetatils";
            this.Load += new System.EventHandler(this.frmReservationDetatils_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ctrlReservationDetails ctrlReservationDetails1;
    }
}
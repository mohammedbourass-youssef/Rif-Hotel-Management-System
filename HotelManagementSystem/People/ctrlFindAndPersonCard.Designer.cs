namespace HotelManagementSystem.People
{
    partial class ctrlFindAndPersonCard
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
            this.ctrlPersonCard1 = new HotelManagementSystem.People.ctrlPersonCard();
            this.ctrlFindPerson1 = new HotelManagementSystem.People.ctrlFindPerson();
            this.SuspendLayout();
            // 
            // ctrlPersonCard1
            // 
            this.ctrlPersonCard1.Location = new System.Drawing.Point(0, 75);
            this.ctrlPersonCard1.Name = "ctrlPersonCard1";
            this.ctrlPersonCard1.Size = new System.Drawing.Size(1075, 386);
            this.ctrlPersonCard1.TabIndex = 0;
            // 
            // ctrlFindPerson1
            // 
            this.ctrlFindPerson1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(70)))));
            this.ctrlFindPerson1.Location = new System.Drawing.Point(127, 3);
            this.ctrlFindPerson1.Name = "ctrlFindPerson1";
            this.ctrlFindPerson1.Size = new System.Drawing.Size(826, 71);
            this.ctrlFindPerson1.TabIndex = 1;
            this.ctrlFindPerson1.Load += new System.EventHandler(this.ctrlFindPerson1_Load);
            // 
            // ctrlFindAndPersonCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(70)))));
            this.Controls.Add(this.ctrlFindPerson1);
            this.Controls.Add(this.ctrlPersonCard1);
            this.Name = "ctrlFindAndPersonCard";
            this.Size = new System.Drawing.Size(1077, 465);
            this.ResumeLayout(false);

        }

        #endregion

        private ctrlPersonCard ctrlPersonCard1;
        private ctrlFindPerson ctrlFindPerson1;
    }
}

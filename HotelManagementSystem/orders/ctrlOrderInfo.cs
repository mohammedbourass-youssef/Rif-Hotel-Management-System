using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagementSystem.orders
{
    public partial class ctrlOrderInfo: UserControl
    {
        public event EventHandler<string> OrderChanged;
        public ctrlOrderInfo()
        {
            InitializeComponent();
        }
        bool IsClicked = false;
        private void btnID_MouseEnter(object sender, EventArgs e)
        {
            if(!IsClicked)
            {
                guna2Panel1.FillColor = Color.FromArgb(235, 138, 20);
                lblRoomNumber.ForeColor = Color.White;
                btnOptions.BackColor = Color.FromArgb(235, 138, 20);
                btnID.FillColor = guna2Panel1.FillColor;
            }
        }
        private void btnID_MouseLeave(object sender, EventArgs e)
        {
            if (!IsClicked)
            {
                guna2Panel1.FillColor = Color.White;
                lblRoomNumber.ForeColor = Color.FromArgb(30, 40, 70);
                btnOptions.BackColor = Color.White;
                btnID.FillColor = guna2Panel1.FillColor;
            }
        }
        private void btnID_Click(object sender, EventArgs e)
        {
            this.OnClick(e);
            guna2Panel1.FillColor = Color.FromArgb(30, 40, 70);
            lblRoomNumber.ForeColor = Color.White;
            btnOptions.BackColor = Color.FromArgb(30, 40, 70);
            btnID.FillColor = Color.White;
            IsClicked = true;
            
        }
        public void ChangeToNonClicked(object obj,EventArgs e)
        {
            guna2Panel1.FillColor = Color.White;
            lblRoomNumber.ForeColor = Color.FromArgb(30, 40, 70);
            btnOptions.BackColor = Color.White;
            btnID.FillColor = guna2Panel1.FillColor;
            IsClicked = false;
        }
        public void LoadTheControl(int ID,string roomnumber)
        {
            btnID.Text = ID.ToString();
            lblRoomNumber.Text = roomnumber;
        }

        private void btnOptions_Click(object sender, EventArgs e)
        {

        }

        private void ctrlOrderInfo_Click(object sender, EventArgs e)
        {
            OrderChanged?.Invoke(this,lblRoomNumber.Text);
        }
    }
}

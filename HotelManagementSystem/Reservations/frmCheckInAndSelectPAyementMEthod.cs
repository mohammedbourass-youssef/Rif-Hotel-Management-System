using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusnessLayer;

namespace HotelManagementSystem.Reservations
{
    public partial class frmCheckInAndSelectPAyementMEthod : Form
    {
        public event EventHandler<int> OnSaveClicked;
        int _payementID = 6;
        clsRoomsCategory _room = null;
        DateTime SD; DateTime ED;
        public frmCheckInAndSelectPAyementMEthod(string roomNumber ,DateTime SD , DateTime ED)
        {
            InitializeComponent();
             _room = clsRoomsCategory.Find(clsRooms.GetCategory_By_RoomID(clsRooms.GetIDByRoomNumber(roomNumber)));
            this.SD = SD;
            this.ED = ED;
        }

        private void frmCheckInAndSelectPAyementMEthod_Load(object sender, EventArgs e)
        {
            Cash.Checked = true;
            if (_room != null)
                txtPricePerDay.Text = _room.Price.ToString() + "          MAD";
            TimeSpan defference = ED - SD;
            double price = _room.Price* defference.Days;
            txtTotalPrice.Text = price.ToString() + "         MAD";
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            
            DialogResult result = MessageBox.Show(
                                 "Are you sure you want to continue?",
                                 "Confirmation",
                                 MessageBoxButtons.YesNo,
                                 MessageBoxIcon.Question
            );
            if (result == DialogResult.Yes)
            {
                this.Close();
                OnSaveClicked?.Invoke(this, _payementID);
            }
            else
            {
                this.Close();
                MessageBox.Show("You canceled the operation...");
            }
            
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Visa.Checked = true;
        }

        private void Visa_CheckedChanged(object sender, EventArgs e)
        {
            _payementID = 7;
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            MasterCard.Checked = true;
        }

        private void MasterCard_CheckedChanged(object sender, EventArgs e)
        {
            _payementID = 8;
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            Cash.Checked = true;
        }

        private void Cash_CheckedChanged(object sender, EventArgs e)
        {
            _payementID = 6;
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            Paypal.Checked = true;
        }

        private void Paypal_CheckedChanged(object sender, EventArgs e)
        {
            _payementID = 9;
        }

        private void pictureBox11_MouseEnter(object sender, EventArgs e)
        {
            PictureBox picture = (PictureBox)sender;
            picture.BackColor =Color.FromArgb(235, 138, 20); 
        }

        private void pictureBox11_MouseLeave(object sender, EventArgs e)
        {
            PictureBox picture = (PictureBox)sender;
            picture.BackColor = Color.Transparent;
        }
    }
}

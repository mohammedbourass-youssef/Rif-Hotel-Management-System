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
    public partial class frmReservationDetatils : Form
    {
        clsReservation reservation;
        public frmReservationDetatils(clsReservation reservation)
        {
            InitializeComponent();
            this.reservation = reservation;
        }

        private void frmReservationDetatils_Load(object sender, EventArgs e)
        {
            ctrlReservationDetails1.SetDataToShow(reservation);
        }
    }
}

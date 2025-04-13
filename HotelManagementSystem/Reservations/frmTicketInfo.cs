using BusnessLayer;
using PdfSharp;
using System;
using System.Media;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PdfSharp.Drawing;
using PdfSharp.Pdf;
using PdfSharp.Fonts;
using System.Diagnostics;
using PdfSharp.UniversalAccessibility.Drawing;
using HotelManagementSystem.Classes;

namespace SamplePortProject
{
    public partial class frmTicketInfo : Form
    {
        clsReservation _resrvation = null;
        public frmTicketInfo(clsReservation reservation)
        {
            
            InitializeComponent();
            _resrvation= reservation;
        }
        private void frmTicketInfo_Load(object sender, EventArgs e)
        {
            lblticketID.Text = clsRegistryAndLog.ReadFromRegistry("Ticket");
            int x = int.Parse(lblticketID.Text);
            x++;
            clsRegistryAndLog.WriteToRegistry("Ticket", x.ToString());
            if (_resrvation != null)
            {
                lblFullName.Text = _resrvation.Guest.person.GetFullName();
                lblGuestID.Text = _resrvation.Guest.guestsID.ToString();

                clsUser user = clsUser.Find(_resrvation.CreatedByUserID);
                lblUserName.Text = user.username;
                lblDate.Text = DateTime.Now.ToString("D");
                lblReservationID.Text = _resrvation.ReservationID.ToString();
                lblBookingDate.Text = _resrvation.AppliedDate.ToString();
                clsPayement BookingPrice = clsPayement.Find(_resrvation.ReservationID);
                if(BookingPrice != null)
                {
                    lblBookingPrice.Text = BookingPrice.Amount.ToString();
                }
                else
                {
                    lblBookingPrice.Text = "Free Booking For Extend";
                }
                lblStartTime.Text = _resrvation.StartDate.ToString("D");
                lblEndDate.Text = _resrvation.EndDate.ToString("D");
                clsPayement totalprice = clsPayement.FindTotal(_resrvation.ReservationID);
                lblamount.Text = totalprice.Amount.ToString();
                TimeSpan deff = _resrvation.EndDate - _resrvation.StartDate;
                lblNumberOFDays.Text = deff.Days.ToString();
                lblRoomNumber.Text = clsRooms.GetRoomNumberByID(_resrvation.RoomID);
                lblRoomType.Text = clsRooms.GetCategory_By_RoomID(_resrvation.RoomID);
                if(_resrvation.GuestmateID != null)
                {
                    lblCompanion.Text = _resrvation.Guestemate.person.GetFullName();
                }
            }
        }

        public void LoadAllMemmbers()
        {
            lblticketID.Text = clsRegistryAndLog.ReadFromRegistry("Ticket");
            int x = int.Parse(lblticketID.Text);
            x++;
            clsRegistryAndLog.WriteToRegistry("Ticket", x.ToString());
            if (_resrvation != null)
            {
                lblFullName.Text = _resrvation.Guest.person.GetFullName();
                lblGuestID.Text = _resrvation.Guest.guestsID.ToString();

                clsUser user = clsUser.Find(_resrvation.CreatedByUserID);
                lblUserName.Text = user.username;
                lblDate.Text = DateTime.Now.ToString("D");
                lblReservationID.Text = _resrvation.ReservationID.ToString();
                lblBookingDate.Text = _resrvation.AppliedDate.ToString();
                clsPayement BookingPrice = clsPayement.Find(_resrvation.ReservationID);
                if (BookingPrice != null)
                {
                    lblBookingPrice.Text = BookingPrice.Amount.ToString();
                }
                else
                {
                    lblBookingPrice.Text = "Free Booking For Extend";
                }
                lblStartTime.Text = _resrvation.StartDate.ToString("D");
                lblEndDate.Text = _resrvation.EndDate.ToString("D");
                clsPayement totalprice = clsPayement.FindTotal(_resrvation.ReservationID);
                lblamount.Text = totalprice.Amount.ToString();
                TimeSpan deff = _resrvation.EndDate - _resrvation.StartDate;
                lblNumberOFDays.Text = deff.Days.ToString();
                lblRoomNumber.Text = clsRooms.GetRoomNumberByID(_resrvation.RoomID);
                lblRoomType.Text = clsRooms.GetCategory_By_RoomID(_resrvation.RoomID);
                if (_resrvation.GuestmateID != null)
                {
                    lblCompanion.Text = _resrvation.Guestemate.person.GetFullName();
                }
            }
        }

        private void btmCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            notifyIcon1.Icon = SystemIcons.Application;
            PrintSecondTicket();
            
           
        }
        //by mohammed bourass 
        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.BackColor = Color.FromArgb(1, 38, 70);
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.FromArgb(1, 12, 24);
        }
        public void PrintSecondTicket()
        {
            // Create a new PDF document
            PdfDocument document = new PdfDocument();
            document.Info.Title = "Formatted Ticket Information";

            // Create an empty page
            PdfPage page = document.AddPage();
            XGraphics gfx = XGraphics.FromPdfPage(page);

            // Set up fonts
            XFont textFont = new XFont("Times New Roman", 12,XFontStyleEx.Bold);


            double yPoint = 80;
            XPen pen = new XPen(XColor.FromArgb(0, 0, 0), 5);

            gfx.DrawString("RIF HOTEL", textFont, XBrushes.Black, new XPoint(400, 30));
            gfx.DrawLine(pen, 0, 44, 600, 44);

            gfx.DrawString("TicketID        : ", textFont, XBrushes.Black, new XPoint(10, yPoint));
            gfx.DrawString(lblticketID.Text, textFont, XBrushes.Black, new XPoint(160, yPoint));
            yPoint += 20;
            gfx.DrawString("Full Name       : ", textFont, XBrushes.Black, new XPoint(10, yPoint));
            gfx.DrawString(lblFullName.Text, textFont, XBrushes.Black, new XPoint(160, yPoint));
            yPoint += 20;
            gfx.DrawString("Guest ID        : ", textFont, XBrushes.Black, new XPoint(10, yPoint));
            gfx.DrawString(lblGuestID.Text, textFont, XBrushes.Black, new XPoint(160, yPoint));
            yPoint += 20;
            gfx.DrawString("User Name       : ", textFont, XBrushes.Black, new XPoint(10, yPoint));
            gfx.DrawString(lblUserName.Text, textFont, XBrushes.Black, new XPoint(160, yPoint));
            yPoint += 20;
            gfx.DrawString("Date            : ", textFont, XBrushes.Black, new XPoint(10, yPoint));
            gfx.DrawString(lblDate.Text, textFont, XBrushes.Black, new XPoint(160, yPoint));
            yPoint += 20;
            gfx.DrawString("Reservation ID  : ", textFont, XBrushes.Black, new XPoint(10, yPoint));
            gfx.DrawString(lblReservationID.Text, textFont, XBrushes.Black, new XPoint(160, yPoint));
            yPoint += 20;
            gfx.DrawString("Room Number     : ", textFont, XBrushes.Black, new XPoint(10, yPoint));
            gfx.DrawString(lblRoomNumber.Text, textFont, XBrushes.Black, new XPoint(160, yPoint));
            yPoint += 20;
            gfx.DrawString("Room Type       : ", textFont, XBrushes.Black, new XPoint(10, yPoint));
            gfx.DrawString(lblRoomType.Text, textFont, XBrushes.Black, new XPoint(160, yPoint));
            yPoint += 20;
            gfx.DrawString("Booking Date    : ", textFont, XBrushes.Black, new XPoint(10, yPoint));
            gfx.DrawString(lblBookingDate.Text, textFont, XBrushes.Black, new XPoint(160, yPoint));
            yPoint += 20;
            gfx.DrawString("Booking Price   : ", textFont, XBrushes.Black, new XPoint(10, yPoint));
            gfx.DrawString(lblBookingPrice.Text, textFont, XBrushes.Black, new XPoint(160, yPoint));
            yPoint += 20;
            gfx.DrawString("Number Of Days  : ", textFont, XBrushes.Black, new XPoint(10, yPoint));
            gfx.DrawString(lblNumberOFDays.Text, textFont, XBrushes.Black, new XPoint(160, yPoint));
            yPoint += 20;
            gfx.DrawString("Start Time      : ", textFont, XBrushes.Black, new XPoint(10, yPoint));
            gfx.DrawString(lblStartTime.Text, textFont, XBrushes.Black, new XPoint(160, yPoint));
            yPoint += 20;
            gfx.DrawString("End Date        : ", textFont, XBrushes.Black, new XPoint(10, yPoint));
            gfx.DrawString(lblDate.Text, textFont, XBrushes.Black, new XPoint(160, yPoint));
            yPoint += 20;
            gfx.DrawString("Amount          : ", textFont, XBrushes.Black, new XPoint(10, yPoint));
            gfx.DrawString(lblamount.Text, textFont, XBrushes.Black, new XPoint(160, yPoint));
            yPoint += 20;
            gfx.DrawString("Companion       : ", textFont, XBrushes.Black, new XPoint(10, yPoint));
            gfx.DrawString(lblCompanion.Text, textFont, XBrushes.Black, new XPoint(160, yPoint));

            string imagePath = @"C:\Users\USER\Documents\HotelManagementSystem\HotelManagementSystem\Resources\Screenshot 2025-03-11 192558.png";
            XImage img = XImage.FromFile(imagePath);
            gfx.DrawImage(img, 400, 200, 150, 150);
            gfx.DrawLine(pen, 0, yPoint+10, 600, yPoint+10);

            // Save the document
            string filename = @"C:\Users\USER\Downloads\TicketOfClientNumber" + lblticketID.Text + ".pdf";
            document.Save(filename);

            // Open the created PDF (optional)
            Process.Start(filename);
            notifyIcon1.ShowBalloonTip(1000, "File Dowloaded sccefully", "Tap To view", ToolTipIcon.Info);
        }

        private void notifyIcon1_BalloonTipClicked(object sender, EventArgs e)
        {
            
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }
    }
}

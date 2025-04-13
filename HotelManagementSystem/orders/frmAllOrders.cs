using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagementSystem.orders
{
    public partial class frmAllOrders: Form
    {
        public frmAllOrders()
        {
            InitializeComponent();
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            SetRoundedRegion(30); // Call function to make the form rounded
        }
        private void SetRoundedRegion(int radius)
        {
            GraphicsPath path = new GraphicsPath();
            int d = radius * 2;
            Rectangle rect = this.ClientRectangle;

            // Create arcs for rounded corners
            path.AddArc(rect.X, rect.Y, d, d, 180, 90);
            path.AddArc(rect.Right - d, rect.Y, d, d, 270, 90);
            path.AddArc(rect.Right - d, rect.Bottom - d, d, d, 0, 90);
            path.AddArc(rect.X, rect.Bottom - d, d, d, 90, 90);

            path.CloseFigure();
            this.Region = new Region(path); // Apply rounded region
        }
        public event EventHandler<EventArgs> OnOrderClickedChangeThecolorOfOthers;
        private void frmAllOrders_Load(object sender, EventArgs e)
        {
            for(int i = 1; i <= 10; i++)
            {
                ctrlOrderInfo ctrl = new ctrlOrderInfo();
                ctrl.Dock = DockStyle.Top;
                ctrl.LoadTheControl(i,"message"+Convert.ToString(i));
                ctrl.Click += (obj,a) =>
                {
                    OnOrderClickedChangeThecolorOfOthers?.Invoke(this, new EventArgs());
                };
                OnOrderClickedChangeThecolorOfOthers += ctrl.ChangeToNonClicked;
                pnlAllOrders.Controls.Add(ctrl);
                ctrl.OrderChanged += OnOrderClicked;
            }         
        }
        private void OnOrderClicked(object obj,string e)
        {
            lblRoomNumber.Text = e;
        }
        private void pnlBody_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

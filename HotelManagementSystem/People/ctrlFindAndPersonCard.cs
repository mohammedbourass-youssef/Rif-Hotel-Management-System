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

namespace HotelManagementSystem.People
{
    public partial class ctrlFindAndPersonCard : UserControl
    {
        public ctrlFindAndPersonCard()
        {
            InitializeComponent();
        }
        public event EventHandler<clsPerson> OnPersonSelected;
        public bool IsUpdate
        {
            set { ctrlFindPerson1.Enabled = value; }
        }
        /// <summary>
        /// Set The Person Info to ctrl Person Card, and Invoke The Event To Anounce Outside that the oerson Is Selected ; 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ShowPerson(object  sender, clsPerson e)
        {
            if (clsEmployee.IsExist(e.PersonID))
            {
                MessageBox.Show("This is Already An Employee, Try Another One !!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                ctrlPersonCard1.SetInfo(e);
                OnPersonSelected?.Invoke(this, e);
            }    
        }
        private void ShowGuest(object sender, clsPerson e)
        {
            ctrlPersonCard1.SetInfo(e);
            OnPersonSelected?.Invoke(this, e);
        }
        public void SetAsGuestFinder()
        {
            ctrlFindPerson1.BackedData += ShowGuest;
            ctrlFindPerson1.LoadData();
        }
        /// <summary>
        ///  Load the ctrl from outside and And Subscribe to The Data BAck event From Ctrl Find 
        /// </summary>
        public void LoadTheCtrl()
        {
            ctrlFindPerson1.BackedData += ShowPerson;
            ctrlFindPerson1.LoadData();
        }
        /// <summary>
        /// To For Only the item of manage people Form , Set Person Send by Datagrid view
        /// </summary>
        public void SetPersonAsEmployee(clsPerson person)
        {
            ctrlPersonCard1.SetInfo(person);
            ctrlFindPerson1.Enabled = false;
        }
        public void LoadUpdateInfo(clsPerson e)
        {
            ctrlPersonCard1.SetInfo(e);
            ctrlFindPerson1.Enabled = false;
        }
        private void ctrlFindPerson1_Load(object sender, EventArgs e)
        {

        }
    }
}

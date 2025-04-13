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

namespace HotelManagementSystem.Payement
{
    public partial class frmAllPayements : Form
    {
        int _currentpage = 1;
        int _totalpages = 0;
        public frmAllPayements()
        {
            InitializeComponent();
        }
        void _FetchNEXT()
        {
            if (_currentpage == _totalpages)
                _currentpage = 1;
            else
                _currentpage++;
            lblTitle.Text ="Page "+_currentpage;
            dgvAllPayements.DataSource = clsPayement.GetPagingAllPayement(_currentpage);
        }
        void _Previous()
        {
            if (_currentpage == 1)
                _currentpage = _totalpages;
            else
                _currentpage--;
            lblTitle.Text = "Page " + _currentpage;
            dgvAllPayements.DataSource = clsPayement.GetPagingAllPayement(_currentpage);
        }
        void _Load()
        {
            dgvAllPayements.DataSource = clsPayement.GetPagingAllPayement(_currentpage);
        }

        private void frmAllPayements_Load(object sender, EventArgs e)
        {
            _Load();
            _totalpages = clsPayement.CountTotalPayement();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            _Previous();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            _FetchNEXT();
        }
    }
}

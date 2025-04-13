using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagementSystem.Classes
{
    public  class OnSaveClickedAddedUSerEventArgs : EventArgs
    {
       
        public string username { get; set; }
        public string password { get; set; }
        public int permissions { get; set; }

        public OnSaveClickedAddedUSerEventArgs(string username,string password ,int permissions)
        {
            this.username = username;
            this.password = password;
            this.permissions = permissions;
        }

    }
}

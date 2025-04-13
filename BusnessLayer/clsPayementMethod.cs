using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;

namespace BusnessLayer
{
    public  class clsPayementMethod
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        clsPayementMethod(int ID, string Name, string Description)
        {
            this.ID = ID;
            this.Name = Name;
            this.Description = Description;
        }
        public static DataTable GetAllPayement()
        {
            return clsPayementMethodDataAccess.Get();
        }
        public static clsPayementMethod Find(int ID)
        {
            string name = string.Empty;
            string description = string.Empty;
            return (clsPayementMethodDataAccess.Find(ID,ref name,ref description))? new clsPayementMethod(ID,name,description) : null;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;

namespace BusnessLayer
{
    public  class clsEmployeeRole
    {
        public int roleID {  get; set; }
        public string Rolename { get; set; }
        public string descrition { get; set; }
        
        clsEmployeeRole(int roleID,string RoleName , string descrition)
        {
            this.roleID = roleID;
            this.descrition = descrition;
            this.Rolename = RoleName;
        }
        static public DataTable RetreiveAllRolesAndCountEmployee()
        {
            return clsEmployeeRoleDataAccess.RetreiveAllRolesAndCountEmployee();
        }
        public static clsEmployeeRole Find(int RoleID)
        {
            string RoleName = string.Empty;
            string descrition = string.Empty;
            return (clsEmployeeRoleDataAccess.Find(RoleID, ref RoleName, ref descrition) ? new clsEmployeeRole(RoleID, RoleName, descrition) : null);
        }
       
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusnessLayer;
using HACH_ME_EXEMPLE;

namespace HotelManagementSystem
{
    internal class clsGlobal
    {
        public static clsUser current_user = null;
        public static string Key = "1234567890123456";
        public static string RegistryName = "RememberMe";
        public static string DontRemmeberMeString = "--";
        public static frmMainForm mainForm;
        public static string DowloadPath = @"C:\Users\USER\Downloads\TicketOfClientNumber";
    }
}

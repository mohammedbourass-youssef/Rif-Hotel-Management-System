using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusnessLayer;
using Microsoft.Win32;

namespace HotelManagementSystem.Classes
{
    internal class clsRegistryAndLog
    {
        public static bool WriteToRegistry(string valueName , string valueData)
        {
                // Specify the Registry key and path
            string keyPath = @"HKEY_CURRENT_USER\SOFTWARE\HOTELMS";
            try
            {
                // Write the value to the Registry
                Registry.SetValue(keyPath, valueName, valueData, RegistryValueKind.String);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
            
        }
        public static string ReadFromRegistry(string valueName)
        {
            string keyPath = @"HKEY_CURRENT_USER\SOFTWARE\HOTELMS";
            try
            {
                string value = Registry.GetValue(keyPath, valueName, null) as string;
                if (value != null)
                {
                    return value;
                }
            }
            catch (Exception ex)
            {
                return null;
            }
            return null; 
        }
    }
}

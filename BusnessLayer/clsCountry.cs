using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;

namespace BusnessLayer
{
    public class clsCountry
    {
        public int CountryId { get; set; }
        public string CountryName { get; set; }

        clsCountry(int CountryId, string CountryName)
        {
            this.CountryId = CountryId;
            this.CountryName = CountryName;
        }
        public static DataTable RetreiveAllCountries()
        {
            return clsCountryDataAccess.ReTreiveAllCountries();
        }
        public static clsCountry Find(int CountryId)
        {
            string cname= string.Empty;
            if(clsCountryDataAccess.Find(CountryId,ref cname)){
                return new clsCountry(CountryId,cname);
            }
            else 
                return null;
        }
        public static clsCountry Find(string cname)
        {
            int CountryId = 0;
            if (clsCountryDataAccess.Find( cname,ref CountryId  ))
            {
                return new clsCountry(CountryId, cname);
            }
            else
                return null;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;

namespace BusnessLayer
{
    public class clsRoomsCategory
    {
        public int ID { get; set; }
        public string Category { get; set; }
        public double Price { get; set; }

        clsRoomsCategory(int ID,string Category,double Price)
        {
            this.ID = ID;
            this.Category = Category;
            this.Price = Price;
        }
        public static DataTable GetAll()
        {
            return clsRoomsCategoryDataAccess.Get();
        }
        public static int FindByName(string name) {
            int ID = 0;
            double Price  = 0;
            
            return (clsRoomsCategoryDataAccess.Find(name, ref ID, ref name, ref Price)) ? ID : -1;
        }
        public static clsRoomsCategory Find(string name)
        {
            int ID = 0;
            double Price = 0;

            return (clsRoomsCategoryDataAccess.Find(name, ref ID, ref name, ref Price)) ? new clsRoomsCategory(ID,name,Price) : null;
        }
    }
}

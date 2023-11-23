using Model;
using ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceModel
{
    public class ServiceSnack : IServiceSnack
    {
        public CityList GetAllCities()
        {
            CityDB db = new CityDB();
            CityList list = db.SelectAll();
            return list;
        }

        public SnackList GetSnackList() 
        {
            return null;
        }

        public SnackList GetSnacks()
        {

            SnackDB dB = new SnackDB();
            SnackList list = dB.SelectAll();
            return list;
        }

        public SnackList GetUserBySnack()
        {
           
        }
        public UserList GetUsers()
        {
            UserDB us = new UserDB();
            UserList list = us.SelectAll();
            return list;
        }

        public UserList GetUsersBySnack()
        {
            return null;
        }

        public User login(User user)
        {
            
        }
    }
}

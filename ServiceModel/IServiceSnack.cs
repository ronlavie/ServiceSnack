using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ServiceModel
{
    [ServiceContract]
    public interface IServiceSnack
    {
        [OperationContract]
        CityList GetAllCities();
        [OperationContract]
        UserList GetUsers ();
        [OperationContract]
        SnackList GetSnacks ();
        [OperationContract]
        SnackList GetUserBySnack();
        [OperationContract]
        UserList GetUsersBySnack();
        [OperationContract]
        User login(User user);

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TOKENBASEDAUTH.Models.DBclass;

namespace TOKENBASEDAUTH.Models
{
    public class UserMasterRepository : IDisposable
    {
        // SECURITY_DBEntities it is your context class
        Defaultdbcontext context = new Defaultdbcontext();
        //This method is used to check and validate the user credentials
        public UserMaster ValidateUser(string username, string password)
        {
            return context.userMasters.FirstOrDefault(user =>
            user.UserName.Equals(username, StringComparison.OrdinalIgnoreCase)
            && user.UserPassword == password);
        }
        public void Dispose()
        {
            context.Dispose();
        }
    }
}
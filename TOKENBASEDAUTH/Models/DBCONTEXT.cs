using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace TOKENBASEDAUTH.Models.DBclass
{
    public class Defaultdbcontext : DbContext

    {
        public Defaultdbcontext() : base("MyConnectionString")
        {
            Database.SetInitializer<Defaultdbcontext>(null);
        }
        public DbSet<UserMaster> userMasters { get; set; }
    }
}
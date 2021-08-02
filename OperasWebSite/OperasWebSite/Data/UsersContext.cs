using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace OperasWebSite.Data
{
    public class UsersContext : DbContext

    {
        public UsersContext(): base("DefaultConnection")
        {

        }

    }
}
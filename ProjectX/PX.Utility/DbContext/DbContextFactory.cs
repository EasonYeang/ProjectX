using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace PX.Utility.DbContext
{
    public class DbContextFactory
    {
        public static System.Data.Entity.DbContext GetCurrentDbContext()
        {
            System.Data.Entity.DbContext dbContext = CallContext.GetData("DbContext") as System.Data.Entity.DbContext;

            if (dbContext == null)
            {
                dbContext = new PXContext();
                CallContext.SetData("DbContext", dbContext);
            }

            return dbContext;
        }
    }
}

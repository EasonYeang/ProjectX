using System.Data.Entity;
using System.Reflection;
using PX.Domain.DAC;

namespace PX.Utility.DbContext
{
    public class PXContext : System.Data.Entity.DbContext
    {
        public PXContext() : base("ProjectX")
        {
        }

        #region Tables

        public DbSet<SysUser> SysUsers { get; set; }

        #endregion

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //Load all map files -- inherited from EntityTypeConfiguration
            modelBuilder.Configurations.AddFromAssembly(Assembly.Load("PX.Map"));
            
            base.OnModelCreating(modelBuilder);
        }
    }
}
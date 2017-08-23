using System.Data.Entity.ModelConfiguration;
using PX.Domain.DAC;

namespace PX.Map.Maps
{
    public class SysUserMap : EntityTypeConfiguration<SysUser>
    {
        public SysUserMap()
        {
            ToTable("SysUser");
            HasKey(d => d.ID);
            Property(d => d.NickName).HasMaxLength(12);
        }
    }
}

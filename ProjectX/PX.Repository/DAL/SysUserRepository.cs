using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PX.Domain.DAC;
using PX.IRepository.IDAL;

namespace PX.Repository.DAL
{
    public class SysUserRepository : BaseRepository<SysUser>, ISysUserRepository
    {
    }
}

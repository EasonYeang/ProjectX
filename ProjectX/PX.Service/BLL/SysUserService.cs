using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PX.Domain.DAC;
using PX.IRepository.IDAL;
using PX.IService.IBLL;

namespace PX.Service.BLL
{
    public class SysUserService : BaseService<SysUser>, ISysUserService
    {
        public SysUserService(IBaseRepository<SysUser> baseRepository) : base(baseRepository)
        {
        }
    }
}

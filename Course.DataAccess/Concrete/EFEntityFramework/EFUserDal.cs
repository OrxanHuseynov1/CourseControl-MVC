using Course.DataAccess.Abstract;
using Course.DataAccess.Context;
using Course.Domain.Entites;
using Course.Repository.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course.DataAccess.Concrete.EFEntityFramework
{
    internal class EFUserDal : EFEntityRepositoryBase<User, ApplicationDbContext>, IUserDal
    {
    }
}

using Course.DataAccess.Abstract;
using Course.DataAccess.Context;
using Course.Domain.Entites;
using Course.Repository.Infrastructure;

namespace Course.DataAccess.Concrete.EFEntityFramework;

public class EFUserDal : EFEntityRepositoryBase<User, ApplicationDbContext>, IUserDal
{

}


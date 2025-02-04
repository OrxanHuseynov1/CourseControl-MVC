using Course.DataAccess.Abstract;
using Course.DataAccess.Context;
using Course.Domain.Abstract;
using Course.Domain.Entites;
using Course.Repository.Infrastructure;

namespace Course.DataAccess.Concrete.EFEntityFramework;

public class EFBookDal : EFEntityRepositoryBase<Book, ApplicationDbContext>, IBookDal
{
}

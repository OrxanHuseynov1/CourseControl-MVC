using Course.DataAccess.Abstract;
using Course.DataAccess.Context;
using Course.Repository.Infrastructure;

namespace Course.DataAccess.Concrete.EFEntityFramework;

public class EFCourseDal : EFEntityRepositoryBase<Domain.Entites.Course,ApplicationDbContext> , ICourseDal
{
}

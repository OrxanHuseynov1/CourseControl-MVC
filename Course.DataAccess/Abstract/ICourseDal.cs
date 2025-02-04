using Course.Repository.Infrastructure;

namespace Course.DataAccess.Abstract;

public interface ICourseDal : IEntityRepository<Domain.Entites.Course> 
{
}

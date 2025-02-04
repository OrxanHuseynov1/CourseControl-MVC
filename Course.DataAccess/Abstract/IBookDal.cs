using Course.Domain.Entites;
using Course.Repository.Infrastructure;

namespace Course.DataAccess.Abstract;

public interface IBookDal : IEntityRepository<Book>
{
}

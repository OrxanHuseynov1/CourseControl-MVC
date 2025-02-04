using Course.Domain.Entites;

namespace Course.Application.Abstract;

public interface IUserService
{
    public List<User> GetAll();
}

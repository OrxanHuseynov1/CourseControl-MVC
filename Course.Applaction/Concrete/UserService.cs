using Course.Application.Abstract;
using Course.DataAccess.Abstract;
using Course.Domain.Entites;

namespace Course.Application.Concrete
{
    public class UserService(IUserDal userDal) : IUserService
    {
        private readonly IUserDal _userDal = userDal;
        public List<User> GetAll()
        {
            return _userDal.GetAll();
        }
    }
}

using Course.Domain.Entites;

namespace Course.Application.Abstract;

public interface IBookService
{
    public List<Book> GetAll();
}

using Course.Application.Abstract;
using Course.DataAccess.Abstract;
using Course.Domain.Entites;

namespace Course.Application.Concrete;

public class BookService(IBookDal bookDal) : IBookService
{
    private readonly IBookDal _bookDal = bookDal;
    public List<Book> GetAll()
    {
        return _bookDal.GetAll();
    }
}

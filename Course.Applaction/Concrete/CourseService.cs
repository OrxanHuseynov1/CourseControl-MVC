using Course.Application.Abstract;
using Course.DataAccess.Abstract;

namespace Course.Application.Concrete;

public class CourseService(ICourseDal courseDal) : ICourseService
{
    private readonly ICourseDal _courseDal = courseDal;
    public List<Domain.Entites.Course> GetAll()
    {
        return _courseDal.GetAll();
    }
}

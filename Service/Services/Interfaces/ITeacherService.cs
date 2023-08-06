using Domain.Models;
namespace Service.Services.Interfaces
{
    public interface  ITeacherService
	{
        void Create(Teacher teacher);
        List<Teacher> GetAll();
    }
}



using Domain.Models;
using Repository.Repositories;
using Service.Services.Interfaces;
using Repository.Repositories.Interfaces;

namespace Service.Services
{
    public class TeacherService : ITeacherService
    {
        private readonly ITeacherRepository _teacherRepositor;
        private int _count = 1;

        public TeacherService() => _teacherRepositor = new TeacherRepository();

        public void Create(Teacher teacher)
        {
            teacher.Id = _count;
            _teacherRepositor.Create(teacher);
            _count++;
        }


        public List<Teacher> GetAll() => _teacherRepositor.GetAll();

      
    }
}


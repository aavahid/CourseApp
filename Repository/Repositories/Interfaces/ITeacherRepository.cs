using Domain.Models;
using Repository.Data;

namespace Repository.Repositories.Interfaces
{
    public interface ITeacherRepository : IBaseRepository<Teacher>
    {
        void GetFullName(string fullname)
        {
            AppDbContext<Teacher>.datas.FirstOrDefault(m => m.FullName == fullname);

        }
    }
}
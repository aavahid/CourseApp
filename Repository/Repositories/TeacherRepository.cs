using Domain.Models;
using Repository.Data;
using Repository.Repositories.Interfaces;
namespace Repository.Repositories
{
	public class TeacherRepository : BaseRepository<Teacher>, ITeacherRepository
    {
        public void GetFullName(string fullname)
        {
            AppDbContext<Teacher>.datas.FirstOrDefault(m => m.FullName == fullname);
        }
    }
}


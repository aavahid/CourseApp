using System;
using Repository.Data;
using Domain.Models;
using Repository.Repositories.Interfaces;

namespace Repository.Repositories.Interfaces
{
	public interface IStudentRepository : IBaseRepository<Student>
	{
		List<Student> Search(string text);
        
	}
}


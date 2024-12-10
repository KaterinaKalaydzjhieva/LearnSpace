using LearnSpace.Core.Models.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnSpace.Core.Interfaces
{
	public interface IClassService
	{
		Task<AllClassesViewModel> GetAllClassesAsync(string id);
		Task LeaveClassAsync(string userId, int classId);
	}
}

using DAL.Abstract;
using DAL.Concrete;
using DAL.Repositories;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EntityFramework
{
	public class EFInstructorDal : GenericRepository<Instructor, NTierKodlamaDbContext>, IInstructorDal
	{
		
	}
}

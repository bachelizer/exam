using System.Collections.Generic;
using System.Threading.Tasks;
using crud_app_backend.Model;

namespace crud_app_backend.Contracts
{
	public interface IReport
	{
		 public Task<IEnumerable<Report>> Read();
	}
}

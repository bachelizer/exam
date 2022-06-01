using System.Collections.Generic;
using System.Threading.Tasks;
using crud_app_backend.Model;

namespace crud_app_backend.Contracts
{
	public interface ICRUD
	{
		public Task<IEnumerable<Instructor>> Read();
        public Task Create(Instructor data);
        public Task Update(Instructor data);
        public Task Delete(int instuctor_id);
		
	}
}

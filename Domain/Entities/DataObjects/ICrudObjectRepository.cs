using Domain.GenericRepository;
using Domain.GenericRepository.DataObjects;

namespace Domain.Entities.DataObjects
{
	public interface ICrudObjectRepository : IGenericRepository<CrudObject>
	{
		CrudObject Create(string prop1, string prop2);
	}
}

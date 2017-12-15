using Domain.Entities.DataObjects;
using Domain.GenericRepository;

namespace Domain.Entities
{
	public class CrudObjectRepository : GenericRepository<CrudObject>, ICrudObjectRepository
	{
		public CrudObject Create(string prob1, string prob2)
		{
			var crudObject2 = new CrudObject { Property1 = prob1, Property2 = prob2 };
			return Create(crudObject2);
		}

	}
}

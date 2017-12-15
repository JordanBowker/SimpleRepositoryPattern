using Domain.Entities.DataObjects;
using Domain.GenericRepository.DataObjects;

namespace Domain.GenericRepository
{
	public class GenericRepository<T> : IGenericRepository<T> where T : IEntity
	{
		public T Create(T unpersistedObject)
		{
			//talk to the Database and create an Entity
			unpersistedObject.Id = 4;
			return unpersistedObject;
		}
	}
}

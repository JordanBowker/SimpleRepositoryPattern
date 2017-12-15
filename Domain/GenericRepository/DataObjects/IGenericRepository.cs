using Domain.Entities.DataObjects;

namespace Domain.GenericRepository.DataObjects
{
	public interface IGenericRepository<T> where T : IEntity
	{
		T Create(T unpersistedObject);
	}
}

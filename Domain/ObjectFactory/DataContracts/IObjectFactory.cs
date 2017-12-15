using Domain.Entities.DataObjects;

namespace Domain.ObjectFactory.DataContracts
{
	public interface IObjectFactory<T> where T : IEntity
	{
		T Get();
	}
}

using Domain.Entities.DataObjects;
using Domain.ObjectFactory.DataContracts;

namespace Domain.ObjectFactory
{
	public class ObjectFactory<T> : IObjectFactory<T> where T : IEntity
	{
		private readonly T _entity;

		public ObjectFactory(T entity)
		{
			_entity = entity;
		}

		public T Get()
		{
			return _entity;
		}
	}
}

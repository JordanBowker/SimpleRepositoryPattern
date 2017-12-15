using Domain.Entities.DataObjects;
using Domain.GenericRepository;
using System;
using Domain.ObjectFactory.DataContracts;

namespace Domain.Entities
{
	public class CrudObjectRepository : GenericRepository<CrudObject>, ICrudObjectRepository
	{
		private readonly IObjectFactory<CrudObject> _objectFactory;

		public CrudObjectRepository(IObjectFactory<CrudObject> objectFactory)
		{
			_objectFactory = objectFactory;
		}

		public CrudObject Create(string prop1, string prop2)
		{
			var crudObject1 = _objectFactory.Get();
			if (crudObject1 == null) throw new Exception();

			crudObject1.Property1 = prop1;
			crudObject1.Property2 = prop2;
			return Create(crudObject1);
		}

	}
}

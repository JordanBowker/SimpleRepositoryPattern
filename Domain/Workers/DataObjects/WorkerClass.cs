using Domain.Entities;
using Domain.Entities.DataObjects;

namespace Domain.Workers.DataObjects
{
	public class WorkerClass : IWorkerClass
	{
		private readonly ICrudObjectRepository _crudRepository;

		public WorkerClass(ICrudObjectRepository crudRepository)
		{
			_crudRepository = crudRepository;
		}

		public virtual CrudObject CreateCrudObject()
		{
			return _crudRepository.Create("prop1", "prop2");
		}

	}
}

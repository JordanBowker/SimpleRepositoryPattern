using Domain.Entities;

namespace Domain.Workers.DataObjects
{
	public interface IWorkerClass
	{
		CrudObject CreateCrudObject();
	}
}

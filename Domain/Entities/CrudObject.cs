using Domain.Entities.DataObjects;
using Domain.Services.DataObjects;

namespace Domain.Entities
{
	public class CrudObject : IEntity
	{
		public CrudObject(IService service)
		{

		}

		public int? Id { get; set; }
		public string Property1 { get; set; }
		public string Property2 { get; set; }
	}
}

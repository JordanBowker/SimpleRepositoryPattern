using Domain.Entities.DataObjects;

namespace Domain.Entities
{
	public class CrudObject : IEntity
	{
		public int? Id { get; set; }
		public string Property1 { get; set; }
		public string Property2 { get; set; }
	}
}

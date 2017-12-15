using Castle.MicroKernel.Registration;
using Castle.Windsor;
using Domain.Entities;
using Domain.Entities.DataObjects;
using Domain.Workers.DataObjects;
using NUnit.Framework;

namespace Tests
{
	public class WorkerTests
	{
		private IWorkerClass _instance;

		[SetUp]
		public void SetUp()
		{
			var windsorContainer = new WindsorContainer();

			windsorContainer.Register(Component.For<ICrudObjectRepository>().ImplementedBy<CrudObjectRepository>());
			windsorContainer.Register(Component.For<IWorkerClass>().ImplementedBy<WorkerClass>());

			_instance = windsorContainer.Resolve<IWorkerClass>();
		}

		[Test]
		public void CreateCrudObject()
		{
			var actual = _instance.CreateCrudObject();

			Assert.That(actual.Id, Is.EqualTo(4));
			Assert.That(actual.Property1, Is.EqualTo("prop1"));
			Assert.That(actual.Property2, Is.EqualTo("prop2"));
		}
	}
}

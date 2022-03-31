using GoldenShoeAPI.Context;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace GoldenShoeAPI.Controllers
{
	[ApiController]
	[Route("shoes")]
	public class ShoesController : ControllerBase
	{
		private readonly IShoeRepository _repository;

		public ShoesController(IShoeRepository repository)
		{
			_repository = repository;
		}

		[HttpGet]
		public IEnumerable<Shoe> Get()
		{
			return _repository.FindAll();
		}

		[HttpPost]
		public void Post(IEnumerable<Shoe> shoes)
		{
			foreach(Shoe shoe in shoes)
			{
				_repository.Create(shoe);
			}
		}
	}
}

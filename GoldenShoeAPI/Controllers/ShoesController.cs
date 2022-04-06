using GoldenShoeAPI.Context;
using GoldenShoeAPI.Domain;
using GoldenShoeAPI.DTO;
using GoldenShoeAPI.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace GoldenShoeAPI.Controllers
{
	[ApiController]
	[Route("shoes")]
	public class ShoesController : ControllerBase
	{
        private readonly IShoeRepository _shoeRepository;
		private readonly IShoeDTOFactory _shoeDTOFactory;

        public ShoesController(
			IShoeRepository shoeRepository,
			IShoeDTOFactory shoeDTOFactory)
        {
            _shoeRepository = shoeRepository;
            _shoeDTOFactory = shoeDTOFactory;
        }

        [HttpGet]
		public IEnumerable<IShoeDTO> Get()
		{
			IEnumerable<Shoe> shoes = _shoeRepository.FindAll();
			IList<IShoeDTO> shoeInfo = new List<IShoeDTO>();
			foreach (Shoe shoe in shoes)
            {
				shoeInfo.Add(_shoeDTOFactory.Create(shoe));
            }
			return shoeInfo;
		}
	}
}

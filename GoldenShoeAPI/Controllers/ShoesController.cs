using GoldenShoeAPI.Context;
using GoldenShoeAPI.Domain;
using GoldenShoeAPI.DTO;
using GoldenShoeAPI.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace GoldenShoeAPI.Controllers
{
	[ApiController]
    [Route("api")]
    public class ShoesController : ControllerBase
	{
        private readonly IShoeRepository _shoeRepository;
        private readonly IShoeColourRepository _shoeColourRepository;
        private readonly IShoeColourSizeRepository _shoeColourSizeRepository;
        private readonly IShoeDTOFactory _shoeDTOFactory;

        public ShoesController(
			IShoeRepository shoeRepository,
            IShoeColourRepository shoeColourRepository,
            IShoeColourSizeRepository shoeColourSizeRepository,
            IShoeDTOFactory shoeDTOFactory)
        {
            _shoeRepository = shoeRepository;
            _shoeColourRepository = shoeColourRepository;
            _shoeColourSizeRepository = shoeColourSizeRepository;
            _shoeDTOFactory = shoeDTOFactory;
        }

        #region Shoes

        [HttpGet]
        [Route("shoes/")]
        public IEnumerable<IShoeDTO> GetShoes()
        {
            return _shoeRepository.FindAll().Select(s => _shoeDTOFactory.Create(s));
        }

        [HttpGet]
        [Route("shoes/{shoeId}")]
        public IShoeDTO GetShoe(int shoeId)
        {
            return _shoeDTOFactory.Create(_shoeRepository.FindByID(shoeId));
        }

        #endregion

        #region Colours

        [HttpGet]
        [Route("shoes/{shoeId}/colours")]
        public IEnumerable<Colour> GetShoeColours(int shoeId)
        {
            return _shoeColourRepository.FindByCondition(s => s.Shoe.ShoeId.Equals(shoeId)).Select(s => s.Colour);
        }

        #endregion

        #region Sizes

        [HttpGet]
        [Route("shoes/{shoeId}/sizes")]
        public IEnumerable<ShoeSize> GetShoeSizes(int shoeId)
        {
            return _shoeColourSizeRepository.FindByCondition(s => s.ShoeColour.Shoe.ShoeId.Equals(shoeId)).Select(s => s.ShoeSize).Distinct();
        }

        #endregion
    }
}

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using GoldenShoeAPI.Domain;
using GoldenShoeAPI.DTO;
using GoldenShoeAPI.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace GoldenShoeAPI.Factories
{
    public class ShoeDTOFactory: IShoeDTOFactory
    {
        private readonly IShoeColourRepository _shoeColourRepository;
        private readonly IShoeColourSizeRepository _shoeColourSizeRepository;
        private readonly IServiceProvider _serviceProvider;

        public ShoeDTOFactory(
            IServiceProvider serviceProvider,
            IShoeColourRepository shoeColourRepository,
            IShoeColourSizeRepository shoeColourSizeRepository,
            IBrandRepository brand,
            IStyleRepository styleRepository)
        {
            _serviceProvider = serviceProvider;
            _shoeColourRepository = shoeColourRepository;
            _shoeColourSizeRepository = shoeColourSizeRepository;
        }

        public IShoeDTO Create(Shoe shoe)
        {
            if (shoe == null) return null;

            IShoeDTO dto = ActivatorUtilities.GetServiceOrCreateInstance<IShoeDTO>(_serviceProvider);
            dto.ShoeId = shoe.ShoeId;
            dto.Name = shoe.Name;
            dto.Description = shoe.Description;
            dto.Price = shoe.Price;
            dto.Brand = shoe.Brand;
            dto.Style = shoe.Style;
            dto.Colours = _shoeColourRepository.FindByCondition(s => s.Shoe.ShoeId.Equals(shoe.ShoeId)).Select(s => s.Colour).ToList();
            dto.Sizes = _shoeColourSizeRepository.FindByCondition(s => s.ShoeColour.Shoe.ShoeId.Equals(shoe.ShoeId)).Select(s => s.ShoeSize).Distinct().ToList();
            return dto;
        }
    }
}

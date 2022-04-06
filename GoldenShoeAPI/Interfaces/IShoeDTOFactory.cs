using System;
using GoldenShoeAPI.Controllers;
using GoldenShoeAPI.Domain;
using GoldenShoeAPI.DTO;

namespace GoldenShoeAPI.Interfaces
{
    public interface IShoeDTOFactory
    {
        public IShoeDTO Create(Shoe shoe);
    }
}

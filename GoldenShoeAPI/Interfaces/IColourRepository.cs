using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using GoldenShoeAPI.Domain;

namespace GoldenShoeAPI.Interfaces
{
	public interface IColourRepository: IRepository<Colour, int> { }
}

using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using GoldenShoeAPI.Domain;

namespace GoldenShoeAPI.Interfaces
{
	public interface IStyleRepository: IRepository<Style, int> { }
}

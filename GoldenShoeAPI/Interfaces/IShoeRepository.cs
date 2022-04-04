using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace GoldenShoeAPI.Context
{
	public interface IShoeRepository: IRepository<Shoe, int> { }
}

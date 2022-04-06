using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using GoldenShoeAPI.Domain;

namespace GoldenShoeAPI.Interfaces
{
	public interface IStoreRepository: IRepository<Store, int> { }
}

using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace GoldenShoeAPI.Interfaces
{
	public interface IRepository<T, K>
	{
		IEnumerable<T> FindAll();
		T FindByID(K id);
		IEnumerable<T> FindByCondition(Func<T, bool> expression);
		void Create(T entity);
		void Update(T entity);
		void Delete(T entity);
	}
}

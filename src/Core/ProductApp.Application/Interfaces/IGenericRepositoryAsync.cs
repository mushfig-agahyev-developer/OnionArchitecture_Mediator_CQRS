using ProductApp.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ProductApp.Application.Interfaces
{
    public interface IGenericRepositoryAsync <T> where T : BaseEntity
    {
        Task<List<T>> GetAllAsync();
        Task<T> GetByidAsync(Guid id);
        Task<T> AddAsync(T entity);
    }
}

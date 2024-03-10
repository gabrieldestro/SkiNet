using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Core.Specifications;

namespace Core.Interfaces
{
    public interface IGenericRepository<T> where T : BaseEntity
    {
        Task<T> GetByIdAsync(int Id);
        Task<IReadOnlyList<T>> ListAllAsync();
        Task<T> GetEntityWithSpec(Ispecification<T> spec);
        Task<IReadOnlyList<T>> ListAsync(Ispecification<T> spec);
        Task<int> CountAsync(Ispecification<T> spec);
    }
}
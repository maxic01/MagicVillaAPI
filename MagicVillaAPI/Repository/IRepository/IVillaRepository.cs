using MagicVillaAPI.Models;
using System.Linq.Expressions;

namespace MagicVillaAPI.Repository.IRepository
{
    public interface IVillaRepository : IRepository<Villa>
    {
        Task<Villa> UpdateAsync(Villa entity);
    }
}

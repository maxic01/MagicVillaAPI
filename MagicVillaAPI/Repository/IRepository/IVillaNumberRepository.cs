using MagicVillaAPI.Models;
using System.Linq.Expressions;

namespace MagicVillaAPI.Repository.IRepository
{
    public interface IVillaNumberRepository : IRepository<VillaNumber>
    {
        Task<VillaNumber> UpdateAsync(VillaNumber entity);
    }
}

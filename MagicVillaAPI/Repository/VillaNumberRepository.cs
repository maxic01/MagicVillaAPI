using MagicVillaAPI.Data;
using MagicVillaAPI.Models;
using MagicVillaAPI.Repository.IRepository;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Linq.Expressions;

namespace MagicVillaAPI.Repository
{
    public class VillaNumberRepository : Repository<VillaNumber>, IVillaNumberRepository
    {
        private readonly ApplicationDbContext _db;
        public VillaNumberRepository(ApplicationDbContext db): base(db)
        {
            _db = db;
        }
        public async Task<VillaNumber> UpdateAsync(VillaNumber entity)
        {
            entity.UpdateDate = DateTime.Now;
            _db.VillaNumbers.Update(entity);
            await _db.SaveChangesAsync();
            return entity;
        }
    }
}
